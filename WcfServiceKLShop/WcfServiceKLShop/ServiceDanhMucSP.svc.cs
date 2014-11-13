using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceKLShop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDanhMucSP" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDanhMucSP.svc or ServiceDanhMucSP.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDanhMucSP : IServiceDanhMucSP
    {
        private KLShopEntities db = new KLShopEntities();
        public List<DanhMucSP> All()
        {
            return this.db.DanhMucSPs.ToList();
        }
        public bool XoaDanhMuc(string madm)
        {
            try
            {
                DanhMucSP dm = db.DanhMucSPs.Single(x => x.MaDM == madm);
                db.DanhMucSPs.Remove(dm);
                db.SaveChanges();
                return true;
            }
            catch {

                return false;
            }
        }
        public bool ThemDanhMuc(string madm, string tendm)
        {
            try
            {
                DanhMucSP dm = new DanhMucSP();
                dm.MaDM = madm;
                dm.TenDM = tendm;
                db.DanhMucSPs.Add(dm);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDanhMuc(string madm, string tendm)
        {
            try
            {
                DanhMucSP dm = db.DanhMucSPs.Single(x =>x.MaDM == madm);
                dm.TenDM = tendm;
                db.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }

    }
}
