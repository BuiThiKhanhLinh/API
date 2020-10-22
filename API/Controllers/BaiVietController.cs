﻿using System;
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
    public class BaiVietController : ControllerBase
    {
        private IBaiVietBusiness _baivietBusiness;
        public BaiVietController(IBaiVietBusiness baivietBusiness)
        {
            _baivietBusiness = baivietBusiness;
        }

        [Route("create-baiviet")]
        [HttpPost]
        public BaiViet CreateBaiViet([FromBody] BaiViet model)
        {
            _baivietBusiness.Create(model);
            return model;
        }
        [Route("delete-baiviet")]
        [HttpPost]
        public IActionResult DeleteBaiViet([FromBody] Dictionary<string, object> formData)
        {
            int MaBaiViet = 0;
            if (formData.Keys.Contains("MaBaiViet") && !string.IsNullOrEmpty(Convert.ToString(formData["MaBaiViet"]))) { MaBaiViet = int.Parse(Convert.ToString(formData["MaBaiViet"])); }
            _baivietBusiness.Delete(MaBaiViet);
            return Ok();
        }

        [Route("update-baiviet")]
        [HttpPost]
        public BaiViet UpdateTinTuc([FromBody] BaiViet model)
        {
            _baivietBusiness.Update(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public BaiViet GetDatabyID(int id)
        {
            return _baivietBusiness.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<BaiViet> GetDatabAll()
        {
            return _baivietBusiness.GetDataAll();
        }
        [Route("get-top5-bai-viet")]
        [HttpGet]
        public IEnumerable<TopBaiViet> GetDataTopBaiViet()
        {
            return _baivietBusiness.GetDataTopBaiViet();
        }

        [Route("search")]
        [HttpPost]
        public ResponseModel Search([FromBody] Dictionary<string, object> formData)
        {
            var response = new ResponseModel();
            try
            {
                var page = int.Parse(formData["page"].ToString());
                var pageSize = int.Parse(formData["pageSize"].ToString());
                string tieude = "";
                if (formData.Keys.Contains("tieude") && !string.IsNullOrEmpty(Convert.ToString(formData["tieude"]))) { tieude = Convert.ToString(formData["tieude"]); }
                long total = 0;
                var data = _baivietBusiness.Search(page, pageSize, out total, tieude);
                response.TotalItems = total;
                response.Data = data;
                response.Page = page;
                response.PageSize = pageSize;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return response;
        }
    }
}