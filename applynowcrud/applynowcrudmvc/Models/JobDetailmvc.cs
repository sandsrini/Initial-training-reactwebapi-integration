﻿using System;
using System.Collections.Generic;

#nullable disable

namespace applynowcrud.Models
{
    public partial class JobDetailmvc
    {
        public JobDetailmvc()
        {
            Jdapplynows = new HashSet<Jdapplynowmvc>();
        }

        public int JobDetailsId { get; set; }
        public string Companyname { get; set; }
        public string JobCategory { get; set; }
        public string Requiredskills { get; set; }
        public string Experience { get; set; }
        public int NoOfVacancies { get; set; }
        public double Salary { get; set; }
        public DateTime EndDate { get; set; }
        public string Email { get; set; }
        public string JobLocation { get; set; }
        public double PhNo { get; set; }
        public string CompanyAddress { get; set; }
        public string JobDescription { get; set; }
        public string JobType { get; set; }

        public virtual ICollection<Jdapplynowmvc> Jdapplynows { get; set; }
    }
}
