using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Models.Repository;
using News.Models;

namespace News.Controllers
{
    public class VeDoanController : Controller
    {
        public IActionResult ListVeDoan()
        {
            VeDoanRepository VeDoan_Rep = new VeDoanRepository();
            List<VeDoanModel> result = VeDoan_Rep.ListVeDoan();

            return View(result);
        }


        public IActionResult Laythongtinve(string khoachinh, string sl, double tongtien)
        {
            //if (sl== null)
            //{
            //    sl = "1";
            //}
            VeDoanRepository VeDoan_Rep = new VeDoanRepository();
            List<VeDoanModel> result = VeDoan_Rep.thongtinve(khoachinh, sl, tongtien);

            return View(result);
        }
        public IActionResult Thongtinve(string saveBtn, string thongtinbay ,int fightid, string name, string mast, string email, string sdt, string ghichu, string hanhtrinh, double gia, string soluong, double tongtien)
        {

            VeDoanRepository VeDoan_Rep = new VeDoanRepository();
            Luuthongtin result = new Luuthongtin();
            if(mast== null)
            {
                mast = "";
            }
            if (ghichu==null)
            {
                ghichu = "";
            }
            bool resut_sendmail = VeDoan_Rep.luuthongtinve(thongtinbay ,fightid,name,mast,email,sdt,ghichu, hanhtrinh,gia,soluong,tongtien);
            if (resut_sendmail == true)
            {
                ViewBag.thongbao = "Én Việt đã xác nhận thông tin của anh chị , vui lòng kiểm tra lại thông tin trong mail";
            }
            else
            {
                ViewBag.thongbao = "Đặt vé thất bại";
            }
            List<VeDoanModel> result_VeDoan = VeDoan_Rep.ListVeDoan();
         
            return View("ListVeDoan", result_VeDoan);
        }
    }
   
}


