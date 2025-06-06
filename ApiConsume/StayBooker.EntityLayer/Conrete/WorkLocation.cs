using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.EntityLayer.Conrete
{
    public class WorkLocation
    {
        [Key]
        public int WorkLocationId { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
