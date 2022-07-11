using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News_Online.Models
{
    public class CongVanModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<ListCongVan> result { get; set; }
    }
    public class ListCongVan
    {
        public string subject_id { get; set;}
        public string image { get; set;}
        public string title { get; set; }
        public string description { get; set; }
        public string date  { get; set; }
    }
    public class ChiTietCongVan
    {
        public string status { get; set; }
        public string message { get; set; }
        public NoiDungCongVan result { get; set; }
    }
    public class NoiDungCongVan
    {
        public string htmlContent { get; set; }
    }
    public class Agent
    {
        public string AgentId { get; set; }

    }
}
