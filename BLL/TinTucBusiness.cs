using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class TinTucBusiness: ITinTucBusiness
    {
        private ITinTucRepository _res;
        public TinTucBusiness (ITinTucRepository Lopgroup)
        {
            _res = Lopgroup;
        }
        public bool Create(TinTuc model)
        {
            return _res.Create(model);
        }
        public TinTuc GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<TinTuc> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}
