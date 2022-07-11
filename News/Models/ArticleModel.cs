using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News_Online.Models
{
    public class ArticleModel
    {
        public  int IDMenuChild { get; set; }
        public string Title { get; set; }
        public string Content_Article { get; set; }
        public string CreateDate { get; set; }
        public string CreateEmployee { get; set; }
        public string UrlImage { get; set; }
    }
}
