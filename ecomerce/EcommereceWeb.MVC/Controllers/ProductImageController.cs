using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductImageController : BaseMVCController
    {
        public IActionResult Index()
        {
            return View();
        }        public IActionResult Create()
        {
            return View();
        }
    }
}
