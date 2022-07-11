using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Security.Principal;
using System.ComponentModel.DataAnnotations;

namespace News_Online.Models
{
    public class AccountKH
    {
        public string RowID { get; set; }
        public string MaKH { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string SinhNhat { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }      
        public string MatKhau { get; set; }
        public string NgayTao { get; set; }
        public string ThongBao { get; set; }
    }
  
}