using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLDA
{
    public class DonHang
    {
        public int id { get; set; }

        public DateTime? NgayDat { get; set; }

        [StringLength(50)]
        public string TenKhach { get; set; }

        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        public string DiaChi { get; set; }

        public string DiaChiDi { get; set; }

        public DateTime? NgayDi { get; set; }

        public string DiaChiDen { get; set; }

        public DateTime? NgayDen { get; set; }

        public string TinhTrang { get; set; }
        public string LoaiDichVu { get; set; }

        public int? TongTien { get; set; }
        public int? idTaiXe { get; set; }
        public int? idNVLap { get; set; }
        public int? idXe { get; set; }

    }
}
