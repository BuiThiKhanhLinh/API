using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface ITKBBusiness
    {
        bool Create(TKB model);
        TKB GetDatabyID(string id);
        List<TKB> GetDataAll();
    }
}
