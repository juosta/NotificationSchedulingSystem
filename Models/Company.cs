using Notificationschedulingsystem.Models.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Notificationschedulingsystem.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [DisplayName("Company Number")]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Entered company number format is not valid.")]
        public string CompanyNumber { get; set; }
        public CompanyTipe Type { get; set; }
        public Market Market { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
