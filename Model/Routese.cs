using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Routese
    {
        public int RouteId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int StartArae { get; set; }
        public int EndArae { get; set; }
        public int Includes { get; set; }
        public double Price { get; set; }
    }
}
