using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductAttributeController : BaseMVCController
    {
        private readonly ICustomConventer _customConventer;

        public ProductAttributeController(ICustomConventer customConventer)
        {
            _customConventer = customConventer;
        }

        // GET: ProductAttributeController
        public ActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> getAttrItems(int id)
        {
            var res = await ServiceManager.AttributeItemService.Find(a => a.AttributeId == id);
            
            if (res.Status.Succeeded)
            {
                ProductAdditionalVM vm =new ProductAdditionalVM();
              vm.checkBoxListVms  = new List<CheckBoxListVm>();
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
        public ActionResult Details(int id)
        {
            return View();
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
            Console.WriteLine($"000000000000000000000000  {entity.ProductId}");
            Console.WriteLine($"11111111111111111111  {entity.AttributeId}");
            if (entity.AttributeItemId != null)
            {
                var d = entity.AttributeItemId.Split(","); 
                foreach(var item in d) {
                    Console.WriteLine($"ccccccccccccc   {item}");
                    var ob = new ProductAttributeDto
                    {
                        AttributeId = entity.AttributeId,
                        AttributeItemId = int.Parse(item),
                        ProductId = entity.ProductId
                    };
                    var res = await ServiceManager.ProductAttributeService.Add(ob);
                    if (res.Status.Succeeded)
                    {
                        Console.WriteLine(res.Status.message);
                      //  return View();
                    }
                    Console.WriteLine(res.Status.message);
                  //  return View();
                }

            }
            return RedirectToAction("Create");


            //  Console.WriteLine($"2222222222222222222222  {d.AttributeItemId}");

        }
       
         public async  Task<ActionResult> GetAttribute()
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
