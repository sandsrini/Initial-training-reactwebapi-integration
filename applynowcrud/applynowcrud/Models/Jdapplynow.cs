using System;
using System.Collections.Generic;

#nullable disable

namespace applynowcrud.Models
{
    public partial class Jdapplynow
    {
        public int ApplyId { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public string Link { get; set; }
        public string Resume { get; set; }
        public string Letter { get; set; }
        public int? UserId { get; set; }
        public int? JobId { get; set; }

        public virtual JobDetail Job { get; set; }
        public virtual Jduserregister User { get; set; }
        //public virtual int user_id { get; set; }//dependent key
        //[ForeignKey("user_id")]
        //public virtual TblOne user_reg { get; set; }//navigation property
    }
}
