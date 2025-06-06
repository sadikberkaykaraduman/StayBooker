using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.WebUI.Dtos.ContactDtos
{
    public class CreateContactDto
    {
        public string ContactName { get; set; }
        public string ContactMail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }
        public int MessageCategoryId { get; set; }
    }
}
