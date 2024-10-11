using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactUserName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ConctactDate { get; set; }
        public bool ContactStatus { get; set; }
    }
}
