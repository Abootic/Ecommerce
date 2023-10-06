using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using EcommereceWeb.MVC.Services;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.MVC.Controllers
{
    public class BasicClassificationController : BaseMVCController
    {
        public async Task<IActionResult> Index(int MainClassificationId)
        {
            Console.WriteLine($"ffffffffffff   {MainClassificationId}");
            TempData.SetTemp<int>("MainClassificationId", MainClassificationId); var res = await ServiceManager.BasicClassificationService.Find(a=>a.MainClassificationId== MainClassificationId);
            if (res.Status.Succeeded)
            {
                var mainRes = await ServiceManager.MainClassificationService.GetById(MainClassificationId);
                if (mainRes.Status.Succeeded)
                    TempData.SetTemp<string>("name", mainRes.Data.ArMainClassificationName);
                
                


                return View(res.Data);
            }
            return View();

        }
        public async Task<IActionResult> Create(int MainClassificationId)
        {
            var obj = new BasicClassificationDto { MainClassificationId = MainClassificationId };
            var res = await ServiceManager.MainClassificationService.GetById(MainClassificationId);
            if (res.Status.Succeeded)
            {
                TempData.SetTemp<string>("name", res.Data.ArMainClassificationName);
;               
                return View(obj);
            }
           
            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BasicClassificationDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.BasicClassificationService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index",new{ MainClassificationId=entity.MainClassificationId});
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.BasicClassificationService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BasicClassificationDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.BasicClassificationService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { MainClassificationId = entity.MainClassificationId });
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var res = await ServiceManager.BasicClassificationService.Remove(Id);
            if (res.Status.Succeeded)
            {
                const string folderName = "BasicClassification";
                var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);


                if (deleteRes == true)
                {
                    TempData["success"] = res.Status.message;
                    return RedirectToAction("Index", new { MainClassificationId = res.Data.MainClassificationId });
                }
                else
                {
                    TempData["err"] = "file not deleted because there is no file name ";

                    return RedirectToAction("Index", new { MainClassificationId = res.Data.MainClassificationId });
                }

            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> GetmainBisikClassFication(int mainClassficationId)
        {
            var res = await ServiceManager.BasicClassificationService.Find(a => a.MainClassificationId == mainClassficationId);
            var list = new List<dynamic>();
            if (res.Status.Succeeded)
            {
                foreach (var item in res.Data)
                {
                    var dict = new Dictionary<string, dynamic>();
                    dict.Add("id", item.Id);
                    dict.Add("name", item.ArBasicClassificationName);
                    list.Add(dict);
                }
                return Ok(list);
            }
            return BadRequest(res.Status.message);
        }


    }
}
