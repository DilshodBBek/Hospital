using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IDoctor: IPerson
    {
        public string Speciality { get; set; }
        public TimeSpan Experience { get; set; }
        public List<IWork> WorkHistory { get; set; }
        public Dictionary<IPatient, string> CommentsByPatients { get; set; }
    }
}
