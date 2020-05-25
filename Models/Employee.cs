using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPAuthorized.Models
{
    public class Employee 
    {
        public Guid Id { get; private set; }
        [Required]
        public string Email { get; private set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public List<EmployeeSubject> EmployeeSubjects { get; set; }
    }
}
