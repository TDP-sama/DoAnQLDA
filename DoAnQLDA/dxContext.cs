using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLDA
{
    public class dxContext : DbContext
    {
        public dxContext(): base("name=con") { }
        public DbSet<Xe> Xe { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<DonHang> DonHang { get; set;}
    }
}
