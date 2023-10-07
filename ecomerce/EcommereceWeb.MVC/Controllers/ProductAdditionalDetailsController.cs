using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductAdditionalDetailsController : BaseMVCController
    {
        public async Task<IActionResult> Index()
        {
            var res = await ServiceManager.ProductAdditionalDetailsService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            return View();

        }
        public async Task<IActionResult> Create(int productId)
        {
            ProductAdditionalDetailsDto productAdditionalDetailsDto = new ProductAdditionalDetailsDto();
            productAdditionalDetailsDto.ProductId = productId;
            return View(productAdditionalDetailsDto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductAdditionalDetailsDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return RedirectToAction("Create", new { productId = entity.ProductId }); }
            var res = await ServiceManager.ProductAdditionalDetailsService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Create", new { productId =entity.ProductId});
            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Create", new { productId = entity.ProductId });
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.ProductAdditionalDetailsService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductAdditionalDetailsDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.ProductAdditionalDetailsService.Update(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var res = await ServiceManager.ProductAdditionalDetailsService.Remove(Id);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index");
        }

    }
}
