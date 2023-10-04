using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class AttributeItemController : BaseMVCController
    {
        // GET: AttributeItemController
        public async Task<ActionResult> Index(int id)
        {
            Console.WriteLine("Aqlan IS here in items");
            if (id != 0)
            {
                Console.WriteLine("not 0");

                var res = await ServiceManager.AttributeItemService.Find(x => x.AttributeId == id);
                var AttItem = await ServiceManager.AttributeService.GetById(id);

                Console.WriteLine( "ssssssssssssssssss");
                if (AttItem.Data == null)
                {
                    Console.WriteLine("in null");

                    TempData["msg"] = "لا توجد صفة بهذا الرقم";
                    return RedirectToAction("Index", "Attribute");

                }
                else
                {
                    Console.WriteLine("in else");

                    if (res.Status.Succeeded)
                    {
                        Console.WriteLine("in suceeded");

                       
                            Console.WriteLine("in attitem");

                            TempData["AttName"] = AttItem.Data.EnName;
                            TempData["AttId"] = id;

                            return View(res.Data);

                        

                    }
                    TempData["msg"] = res.Status.message;
                    return View();



                }

                //return RedirectToAction("Index", "Attribute");
            }
            else
            {
                return RedirectToAction("Index", "Attribute");

            }
        }


        // GET: AttributeItemController/Details/5
        public async Task<ActionResult> IndexAll()
        {

            var res = await ServiceManager.AttributeItemService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;
            return View();
        }

        // GET: AttributeItemController/Create
        public async Task<ActionResult> Create(int AttId)
        {

            if (AttId != 0)
            {
                Console.WriteLine("not 0");

                var AttItem = await ServiceManager.AttributeService.GetById(AttId);

                Console.WriteLine("ssssssssssssssssss");
                if (AttItem.Data == null)
                {
                    Console.WriteLine("in null");
                    TempData["AttId"] = AttId;
                    TempData["msg"] = "لا توجد صفة بهذا الرقم";
                    return RedirectToAction("Index", new {id= AttId });

                }
                else
                {
                    TempData["AttId"] = AttId;

                    return View();

                }
            }
            else
            {
                return RedirectToAction("Index", "Attribute");

            }
        

    }

        // POST: AttributeItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AttributeItemDto entity)
        {
            try
            {
                Console.WriteLine("in try");
                if (entity == null)
                {
                    Console.WriteLine("in entity null");

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
                    TempData["AttId"] = entity.AttributeId;

                    return View(entity);

                }
                else
                {
                    Console.WriteLine("in add before");
                    
                    var res = await ServiceManager.AttributeItemService.Add(entity);
                    Console.WriteLine("in add after");

                    if (res.Status.Succeeded)
                    {
                        Console.WriteLine("in secees");

                        TempData["AttId"] = entity.AttributeId;

                        TempData["msg"] = res.Status.message;
                        return RedirectToAction("Index","AttributeItem",new {id=entity.AttributeId});
                    }
                    else
                    {
                        Console.WriteLine("in else success");

                        TempData["AttId"] = entity.AttributeId;
                        TempData["msg"] = res.Status.message;
                        return View(res.Data);
                    }
                    
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
