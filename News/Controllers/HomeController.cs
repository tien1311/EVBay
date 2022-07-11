using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News_Online.Models.Repository;
using News_Online.Models;
using ReflectionIT.Mvc.Paging;

namespace News_Online.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ArticleRepository Arti_Rep = new ArticleRepository();
            ArticleModel result = Arti_Rep.ArticleMain();
            return View(result);
        } 
        public IActionResult BaiViet(int IDMenuChild)
        {
            ArticleRepository Arti_Rep = new ArticleRepository();
            ArticleModel result = Arti_Rep.Article(IDMenuChild);
            return View(result);
        }
        public IActionResult CongVan(int? page = 1, int pageSize = 7)
        {
            CongVanRepository CongVan_Rep = new CongVanRepository();
            Task<CongVanModel> result = CongVan_Rep.CongVan();
            List<ListCongVan> list = result.Result.result;
            int pageNumber = (page ?? 1);
            //Phân trang 
            var model = PagingList.Create(list, pageSize, pageNumber);
            model.Action = "CongVan";
            
            return View(model);
        }
        public JsonResult DetailCongVan (string ID)
        {
            CongVanRepository CongVan_Rep = new CongVanRepository();
            Task<ChiTietCongVan> result = CongVan_Rep.DetailCongVan(ID);
            string ND = result.Result.result.htmlContent;
            return Json(ND);
        }
    }
}
