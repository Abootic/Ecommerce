using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductController : BaseMVCController
    {
        public IActionResult Index()
        {
            return View();
        }  
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> GetmainBisikClassFication(int mainClassficationId)
        {
            var res=await ServiceManager.BasicClassificationService.Find(a=>a.MainClassificationId == mainClassficationId);
            var list = new List<dynamic>();
            if (res.Status.Succeeded){
                foreach(var  item in res.Data) {
                var dict=new Dictionary<string, dynamic>();
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
