using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface ILopBusiness
    {
        bool Create(Lop model);
        bool Update(Lop model);
        bool Delete(int id);
        Lop GetDatabyID(string id);
        List<Lop> GetDataAll();
        List<Lop> Search(int pageIndex, int pageSize, out long total, string tenlop );
    }
}
