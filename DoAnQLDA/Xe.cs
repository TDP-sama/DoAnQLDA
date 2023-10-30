using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLDA
{
    public class Xe
    {
        public int id { get; set; }

        [StringLength(50)]
        public string LoaiXe { get; set; }

        public int GiaTien { get; set; }

        public DateTime? NgayNhap { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }


    }
}
