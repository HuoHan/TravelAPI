using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace WebAPITravel.Controllers
{
    public class QuesApiController : ApiController
    {
        QueBll bll = new QueBll();
        /// <summary>
        /// 显示问题
        /// </summary>
        /// <returns></returns>
        public List<Question> Get()
        {
            return bll.Show();
        }
    }
}
