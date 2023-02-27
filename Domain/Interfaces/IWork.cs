using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IWork
    {
        public Guid Id { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationLocation { get; set; }
        public string SpecialityInCurrentOrganization { get; set; }
        public DateOnly StartTime { get; set; }
        public DateOnly EndTime { get; set; }
        public string ReasonOfFired { get; set; }
    }
}
