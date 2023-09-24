using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommereceWeb.Application.DTOs;

namespace EcommereceWeb.MVC.Controllers
{
    public class AttributeController : BaseMVCController
    {
        // GET: AttributeController
        public async Task<ActionResult> Index()
        {
            
            var res = await ServiceManager.AttributeService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;
            return View();
        }

        // GET: AttributeController/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: AttributeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttributeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AttributeDto entity)
        {
            try
            {
                if (entity == null)
                {
                    TempData["msg"] = "ادخل البيانات";
                    return View(entity);
                }
                if (!ModelState.IsValid)
                {

                    TempData["msg"] = "خطاء في البيانات";
                    //TempData["msg"] = "errrror";
                    Console.WriteLine("in ModelState inValid");
                    ModelState.AsEnumerable().ToList().ForEach(x => Console.WriteLine("Key : {0},value:{1}", x.Key, ModelState.GetValidationState(x.Key).ToString()));
                  
                        Console.WriteLine("Ar: "+entity.ArName);
                        Console.WriteLine("En: " + entity.EnName);
                        Console.WriteLine("Code: " + entity.Code);
                        Console.WriteLine("Type: " + entity.Type);
                   
                    return View(entity);

                }
                else
                {
                    var res = await ServiceManager.AttributeService.Add(entity);
                    if (res.Status.Succeeded)
                    {
                        TempData["msg"] = res.Status.message;
                        return RedirectToAction("Index");
                    }
                    TempData["msg"] = res.Status.message;
                    return View(entity);
                }
             
            }
            catch (Exception ex)
            {

                TempData["msg"] = ex.Message;
                Console.WriteLine("in Catch");

                return View(entity);
            }
        }

        // GET: AttributeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AttributeController/Edit/5
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

        // GET: AttributeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AttributeController/Delete/5
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
