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
        /// <summary>
        /// 点击旅游套餐页面/显示所有旅游项目
        /// </summary>
        /// <param name="countyId">根据国家进行查询</param>
        /// <param name="addressId">根据地方进行查询</param>
        /// <param name="monthsId">根据月份进行查询</param>
        /// <returns></returns>
        public List<ScenicArea> Get(string countyId, string addressId, string monthsId)
        {
            return bll.GetScenicAreas(countyId, addressId, monthsId);
        }
        /// <summary>
        /// 具体的旅游路线
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ScenicArea> Get(int id)
        {
            return bll.GetAreas(id);
        }
    }
}
