using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class SubSubclassificationController : BaseMVCController
    {
        public async Task<IActionResult> Index(int SubSubclassificationBaseId)
        {
            var res = await ServiceManager.SubSubclassificationService.Find(a => a.SubClassificationBaseId == SubSubclassificationBaseId);
            if (res.Status.Succeeded)
            {
                var mainRes = await ServiceManager.SubClassificationBaseService.GetById(SubSubclassificationBaseId);
                if (mainRes.Status.Succeeded)
                    TempData.SetTemp<string>("name", mainRes.Data.ArSubClassificationName);
                TempData.SetTemp<int>("SubSubclassificationBaseId", SubSubclassificationBaseId);



                return View(res.Data);
            }
            return View();

        }
        public async Task<IActionResult> Create(int SubSubclassificationBaseId)
        {
            var obj = new SubSubclassificationDto { SubClassificationBaseId = SubSubclassificationBaseId };
            var res = await ServiceManager.SubClassificationBaseService.GetById(SubSubclassificationBaseId);
            if (res.Status.Succeeded)
            {
                TempData.SetTemp<string>("name", res.Data.ArSubClassificationName);
                ;
                return View(obj);
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubSubclassificationDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.SubSubclassificationService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { SubSubclassificationBaseId = entity.SubClassificationBaseId });
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.SubSubclassificationService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubSubclassificationDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.SubSubclassificationService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { SubSubclassificationBaseId = entity.SubClassificationBaseId });
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var res = await ServiceManager.SubSubclassificationService.Remove(Id);
            if (res.Status.Succeeded)
            {
                const string folderName = "SubClassification";
                var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);


                if (deleteRes == true)
                {
                    TempData["success"] = res.Status.message;
                    return RedirectToAction("Index", new { SubSubclassificationBaseId = res.Data.SubClassificationBaseId });
                }
                else
                {
                    TempData["err"] = "file not deleted because there is no file name ";

                    return RedirectToAction("Index", new { SubSubclassificationBaseId = res.Data.SubClassificationBaseId });
                }

            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> GetSubclassFication(int subId)
        {
            var res = await ServiceManager.SubSubclassificationService.Find(a => a.SubClassificationBaseId == subId);
            var list = new List<dynamic>();
            if (res.Status.Succeeded)
            {
                foreach (var item in res.Data)
                {
                    var dict = new Dictionary<string, dynamic>();
                    dict.Add("id", item.Id);
                    dict.Add("name", item.ArSubSubClassificationName);
                    list.Add(dict);
                }
                return Ok(list);
            }
            return BadRequest(res.Status.message);
        }

    }
}
