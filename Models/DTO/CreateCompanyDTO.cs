using Notificationschedulingsystem.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Notificationschedulingsystem.Models.DTO
{
    public class CreateCompanyDTO
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        [RegularExpression("[0-9]{10}", ErrorMessage = "Entered company number format is not valid.")]
        public string CompanyNumber { get; set; }
        public CompanyTipe Type { get; set; }
        public Market Market { get; set; }
    }
}
