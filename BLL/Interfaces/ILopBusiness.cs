using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface ILopBusiness
    {
        bool Create(Lop model);
        Lop GetDatabyID(string id);
        List<Lop> GetDataAll();
    }
}
