using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class AccountController : BaseMVCController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            try { 
            if(userDto == null) {
                    TempData["err"] = "null value";
                return View(userDto);
            }
            var res=await ServiceManager.UserService.AddAsync(userDto);
                if (res.Status.Succeeded)
                {
                    TempData["suc"] = "done";
                    return View(res);
                }
                TempData["err"] = "error";
                return   View(userDto);
            }
            catch(Exception ex)
            {
                TempData["err"] = $"catch err {ex.Message}";
                Console.WriteLine($" error is {ex.Message}");
                Console.WriteLine($" error is {ex.InnerException.Message}");
                return View(userDto);
            }
        }
    }
}
