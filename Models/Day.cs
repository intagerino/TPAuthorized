using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPAuthorized.Models
{
    public class Day 
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
