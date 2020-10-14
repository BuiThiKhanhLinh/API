using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface ITinTucRepository 
    {
        bool Create(TinTuc model);
        TinTuc GetDatabyID(int id);
        List<TinTuc> GetDataAll();
        List<TinTuc> GetDataLoai(int loai);
        List<TinTuc> GetDataTop3();
    }
}
