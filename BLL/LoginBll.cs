using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class LoginBll
    {

        /// <summary>
        /// 通过用户名查询  判断输入的用户名是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string CheckUser(string userName)
        {
            string sql = string.Format("select * from UserLogin where UserName='{0}'", userName);
            var dt = DBHelper.GetDataTable(sql);
            var count = DBHelper.ConvertTableToList<List<UserLogin>>(dt).Count();
            var isExists = count > 0 ? true : false;
            if (isExists)
            {
                return "existed";
            }
            return "noexisted";
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [Obsolete]
        public int Register(UserLogin u)
        {
            string sql = string.Format("insert into UserLogin values('{0}','{1}','{2}','{3}','{4}')", u.UserName, u.UserPwd, u.UserPhone, u.UserName, 0);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        public int CheckLogin(string userName, string userPwd)
        {
            SqlParameter[] par = new SqlParameter[] {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@UserPwd",userPwd)
            };
            string sql = string.Format("select * from UserLogin where UserName='{0}' and UserPwd='{1}'", par);
            var dt = DBHelper.GetDataTable(sql);
            return DBHelper.ConvertTableToList<List<UserLogin>>(dt).Count();
        }
    }
}
