using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ScenicArea
    {
        public int ScenicAreaId { get; set; }
        public string ScenicAreaName { get; set; }
        public int Url_Id { get; set; }
        public string Introduce { get; set; }
        public string ScenicAreaUrl { get; set; }






        public int Id { get; set; }
        public string Name { get; set; }
        public int AddId { get; set; }
        public int ScId { get; set; }



        public int RouteId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int StartArae { get; set; }
        public int EndArae { get; set; }
        public int Includes { get; set; }
        public double Price { get; set; }





        public int AddressId { get; set; }
        public string AddressName { get; set; }
        public int Pid { get; set; }
        public int Month_Id { get; set; }
        public int CountryId { get; set; }
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }

    }
}
