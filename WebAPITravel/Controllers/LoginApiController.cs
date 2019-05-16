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
    public class LoginApiController : ApiController
    {
        LoginBll bll = new LoginBll();

        //注册
        [Obsolete]
        public int Post(UserLogin u)
        {
            return bll.Register(u);
        }
        //检查是否存在该用户/登陆
        public List<UserLogin> Get(string userName, string userPwd)
        {
            return bll.CheckLogin(userName, userPwd);
        }
        //检查是否已存在该用户名/注册验证账户存在
        public string Get(string userName)
        {
            return bll.CheckUser(userName);
        }
    }
}
