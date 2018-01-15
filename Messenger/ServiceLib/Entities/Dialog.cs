using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLib.Entities
{
    public class Dialog
    {
        public int DialogId { get; set; }
        public string Name { get; set; }

        public ICollection<Message> Messages { get; set; }
        public ICollection<Membership> Members { get; set; }

        public Dialog()
        {
            Messages = new List<Message>();
            Members = new List<Membership>();
        }
    }
}
