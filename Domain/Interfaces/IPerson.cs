using Domain.Enums;

namespace Domain.Interfaces
{
    internal interface IPerson
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
    }
}
