﻿using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MyBll
    {
        //添加博客
        [Obsolete]
        public int AddBlogs(Blogs blogs)
        {
            //默认值
            blogs.Users_Id = 1;
            string sql = "insert Blogs values('" + blogs.Title + "','" + blogs.Url + "','" + blogs.StartTime + "','" + blogs.Remark + "','" + blogs.Users_Id + "')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        //显示博客
        public List<Blogs> GetBlogs()
        {
            string sql = "select * from Blogs b join UserLogin u on b.Users_Id=u.UserId";
            var list = DBHelper.GetDataTable(sql);
            return DBHelper.ConvertTableToList<List<Blogs>>(list);
        }

        //添加评论
        [Obsolete]
        public int AddComment(Comment com)
        {
            string sql = "insert Comment values('" + com.CommentName + "','" + com.Blogs_Id + "','" + com.Users_Id + "')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        //显示评论
        public List<Comment> GetComments()
        {
            string sql = "select *,u.UserName as Users_Name from Blogs b join Comment c on b.BlogsId=c.Blogs_Id join UserLogin u on u.UserId = c.Users_Id join Reply r on r.Comment_Id = c.CommentId";
            var list = DBHelper.GetDataTable(sql);
            return DBHelper.ConvertTableToList<List<Comment>>(list);
        }

        //添加回复
        [Obsolete]
        public int AddReply(Reply reply)
        {
            string sql = "insert Reply values('"+reply.ReplayRemark+"','"+reply.Comment_Id+"')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        //显示回复1
        [Obsolete]
        public List<Reply> GetRepys()
        {
            string sql = "select * from Comment c join Reply r on c.CommentId=r.Comment_Id join Blogs b on c.Blogs_Id=b.BlogsId";
            var list = DBHelper.GetDataTable(sql);
            return DBHelper.ConvertTableToList<List<Reply>>(list);
        }
    }
}
