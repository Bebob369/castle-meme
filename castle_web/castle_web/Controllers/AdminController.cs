using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace castle_web.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            
            _context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users;
            return View(users);
        }

    }
}
