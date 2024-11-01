﻿using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class SliderController : BaseMVCController
    {
        public async Task<IActionResult> Index()
        {
            var res = await ServiceManager.SliderService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            return View();

        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.SliderService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.SliderService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SliderDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.SliderService.Update(entity);
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
            var res = await ServiceManager.SliderService.Remove(Id);
            if (res.Status.Succeeded)
            {
                const string folderName = "Slider";
                var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImgUrl, folderName);


                if (deleteRes == true)
                {
                    TempData["success"] = res.Status.message;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["err"] = "file not deleted because there is no file name ";

                    return RedirectToAction(nameof(Index));
                }

            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index");
        }


    }
}
