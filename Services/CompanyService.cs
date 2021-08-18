using Microsoft.EntityFrameworkCore;
using Notificationschedulingsystem.Data;
using Notificationschedulingsystem.Models;
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

        public async Task CreateCompany(CreateCompanyDTO model)
        {
            var newCompany = new Company()
            {
                Id = model.Id,
                CompanyName = model.CompanyName,
                CompanyNumber = model.CompanyNumber,
                Type = model.Type,
                Market = model.Market,
                Notifications = new List<Notification>()
            };
            var callDate = DateTime.UtcNow.Date;
            List<int> notificationDays;
            switch (model.Market)
            {
                case Models.Enums.Market.Denmark:
                    notificationDays = new List<int>() { 1, 5, 10, 15, 20 };
                    break;
                case Models.Enums.Market.Norway:
                    notificationDays = new List<int>() { 1, 5, 10, 20 };
                    break;
                case Models.Enums.Market.Sweden:
                    if (model.Type != Models.Enums.CompanyTipe.large)
                    {
                        notificationDays = new List<int>() { 1, 7, 14, 28 };
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                case Models.Enums.Market.Finland:
                    if (model.Type == Models.Enums.CompanyTipe.large)
                    {
                        notificationDays = new List<int>() { 1, 5, 10, 15, 20 };
                    } else
                    {
                        goto default;
                    }
                    break;
                default:
                    notificationDays = new List<int>();
                    break;
            }
            foreach(var day in notificationDays)
            {
                newCompany.Notifications.Add(new Notification
                {
                    SendDate = callDate.AddDays(day)
                }); 
            }
            _db.Companies.Add(newCompany);
            await _db.SaveChangesAsync();
        }

        public async Task<CompanyDTO> GetCompanyNotifications(Guid id)
        {
            return await _db.Companies
                .Select(x => new CompanyDTO() 
                { 
                    CompanyId = x.Id,
                    Notifications = x.Notifications.Select(e => e.SendDate.ToString("dd/MM/yyyy")).ToList()
                })
                .FirstOrDefaultAsync(x => x.CompanyId == id);
        }
    }
}
