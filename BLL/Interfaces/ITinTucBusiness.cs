using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface ITinTucBusiness
    {
        bool Create(TinTuc model);
        TinTuc GetDatabyID(string id);
        List<TinTuc> GetDataAll();
    }
}
