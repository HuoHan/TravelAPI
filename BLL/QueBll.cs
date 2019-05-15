using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class QueBll
    {
        /// <summary>
        /// 显示常问问题
        /// </summary>
        /// <returns></returns>
        public List<Question> Show()
        {
            string sql = "select * from Question q join Answer a on q.QuestionId=a.Question_Id";
            var dt = DBHelper.GetDataTable(sql);
            return DBHelper.ConvertTableToList<List<Question>>(dt);
        }
    }
}
