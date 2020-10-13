using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IDanhMucTinBusiness
    {
        bool Create(DanhMucTin model);
        DanhMucTin GetDatabyID(string id);
        List<DanhMucTin> GetDataAll();
    }
}
