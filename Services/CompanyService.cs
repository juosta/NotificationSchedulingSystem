using Microsoft.EntityFrameworkCore;
using Notificationschedulingsystem.Data;
using Notificationschedulingsystem.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notificationschedulingsystem.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _db;
        public CompanyService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<CompanyDTO> GetCompanyNotifications(Guid id)
        {
            return await _db.Companies.Select(x => new CompanyDTO() 
                                        { 
                                            CompanyId = x.Id,
                                            Notifications = x.Notifications.Select(e => e.SendDate.ToString("dd/MM/YYYY")).ToList()
                                        })
                                        .FirstOrDefaultAsync();
        }
    }
}
