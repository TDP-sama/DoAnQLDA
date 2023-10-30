using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoAnQLDA
{
    public partial class QuanLyXe : Form
    {
        public QuanLyXe()
        {
            InitializeComponent();
        }

        Xe xe = new Xe();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            dgvXe.Enabled = false;

            txtMaXe.Clear();
            txtLoaiXe.Clear();
            txtGiatien.Clear();
        }

        private void QuanLyXe_Load(object sender, EventArgs e)
        {
            dgvXe.DataSource = (
                                from x in csdl.lstxe
                                select new
                                {
                                    Ma_Don_Hang = x.id,
                                    Loai_Xe = x.LoaiXe,
                                    Gia_Tien = x.GiaTien,
                                    Ngay_Nhap = x.NgayNhap.Value,
                                    Tinh_Trang = x.TinhTrang,

                                }).ToList();

            panel1.Enabled = false;
            dgvXe.Enabled = true;
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<Xe> xes = csdl.lstxe;
                if (dgvXe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    foreach (var i in xes)
                    {
                        if (dgvXe.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == i.id.ToString())
                        {
                            xe = i;
                        }
                    }
                }

                txtMaXe.Text=xe.id.ToString();
                txtLoaiXe.Text = xe.LoaiXe.ToString();
                txtGiatien.Text = xe.GiaTien.ToString();
                dtpNgayNhap.Value = (DateTime)xe.NgayNhap;
                cbxTheLoai.Text = xe.TinhTrang.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Xe> tinhtrang = new List<Xe>();
            foreach (var i in csdl.lstxe)
            {
                if (i.TinhTrang == cbxTinhTrang.Text)
                {
                    tinhtrang.Add(i);
                }
            }
            dgvXe.DataSource = (
                                from x in tinhtrang
                                select new
                                {
                                    Ma_Don_Hang = x.id,
                                    Loai_Xe = x.LoaiXe,
                                    Gia_Tien = x.GiaTien,
                                    Ngay_Nhap = x.NgayNhap.Value,
                                    Tinh_Trang = x.TinhTrang,
                                }).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            dgvXe.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa xe này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Xe deleteX = csdl.lstxe.FirstOrDefault(p => p.id.ToString() == txtMaXe.Text);
                if (deleteX != null)
                {
                    csdl.lstxe.Remove(deleteX);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    QuanLyXe_Load(sender, e);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtLoaiXe.Text != "" && txtGiatien.Text != "" && cbxTinhTrang.Text != "")
            {
                xe.LoaiXe=txtLoaiXe.Text;
                xe.GiaTien=int.Parse(txtGiatien.Text);
                xe.NgayNhap=dtpNgayNhap.Value;
                xe.TinhTrang = cbxTinhTrang.Text;
                if (txtMaXe.Text == "")
                {
                    xe.id = (csdl.lstxe.Last().id + 1);
                    csdl.lstxe.Add(xe);
                }
                else
                {
                    Xe updateX = csdl.lstxe.FirstOrDefault(p => p.id.ToString() == txtMaXe.Text);
                    if (updateX != null)
                    {
                        updateX = xe;
                    }
                }
                dgvXe.Enabled = true;
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
                QuanLyXe_Load(sender, e);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                QuanLyXe_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                this.Close();
        }
    }
}
