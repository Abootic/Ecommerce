using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductController : BaseMVCController
    {
        public IActionResult Index(int? pid )
        {

            ProductDto productDto = new ProductDto();
            if (pid != null)
            {
                productDto.Id = pid.Value;
            }
           
            return View(productDto); 
           
        }  
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDto entity) {
            if (entity == null) RedirectToAction("Index");
           
            entity.Code = "2";
            entity.TaxType = 4;
            entity.VideoProvider = "5";
            entity.VideoUrl = "8";
            var res = await ServiceManager.ProductService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { pid = res.Data.Id });

            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index", new { pid =0 });
        }

     
    }
}
