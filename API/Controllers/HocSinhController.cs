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
    public class HocSinhController : ControllerBase
    {
        private IHocSinhBusiness _hocsinhBusiness;
        public HocSinhController(IHocSinhBusiness hocsinhBusiness)
        {
            _hocsinhBusiness = hocsinhBusiness;
        }

        [Route("create-hocsinh")]
        [HttpPost]
        public HocSinh CreateItem([FromBody] HocSinh model)
        {
            _hocsinhBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public HocSinh GetDatabyID(string id)
        {
            return _hocsinhBusiness.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<HocSinh> GetDatabAll()
        {
            return _hocsinhBusiness.GetDataAll();
        }
    }
}
