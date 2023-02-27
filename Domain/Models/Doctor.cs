using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Models
{
    internal class Doctor : IDoctor
    {
        public string Speciality { get; set; } 
        public TimeSpan Experience { get; set; }
        public List<IWork> WorkHistory { get; set; }
        public Dictionary<IPatient, string> CommentsByPatients { get; set; }
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
    }
}
