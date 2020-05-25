using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace TPAuthorized.Models
{
    public class EmployeeSubject
    {
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
