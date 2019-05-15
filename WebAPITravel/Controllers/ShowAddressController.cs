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
    public class ShowAddressController : ApiController
    {
        ScenicAreaBll bll = new ScenicAreaBll();
        /// <summary>
        /// 绑定国家和城市
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Addresses> ShowAddress(int id)
        {
            return bll.ShowAddress(id);
        }
    }
}
