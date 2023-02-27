using Domain.Interfaces;

namespace Domain.Models
{
    internal class WorkHistory : IWork
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
