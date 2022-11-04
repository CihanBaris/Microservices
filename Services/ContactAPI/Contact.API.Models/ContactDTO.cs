using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Models
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Lastname { get; set; }
        public String Fullname => $"{Name} {Lastname}";

    }
}
