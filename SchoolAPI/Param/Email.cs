//using _3___DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolAPI.Param
{
    public class Email
    {
        public bool SendEmail(string MailAddress, string msg, string Subject, string UserName, string Password, string Port, string SMTPhost)
        {
            SchoolERPContext db = new SchoolERPContext();
            try
            {
                //var Hostinfo = db.tbl_emailsettings.FirstOrDefault();
                //var username = Hostinfo.fromid;


                //SmtpClient mailSender = new SmtpClient(Hostinfo.host);//"smtp.gmail.com"

                ////mailSender.Port = Int32.Parse(Port );// 25;
                //mailSender.Port = 25;


                //MailMessage message = new MailMessage();

                //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(username, CryptIt.Decrypt(Hostinfo.password));
                //mailSender.Credentials = credentials;
                //mailSender.EnableSsl = true;



                //message.From = new MailAddress(username, "GRIEVANCE");
                //if (MailAddress.Contains(","))//MailAddress
                //{
                //    string[] Multiple = MailAddress.Split(',');
                //    foreach (string Multi in Multiple)
                //    {
                //        message.To.Add(new MailAddress(Multi));
                //    }

                //}
                //else
                //{
                //    message.To.Add(new MailAddress(MailAddress));//MailAddress
                //}


                //message.Subject = Subject;
                //message.Body = msg;
                //message.IsBodyHtml = true;

                //mailSender.Send(message);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}