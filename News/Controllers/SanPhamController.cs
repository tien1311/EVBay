using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult SanPham()
        {
            return View();
        }
        public IActionResult ChiTietSanPham()
        {
            return View();
        }
    }
}
