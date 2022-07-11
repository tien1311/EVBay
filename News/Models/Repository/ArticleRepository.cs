using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TangDuLieu;

namespace News_Online.Models.Repository
{
    public class ArticleRepository
    {
        DBase db = new DBase();
        public ArticleModel Article(int ID)
        {
            ArticleModel result = new ArticleModel();
            string sql = @"select * from Article where IDMenuChild = '"+ ID +"'";
            DataTable tb = db.ExecuteDataSet(sql, CommandType.Text, "server37_Article", null).Tables[0];
            if (tb != null && tb.Rows.Count > 0)
            {
                result.CreateDate = tb.Rows[0]["CreateDate"].ToString();
                result.CreateEmployee = tb.Rows[0]["CreateEmployee"].ToString();
                result.UrlImage = tb.Rows[0]["UrlImage"].ToString();
                result.Title = tb.Rows[0]["Title"].ToString();
                result.Content_Article = tb.Rows[0]["Content_Article"].ToString();
            } 
            return result;
        }
        public ArticleModel ArticleMain()
        {
            ArticleModel result = new ArticleModel();
            string SqlView = "select NOIDUNG FROM BAIVIET where ROWID = '177'";
            DataTable dt = db.ExecuteDataSet(SqlView, CommandType.Text, "serverAirline24h", null).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                result.Content_Article = dt.Rows[0]["NOIDUNG"].ToString();
            }
            return result;
        }
    }
}
