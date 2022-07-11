using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Security.Principal;
using System.ComponentModel.DataAnnotations;

namespace News_Online.Models
{
    public class AccountModel
    {

        public int member_id { get; set; }
        public string member_kh { get; set; }


        public string member_company { get; set; }
        public string member_name { get; set; }

        public string member_agency_email { get; set; } //Email đại lý
        public string member_email { get; set; }
        public string member_address { get; set; }
        public string member_phone { get; set; }
        public string giolamviec { get; set; }
        public DateTime member_date { get; set; }
        public bool member_isshow { get; set; }
        public bool member_ishot { get; set; }
        public bool member_isnew { get; set; }
        public bool member_isactive { get; set; }
        public DateTime last_login { get; set; }
        public string lockReason { get; set; }
        public string member_admin { get; set; }
        public string member_fax { get; set; }
        public string member_code { get; set; }
        public ThongTinHopDong ThongTinHD { get; set; }
        public string member_website { get; set; }
        public string nhanvien_kd { get; set; }
        public string sodienthoai_kd { get; set; }
        public string nhanvien_kt { get; set; }
        public string sodienthoai_kt { get; set; }
        public string skype_kd { get; set; }
        public string skype_kt { get; set; }
        public string language { get; set; }
    }

    public class ThongTinHopDong
    {
        public string MAKETOAN { get; set; }
        public string TENCONGTY { get; set; }
        public string MASOTHUE { get; set; }
        public string GPKD { get; set; }
        public string DIACHI { get; set; }
        public string DIENTHOAI { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }

        public string NGUOIDAIDIEN { get; set; }
        public string CHUCVU { get; set; }

        public string NGAYSINH { get; set; }
        public string DTNGUOIDAIDIEN { get; set; }
        public string CMND { get; set; }
        public string NGAYNOICAP { get; set; }
        public string NHANVIENKETOAN { get; set; }
        public string DIENTHOAIKETOAN { get; set; }
        public string LINE { get; set; }
        public string MaHD { get; set; }
        public List<string> FileHopDong { get; set; }
        public string NgayKy { get; set; }
    }
    public class HotroModel
    {
        public List<HotroWeb> ListHotroWeb { get; set; }
        public List<HotroKeToanCN> ListHotroKeToanCN { get; set; }
    }
    public class HotroWeb
    {
        public string member_name { get; set; }
        public string member_phone { get; set; }
        public string giolamviec { get; set; }
    }
    public class HotroKeToanCN
    {
        public string member_name { get; set; }
        public string member_phone { get; set; }
        public string giolamviec { get; set; }
    }

}