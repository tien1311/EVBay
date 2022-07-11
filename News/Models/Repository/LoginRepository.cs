
using EV.Common.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using TangDuLieu;

namespace News_Online.Models.Repository
{
    public class LoginRepository
    {


        static DBase db = new DBase();

        //Kiểm tra đăng nhập
        public static AccountModel Login(string Email, string Password)
        {

            AccountModel result = new AccountModel();

            string StrEmail = Email;



            //Mã hóa password
            string StrPassword = db.MD5Encrypt(Password);

            //DataTable dt = db.ExecuteDataSet($"EXEC SP_LOGIN N'{Email}','{StrPassword}'", CommandType.Text, "server18", null).Tables[0];

            //Login mới
            DataTable dt = db.ExecuteDataSet($"EXEC SP_LOGIN_NEW N'{Email}','{StrPassword}'", CommandType.Text, "server18", null).Tables[0];



            if (dt.Rows.Count > 0 && dt != null)
            {
                result.member_id = int.Parse(dt.Rows[0]["member_id"].ToString());

                result.member_name = dt.Rows[0]["member_name"].ToString();
                result.member_kh = dt.Rows[0]["member_kh"].ToString();
                result.member_company = dt.Rows[0]["member_company"].ToString();
                result.member_email = dt.Rows[0]["member_email"].ToString();
                result.member_address = dt.Rows[0]["member_address"].ToString();
                result.member_phone = dt.Rows[0]["member_phone"].ToString();
                result.member_date = DateTime.Parse(dt.Rows[0]["member_date"].ToString());
                string isshow = dt.Rows[0]["member_isshow"].ToString();
                string ishot = dt.Rows[0]["member_ishot"].ToString();
                string isnew = dt.Rows[0]["member_isnew"].ToString();
                string isActive = dt.Rows[0]["member_isactive"].ToString();
                result.member_isshow = Convert.ToBoolean(isshow);
                result.member_ishot = Convert.ToBoolean(Convert.ToInt16(ishot));
                result.member_isnew = Convert.ToBoolean(Convert.ToInt16(isnew));
                result.member_isactive = Convert.ToBoolean(Convert.ToInt16(isActive));

                result.last_login = DateTime.Parse(dt.Rows[0]["last_login"].ToString());
                result.lockReason = dt.Rows[0]["lockReason"].ToString();
                result.member_admin = dt.Rows[0]["member_admin"].ToString();
                result.member_agency_email = dt.Rows[0]["member_agency_email"].ToString();
                //result.token = dt.Rows[0]["token"].ToString();
                //Lấy thông tin kinh doanh
                string sql_kinhdoanh = @"select top 1  NV.Ten,NV.DienThoai,NV.GioiTinh,NV.Skyper
                                        from KHACHHANG_HOPDONG HD 
                                        left join DM_NV NV on HD.MAKINHDOANH = NV.MaNV

                                
                                where HD.MAKETOAN = '" + dt.Rows[0]["member_kh"].ToString() + "' order by NGAYLAP DESC";

                DataTable tb = db.ExecuteDataSet(sql_kinhdoanh, CommandType.Text, "serverUpdate", null).Tables[0];
                if (tb != null && tb.Rows.Count > 0)
                {
                    string[] ten = tb.Rows[0]["Ten"].ToString().Split(' ');
                    if (tb.Rows[0]["GioiTinh"].ToString() == "Nam")
                    {

                        result.nhanvien_kd = "Mr." + ten[ten.Length - 1];

                    }
                    else
                    {
                        result.nhanvien_kd = "Ms." + ten[ten.Length - 1];

                    }
                    result.sodienthoai_kd = tb.Rows[0]["DienThoai"].ToString();
                    result.skype_kd = tb.Rows[0]["Skyper"].ToString();
                }
                else
                {
                    result.nhanvien_kd = "Chưa cập nhật";
                    result.sodienthoai_kd = "Chưa cập nhật";
                    result.skype_kd = "Chưa cập nhật";
                }
                //Lấy thông tin kế toán
                string sql_ketoan = @"select top 1  NV.Ten,NV.DienThoai,NV.GioiTinh,NV.Skyper
                                        from KHACHHANG_HOPDONG HD 
                                        left join DM_NV NV on HD.MANVKETOAN = NV.MaNV

                                
                                where HD.MAKETOAN = '" + dt.Rows[0]["member_kh"].ToString() + "' order by NGAYLAP DESC";

                DataTable tbKT = db.ExecuteDataSet(sql_ketoan, CommandType.Text, "serverUpdate", null).Tables[0];
                if (tbKT != null && tbKT.Rows.Count > 0)
                {
                    string[] ten = tbKT.Rows[0]["Ten"].ToString().Split(' ');
                    if (tbKT.Rows[0]["GioiTinh"].ToString() == "Nam")
                    {

                        result.nhanvien_kt = "Mr." + ten[ten.Length - 1];

                    }
                    else
                    {
                        result.nhanvien_kt = "Ms." + ten[ten.Length - 1];

                    }
                    result.sodienthoai_kt = tbKT.Rows[0]["DienThoai"].ToString();
                    result.skype_kt = tbKT.Rows[0]["Skyper"].ToString();
                }
                else
                {
                    result.nhanvien_kt = "Chưa cập nhật";
                    result.sodienthoai_kt = "Chưa cập nhật";
                    result.skype_kt = "Chưa cập nhật";
                }
            }

            return result;
        }


