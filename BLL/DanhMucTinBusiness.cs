using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class DanhMucTinBusiness: IDanhMucTinBusiness
    {
        private IDanhMucLoaiRepository _res;
        public DanhMucTinBusiness(IDanhMucLoaiRepository DanhMucTingroup)
        {
            _res = DanhMucTingroup;
        }
        public bool Create(DanhMucTin model)
        {
            return _res.Create(model);
        }
        public DanhMucTin GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<DanhMucTin> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}
