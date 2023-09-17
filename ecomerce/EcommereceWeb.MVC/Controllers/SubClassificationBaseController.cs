using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class SubClassificationBaseController : BaseMVCController
    {

        public async Task<IActionResult> Index(int BasicClassificationId)
        {
            var res = await ServiceManager.SubClassificationBaseService.Find(a => a.BasicClassificationId == BasicClassificationId);
            if (res.Status.Succeeded)
            {
                var mainRes = await ServiceManager.BasicClassificationService.GetById(BasicClassificationId);
                if (mainRes.Status.Succeeded)
                    TempData.SetTemp<string>("name", mainRes.Data.ArBasicClassificationName);
                TempData.SetTemp<int>("BasicClassificationId", BasicClassificationId);



                return View(res.Data);
            }
            return View();

        }
        public async Task<IActionResult> Create(int BasicClassificationId)
        {
            var obj = new SubClassificationBaseDto { BasicClassificationId = BasicClassificationId };
            var res = await ServiceManager.BasicClassificationService.GetById(BasicClassificationId);
            if (res.Status.Succeeded)
            {
                TempData.SetTemp<string>("name", res.Data.ArBasicClassificationName);
                ;
                return View(obj);
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubClassificationBaseDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.SubClassificationBaseService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { BasicClassificationId = entity.BasicClassificationId });
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.SubClassificationBaseService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubClassificationBaseDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.SubClassificationBaseService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { BasicClassificationId = entity.BasicClassificationId });
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var res = await ServiceManager.SubClassificationBaseService.Remove(Id);
            if (res.Status.Succeeded)
            {
                const string folderName = "SubClassificationBase";
                var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);


                if (deleteRes == true)
                {
                    TempData["success"] = res.Status.message;
                    return RedirectToAction("Index", new { BasicClassificationId = res.Data.BasicClassificationId });
                }
                else
                {
                    TempData["err"] = "file not deleted because there is no file name ";

                    return RedirectToAction("Index", new { BasicClassificationId = res.Data.BasicClassificationId });
                }

            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index");
        }

    }
}
