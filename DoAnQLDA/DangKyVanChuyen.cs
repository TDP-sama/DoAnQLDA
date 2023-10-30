using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DoAnQLDA
{
    public partial class DangKyVanChuyen : Form
    {
        public DangKyVanChuyen()
        {
            InitializeComponent();
        }

        string otp = null;//tạo 1 mã otp rỗng

        public string makeRandomOTP()
        {
            //Tạo 1 dãy chuỗi có các ký tự chữ hoa, thường, số
            string UpperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string LowerCase = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "1234567890";
            string allCharacters = UpperCase + LowerCase + Digits;
            Random r = new Random();

            //tạo 1 chuỗi rỗng
            String password = "";

            //lấy ngẫu nhiến 5 ký tự bất kỳ từ chuỗi
            for (int i = 0; i < 5; i++)
            {
                double rand = r.NextDouble();
                if (i == 0)
                {
                    password += UpperCase.ToCharArray()[(int)Math.Floor(rand * UpperCase.Length)];
                }
                else
                {
                    password += allCharacters.ToCharArray()[(int)Math.Floor(rand * allCharacters.Length)];
                }
            }

            //trả về chuỗi ngẫu nhiên
            return password;
        }

        public void guiMail(string otp)
        {


            var fromAddress = new MailAddress("phudinhtruong69@gmail.com"); //email gửi
            var toAddress = new MailAddress(txtEmail.ToString()); //email nhận được nhập vào
            const string fromPassword = "gzqu icij ksxr ywth";//mk app của email gửi
            const string subject = "OTP Code";//tiêu đề email
            string body = otp;//otp đã được tạo từ trước
            var smtp = new SmtpClient //mã gửi gmail, lụm trên mạng đéo hiểu lắm
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };


            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {

                smtp.Send(message);
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (otp != null && otp.Equals(txtOTP.Text)
                && txtHoTen.Text != null
                && txtDiaChi.Text != null
                && txtSDT.Text != null
                && txtEmail.Text != null)
            {
                pnlBuoc1.Visible = false;
                pnlBuoc2.Visible = true;
                pnlBuoc3.Visible = false;
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            try
            {
                otp = makeRandomOTP();
                guiMail(otp);
                MessageBox.Show("Đã gửi OTP thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Có chắc hủy?", "Hủy?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXacNhan2_Click(object sender, EventArgs e)
        {
            if (txtDiaChiDi.Text != null && txtDiaChiDen.Text != null && cbxLoaiDichVu.Text != null)
            {
                pnlBuoc1.Visible = false;
                pnlBuoc2.Visible = false;
                pnlBuoc3.Visible = true;

                txtCheckHoTen.Text = txtHoTen.Text;
                txtCheckSDT.Text = txtSDT.Text;
                txtCheckEmail.Text = txtEmail.Text;
                txtCheckDiaChi.Text = txtDiaChi.Text;
                txtCheckDiaChiDi.Text = txtDiaChiDi.Text;
                txtCheckDiaChiDen.Text = txtDiaChiDen.Text;
                txtCheckLoaiDichVu.Text = cbxLoaiDichVu.Text;
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnQuaylai2_Click(object sender, EventArgs e)
        {
            pnlBuoc1.Visible = true;
            pnlBuoc2.Visible = false;
            pnlBuoc3.Visible = false;
        }

        private void btnQuaylai3_Click(object sender, EventArgs e)
        {
            pnlBuoc1.Visible = false;
            pnlBuoc2.Visible = true;
            pnlBuoc3.Visible = false;
        }

        private void DangKyVanChuyen_Load(object sender, EventArgs e)
        {
            pnlBuoc1.Visible = true;
            pnlBuoc2.Visible = false;
            pnlBuoc3.Visible = false;
        }

        private void cbxLoaiDichVu_DropDownClosed(object sender, EventArgs e)
        {
            if (cbxLoaiDichVu.Text.Equals("Chuyển nhà"))
            {
                txtDiaChiDi.Text = txtDiaChi.Text.ToString();
            }
        }

        private void btnXacNhan3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đặt đơn hàng này", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DonHang dh = new DonHang();
                dh.id = csdl.lstdh.Last().id + 1;
                dh.TenKhach = txtCheckHoTen.Text;
                dh.SDT = txtCheckSDT.Text;
                dh.Email = txtCheckEmail.Text;
                dh.DiaChi = txtCheckDiaChi.Text;
                dh.DiaChiDen = txtCheckDiaChiDen.Text;
                dh.DiaChiDi = txtCheckDiaChiDi.Text;
                dh.LoaiDichVu = txtCheckLoaiDichVu.Text;
                dh.NgayDat = DateTime.Today;
                dh.TinhTrang = "Đang chờ";
                csdl.lstdh.Add(dh);
                MessageBox.Show("Đặt đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
