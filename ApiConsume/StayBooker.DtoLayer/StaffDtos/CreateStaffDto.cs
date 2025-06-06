using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DtoLayer.StaffDtos
{
    public class CreateStaffDto
    {
        public string StaffName { get; set; }
        public string StaffTitle { get; set; }
        public string StaffImage { get; set; }
        public string StaffSocialMedia1 { get; set; }
        public string StaffSocialMedia2 { get; set; }
        public string StaffSocialMedia3 { get; set; }
    }
}
