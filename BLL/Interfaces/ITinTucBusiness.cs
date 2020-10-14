using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface ITinTucBusiness
    {
        bool Create(TinTuc model);
        TinTuc GetDatabyID(int id);
        List<TinTuc> GetDataAll();
        List<TinTuc> GetDataLoai(int loai);
        List<TinTuc> GetDataTop3();
    }
}
