using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class TKBBusiness : ITKBBusiness
    {
        private ITKBRepository _res;
        public TKBBusiness(ITKBRepository TKBgroup)
        {
            _res = TKBgroup;
        }
        public bool Create(TKB model)
        {
            return _res.Create(model);
        }
        public TKB GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<TKB> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}
