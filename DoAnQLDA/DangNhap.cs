using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLDA
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool dangnhapthanhcong = false;

            foreach (var i in csdl.lstnv)
            {
                if (i.Email.Equals(txtEmail.Text) && i.MatKhau.Equals(txtPass.Text))
                {
                    //kiểm tra trong list nhanvien
                    Form1.nv = i;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    dangnhapthanhcong = true; //nếu đúng thì hiện thông báo và đi tới trang chủ
                    this.Close();
                    
                    break;
                }
            }

            if (!dangnhapthanhcong)
                //nếu tìm không thấy tài khoản thì hiện thông báo
                MessageBox.Show("Sai email hoặc mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
