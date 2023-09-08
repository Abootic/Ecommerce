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
                return View(userDto);
            }
            var res=await ServiceManager.UserService.AddAsync(userDto);
                if (res.Status.Succeeded)
                {
                    return View(res);
                }
                return   View(userDto);
            }
            catch(Exception ex)
            {
                Console.WriteLine($" error is {ex.Message}");
                return View(userDto);
            }
        }
    }
}
