using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Models
{
    internal class Patient : IPatient
    {
        public List<IPatientHistory> PatienceHistory { get; set; }
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
    }
}
