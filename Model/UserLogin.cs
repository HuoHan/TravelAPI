using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserLogin
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string UserPhone { get; set; }
        public string TrueName { get; set; }
        public int IsState { get; set; }
    }
}
