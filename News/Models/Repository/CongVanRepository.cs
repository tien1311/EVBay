using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace News_Online.Models.Repository
{
    public class CongVanRepository
    {
        public async Task<CongVanModel> CongVan()
        {
            CongVanModel result3 = new CongVanModel();
            try
            {
                string URL = "http://api.enviet-group.com/OnlineTicket/Archives/Document";
                ServicePointManager.Expect100Continue = true;
                string strUrl = String.Format(URL);
                WebRequest requestObjPost = WebRequest.Create(strUrl);
                requestObjPost.Method = "POST";
                requestObjPost.ContentType = "application/json";
                requestObjPost.Headers.Add("X-master-key", "1370542bcb7c6b71e34e975d4697f89bab164a520934ff47a5aceb780fdc92e6");
                using (var streamWrite = new StreamWriter(requestObjPost.GetRequestStream()))
                {
                    var httpResponse = (HttpWebResponse) requestObjPost.GetResponse();

                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result2 = streamReader.ReadToEnd();
                            result3 = JsonConvert.DeserializeObject<CongVanModel>(result2);
                        }
                    }
                }
                return result3;
            }
            catch (Exception ex)
            {
                return result3;
                throw;
            }
        }
        public async Task<ChiTietCongVan> DetailCongVan(string ID)
        {
            ChiTietCongVan result3 = new ChiTietCongVan();
            try
            {
                string URL = "http://api.enviet-group.com/OnlineTicket/Archives/" + ID;
                ServicePointManager.Expect100Continue = true;
                string strUrl = String.Format(URL);
                WebRequest requestObjPost = WebRequest.Create(strUrl);
                requestObjPost.Method = "GET";
                requestObjPost.ContentType = "application/json";
            
                    var httpResponse = (HttpWebResponse)requestObjPost.GetResponse();

                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result2 = streamReader.ReadToEnd();
                            result3 = JsonConvert.DeserializeObject<ChiTietCongVan>(result2);
                        }
                    }
                
                return result3;
            }
            catch (Exception ex)
            {
                return result3;
                throw;
            }
        }
    }
}
