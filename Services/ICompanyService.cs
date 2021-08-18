using Notificationschedulingsystem.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notificationschedulingsystem.Services
{
    public interface ICompanyService
    {
        public Task<CompanyDTO> GetCompanyNotifications(Guid id);
        public Task CreateCompany(CreateCompanyDTO model); 
    }
}
