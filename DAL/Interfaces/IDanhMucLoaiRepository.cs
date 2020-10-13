using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface IDanhMucLoaiRepository
    {
        bool Create(DanhMucTin model);
        DanhMucTin GetDatabyID(string id);
        List<DanhMucTin> GetDataAll();
    }
}
