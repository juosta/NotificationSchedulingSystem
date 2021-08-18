using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notificationschedulingsystem.Models.DTO
{
    public class CompanyDTO
    {
        public Guid CompanyId { get; set; }
        public List<string> Notifications { get; set; }
    }
}
