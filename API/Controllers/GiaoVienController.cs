using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaoVienController : ControllerBase
    {
        private IGiaoVienBusiness _giaovienBusiness;
        public GiaoVienController(IGiaoVienBusiness giaovienBusiness)
        {
            _giaovienBusiness = giaovienBusiness;
        }

        [Route("create-giaovien")]
        [HttpPost]
        public GiaoVien CreateItem([FromBody] GiaoVien model)
        {
            _giaovienBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public GiaoVien GetDatabyID(string id)
        {
            return _giaovienBusiness.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<GiaoVien> GetDatabAll()
        {
            return _giaovienBusiness.GetDataAll();
        }
    }
}
