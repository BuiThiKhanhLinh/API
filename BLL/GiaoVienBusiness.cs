using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class GiaoVienBusiness: IGiaoVienBusiness
    {
        private IGiaoVienRepository _res;
        public GiaoVienBusiness(IGiaoVienRepository GiaoViengroup)
        {
            _res = GiaoViengroup;
        }
        public bool Create(GiaoVien model)
        {
            return _res.Create(model);
        }
        public GiaoVien GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<GiaoVien> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}
