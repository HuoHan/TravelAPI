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
            string sql = "select a.AddressId as CountryId,a.AddressName CountryName,b.AddressName PlaceName,b.AddressId PlaceId,s.*,m.* from Addresses a join Addresses b on a.AddressId = b.Pid join ScenicArea s on b.AddressId = s.Address_id join Monthes m on b.Month_Id = m.Id where m.Id ="+month+" and a.Pid = 0";
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
            string sql = "select a.AddressId as CountryId,a.AddressName CountryName,b.AddressName PlaceName,b.AddressId PlaceId,s.*,m.* from Addresses a join Addresses b on a.AddressId = b.Pid join ScenicArea s on b.AddressId = s.Address_id join Monthes m on b.Month_Id = m.Id where m.Id =" + month + " and b.Pid != 0";
            var table = DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<Addresses>>(table);
            return list;
        }
        /// <summary>
        /// 点击旅游套餐页面/显示所有旅游项目
        /// </summary>
        /// <param name="countyId">根据国家进行查询</param>
        /// <param name="addressId">根据地方进行查询</param>
        /// <param name="monthsId">根据月份进行查询</param>
        /// <returns></returns>
        public List<ScenicArea> GetScenicAreas(string countyId = null, string addressId = null, string monthsId = null)
        {
            string sql = "select a.AddressId as CountryId,a.AddressName CountryName,b.AddressName PlaceName,b.AddressId PlaceId,s.*,m.* from Addresses a join Addresses b on a.AddressId = b.Pid join ScenicArea s on b.AddressId = s.Address_id join Monthes m on b.Month_Id = m.Id where 1 = 1";
            if (!string.IsNullOrEmpty(countyId))
            {
                sql += " and a.AddressId in(" + countyId + ")";
            }
            if (!string.IsNullOrEmpty(addressId))
            {
                sql += " and b.AddressId in(" + addressId + ")";
            }
            if (!string.IsNullOrEmpty(monthsId))
            {
                sql += " and m.Id in(" + monthsId + ")";
            }
            var table = DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<ScenicArea>>(table);
            return list;
        }
        /// <summary>
        /// 具体的旅游路线
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ScenicArea> GetAreas(int id)
        {
            var sql = " select * from ScenicArea s join Picture p on s.Url_Id=p.PictureId where s.ScenicAreaId="+id;
            var table = DBHelper.GetDataTable(sql);
            var list = DBHelper.ConvertTableToList<List<ScenicArea>>(table);
            return list;
        }
        /// <summary>
        /// 绑定国家和城市
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Addresses> ShowAddress(string id)
        {
            string str = string.Format("select * from Addresses where Pid in('{0}')",id);
            var item = DBHelper.GetDataTable(str);
            var items = DBHelper.ConvertTableToList<List<Addresses>>(item);
            return items;
        }
        /// <summary>
        /// 绑定月份
        /// </summary>
        /// <returns></returns>
        public List<Monthes> ShowMonthes()
        {
            string str = string.Format("select * from Monthes");
            var item = DBHelper.GetDataTable(str);
            var items = DBHelper.ConvertTableToList<List<Monthes>>(item);
            return items;
        }
    }
}
