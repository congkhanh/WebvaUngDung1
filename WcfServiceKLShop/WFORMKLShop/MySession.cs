using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFORMKLShop
{
    class MySession
    {
        public static string MaSanPham
        {
            get { return "0"; }
        }
        public static string TongSL
        {
            get { return "1"; }
        }
       
        
      //  public static decimal? TongTien { get; set; }

        public static List<CTPhieuNhap> ChiTietPhieuNhap { get; set; }

       // public static List<ChiTietDonHang> ChiTietDonHang { get; set; }
    }
}
