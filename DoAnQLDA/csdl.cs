using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLDA
{
    public class csdl
    {
        public static List<NhanVien> lstnv = new List<NhanVien>();
        public static List<Xe> lstxe = new List<Xe>();
        public static List<DonHang> lstdh = new List<DonHang>();

        Random rnd = new Random();
        public void AddDL()
        {

            lstnv.Add(new NhanVien() { id = 1, TenNV = "Tran Van A", GioiTinh = "Nam", Email = "tranvana@gmail.com", SDT = "0123546987", MatKhau = "Aa1234", Chucvu = "Quản lý", NgaySinh = new DateTime(2002, 5, 9), Luong=100000000 });
            lstnv.Add(new NhanVien() { id = 2, TenNV = "Nguyen Thi B", GioiTinh = "Nữ", Email = "nguyenthib@gmail.com", SDT = "8727557557", MatKhau = "Aa1234", Chucvu = "Nhân viên", NgaySinh = new DateTime(1999, 8, 12), Luong = 10000000 });
            lstnv.Add(new NhanVien() { id = 3, TenNV = "Hoang Thi C", GioiTinh = "Nam", Email = "Hoangthic@gmail.com", SDT = "75722727257", MatKhau = "Aa1234", Chucvu = "Nhân viên", NgaySinh = new DateTime(2000, 12, 30), Luong = 20000000 });
            lstnv.Add(new NhanVien() { id = 4, TenNV = "Nhan Vien 1", GioiTinh = "Nam", Email = "nv1@gmail.com", SDT = "72757676", MatKhau = "Aa1234", Chucvu = "Nhân viên", NgaySinh = new DateTime(1989, 1, 29), Luong = 20000000 });
            lstnv.Add(new NhanVien() { id = 5, TenNV = "Nhan Vien 2", GioiTinh = "Nữ", Email = "nv2@gmail.com", SDT = "0123546987", MatKhau = "Aa1234", Chucvu = "Tài xế", NgaySinh = new DateTime(2002, 8, 1) , Luong = 5000000 });
            lstnv.Add(new NhanVien() { id = 6, TenNV = "Nhan Vien 5", GioiTinh = "Nam", Email = "nv5@gmail.com", SDT = "0445577575", MatKhau = "Aa1234", Chucvu = "Tài xế", NgaySinh = new DateTime(1993, 1, 1) , Luong = 10000000 });
            lstnv.Add(new NhanVien() { id = 7, TenNV = "Nhan Vien 7", GioiTinh = "Nữ", Email = "nv7@gmail.com", SDT = "0888888888", MatKhau = "Aa1234", Chucvu = "Tài xế", NgaySinh = new DateTime(2004, 3, 2) , Luong = 10000000 });
            lstnv.Add(new NhanVien() { id = 8, TenNV = "Nhan Vien 8", GioiTinh = "Nam", Email = "nv8@gmail.com", SDT = "0343434376", MatKhau = "Aa1234", Chucvu = "Tài xế", NgaySinh = new DateTime(1987, 6, 25), Luong = 10000000 });
            lstnv.Add(new NhanVien() { id = 9, TenNV = "Nhan Vien 9", GioiTinh = "Nam", Email = "nv9@gmail.com", SDT = "0123546987", MatKhau = "Aa1234", Chucvu = "Tài xế", NgaySinh = new DateTime(2000, 8, 8), Luong = 10000000 });


            lstxe.Add(new Xe() { id = 1, LoaiXe = "Xe tải", GiaTien = 300000, NgayNhap = new DateTime(2023, rnd.Next(1, 12), rnd.Next(1, 30)), TinhTrang = "Tốt" });
            lstxe.Add(new Xe() { id = 2, LoaiXe = "Xe tải", GiaTien = 300000, NgayNhap = new DateTime(2023, rnd.Next(1, 12), rnd.Next(1, 30)), TinhTrang = "Tốt" });
            lstxe.Add(new Xe() { id = 3, LoaiXe = "Xe tải", GiaTien = 250000, NgayNhap = new DateTime(2020, rnd.Next(1, 12), rnd.Next(1, 30)), TinhTrang = "Hỏng nhẹ" });
            lstxe.Add(new Xe() { id = 4, LoaiXe = "Xe tải", GiaTien = 250000, NgayNhap = new DateTime(2021, rnd.Next(1, 13), rnd.Next(1, 30)), TinhTrang = "Tốt" });
            lstxe.Add(new Xe() { id = 5, LoaiXe = "Xe máy", GiaTien = 100000, NgayNhap = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TinhTrang = "Tốt" });
            lstxe.Add(new Xe() { id = 6, LoaiXe = "Xe ba gác", GiaTien = 150000, NgayNhap = new DateTime(2020, rnd.Next(1, 13), rnd.Next(1, 30)), TinhTrang = "Tốt" });
            lstxe.Add(new Xe() { id = 7, LoaiXe = "Xe ba gác", GiaTien = 125000, NgayNhap = new DateTime(2020, rnd.Next(1, 13), rnd.Next(1, 30)), TinhTrang = "Tốt" });
            lstxe.Add(new Xe() { id = 8, LoaiXe = "Xe máy", GiaTien = 200000, NgayNhap = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TinhTrang = "Tốt" });
            lstxe.Add(new Xe() { id = 9, LoaiXe = "Xe máy", GiaTien = 200000, NgayNhap = new DateTime(2022, rnd.Next(1, 13), rnd.Next(1, 30)), TinhTrang = "Tốt" });


            lstdh.Add(new DonHang() { id = 1, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "Trương Đình Phú", SDT = "02345465", DiaChi = "12 Cây keo, Quận Thủ Đức", Email = "dinhphu@gmail.com", DiaChiDi = "12 Cây keo, Quận Thủ Đức", DiaChiDen = "34 Bến Vân Đồn, Quận 4", NgayDi = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), NgayDen = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), LoaiDichVu = "Chuyển nhà", TongTien=10000000, idNVLap = 3, idTaiXe = 5, idXe = 8, TinhTrang="Đã hoàn thành" });
            lstdh.Add(new DonHang() { id = 2, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "Đào Mạnh Thắng", SDT = "03235325", DiaChi = "123 Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1", Email = "dinhphu@gmail.com", DiaChiDi = "123456 Đồng Khởi, Phường Bến Nghé, Quận 1", DiaChiDen = "1011 Phạm Văn Đồng, Phường Hiệp Bình Chánh, Quận Thủ Đức", NgayDi = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), NgayDen = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), LoaiDichVu = "Chuyển nhà", TongTien=60222222, idNVLap = 3, idTaiXe = 5, idXe = 8, TinhTrang="Đã hoàn thành" });
            lstdh.Add(new DonHang() { id = 3, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "Nguyễn Thị A", SDT = "0213165448", DiaChi = "456 Trần Hưng Đạo, Phường Phạm Ngũ Lão, Quận 1", Email = "dinhphu@gmail.com", DiaChiDi = "1011 Phạm Văn Đồng, Phường Hiệp Bình Phước, Quận Thủ Đức", DiaChiDen = "34 Bến Vân Đồn, Quận 4", NgayDi = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), NgayDen = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), LoaiDichVu = "Chuyển nhà", TongTien=80222000, idNVLap = 3, idTaiXe = 5, idXe = 8, TinhTrang="Đã xác nhận" });
            lstdh.Add(new DonHang() { id = 4, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "Trương Lê Hoàn Thiện", SDT = "08779952", DiaChi = "789 Lê Lợi, Phường Bến Nghé, Quận 1", Email = "dinhphu@gmail.com", DiaChiDi = "1234 Nguyễn Văn Trỗi, Phường 9, Quận Phú Nhuận", DiaChiDen = "1234 Nguyễn Văn Trỗi, Phường 9, Quận Phú Nhuận", NgayDi = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), NgayDen = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), LoaiDichVu = "Chuyển nhà", TongTien=583000000, idNVLap = 2, idTaiXe = 5, idXe = 8, TinhTrang="Đang chờ" });
            lstdh.Add(new DonHang() { id = 5, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "Trần Nhật Khang", SDT = "0756113", DiaChi = "1011 Phạm Văn Đồng, Phường Hiệp Bình Chánh, Quận Thủ Đức", Email = "dinhphu@gmail.com", DiaChiDi = "1011 Phạm Văn Đồng, Phường Hiệp Bình Chánh, Quận Thủ Đức", DiaChiDen = "78901 Lê Văn Sỹ, Phường 2, Quận 3", NgayDi = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), NgayDen = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), LoaiDichVu = "Chuyển nhà", TongTien=66600000, idNVLap = 2, idTaiXe = 5, idXe = 8, TinhTrang="Hủy đơn" });
            lstdh.Add(new DonHang() { id = 6, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "Trần Hải Đăng", SDT = "02345465", DiaChi = "1234 Nguyễn Văn Trỗi, Phường 15, Quận Phú Nhuận", Email = "dinhphu@gmail.com", DiaChiDi = "1234 Nguyễn Văn Trỗi, Phường 15, Quận Phú Nhuận", DiaChiDen = "123456 Đồng Khởi, Phường Bến Nghé, Quận 1", NgayDi = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), NgayDen = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), LoaiDichVu = "Chuyển nhà", TongTien=50000000, idNVLap = 1, idTaiXe = 5, idXe = 8, TinhTrang="Đang chờ" });
            lstdh.Add(new DonHang() { id = 7, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "Nguyễn Thị B", SDT = "548777744", DiaChi = "7890 Võ Văn Kiệt, Phường Nguyễn Thái Bình, Quận 1", Email = "dinhphu@gmail.com", DiaChiDi = "12345 Nguyễn Trãi, Phường 11, Quận 5", DiaChiDen = "123 Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1", NgayDi = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), NgayDen = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), LoaiDichVu = "Chuyển nhà", TongTien=90099900, idNVLap = 1, idTaiXe = 5, idXe = 8, TinhTrang="Đang vận chuyển" });
            lstdh.Add(new DonHang() { id = 8, NgayDat = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 30)), TenKhach = "egwgwegewgw", SDT = "077777777", DiaChi = "12345 Nguyễn Trãi, Phường 11, Quận 5", Email = "dinhphu@gmail.com", DiaChiDi = "78901 Lê Văn Sỹ, Phường 10, Quận 3", DiaChiDen = "1011 Phạm Văn Đồng, Phường Hiệp Bình Chánh, Quận Thủ Đức", LoaiDichVu = "Chuyển nhà", TongTien=10000000, idNVLap = 1, idTaiXe = 5, idXe = 8, TinhTrang="Đang chờ" });
        }
    }
}
