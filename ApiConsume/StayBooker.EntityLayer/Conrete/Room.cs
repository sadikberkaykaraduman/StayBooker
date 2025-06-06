using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.EntityLayer.Conrete
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomTitle { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        public int RoomPrice { get; set; }
        public string RoomBadCount { get; set; }
        public string RoomBathCount { get; set; }
        public string RoomWifi { get; set; }
        public string RoomDescription { get; set; }
    }
}
