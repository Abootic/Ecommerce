using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class AttributeItemController : BaseMVCController
    {
        // GET: AttributeItemController
        public async Task<ActionResult> Index()
        {
          /*  if(id == 0)
            {
                var res = await ServiceManager.AttributeItemService.GetAll();
                if (res.Status.Succeeded)
                {
                    return View(res.Data);
                }
                TempData["msg"] = res.Status.message;
                return View();

                return  RedirectToAction("Index","Attribute");
            }
            else
            {*/
             var res = await ServiceManager.AttributeItemService.GetAll();
                if (res.Status.Succeeded)
                  {
                      return View(res.Data);
                  }
                  TempData["msg"] = res.Status.message;
                   return View();
         
           
        }


        // GET: AttributeItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AttributeItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttributeItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AttributeItemDto entity)
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

                    Console.WriteLine("Ar: " + entity.ArName);
                    Console.WriteLine("En: " + entity.EnName);
                    Console.WriteLine("Code: " + entity.Code);

                    return View(entity);

                }
                else
                {
                    var res = await ServiceManager.AttributeItemService.Add(entity);
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

        // GET: AttributeItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AttributeItemController/Edit/5
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

        // GET: AttributeItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AttributeItemController/Delete/5
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
