using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class HocSinhBusiness : IHocSinhBusiness
    {
        private IHocSinhRepository _res;
        public HocSinhBusiness(IHocSinhRepository HocSinhgroup)
        {
            _res = HocSinhgroup;
        }
        public bool Create(HocSinh model)
        {
            return _res.Create(model);
        }
        public HocSinh GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<HocSinh> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}
