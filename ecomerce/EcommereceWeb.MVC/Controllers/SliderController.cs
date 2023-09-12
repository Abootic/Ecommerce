using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class SliderController : BaseMVCController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
