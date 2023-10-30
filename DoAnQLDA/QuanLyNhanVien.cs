using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLDA
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = (from nv in csdl.lstnv
                                      select new
                                      {
                                          Ma_Nhan_Vien = nv.id,
                                          Ten_Nhan_Vien = nv.TenNV,
                                          Gioi_Tinh= nv.GioiTinh,
                                          SDT= nv.SDT,
                                          Chuc_Vu=nv.Chucvu,
                                          Luong=nv.Luong,
                                      }).ToList();

            txtTimNV.Text = "";
            panel1.Enabled = false;
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            List<NhanVien> TimNVTheoTen = new List<NhanVien>();
            foreach (var i in csdl.lstnv)
            {
                if (txtTimNV.Text.Contains(i.TenNV))
                {
                    TimNVTheoTen.Add(i);
                }
            }
            dgvNhanVien.DataSource = (from nv in TimNVTheoTen
                                      select new
                                      {
                                          Ma_Nhan_Vien = nv.id,
                                          Ten_Nhan_Vien = nv.TenNV,
                                          Gioi_Tinh = nv.GioiTinh,
                                          SDT = nv.SDT,
                                          Chuc_Vu = nv.Chucvu,
                                          Luong = nv.Luong,
                                      }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            
            txtMaNV.Clear();
            txtHoTen.Clear();
            cbxChucVu.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Clear();
            cbxGioiTinh.Text = "Nam";
            txtSDT.Clear();

            
            dgvNhanVien.Enabled = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            dgvNhanVien.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NhanVien deleteNV = csdl.lstnv.FirstOrDefault(p => p.id.ToString() == txtMaNV.Text);
                if (deleteNV != null)
                {
                    csdl.lstnv.Remove(deleteNV);
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                    QuanLyNhanVien_Load(sender, e);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now.Year - dtpNgaySinh.Value.Year) <= 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "", MessageBoxButtons.OK);
            }

            else if (txtHoTen.Text != "" &&
                txtEmail.Text != "" &&
                txtSDT.Text != null)
            {
                nv.TenNV = txtHoTen.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.Email = txtEmail.Text;
                nv.GioiTinh = cbxGioiTinh.Text;
                nv.SDT = txtSDT.Text;
                nv.Chucvu = cbxChucVu.Text;
                nv.Luong = int.Parse(txtLuong.Text);
                if (txtMaNV.Text == "")
                {
                    nv.id = (csdl.lstnv.Last().id + 1);
                    nv.MatKhau = "123";
                    csdl.lstnv.Add(nv);
                }
                else
                {
                    NhanVien updateNV = csdl.lstnv.FirstOrDefault(p => p.id.ToString() == txtMaNV.Text);
                    if (updateNV != null)
                    {
                        updateNV = nv;
                    }
                }

                dgvNhanVien.Enabled = true;
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
                QuanLyNhanVien_Load(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                QuanLyNhanVien_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<NhanVien> lstNV = csdl.lstnv.ToList();
            if (dgvNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                foreach (var i in lstNV)
                {
                    if (dgvNhanVien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == i.id.ToString())
                    {
                        nv = i;
                    }
                }
            }
            txtMaNV.Text = nv.id.ToString();
            txtHoTen.Text = nv.TenNV;
            cbxChucVu.Text = nv.Chucvu;
            dtpNgaySinh.Value = (DateTime)nv.NgaySinh;
            txtEmail.Text = nv.Email;
            cbxGioiTinh.Text = nv.GioiTinh;
            txtSDT.Text = nv.SDT;
            txtLuong.Text = nv.Luong.ToString();
        }
    }
}
