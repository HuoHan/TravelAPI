using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITravel.Controllers
{
    public class ScenicAreasController : ApiController
    {
        ScenicAreaBll bll = new ScenicAreaBll();

        /// <summary>
        /// 根据当前月份推荐旅游的景点
        /// </summary>
        /// <returns></returns>
        public List<Addresses> Get()
        {
            return bll.GetAddresses();
        }
        public List<ScenicArea> Get(string countyId = null, string addressId = null, string monthsId = null)
        {
            return bll.GetScenicAreas(countyId, addressId, monthsId);
        }
    }
}
