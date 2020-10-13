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
    public class TKBController : ControllerBase
    {
        private ITKBBusiness _tkbBusiness;
        public TKBController(ITKBBusiness tkbBusiness)
        {
            _tkbBusiness = tkbBusiness;
        }

        [Route("create-hocsinh")]
        [HttpPost]
        public TKB CreateItem([FromBody] TKB model)
        {
            _tkbBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public TKB GetDatabyID(string id)
        {
            return _tkbBusiness.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<TKB> GetDatabAll()
        {
            return _tkbBusiness.GetDataAll();
        }
    }
}
