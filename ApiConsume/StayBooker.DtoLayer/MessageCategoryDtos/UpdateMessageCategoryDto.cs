using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DtoLayer.MessageCategoryDtos
{
    public class UpdateMessageCategoryDto
    {
        public int MessageCategoryId { get; set; }
        public string MessageCategoryName { get; set; }
    }
}
