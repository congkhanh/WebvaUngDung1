using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceKLShop
{
    public class CTDonHangCustom
    {
        public int? MaSP { get; set; }
        public int? ID { get; set; }
        public int? MaDonHang { get; set; }
        public int? SoLuong { get; set; }
        public string TenSP { get; set; }
        public decimal? Gia { get; set; }
        public decimal? ThanhTien { get; set; } 
        /* MaSP = p.MaSP,
                        ID = p.ID,
                        MaDonHang = p.MaDonHang,
                        SoLuong = p.SoLuong,
                        TenSP = q.TenSP,
                        Gia = decimal.Ceiling((decimal)p.Gia + 0),
                        ThanhTien = decimal.Ceiling((decimal)p.ThanhTien + 0)*/
    }
}