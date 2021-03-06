using Notificationschedulingsystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Notificationschedulingsystem.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public CompanyTipe Type { get; set; }
        public Market Market { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
