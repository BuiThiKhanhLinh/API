using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IGiaoVienBusiness
    {
        bool Create(GiaoVien model);
        GiaoVien GetDatabyID(string id);
        List<GiaoVien> GetDataAll();
    }
}
