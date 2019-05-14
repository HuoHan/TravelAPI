using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Blogs
    {
        public int BlogsId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string StartTime { get; set; }
        public string Remark { get; set; }
        public int Users_Id { get; set; }
    }
}
