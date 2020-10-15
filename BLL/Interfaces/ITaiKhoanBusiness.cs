using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface ITaiKhoanBusiness
    {
        TaiKhoan Authenticate(string username, string password);
        bool Create(TaiKhoan model);
        TaiKhoan GetDatabyID(string id);
        List<TaiKhoan> GetDataAll();
    }
}
