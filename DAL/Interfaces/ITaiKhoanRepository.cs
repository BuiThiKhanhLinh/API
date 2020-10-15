using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface ITaiKhoanRepository
    {
        TaiKhoan GetUser(string username, string password);
        bool Create(TaiKhoan model);
        TaiKhoan GetDatabyID(string id);
        List<TaiKhoan> GetDataAll();
    }
}
