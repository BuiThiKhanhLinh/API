using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface IGiaoVienRepository
    {
        bool Create(GiaoVien model);
        GiaoVien GetDatabyID(string id);
        List<GiaoVien> GetDataAll();
    }
}
