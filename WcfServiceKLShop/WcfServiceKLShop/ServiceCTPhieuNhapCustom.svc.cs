using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceKLShop.Model;

namespace WcfServiceKLShop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCTPhieuNhapCustom" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCTPhieuNhapCustom.svc or ServiceCTPhieuNhapCustom.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCTPhieuNhapCustom : IServiceCTPhieuNhapCustom
    {
        private KLShopEntities db = new KLShopEntities();

        public List<CTPhieuNhapCustom> CTPhieuNhap(int mapn)
        {
            var ctpn = (from p in db.CTPhieuNhaps
                        join q in db.SanPhams on p.MaSP equals q.MaSP
                       
                        where p.MaPN == mapn

                        select new CTPhieuNhapCustom
                        {
                            MaSP = p.MaSP,
                            MaPN = p.MaPN,
                            ID = p.ID,
                            TenSP = q.TenSP,
                            SoLuong = p.SoLuong
                           
                        }).ToList();

            return ctpn;


        }
    }
}
