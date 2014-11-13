using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceKLShop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDanhMucSP" in both code and config file together.
    [ServiceContract]
    public interface IServiceDanhMucSP
    {
        [OperationContract]
        List<DanhMucSP> All();

        [OperationContract]
        bool SuaDanhMuc(string madm, string tendm);

        [OperationContract]
        bool XoaDanhMuc(string madm);

        [OperationContract]
        bool ThemDanhMuc(string madm, string tendm);
    }
}
