using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DtoLayer.GuestDtos
{
    public class UpdateGuestDto
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string GuestSurname { get; set; }
        public string GuestCity { get; set; }
    }
}
