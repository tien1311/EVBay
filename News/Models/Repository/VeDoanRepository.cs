using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using TangDuLieu;

namespace News.Models.Repository
{
    public class VeDoanRepository
    {
        DBase db = new DBase();
        Mail baoNS_Booking = new Mail("EVM_GUITHONGTINVE");
        public List<VeDoanModel> ListVeDoan()
        {
            List<VeDoanModel> Listresult = new List<VeDoanModel>();
            
            string sql = @"select * from Flight where status = 1";
            DataTable tb = db.ExecuteDataSet(sql, CommandType.Text, "server37", null).Tables[0];
            if (tb != null && tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    VeDoanModel result = new VeDoanModel();
                    result.ID = tb.Rows[i]["ID"].ToString();
                    result.Hang = tb.Rows[i]["Airline"].ToString().Trim();
                    result.HanhTrinh = tb.Rows[i]["Itinerary"].ToString().Trim();
                    result.Gia = double.Parse(tb.Rows[i]["Price"].ToString().Trim());
                    result.KindTrip = tb.Rows[i]["KindTrip"].ToString().Trim();
                    result.SoLuongKhach = tb.Rows[i]["NumberOfGuests"].ToString().Trim();
                    result.DieuKien = tb.Rows[i]["Condition"].ToString().Trim();

                    List<VeDoanDetail> ListVeDoanDetail = new List<VeDoanDetail>();
                    string sqlFlightDetail = @"select *, (convert(varchar, getdate(), 106)) as ngaybay from FlightDetail where  FlightID = '" + tb.Rows[i]["ID"].ToString() + "'";
                    DataTable tbFlightDetail = db.ExecuteDataSet(sqlFlightDetail, CommandType.Text, "server37", null).Tables[0];
                    if (tbFlightDetail != null && tbFlightDetail.Rows.Count > 0)
                    {
                        for (int y = 0; y < tbFlightDetail.Rows.Count; y++)
                        {
                            VeDoanDetail resultDetail = new VeDoanDetail();
                            resultDetail.MaCB = tbFlightDetail.Rows[y]["FlightNumber"].ToString().Trim();
                            resultDetail.NgayBay = tbFlightDetail.Rows[y]["ngaybay"].ToString().Trim();
                            resultDetail.GioBay = tbFlightDetail.Rows[y]["FlightHour"].ToString().Trim();
                            ListVeDoanDetail.Add(resultDetail);
                        }
                        result.ListVeDoan = ListVeDoanDetail;
                    }
                    Listresult.Add(result);
                }
            }
            return Listresult;
        }
        public List<VeDoanModel> thongtinve(string khoachinh, string sl , double tongtien)
        {
            List<VeDoanModel> thongtinve = new List<VeDoanModel>();

            string sql = @"select * from Flight where ID ='"+khoachinh+"' and status = 1 ";
            DataTable tb = db.ExecuteDataSet(sql, CommandType.Text, "server37", null).Tables[0];
            if (tb != null && tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    VeDoanModel result = new VeDoanModel();
                    result.ID = tb.Rows[i]["ID"].ToString();
                    result.Hang = tb.Rows[i]["Airline"].ToString().Trim();
                    result.HanhTrinh = tb.Rows[i]["Itinerary"].ToString().Trim();
                    result.Gia = double.Parse(tb.Rows[i]["Price"].ToString().Trim());
                    result.KindTrip = tb.Rows[i]["KindTrip"].ToString().Trim();
                    //result.SoLuongKhach = tb.Rows[i]["NumberOfGuests"].ToString().Trim();
                    result.DieuKien = tb.Rows[i]["Condition"].ToString().Trim();
                    result.SoLuongKhach = sl[i].ToString().Trim();
                    result.Tongtien = double.Parse(tongtien.ToString().Trim());

                    List<VeDoanDetail> ListVeDoanDetail = new List<VeDoanDetail>();
                    string sqlFlightDetail = @"select *, (convert(varchar, getdate(), 106)) as ngaybay from FlightDetail where  FlightID = '" + tb.Rows[i]["ID"].ToString() + "'";
                    DataTable tbFlightDetail = db.ExecuteDataSet(sqlFlightDetail, CommandType.Text, "server37", null).Tables[0];
                    if (tbFlightDetail != null && tbFlightDetail.Rows.Count > 0)
                    {
                        for (int y = 0; y < tbFlightDetail.Rows.Count; y++)
                        {
                            VeDoanDetail resultDetail = new VeDoanDetail();
                            resultDetail.MaCB = tbFlightDetail.Rows[y]["FlightNumber"].ToString().Trim();
                            resultDetail.NgayBay = tbFlightDetail.Rows[y]["ngaybay"].ToString().Trim();
                            resultDetail.GioBay = tbFlightDetail.Rows[y]["FlightHour"].ToString().Trim();
                            ListVeDoanDetail.Add(resultDetail);
                        }
                        result.ListVeDoan = ListVeDoanDetail;
                    }
                    thongtinve.Add(result);
                }
            }
            return thongtinve;
        }
        public bool luuthongtinve(string thongtinbay, int fightid, string name, string mast, string email, string sdt, string ghichu,string hanhtrinh, double gia, string soluong, double tongtien)
        {
            try
            {
                string sql = "INSERT INTO [BOOKING] ([Name],[Mst] ,[Email],[Tel],[Note],[FlightID],[Quantity],[Price],[Total]) VALUES ( @Name,@Mst,@Email,@Tel,@Note,@FlightID,@Quantity,@Price,@Total)";
                List<TangDuLieu.DBase.AddParameters> Param = new List<TangDuLieu.DBase.AddParameters>();
                Param.Add(new DBase.AddParameters("@Name", name));
                Param.Add(new DBase.AddParameters("@Mst", mast));
                Param.Add(new DBase.AddParameters("@Email", email));
                Param.Add(new DBase.AddParameters("@Tel", sdt));
                Param.Add(new DBase.AddParameters("@Note", ghichu));
                Param.Add(new DBase.AddParameters("@FlightID", fightid));
                Param.Add(new DBase.AddParameters("@Quantity", soluong));
                Param.Add(new DBase.AddParameters("@Price", gia));
                Param.Add(new DBase.AddParameters("@Total", tongtien));

                int abc = db.ExecuteNoneQuery(sql, CommandType.Text, "server37", Param);

                bool resut_sendmail = SendMailDatve(thongtinbay, name,mast,email,sdt,ghichu, hanhtrinh,gia, soluong,tongtien);


                return true;
            }
            catch (Exception ex)
            {
                throw ex;


            }

        }

        public bool SendMailDatve(string thongtinbay, string name, string mast, string email, string sdt, string ghichu,string hanhtrinh, double gia, string soluong, double tongtien)
        {

            MailMessage mail = new MailMessage(baoNS_Booking.username, email);
            mail.From = new MailAddress(baoNS_Booking.username, "ENVIET");
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.Port = baoNS_Booking.port;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(baoNS_Booking.username, new DBase().Decrypt(baoNS_Booking.password, "vodacthe", true));
            client.Host = baoNS_Booking.host;

            string subject = "Thông báo từ New Onlineairticket";
           
            

            mail.Subject = subject;
            ///-------- Start of mail body ------------
            string mailBody;
            var webRequest = System.Net.WebRequest.Create(baoNS_Booking.templateUrl);
            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new System.IO.StreamReader(content))
            { mailBody = reader.ReadToEnd(); }
            mailBody = mailBody.Replace("$_Ngaygui", DateTime.Now.ToString("dd/MM/yyyy"));
            mailBody = mailBody.Replace("$_HoTen", name);
            mailBody = mailBody.Replace("$_Email", email);
            mailBody = mailBody.Replace("$_DienThoai", sdt);
            mailBody = mailBody.Replace("$_GhiChu", ghichu);
            mailBody = mailBody.Replace("$_MaSoThue", mast);
            mailBody = mailBody.Replace("$_Hanhtrinh", hanhtrinh);
            mailBody = mailBody.Replace("$_Lichtrinh", thongtinbay);

            mailBody = mailBody.Replace("$_Gia", string.Format("{0:0,0}",gia).Replace(".", ","));
            mailBody = mailBody.Replace("$_Soluong", soluong);
            mailBody = mailBody.Replace("$_TongTien", string.Format("{0:0,0}", tongtien).Replace(".", ","));

            mail.Body = mailBody;
            mail.IsBodyHtml = true; // Format mail dạng HTML
            ///-------- End of mail body --------------
            client.Send(mail);
            return true;
        }
    }
}
