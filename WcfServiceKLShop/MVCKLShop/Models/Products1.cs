using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCKLShop.Models
{
    public class Products1
    {
        public int? MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal? Gia { get; set; }
        public string HinhAnh { get; set; }
        public int? SoLuong { get; set; }
        public decimal? TongTien { get; set; }
    }
}