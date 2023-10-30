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
    public partial class QLDonHang : Form
    {
        public QLDonHang()
        {
            InitializeComponent();
        }
        DonHang dh = new DonHang();

        private void QLDonHang_Load(object sender, EventArgs e)
        {
            List<NhanVien> taixe = new List<NhanVien>();
            foreach (var i in csdl.lstnv)
            {
                if (i.Chucvu.Equals("Tài xế"))
                {
                    taixe.Add(i);
                }
            }
            cbxTaiXe.DataSource = taixe;
            cbxTaiXe.DisplayMember = "TenNV";

            dgvDonHang.DataSource = (from dh in csdl.lstdh
                                     select new
                                     {
                                         Ma_Don_Hang = dh.id,
                                         Ngay_Dat = dh.NgayDat,
                                         Ten_Khach_Hang = dh.TenKhach,
                                         SDT = dh.SDT,
                                         Dia_Chi_Di = dh.DiaChiDi,
                                         Dia_Chi_Den = dh.DiaChiDen,
                                         Loai_Dich_Vu = dh.LoaiDichVu,
                                         Tinh_Trang = dh.TinhTrang,
                                     }).ToList();

            panel2.Enabled = false;
            cbxTinhTrang.Text = "Tình trạng";
            panel1.Visible = false;
            dgvDonHang.Enabled = true;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            QLDonHang_Load(sender, e);
        }

        private void cbxTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DonHang> tinhtrang = new List<DonHang>();
            foreach (var i in csdl.lstdh)
            {
                if (i.TinhTrang == cbxTinhTrang.Text)
                {
                    tinhtrang.Add(i);
                }
            }
            dgvDonHang.DataSource = (from dh in tinhtrang
                                     select new
                                     {
                                         Ma_Don_Hang = dh.id,
                                         Ngay_Dat = dh.NgayDat,
                                         Ten_Khach_Hang = dh.TenKhach,
                                         SDT = dh.SDT,
                                         Dia_Chi_Di = dh.DiaChiDi,
                                         Dia_Chi_Den = dh.DiaChiDen,
                                         Loai_Dich_Vu = dh.LoaiDichVu,
                                         Tinh_Trang = dh.TinhTrang,
                                     }).ToList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text != "Đã hoàn thành" && txtTinhTrang.Text != "Đang vận chuyển")
            {
                panel2.Enabled = true;
                dgvDonHang.Enabled = false;
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Đơn hàng này không thể sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" &&
                txtDiemDen.Text != "" &&
                txtDiemDi.Text != "" &&
                txtDiaChi.Text != "" &&
                txtEmail.Text != "" &&
                txtSDT.Text != ""
                )
            {
                dh.TenKhach = txtTenKH.Text;
                dh.SDT = txtSDT.Text;
                dh.Email = txtEmail.Text;
                dh.DiaChi = txtDiaChi.Text;
                dh.DiaChiDen = txtDiemDen.Text;
                dh.DiaChiDi = txtDiaChi.Text;
                dh.LoaiDichVu = cbxLoaiDV.Text;
                dh.NgayDat = (DateTime)dtpNgayDat.Value;
                dh.NgayDi = dtpNgayDi.Value;
                dh.NgayDen = dtpNgayDen.Value;
                if (txtTongTien.Text != null)
                    dh.TongTien = int.Parse(txtTongTien.Text);
                if (cbxTaiXe.Text != null)
                {
                    NhanVien tx = (NhanVien)cbxTaiXe.SelectedValue;
                    dh.idTaiXe = tx.id;
                }
                DonHang updateDH = csdl.lstdh.FirstOrDefault(p => p.id.ToString() == txtMaDH.Text);
                if (updateDH != null)
                {
                    updateDH = dh;
                }
            }
            MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
            QLDonHang_Load(sender, e);
        }

        private void btnHuySua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                QLDonHang_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text != "Đã hoàn thành" && txtTinhTrang.Text != "Đang vận chuyển")
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dh.TinhTrang = "Hủy đơn";
                    DonHang updateDH = csdl.lstdh.FirstOrDefault(p => p.id.ToString() == txtMaDH.Text);
                    if (updateDH != null)
                    {
                        updateDH = dh;

                    }
                    MessageBox.Show("Hủy đơn hàng thành công", "", MessageBoxButtons.OK);
                    QLDonHang_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Không thể hủy đơn hàng này", "", MessageBoxButtons.OK);
            }

        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                foreach (var i in csdl.lstdh)
                {
                    if (dgvDonHang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == i.id.ToString())
                    {
                        dh = i;
                    }
                }
            }

            txtMaDH.Text = dh.id.ToString();
            txtTenKH.Text = dh.TenKhach;
            txtSDT.Text = dh.SDT;
            txtDiaChi.Text = dh.DiaChi;
            txtDiemDen.Text = dh.DiaChiDen;
            txtDiemDi.Text = dh.DiaChiDi;
            txtEmail.Text = dh.Email;
            txtTongTien.Text = dh.TongTien.ToString();
            txtTinhTrang.Text = dh.TinhTrang;
            cbxLoaiDV.Text = dh.LoaiDichVu;
            if (dh.idTaiXe != null)
            {
                NhanVien tx = csdl.lstnv.FirstOrDefault(p => p.id == dh.idTaiXe);
                if (tx != null)
                    cbxTaiXe.Text = tx.TenNV;
            }
            dtpNgayDat.Value = (DateTime)dh.NgayDat;
            if (dh.NgayDi != null)
                dtpNgayDi.Value = (DateTime)dh.NgayDi;
            if (dh.NgayDen != null)
                dtpNgayDen.Value = (DateTime)dh.NgayDen;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text != "Đã hoàn thành" && txtTinhTrang.Text != "Đang vận chuyển" && txtTinhTrang.Text != "Hủy đơn")
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xác nhận?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dh.idNVLap = Form1.nv.id;
                    dh.TinhTrang = "Đã xác nhận";
                    DonHang updateDH = csdl.lstdh.FirstOrDefault(p => p.id.ToString() == txtMaDH.Text);
                    if (updateDH != null)
                    {
                        updateDH = dh;
                    }
                    MessageBox.Show("Xác nhận thành công", "", MessageBoxButtons.OK);
                    QLDonHang_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Không thể xác nhận", "", MessageBoxButtons.OK);
            }
        }

        private void btnDangVanChuyen_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text == "Đã xác nhận" && dh.idTaiXe!=null && dh.TongTien!=null)
            {
                DialogResult dr = MessageBox.Show("Đang vận chuyển hàng?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dh.TinhTrang = "Đang vận chuyển";
                    DonHang updateDH = csdl.lstdh.FirstOrDefault(p => p.id.ToString() == txtMaDH.Text);
                    if (updateDH != null)
                    {
                        updateDH = dh;
                    }
                    MessageBox.Show("Chuyển trạng thái thành công", "", MessageBoxButtons.OK);
                    QLDonHang_Load(sender, e);
                }
            }
            else if(dh.idTaiXe == null || dh.TongTien == null)
            {
                MessageBox.Show("Đơn hàng còn thiếu thông tin", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Chuyển trạng thái thất bại", "", MessageBoxButtons.OK);

            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text == "Đang vận chuyển")
            {
                DialogResult dr = MessageBox.Show("Đã hoàn thành đơn hàng?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dh.idNVLap = Form1.nv.id;
                    dh.TinhTrang = "Đã Hoàn thành";
                    DonHang updateDH = csdl.lstdh.FirstOrDefault(p => p.id.ToString() == txtMaDH.Text);
                    if (updateDH != null)
                    {
                        updateDH = dh;
                    }
                    MessageBox.Show("Chuyển trạng thái thành công", "", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("Chuyển trạng thái thất bại", "", MessageBoxButtons.OK);

            }
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
