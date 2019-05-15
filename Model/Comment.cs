using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public int Blogs_Id { get; set; }
        public int Users_Id { get; set; }
        public string Users_Name { get; set; }
    }
}
