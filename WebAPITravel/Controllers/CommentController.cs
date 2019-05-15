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
    public class CommentController : ApiController
    {
        MyBll bll = new MyBll();
        //显示评论
        public List<Comment> Get(int id)
        {
            var list=bll.GetComments();
            if (id != 0)
            {
                list = list.Where(m => m.CommentId == id).ToList();
            }
            return list;
        }

        //添加评论
        [Obsolete]
        public int Post(Comment com)
        {
            return bll.AddComment(com);
        }
    }
}
