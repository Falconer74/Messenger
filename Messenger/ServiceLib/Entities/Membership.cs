using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLib.Entities
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public int UserProfileId { get; set; }
        public int DialogId { get; set; }

        public UserProfile Profile { get; set; }
        public Dialog Dialog { get; set; }
        public ICollection<Message> Messages { get; set; }

        public Membership()
        {
            Messages = new List<Message>();
        }
    }
}
