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
    public class BlogsController : ApiController
    {
        MyBll bll = new MyBll();

        //显示博客
        [Obsolete]
        public List<Blogs> Get()
        {
            return bll.GetBlogs();
        }

        //添加博客
        [Obsolete]
        public int Post(Blogs blogs)
        {
            return bll.AddBlogs(blogs);
        }
        
    }
}
