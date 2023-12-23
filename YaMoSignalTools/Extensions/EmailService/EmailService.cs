using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace YaMoSignalTools.Extensions.EmailService
{
    public class EmailService
    {
        public string SendQQMail(string subject, string bodyContent)
        {
            string smtpService = Constant.EMAIL_QQ_SMTPPROT;
            string sendEmail = Constant.EMAIL_QQ_SENDADDR;
            string sendpwd = Constant.EMAIL_QQ_AUTHCODE;

            //确定smtp服务器地址 实例化一个Smtp客户端
            SmtpClient smtpclient = new SmtpClient();
            smtpclient.Host = smtpService;
            //smtpClient.Port = "";//qq邮箱可以不用端口

            //确定发件地址与收件地址
            MailAddress sendAddress = new MailAddress(sendEmail);
            MailAddress receiveAddress = new MailAddress(Constant.EMAIL_QQ_RECEADDR);

            //构造一个Email的Message对象 内容信息
            MailMessage mailMessage = new MailMessage(sendAddress, receiveAddress);
            mailMessage.Subject = subject + DateTime.Now;
            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            mailMessage.Body = bodyContent;
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;

            //邮件发送方式  通过网络发送到smtp服务器
            smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;

            //如果服务器支持安全连接，则将安全连接设为true
            smtpclient.EnableSsl = true;
            try
            {
                //是否使用默认凭据，若为false，则使用自定义的证书，就是下面的networkCredential实例对象
                smtpclient.UseDefaultCredentials = false;

                //指定邮箱账号和密码,需要注意的是，这个密码是你在QQ邮箱设置里开启服务的时候给你的那个授权码
                NetworkCredential networkCredential = new NetworkCredential(sendEmail, sendpwd);
                smtpclient.Credentials = networkCredential;

                //发送邮件
                smtpclient.Send(mailMessage);
                Console.WriteLine("发送邮件成功");

            }
            catch (System.Net.Mail.SmtpException ex) { Console.WriteLine(ex.Message, "发送邮件出错"); }
            return "发送邮件成功!";
        }

        public void Send163Mail(string subject, string bodyContent)
        {
            MailMessage msg = new MailMessage();
            msg.Subject = subject + DateTime.Now; ;   //标题
            msg.Body = bodyContent;    //内容
            msg.From = new MailAddress(Constant.EMAIL_163_SENDADDR);
            msg.To.Add(Constant.EMAIL_163_RECEADDR);
            SmtpClient client = new SmtpClient();
            client.Host = Constant.EMAIL_163_SMTPPROT;   //发件方服务器地址
            client.Port = 25;  //发件方端口
            client.UseDefaultCredentials = true;
            NetworkCredential credential = new NetworkCredential(Constant.EMAIL_163_SENDADDR, Constant.EMAIL_163_AUTHCODE);
            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.Credentials = credential;
            client.Send(msg);
        }
    }
}
