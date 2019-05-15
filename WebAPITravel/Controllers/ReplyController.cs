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
    public class ReplyController : ApiController
    {
        MyBll bll = new MyBll();

        //显示回复
        [Obsolete]
        public List<Reply> Get(int id)
        {
            var list = bll.GetRepys();
            if (id != 0)
            {
                list = list.Where(m => m.ReplyId == id).ToList();
            }
            return list;
        }

        //添加回复
        [Obsolete]
        public int Post(Reply reply)
        {
            return bll.AddReply(reply);
        }
    }
}
