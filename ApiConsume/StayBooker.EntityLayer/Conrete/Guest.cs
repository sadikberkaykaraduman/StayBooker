using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.EntityLayer.Conrete
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string GuestSurname { get; set; }
        public string GuestCity { get; set; }
    }
}
