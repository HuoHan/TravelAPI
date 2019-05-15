using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Addresses
    {
        public int AddressId { get; set; }
        public string AddressName { get; set; }
        public int Pid { get; set; }
        public int Month_Id { get; set; }
        public List<Monthes> Monthes { get; set; }
    }
}
