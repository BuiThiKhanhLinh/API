using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IHocSinhBusiness
    {
        bool Create(HocSinh model);
        HocSinh GetDatabyID(string id);
        List<HocSinh> GetDataAll();
    }
}
