using System;
using System.Collections.Generic;

#nullable disable

namespace applynowcrud.Models
{
    public partial class Jduserregister
    {
        public Jduserregister()
        {
            Jdapplynows = new HashSet<Jdapplynow>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Emailid { get; set; }
        public string Phone { get; set; }
        public string SecurityQuest { get; set; }
        public string Securityans { get; set; }

        public virtual ICollection<Jdapplynow> Jdapplynows { get; set; }
    }
}
