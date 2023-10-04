using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Infrastraction.Data;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductAttributeController : BaseMVCController
    {
        private readonly ICustomConventer _customConventer;
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductAttributeController(ICustomConventer customConventer, ApplicationDbContext applicationDbContext)
        {
            _customConventer = customConventer;
            _applicationDbContext = applicationDbContext;
        }


        // GET: ProductAttributeController
        public async Task<IActionResult> Index()
        {

            var res = ServiceManager.ProductAttributeService.GetListVaration();
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return View(res.Data);

            }
            TempData["err"] = res.Status.message;
            return View(res.Data);


        }
        public async Task<IActionResult> getAttrItems(int id)
        {
            var res = await ServiceManager.AttributeItemService.Find(a => a.AttributeId == id);

            if (res.Status.Succeeded)
            {
                ProductAdditionalVM vm = new ProductAdditionalVM();
                vm.checkBoxListVms = new List<CheckBoxListVm>();
                foreach (var item in res.Data)
                {

                    vm.CheckBoxListVm = new CheckBoxListVm
                    {
                        id = item.Id,
                        name = item.ArName
                    };

                    vm.checkBoxListVms.Add(vm.CheckBoxListVm);
                }

                return PartialView("_checkBoxList", vm);
            }
            return BadRequest("noo data");

        }

        // GET: ProductAttributeController/Details/5
        [HttpGet]
        public IActionResult CreateVariation(int id, string name)
        {
            var productvaiation = new ProductVariationDto
            {
                AttItemId = id.ToString(),
                EnName = name,

            };
            return PartialView("_varationForm", productvaiation);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVariation(ProductVariationDto productVariationDto)
        {
            var res = await ServiceManager.ProductVariationService.Add(productVariationDto);
            if (res.Status.Succeeded)
            {
                return Ok(res.Status.message);
            }
            return BadRequest(res.Status.message);

        }
        // GET: ProductAttributeController/Create
        public ActionResult Create()
        {
            ProductAdditionalVM vm = new ProductAdditionalVM();
            vm.checkBoxListVms = new List<CheckBoxListVm>();
            vm.CheckBoxListVm = new CheckBoxListVm();
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductAdditionalVM entity)
        {

            if (entity.AttributeItemId != null)
            {
                var AttributeItemIdList = entity.AttributeItemId.Split(",");
                var nameattrList = entity.Name.Split(",");

                for (int i = 0, k = 0; i < nameattrList.Length && k < AttributeItemIdList.Length; i++, k++)
                {

                    var ob = new ProductAttributeDto
                    {
                        AttributeId = entity.AttributeId,
                        AttributeItemId = int.Parse(AttributeItemIdList[k]),
                        ProductId = entity.ProductId,
                        Name = nameattrList[i]

                    };
                    var res = await ServiceManager.ProductAttributeService.Add(ob);
                    if (res.Status.Succeeded)
                    {
                        Console.WriteLine(res.Status.message);
                        //  return View();
                    }
                    else
                    {
                        Console.WriteLine(res.Status.message);
                    }
                }

            }

            return RedirectToAction("Create");


            //  Console.WriteLine($"2222222222222222222222  {d.AttributeItemId}");

        }

        public async Task<ActionResult> GetAttribute()
        {
            var res = await ServiceManager.AttributeService.GetAll();
            //   var list
            if (res.Status.Succeeded)
            {

            }
            return View();
        }



        // GET: ProductAttributeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductAttributeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductAttributeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductAttributeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
