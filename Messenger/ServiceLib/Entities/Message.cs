using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLib.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public int DialogId { get; set; }
        public int MembershipId { get; set; }

        public Dialog Dialog { get; set; }
        public Membership Member { get; set; }
    }
}