        //Lấy thông tin đăng nhập
        public static AccountModel GetMember(string MemID, string MemberRoot)
        {
            AccountModel result = new AccountModel();
            string sql = "";


            if (MemberRoot == "1")
            {
                sql = "select * from member where member_id = " + MemID;

            }
            else
            {
                sql = @"SELECT mb.*, mc.Email, mc.HoTen
	                    FROM dbo.MemberClient as mc 
	                    LEFT JOIN dbo.member mb ON mc.MemIDRoot = mb.member_id
	                    WHERE mb.member_id = " + MemID;
            }

            DataTable dt = db.ExecuteDataSet(sql, CommandType.Text, "server18", null).Tables[0];

            if (dt.Rows.Count > 0 && dt != null)
            {
                result.member_id = int.Parse(dt.Rows[0]["member_id"].ToString());


                result.member_kh = dt.Rows[0]["member_kh"].ToString();
                result.member_company = dt.Rows[0]["member_company"].ToString();

                if (MemberRoot == "1")
                {
                    result.member_name = dt.Rows[0]["member_name"].ToString();
                    result.member_email = dt.Rows[0]["member_email"].ToString();
                    result.member_agency_email = "";
                }
                else
                {
                    result.member_name = dt.Rows[0]["HoTen"].ToString();
                    result.member_email = dt.Rows[0]["Email"].ToString();
                    result.member_agency_email = dt.Rows[0]["member_email"].ToString();
                }

                result.member_address = dt.Rows[0]["member_address"].ToString();
                result.member_phone = dt.Rows[0]["member_phone"].ToString();
                result.member_date = DateTime.Parse(dt.Rows[0]["member_date"].ToString());
                string isshow = dt.Rows[0]["member_isshow"].ToString();
                string ishot = dt.Rows[0]["member_ishot"].ToString();
                string isnew = dt.Rows[0]["member_isnew"].ToString();
                string isActive = dt.Rows[0]["member_isactive"].ToString();
                result.member_isshow = Convert.ToBoolean(isshow);
                result.member_ishot = Convert.ToBoolean(Convert.ToInt16(ishot));
                result.member_isnew = Convert.ToBoolean(Convert.ToInt16(isnew));
                result.member_isactive = Convert.ToBoolean(Convert.ToInt16(isActive));

                result.last_login = DateTime.Parse(dt.Rows[0]["last_login"].ToString());
                result.lockReason = dt.Rows[0]["lockReason"].ToString();
                //result.member_admin = dt.Rows[0]["member_admin"].ToString();
                //result.member_agency_email = dt.Rows[0]["member_agency_email"].ToString();
                //result.member_admin = dt.Rows[0]["member_admin"].ToString();
                //result.token = dt.Rows[0]["token"].ToString();
                //Lấy thông tin kinh doanh
                string sql_kinhdoanh = @"select top 1  NV.Ten,NV.DienThoai,NV.GioiTinh,NV.Skyper
                                        from KHACHHANG_HOPDONG HD 
                                        left join DM_NV NV on HD.MAKINHDOANH = NV.MaNV

                                
                                where HD.MAKETOAN = '" + dt.Rows[0]["member_kh"].ToString() + "' order by NGAYLAP DESC";

                DataTable tb = db.ExecuteDataSet(sql_kinhdoanh, CommandType.Text, "serverUpdate", null).Tables[0];
                if (tb != null && tb.Rows.Count > 0)
                {
                    string[] ten = tb.Rows[0]["Ten"].ToString().Split(' ');
                    if (tb.Rows[0]["GioiTinh"].ToString() == "Nam")
                    {

                        result.nhanvien_kd = "Mr." + ten[ten.Length - 1];

                    }
                    else
                    {
                        result.nhanvien_kd = "Ms." + ten[ten.Length - 1];

                    }
                    result.sodienthoai_kd = tb.Rows[0]["DienThoai"].ToString();
                    result.skype_kd = tb.Rows[0]["Skyper"].ToString();
                }
                else
                {
                    result.nhanvien_kd = "Chưa cập nhật";
                    result.sodienthoai_kd = "Chưa cập nhật";
                    result.skype_kd = "Chưa cập nhật";
                }
                //Lấy thông tin kế toán
                string sql_ketoan = @"select top 1  NV.Ten,NV.DienThoai,NV.GioiTinh,NV.Skyper
                                        from KHACHHANG_HOPDONG HD 
                                        left join DM_NV NV on HD.MANVKETOAN = NV.MaNV

                                
                                where HD.MAKETOAN = '" + dt.Rows[0]["member_kh"].ToString() + "' order by NGAYLAP DESC";

                DataTable tbKT = db.ExecuteDataSet(sql_ketoan, CommandType.Text, "serverUpdate", null).Tables[0];
                if (tbKT != null && tbKT.Rows.Count > 0)
                {
                    string[] ten = tbKT.Rows[0]["Ten"].ToString().Split(' ');
                    if (tbKT.Rows[0]["GioiTinh"].ToString() == "Nam")
                    {

                        result.nhanvien_kt = "Mr." + ten[ten.Length - 1];

                    }
                    else
                    {
                        result.nhanvien_kt = "Ms." + ten[ten.Length - 1];

                    }
                    result.sodienthoai_kt = tbKT.Rows[0]["DienThoai"].ToString();
                    result.skype_kt = tbKT.Rows[0]["Skyper"].ToString();
                }
                else
                {
                    result.nhanvien_kt = "Chưa cập nhật";
                    result.sodienthoai_kt = "Chưa cập nhật";
                    result.skype_kt = "Chưa cập nhật";
                }
            }

            return result;
        }

