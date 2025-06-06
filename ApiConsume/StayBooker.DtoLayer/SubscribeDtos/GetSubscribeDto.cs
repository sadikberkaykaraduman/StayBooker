using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DtoLayer.SubscribeDtos
{
    public class GetSubscribeDto
    {
        public int SubscribeId { get; set; }
        public string SubscribeEmail { get; set; }
    }
}
