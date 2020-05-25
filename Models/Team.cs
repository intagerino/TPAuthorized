using System;
using System.Collections.Generic;

namespace TPAuthorized.Models
{
    public class Team
    {
        public Guid Id { get; set; }

        public Employee teamLeader { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
