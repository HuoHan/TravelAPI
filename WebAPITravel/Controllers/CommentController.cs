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
        public List<Comment> Get()
        {
            return bll.GetComments();
        }

        //添加评论
        [Obsolete]
        public int Post(Comment com)
        {
            return bll.AddComment(com);
        }
    }
}
