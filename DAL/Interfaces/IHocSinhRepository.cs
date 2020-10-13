using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface IHocSinhRepository
    {
        bool Create(HocSinh model);
        HocSinh GetDatabyID(string id);
        List<HocSinh> GetDataAll();
    }
}
