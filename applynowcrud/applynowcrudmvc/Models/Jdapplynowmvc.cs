using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using applynowcrudmvc.Controllers;


#nullable disable

namespace applynowcrud.Models
{
    public partial class Jdapplynowmvc
    {
        public int ApplyId { get; set; }
        [Required]
        [StringLength(25)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Url(ErrorMessage = "Please enter a valid url")]
        public string Link { get; set; }
        [Required]
        //[DataType(DataType.Upload)]
        //[AllowedExtensions(new string[] { ".jpg", ".png" })]
        public string Resume { get; set; }
        public string Letter { get; set; }
        public int? UserId { get; set; }
        public int? JobId { get; set; }
        public virtual JobDetailmvc Job { get; set; }
        public virtual Jduserregistermvc User { get; set; }
    }
}
