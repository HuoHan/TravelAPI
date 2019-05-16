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
    public class ShowMonthController : ApiController
    {
        ScenicAreaBll bll = new ScenicAreaBll();
        /// <summary>
        /// 绑定月份
        /// </summary>
        /// <returns></returns>
        public List<Monthes> Get()
        {

            return bll.ShowMonthes();
        }
    }
}
