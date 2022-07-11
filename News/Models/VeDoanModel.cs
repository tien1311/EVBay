using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class VeDoanModel
    {
        public string ID { get; set; }
        public string Hang { get; set; }
        public string HanhTrinh { get; set; }
        public double Gia { get; set; }
        public string KindTrip { get; set; }
        public string SoLuongKhach { get; set; }
        public double Tongtien { get; set; }
        public string DieuKien { get; set; }
        public List<VeDoanDetail> ListVeDoan { get; set; }
    }
    public class VeDoanDetail
    {
        public string MaCB { get; set; }
        public string NgayBay { get; set; }
        public string GioBay { get; set; }
    }
    public class Luuthongtin
    {
        public string ID { get; set; }
        public string Hang { get; set; }
        public string HanhTrinh { get; set; }
        public double Gia { get; set; }
        public string KindTrip { get; set; }
        public string SoLuongKhach { get; set; }
        public double Tongtien { get; set; }     
        public string hangbay { get; set; }
        public string NgayBay { get; set; }
        public string GioBay { get; set; }
      
    }
}
