using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLib.Entities
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; set; }

        public Account Account { get; set; }
    }
}