        //Template mail quên mật khẩu
        public static string Templmail(string StrUserName, string StrNewPass, string StrDateTime)
        {
            string StrTempMail = @"
            <!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
            <html xmlns='http://www.w3.org/1999/xhtml'>
                        <head>
                        <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
                        <title>Đại lý vé máy bay Én Việt</title>
                        <style>
            body {
	            font-family: Arial;
	            font-size: 13px;
	            margin: 0;
            }
            #content {
	            width: 90%;
	            margin: auto;
            }
            .BDwrapper {
	            width: 100%;
	            height: 80px;
	            background-image: url(http://manager.airline24h.com/images/bg-top.png);
            }
            #wrap {
	            width: 100%;
	            height: 71px;
	            margin: auto;
	            background-image: url(http://manager.airline24h.com/images/group-logo.png);
	            background-repeat: no-repeat;
	            background-position: left top;
            }
            .wrapper1 {
	            width: 100%;
	            background-repeat: no-repeat;
	            background-position: center;
            }
            .main {
	            padding: 20px;
	            min-height: 500px;
	            margin: auto;
	            margin: 20px 0 20px 0;
            }
            .foot {
	            background-color: #909090;
	            width: 100%;
	            height: 256px;
	            position: static;
	            bottom: 0;
	            margin: auto;
            }
            .roundedTop-corners {
	            border-top-left-radius: 10px 5px;
	            border-top-right-radius: 10px 5px;
            }
            .textfoot {
	            float: right;
	            bottom: 0px;
	            font-size: 10px;
	            color: #FFF;
	            margin: 20px 20px 0 20px;
            }
            .rounded-corners {
	            border-radius: 10px;
            }
            .foot table tr th {
	            color: #fff;
	            font-size: 13px;
	            text-transform: uppercase;
	            text-align: left
            }
            .foot table tr th span {
	            font-size: 17px;
	            float: right;
	            color: #000;
            }
            .foot table tr td {
	            color: #fff;
	            vertical-align: top;
            }
            .foot table tr td img {
	            float: left;
	            margin: 0 10px 10px 0;
            }
            .foot table tr td span {
	            margin-bottom: 3px;
            }
            .foot table tr td strong {
	            font-size: 11px;
	            font-weight: normal;
            }
            .call {
	            margin: 10px;
	            font-size: 16px;
            }
            .call p {
	            height: 20px;font-size: 12px;margin: 0 0 2px 0;padding: 0;
            }
            .header {j
                        background-color:#ff6a00;
                        color:#fff;
                        font-weight:bold;
                    }
                    .label {
                        color:#000;background-color:#ededed;
                    }
            </style>
                        </head>

                        <body>
                        <div style='width:90%;margin:auto;'>
                          <div style='width:100%;height:80px;background-image:url(http://manager.airline24h.com/images/bg-top.png);'>
                            <div style='width:100%;height:71px;margin:auto;background-image:url(http://manager.airline24h.com/images/group-logo.png);background-repeat:no-repeat;background-position:left top;'></div>
                          </div>
                          <div style='width:100%;background-repeat: no-repeat;background-position:center;'>
                            <div style='padding:20px;min-height:100px;margin:auto;margin:20px 0 20px 0;'> 
                              <!------ Body ---->
                              <table cellpadding='5' cellspacing='0' border='0' width='100%'>
                                <!--tr>
                                  <td colspan='4' style='font-size:11px;text-align:right;'><label style='float:left;font-size:12px;font-weight:bold;'>Công Ty cổ phần Én Việt </label>
                                   </td>
                                </tr-->
                                <tr>
                                  <td colspan='4'> Én Việt xin thông báo, chúng tôi nhận được yêu cầu khôi phục mật khẩu của bạn</td>
                                </tr>
                                <tr>
                                  <td colspan='4' align='center' valign='top'>
                                  <!--- Thong Tin Ve Hoan --->
                                    <table cellspacing='2' cellpadding='5' border='0' align='center' width='80%'>
                                      <tr>
                                        <td class='header' style='background-color:#ff6a00;color:#fff;font-weight:bold;' colspan='2'> Thông Tin Mật Khẩu Mới</td>
                                      </tr>
                                      <tr>
                                        <td class='label' style='color:#000;background-color:#ededed;width:200px;'>Tên đăng nhập</td>
                                        <td>" + StrUserName + @"</td>
                                      </tr>
                                      <tr>
                                        <td class='label' style='color:#000;background-color:#ededed;'>Mật khẩu:</td>
                                        <td>" + StrNewPass.Trim() + @"</td>
                                      </tr>
                                      <tr>
                                        <td colspan='2'> Thông tin trên được gửi vào lúc :
                                          " + StrDateTime + @"</td>
                                      </tr>
                                    </table>
                                    <!--- Thong Tin Ve Hoan --->
                                    </td>
                                </tr>
                              </table>
                              <!------ Body ----> 
                            </div>
                          </div>
                        </div>
            </body>
            </html>
            ";
            return StrTempMail;
        }


