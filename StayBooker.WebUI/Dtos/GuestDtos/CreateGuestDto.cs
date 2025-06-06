using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.WebUI.Dtos.GuestDtos
{
    public class CreateGuestDto
    {
        public string GuestName { get; set; }
        public string GuestSurname { get; set; }
        public string GuestCity { get; set; }
    }
}
