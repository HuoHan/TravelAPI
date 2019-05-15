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
        public List<Addresses> Addresses { get; set; }
        public List<Monthes> Monthes { get; set; }
    }
}
