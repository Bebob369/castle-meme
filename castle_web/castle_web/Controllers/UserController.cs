using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace castle_web.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Profile()
        {
            try
            {
                var userName = RouteData.Values["id"].ToString();
                var user = _context.Users.FirstOrDefault(x => x.UserName == userName);
                return View(user);
            }
            catch
            {
                return null;
            }
        }

        public IActionResult Index()
        {
            var controller = RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString();
            return Content($"controller: {controller} | action: {action}");
        }
    }
}