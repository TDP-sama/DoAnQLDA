using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.IO;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace DoAnQLDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            csdl cs = new csdl();
            cs.AddDL();
        }
        public static NhanVien nv = null;

        
        private Form KiemTraTonTai(Type formType)
        {

            //kiểm tra form đã tồn tại hay chưa để không mở ra thêm
            pnlThongTinSanPham.Visible = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;

        }

        private void dongform()
        {

            //đóng toàn bộ form con khác khi mở 1 form con mới
            foreach (Form mdiForm in this.MdiChildren)
                mdiForm.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dongform(); //đóng toàn bộ form con
        }

        private void tsDangNhap_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(DangNhap));
            if (frm != null)
                frm.Activate(); //kiểm tra form đăng nhập tồn tại hay chưa, nếu rồi thì ko mở thêm

            else
            {
                dongform();
                DangNhap f = new DangNhap();
                f.MdiParent = this;
                f.Show();   //nếu có form con khác thì đóng form rồi mở form đăng nhập
            }

        }

        private void tsBtnHome_Click(object sender, EventArgs e)
        {
            pnlThongTinSanPham.Visible = true;
            Form1_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(DangKyVanChuyen));
            if (frm != null)
                frm.Activate();

            else
            {
                dongform();
                DangKyVanChuyen f = new DangKyVanChuyen();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void btnQLNV_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(QuanLyNhanVien));
            if (frm != null)
                frm.Activate();

            else
            {
                dongform();
                QuanLyNhanVien f = new QuanLyNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(QLDonHang));
            if (frm != null)
                frm.Activate();

            else
            {
                dongform();
                QLDonHang f = new QLDonHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLX_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(QuanLyXe));
            if (frm != null)
                frm.Activate();

            else
            {
                dongform();
                QuanLyXe f = new QuanLyXe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            if (nv != null)
            {
                btnQLDH.Visible = true;
                btnQLX.Visible = true;
                tsBtnNguoiDung.Text = nv.TenNV;
                if (nv.Chucvu.Equals("Quản lý"))
                {
                    btnQLNV.Visible = true;
                }

                tsDangNhap.Visible = false;
                tsBtnNguoiDung.Visible = true;
            }
            else
            {
                btnQLDH.Visible = false;
                btnQLX.Visible = false;
                btnQLNV.Visible = false;
                tsDangNhap.Visible = true;
                tsBtnNguoiDung.Visible = false;
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dangxuat = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dangxuat == DialogResult.Yes) //xác nhận đăng xuất
            {

                //trả ng dùng thành null
                nv = null;
                tsDangNhap.Visible = true;
                tsBtnNguoiDung.Visible = false;
                Form1_Load(sender, e); //load form lại
            }
        }
    }
}
