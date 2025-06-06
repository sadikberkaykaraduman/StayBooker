using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DtoLayer.BookingDtos
{
    public class UpdateBookingDto
    {
        public int BookingId { get; set; }
        public string BookingName { get; set; }
        public string BookingMail { get; set; }
        public DateTime BookingCheckin { get; set; }
        public DateTime BookingCheckOut { get; set; }
        public string BookingAdultCount { get; set; }
        public string BookingChildCount { get; set; }
        public string BookingRoomCount { get; set; }
        public string BookingSpecialRequest { get; set; }
        public string BookingDescription { get; set; }
        public string BookingStatus { get; set; }
        public string BookingCity { get; set; }
        public string BookingCountry { get; set; }
    }
}
