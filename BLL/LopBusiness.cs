using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class LopBusiness : ILopBusiness
    {
        private ILopRepository _res;
        public LopBusiness(ILopRepository Lopgroup)
        {
            _res = Lopgroup;
        }
        public bool Create(Lop model)
        {
            return _res.Create(model);
        }
        public Lop GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Lop> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}
