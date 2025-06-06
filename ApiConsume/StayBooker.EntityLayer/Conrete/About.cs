using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.EntityLayer.Conrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutTitle1 { get; set; }
        public string AboutTitle2 { get; set; }
        public string AboutContent { get; set; }
        public int AboutRoomCount { get; set; }
        public int AboutStaffCount { get; set; }
        public int AboutCustomerCount { get; set; }
    }
}
