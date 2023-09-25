using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductAttributeController : BaseMVCController
    {
        // GET: ProductAttributeController
        public ActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> getAttrItems(int id)
        {
            var res = await ServiceManager.AttributeItemService.Find(a => a.AttributeId == id);
            Console.WriteLine("ABOODI"+id);
            Console.WriteLine("ID"+res.Data.FirstOrDefault().Id.ToString());

            var json = new List<dynamic>();
            if (res.Status.Succeeded)
            {
                foreach(var item in res.Data)
                {
                    var dict = new Dictionary<string, dynamic>();
                    dict.Add("name", item.ArName);
                    dict.Add("id", item.Id);
                    json.Add(dict);
                }
                return Ok(json);
            }
            return BadRequest("noo data");
     
        }

        // GET: ProductAttributeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductAttributeController/Create
        public ActionResult Create()
        {
            return View();
        }
         public async  Task<ActionResult> GetAttribute()
        {
            var res = await ServiceManager.AttributeService.GetAll();
         //   var list
            if (res.Status.Succeeded)
            {

            }
            return View();
        }

        // POST: ProductAttributeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProductAttributeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductAttributeController/Edit/5
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

        // GET: ProductAttributeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductAttributeController/Delete/5
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
