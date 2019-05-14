using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class ScenicAreaBll
    {
        /// <summary>
        /// 根据月份进行推送旅游的国家
        /// </summary>
        /// <returns></returns>
        public List<Addresses> GetMonthes()
        {
            var month = DateTime.Now.Month;
            string sql = "select a.AddressName,m.Name,m.Id,a.Pid from Monthes m join Addresses a on m.Id=a.Month_Id where Id=" + month + " and Pid=0";
            var table = DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<Addresses>>(table);
            return list;
        }
        /// <summary>
        /// 根据当前月份推荐旅游的景点
        /// </summary>
        /// <returns></returns>
        public List<Addresses> GetAddresses()
        {
            var month = DateTime.Now.Month;
            string sql = "select a.AddressName,m.Name,m.Id,a.Pid from Monthes m join Addresses a on m.Id = a.Month_Id where Id = "+ month + " and Pid!= 0";
            var table = DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<Addresses>>(table);
            return list;
        }

    }
}
