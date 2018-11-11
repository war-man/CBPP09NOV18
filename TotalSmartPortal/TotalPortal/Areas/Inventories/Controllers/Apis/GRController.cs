﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using TotalModel.Models;
using TotalCore.Repositories.Inventories;

namespace TotalPortal.Areas.Inventories.Controllers.Apis
{
    [RoutePrefix("Api/Inventories/GR")]
    public class GRController : ApiController
    {
        private readonly IGoodsReceiptAPIRepository goodsReceiptAPIRepository;
        public GRController() { }
        //public GRController(IGoodsReceiptAPIRepository goodsReceiptAPIRepository)
        //{
        //    this.goodsReceiptAPIRepository = goodsReceiptAPIRepository;
        //}

        //[Route("HelloWorldArea")]
        [Route("GetGoodsArrivals/{locationID}")]
        //[Authorize]
        [HttpGet]
        public IEnumerable<GoodsReceiptPendingGoodsArrival> GetGoodsArrivals(int? locationID)
        {
            List < GoodsReceiptPendingGoodsArrival > x = new List<GoodsReceiptPendingGoodsArrival>();
            return x;// Request.CreateResponse(HttpStatusCode.OK, "Hello, SAY FROM AREA [API OK] INVENTORY [LOCAL], AREA CONTROLLER, " + this.User.Identity.Name + " (" + this.RequestContext.Principal.Identity.GetUserId() + ")");
        }
    }
}