        //Khởi tạo password mới
        public static string GeneratePassword()
        {
            string strPwdchar = "abcdefghijklmnopqrstuvwxyz0123456789#+@&$ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string strPwd = "";
            Random rnd = new Random();
            for (int i = 0; i <= 7; i++)
            {
                int iRandom = rnd.Next(0, strPwdchar.Length - 1);
                strPwd += strPwdchar.Substring(iRandom, 1);
            }
            return strPwd;
        }
        //Gửi mail
        public static string SendMail_recov(string StrMailTo, string from, string subject, string body)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;
            try
            {
                MailAddress fromAddress = new MailAddress(from, "no-reply<reset@enviet-group.com>");
                message.From = fromAddress;
                message.To.Add(StrMailTo);
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = "<html><body>" + body + "</body></html>";
                smtpClient.Host = "mail.enviet-group.com";   // We use gmail as our smtp client
                smtpClient.Port = 25;
                smtpClient.EnableSsl = false;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("reset", "Evevgroup@458903@");
                smtpClient.Send(message);
                msg = "Successful";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        //Reset password và gửi mail
        public static string ForgetPassword(string Email)
        {
            string message = "";
            string Strtempl = "";
            string NewPass = GeneratePassword();
            string StrDateNow = DateTime.Now.ToString("dd/MM/yyyy H:m");
            string EnsryptPass = db.MD5Encrypt(NewPass);
            string sql = " SELECT member_id FROM member WHERE member_email='" + Email + "'";
            DataTable dt = db.ExecuteDataSet(sql, CommandType.Text, "server18", null).Tables[0];

            if (dt.Rows.Count > 0 && dt.Rows.Count < 2)
            {
                string SqlUp = "UPDATE member SET member_status = 1, member_password='" + EnsryptPass + "' WHERE member_email='" + Email + "'";
                int reck = db.ExecuteNoneQuery(SqlUp, CommandType.Text, "server18", null);
                if (reck > 0)
                {
                    Strtempl = Templmail(Email, NewPass.Trim(), StrDateNow);
                    string StrAler = SendMail_recov(Email, "reset@enviet-group.com", " Thông Tin Khôi Phục Mật Khẩu ", Strtempl);//CustomerMail
                    if (StrAler == "Successful")
                    {
                        message = "Khôi phục mật khẩu thành công !";

                    }
                    else
                    {
                        message = StrAler;

                    }
                }
            }
            else
            {
                message = "Tên email không đúng";

            }
            return message;
        }
        //Ẩn hóa đơn
        public static string HiddenInvoice()
        {
            var hidden = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConfigService").GetSection("HiddenHDDT").Value;
            return hidden;
        }
        //Ẩn yêu cầu
        public static string HiddenRequest()
        {
            var hidden = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConfigService").GetSection("HiddenRequest").Value;
            return hidden;
        }
        public static AccountKH LoginKH(string Email, string Password)
        {

            AccountKH result = new AccountKH();

            string StrEmail = Email;
            //Mã hóa password
            string StrPassword = db.MD5Encrypt(Password);
            string sql = "select * from Accout_KH where Email='" + Email + "'";
            DataTable tb = db.ExecuteDataSet(sql, CommandType.Text, "server37_Article", null).Tables[0];
            if (tb.Rows.Count > 0)
            {
                string strMatKhau = tb.Rows[0]["MatKhau"].ToString();
                if (StrPassword == strMatKhau)
                {

                    result.RowID = tb.Rows[0]["RowID"].ToString();
                    result.MaKH = tb.Rows[0]["MaKH"].ToString();
                    result.SinhNhat = tb.Rows[0]["SinhNhat"].ToString();
                    //result.SinhNhat = DateTime.Parse(tb.Rows[0]["SinhNhat"].ToString());
                    result.Ten = tb.Rows[0]["Ten"].ToString();
                    string[] Ten = tb.Rows[0]["Ten"].ToString().Split(' ');
                    if (tb.Rows[0]["GioiTinh"].ToString() == "Nam")
                    {
                        result.Ten = "Mr." + Ten[Ten.Length - 1];
                    }
                    else
                    {
                        result.Ten = "Ms." + Ten[Ten.Length - 1];
                    }
                    result.DienThoai = tb.Rows[0]["DienThoai"].ToString();
                    result.Email = tb.Rows[0]["Email"].ToString();
                    //result.NgayTao = DateTime.Parse(tb.Rows[0]["NgayTao"].ToString());
                    result.Email = tb.Rows[0]["NgayTao"].ToString();
                }
                else
                {
                    result.ThongBao = "Mật khẩu không đúng!";

                }

              
            }
            return result;
        }
        public bool CreateAccoutKH(string Name, string Email, string password, string Phone,string Dateofbirth)
        {
            string StrPassword = db.MD5Encrypt(password);
            string sql = "INSERT INTO [Accout_KH] ([Ten],[Email] ,[MatKhau],[DienThoai],[SinhNhat],[NgayTao]) VALUES ( @Ten,@Email,@MatKhau,@DienThoai,@SinhNhat,@NgayTao)";
            List<TangDuLieu.DBase.AddParameters> Param = new List<TangDuLieu.DBase.AddParameters>();
            Param.Add(new DBase.AddParameters("@Ten", Name));
            Param.Add(new DBase.AddParameters("@Email", Email));
            Param.Add(new DBase.AddParameters("@MatKhau", StrPassword));
            Param.Add(new DBase.AddParameters("@DienThoai", Phone));
            Param.Add(new DBase.AddParameters("@SinhNhat", Dateofbirth));
            Param.Add(new DBase.AddParameters("@NgayTao", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")));

            int abc = db.ExecuteNoneQuery(sql, CommandType.Text, "server37_Article", Param);
            return true;
        }
    }
}

    








