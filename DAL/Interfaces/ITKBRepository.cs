using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface ITKBRepository 
    {
        bool Create(TKB model);
        TKB GetDatabyID(string id);
        List<TKB> GetDataAll();
    }
}
