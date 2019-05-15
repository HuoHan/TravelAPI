using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;
namespace WebAPITravel.Controllers
{
    public class ScenicAreaController : Controller
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
        public List<ScenicArea> Get(int countyId = 0, int addressId = 0, int monthsId = 0)
        {
            return bll.GetScenicAreas(countyId,addressId,monthsId);
        }
    }
}