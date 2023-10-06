using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductController : BaseMVCController
    {
        public IActionResult Index()
        {
              ProductAdditionalVM vm = new ProductAdditionalVM();
            vm.checkBoxListVms = new List<CheckBoxListVm>();
            vm.CheckBoxListVm = new CheckBoxListVm();
            vm.productDto = new ProductDto();
            return View(vm); vm = new ProductAdditionalVM();
            vm.checkBoxListVms = new List<CheckBoxListVm>();
            vm.CheckBoxListVm = new CheckBoxListVm();
            return View(vm);
        
        }  public IActionResult Create()
        {
            return View();
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
    }
}
