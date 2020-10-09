using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface ILopRepository
    {
        bool Create(Lop model);
        Lop GetDatabyID(string id);
        List<Lop> GetDataAll();
    }
}
