using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Notificationschedulingsystem.Models
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; }
        [DisplayName("Company Id")]
        public Guid CompanyId { get; set; }
        public DateTime SendDate { get; set; }
    }
}
