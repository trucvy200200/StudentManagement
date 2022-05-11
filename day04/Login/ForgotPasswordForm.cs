using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Web.UI;
using System.Windows.Forms;
using OpenQA.Selenium;
using MailMessage = System.Net.Mail.MailMessage;
using MailPriority = System.Net.Mail.MailPriority;

namespace day04
{
    public partial class ForgotPasswordForm : Form
    {
        MY_DB mydb = new MY_DB();
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        private string OTP="";
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string CreateOTP(int PasswordLength)
        {
            string _allowedChars = "abcdefghijk0123456789mnopqrstuvwxyz";
            Random randNum = new Random();
            char[] chars = new char[PasswordLength];
            int allowedCharCount = _allowedChars.Length;

            for (int i = 0; i < PasswordLength; i++)
            {
                chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
            }
            return new string(chars);
        }
        public string MaHoaMatKhau(string password)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            Byte[] hashBytes = encoding.GetBytes(password);
            // Compute the SHA-1 hash
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            Byte[] cryptPassword = sha1.ComputeHash(hashBytes);
            return BitConverter.ToString(cryptPassword);
        }
        private void DoiMatKhau(string email, string MatKhau)
        {
            SqlCommand cmd = new SqlCommand("UPDATE login SET password=@pass WHERE email=@email",mydb.getConnection);
            cmd.Parameters.Add("@pass", SqlDbType.Char).Value = MatKhau;
            cmd.Parameters.Add("@email", SqlDbType.Char).Value = email;
            try
            {
                mydb.openConnection();
                // Thực thi cƒu lệnh Update
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                mydb.closeConnection();
            }
        }

        
        private DataTable LayTenDangNhap(string email)
        {
            DataTable dtbTmp = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT username FROM login WHERE email=@email", mydb.getConnection);
            cmd.Parameters.Add("@email", SqlDbType.Char).Value = email;
            try
            {
                // Mở kết nối
                mydb.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Login");
                dtbTmp = ds.Tables[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Đóng kết nối
                mydb.closeConnection();
            }
            return dtbTmp;
        }
        private string NoiDungMail()
        {
            string content = "";
            string email=txtEmail.Text;
            DataTable dtb = LayTenDangNhap(txtEmail.Text + "");
            if (dtb.Rows.Count > 0)
            {
                OTP = CreateOTP(5);
                content += "Your OTP is: " + OTP;
                content += "<br><br><hr>Please do not reply this mail!";
            }
            return content;
        }

        private static readonly string _from = "toan9400@gmail.com"; // Email của Sender (của bạn)
        private static readonly string _pass = "alpspghlealhqtbt"; // Mật khẩu Email của Sender (của bạn)

        public void Send(string sendto, string subject)
        {
            //sendto: Email receiver (người nhận)
            //subject: Tiêu đề email
            //content: Nội dung của email, bạn có thể viết mã HTML
            //Nếu gửi email thành công, sẽ trả về kết quả: OK, không thành công sẽ trả về thông tin l�-i
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                string pass = CreateOTP(5);
                string content = NoiDungMail();
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
            private void btn_Change_Click(object sender, EventArgs e)
        {
            MailMessage objEmail = new MailMessage();
            DataTable dtb = LayTenDangNhap(txtEmail.Text + "");
            string mail = txtEmail.Text;
            if (dtb.Rows.Count > 0)
            {
                try
                {
                    Send(mail, "Get OTP");
                    MessageBox.Show("A message is sent! Please check your email");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Send failure: " + exc.ToString());
                }
            }
            else
            {
                MessageBox.Show("Email not existed!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verif()
        {
            if ((textBoxPass.Text.Trim()=="")||textBoxConfirm.Text.Trim()=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label_Here_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(this);
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (OTP==TextBoxOTP.Text.Trim())
            {
                textBoxPass.ReadOnly = false;
                textBoxConfirm.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("wrong OTP");
            }
        }

        private void btn_Change2_Click(object sender, EventArgs e)
        { 
            string pass = textBoxPass.Text;
            string confirm = textBoxConfirm.Text;
            string email = txtEmail.Text;
            if (verif()==true)
            {
                if (pass == confirm)
                {
                    DoiMatKhau(email, pass);
                    MessageBox.Show("Change successfully!");
                }
                else MessageBox.Show("Confirm password is wrong!");
            }
            else
            {
                MessageBox.Show("Empty Field!", "Error");
            }
        }
    }
}
