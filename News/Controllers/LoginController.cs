using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News_Online.Models.Repository;
using News_Online.Models;
using ReflectionIT.Mvc.Paging;
using JwtAuthenticationHelper.Abstractions;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using News_Online.Controllers;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using System.Data;
using TangDuLieu;

namespace News_Online.Controllers
{
    public class LoginController : Controller
    {
        static DBase db = new DBase();
        CultureInfo provider;   // GET: Login

        public IActionResult Index()
        {
            if (Request.Method == "POST")
            {


                //string memberid = Request.Form["MemID"];
                if (Request.Form["MemID"] != "")
                {

                    string MemberRoot = Request.Form["MemberRoot"];
                    //.AspNet.Consent = yes; expires = Fri, 04 Jun 2021 09:11:47 GMT; path =/; samesite = lax
                    string MemID = Request.Form["MemID"].ToString();
                    AccountModel acc = LoginRepository.GetMember(MemID, MemberRoot);
                    if (acc != null && acc.member_email != null)
                    {



                        var accessTokenResult = tokenGenerator.GenerateAccessTokenWithClaimsPrincipal(
                            acc.member_name,
                            GetUserClaims(acc));


                        HttpContext.SignInAsync(accessTokenResult.ClaimsPrincipal,
                           accessTokenResult.AuthProperties);


                    }

                }
            }
            if (_configuration.GetSection("ConfigService").GetSection("Airline24h").Value == "true")
            {
                return Redirect("http://airline24h.com/");
            }
            else
            {
                return View();
            }
        }
        public IActionResult login1()
        {
            return View();
        }
        private readonly IJwtTokenGenerator tokenGenerator;
        private IConfiguration _configuration;
        public LoginController(IJwtTokenGenerator tokenGenerator, IConfiguration configuration)
        {
            this.tokenGenerator = tokenGenerator;
            _configuration = configuration;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAccount(LoginViewModel model, string returnUrl = null)
        {
            try
            {

                AccountModel acc = LoginRepository.Login(model.Email, model.Password);
                if (acc != null && acc.member_email != null)
                {
                    if (acc.lockReason != "")
                    {
                        TempData["msg"] = acc.lockReason;
                        return View("Index");
                    }

                    var accessTokenResult = tokenGenerator.GenerateAccessTokenWithClaimsPrincipal(
                          acc.member_name,
                          GetUserClaims(acc));


                    await HttpContext.SignInAsync(accessTokenResult.ClaimsPrincipal,
                        accessTokenResult.AuthProperties);




                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["msg"] = "* Tên đăng nhập hoặc mật khẩu không đúng";

                }
            }
                catch (System.Exception ex)
            {

                TempData["msg"] = "* Lỗi trong quá trình đăng nhập, vui lòng liên hệ it";
            }



            return RedirectToAction("Index", "Login");
        }
        private static IEnumerable<Claim> GetUserClaims(AccountModel acc)
        {

            IEnumerable<Claim> claims = new Claim[]
                    {
                    new Claim(ClaimTypes.Name, acc.member_name),

                    new Claim("member_kh", acc.member_kh),
                    new Claim("member_company", acc.member_company),
                    new Claim("member_address", acc.member_address),
                    new Claim("member_phone", acc.member_phone),
                    new Claim("member_id",  acc.member_id.ToString()),
                    new Claim("member_name", acc.member_name),
                    new Claim("member_email", acc.member_email),
                    new Claim("nhanvien_kd", acc.nhanvien_kd),
                    new Claim("sodienthoai_kd", acc.sodienthoai_kd),
                    new Claim("skype_kd", acc.skype_kd),
                    new Claim("nhanvien_kt", acc.nhanvien_kt),
                    new Claim("sodienthoai_kt", acc.sodienthoai_kt),
                    new Claim("skype_kt", acc.skype_kt),                 
                    new Claim("member_agency_email", acc.member_agency_email) //Email đại lý

                };
            return claims;


        }

       [HttpPost]
       
        public IActionResult Logout()
        {

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            return RedirectToAction("Index", "Login");

        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }






        [HttpPost]

        public JsonResult ForgetPassword(string email)
        {

            try
            {
                string result = LoginRepository.ForgetPassword(email);
                ViewBag.msg = result;
                return Json(result);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult forgotpass()
        {
            return View();
        }
        public IActionResult loginKH()
        {
            return View();
        }
        public async Task<IActionResult> LoginAccountKH(LoginViewModel model, string returnUrl = null)
        {
            try
            {

                AccountKH acc = LoginRepository.LoginKH(model.Email, model.Password);
                if (acc != null && acc.Email != null)
                {
                    if (acc.ThongBao != "" && acc.ThongBao != null)
                    {
                        TempData["msg"] = acc.ThongBao;
                        return View("Index");
                    }

                    var accessTokenResult = tokenGenerator.GenerateAccessTokenWithClaimsPrincipal(
                          acc.Ten,
                          GetUserClaimsKH(acc));


                    await HttpContext.SignInAsync(accessTokenResult.ClaimsPrincipal,
                        accessTokenResult.AuthProperties);




                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["msg"] = "* Tên đăng nhập hoặc mật khẩu không đúng";

                }
            }
            catch (System.Exception ex)
            {

                TempData["msg"] = "* Lỗi trong quá trình đăng nhập, vui lòng liên hệ it";
            }



            return RedirectToAction("loginKH", "Login");
        }
        public IActionResult signup()
        {
            return View();
        }
        public IActionResult CreateAccountKH(string Name, string Email,string password, string Phone, string ngaysinh)
        {
            AccountKH acc = new AccountKH();
            LoginRepository rep_login = new LoginRepository();
            //DateTime DOB = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy", provider, DateTimeStyles.None);
            //string Dateofbirth = DOB.ToString("yyyy-MM-dd");
            string sql = @"select * from Accout_KH where Email ='"+Email+"'";
            DataTable dt = db.ExecuteDataSet(sql, CommandType.Text, "server37_Article", null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                ViewBag.thongbao = "Email đã tồn tại ";
                return View("signup");
            }
            else
            {
                bool ret = rep_login.CreateAccoutKH(Name, Email, password, Phone, ngaysinh);
                if (ret == true)
                {
                    ViewBag.thongbao = "Bạn đã thêm mới khách hàng thành công";
                }
                else
                {
                    ViewBag.thongbao = "Bạn đã thêm mới không thành công";
                   
                }
                
            }
           
            return RedirectToAction("loginKH", "Login");
        }

        private static IEnumerable<Claim> GetUserClaimsKH(AccountKH acc)
        {

            IEnumerable<Claim> claims = new Claim[]
                    {
                    new Claim(ClaimTypes.Name, acc.Ten),

                    new Claim("RowID", acc.RowID.ToString()),
                  //  new Claim("MaKH", acc.MaKH),
                    new Claim("Ten",acc.Ten),
                    new Claim("SinhNhat", acc.SinhNhat),
                    new Claim("DienThoai", acc.DienThoai),
                    new Claim("Email", acc.Email),
                };
            return claims;


        }
       
    }
}
