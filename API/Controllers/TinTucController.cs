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
    public class TinTucController : ControllerBase
    {
        private ITinTucBusiness _tintucBusiness;
        public TinTucController (ITinTucBusiness tintucBusiness )
        {
            _tintucBusiness = tintucBusiness ;
        }

        [Route("create-tintuc")]
        [HttpPost]
        public TinTuc CreateItem([FromBody] TinTuc model)
        {
            _tintucBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public TinTuc GetDatabyID(string id)
        {
            return _tintucBusiness.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<TinTuc> GetDatabAll()
        {
            return _tintucBusiness.GetDataAll();
        }
    }
}
