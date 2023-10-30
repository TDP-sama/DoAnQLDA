using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLDA
{
    public class NhanVien
    {
        public int id { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(50)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string SDT { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        public int Luong { get; set; }

        [StringLength(50)]
        public string Chucvu { get; set; }

        public DateTime? NgaySinh { get; set; }

    }
}
