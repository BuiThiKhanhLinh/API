using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopController : ControllerBase
    {
        private ILopBusiness _lopBusiness;
        public LopController(ILopBusiness lopBusiness)
        {
            _lopBusiness = lopBusiness;
        }

        [Route("create-lop")]
        [HttpPost]
        public Lop CreateItem([FromBody] Lop model)
        {
            _lopBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Lop GetDatabyID(string id)
        {
            return _lopBusiness.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Lop> GetDatabAll()
        {
            return _lopBusiness.GetDataAll();
        }
    }
}
