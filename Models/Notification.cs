using System;
using System.ComponentModel.DataAnnotations;

namespace Notificationschedulingsystem.Models
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime SendDate { get; set; }
        public virtual Company Company { get; set; }
    }
}
