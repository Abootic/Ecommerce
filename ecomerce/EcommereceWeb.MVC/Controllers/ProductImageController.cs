using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductImageController : BaseMVCController
    {
        public IActionResult Index()
        {
            return View();
        }        public IActionResult Create(int productId)
        {
            var productimag=new ProductImageDto { ProductId = productId };
            return View(productimag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductImageDto entity)
        {
            Console.WriteLine("ddddddddddddddddddddddddddddddddddddddddddddddd");
            var imgList = new List<string>();
            bool success = false;
            string msg = "";
            var e = new ProductImageDto();

            if (entity == null) return RedirectToAction("Create", new { productId = entity.ProductId });
            for (int i = 0; i < entity.Image1.Count; i++)
            {
                if (entity.Image1[i] != null)
                {
                    imgList = entity.Image1[i].Split(",").ToList();
                }
                else
                {
                    TempData["err"] = "لم يتم اختيار صورة";
                    return View(entity);
                }
            }
            for (int i = 0; i < imgList.Count; i++)
            {

                e.ImageUrl = imgList[i];
              
                var res = await ServiceManager.ProductImageService.Add(e);
                if (res.Status.Succeeded)
                {
                    success = res.Status.Succeeded;
                    msg = res.Status.message;
                }
                else
                {
                    success = res.Status.Succeeded;
                    msg = res.Status.message;
                }

               

            }

            if (success)
            {
                TempData["suc"] = msg;
                return RedirectToAction("Create", new { productId = entity.ProductId });
            }
            TempData["err"] = msg;

            return RedirectToAction("Create", new { productId = entity.ProductId });



        }
    }
}
