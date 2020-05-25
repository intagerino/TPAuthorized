using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPAuthorized.Models
{
    public class Subject
    {
        protected Subject() { }
        public Guid Id { get; private set; }
        [Required]
        public string Name { get; private set; }
        public Guid? ParentSubjectId { get; private set; }
        public string Description { get; private set; }
        public List<EmployeeSubject> EmployeeSubjects { get; set; }

    }
}
