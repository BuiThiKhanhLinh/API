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
    public class DanhMucTinController : ControllerBase
    {
        private IDanhMucTinBusiness _danhmuctinBusiness;
        public DanhMucTinController(IDanhMucTinBusiness danhmuctinBusiness)
        {
            _danhmuctinBusiness = danhmuctinBusiness;
        }

        [Route("create-danhmuctin")]
        [HttpPost]
        public DanhMucTin CreateItem([FromBody] DanhMucTin model)
        {
            _danhmuctinBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public DanhMucTin GetDatabyID(string id)
        {
            return _danhmuctinBusiness.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<DanhMucTin> GetDatabAll()
        {
            return _danhmuctinBusiness.GetDataAll();
        }
    }
}
