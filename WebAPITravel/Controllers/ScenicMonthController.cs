using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
namespace WebAPITravel.Controllers
{
    public class ScenicMonthController : ApiController
    {
        ScenicAreaBll bll = new ScenicAreaBll();
        // GET: ScenicArea
        /// <summary>
        /// 根据月份进行推送旅游的国家
        /// </summary>
        /// <returns></returns>
        public List<Addresses> Get()
        {
            return bll.GetMonthes();
        }
    }
}
