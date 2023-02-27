using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IPatient: IPerson
    {
        public List<IPatientHistory> PatienceHistory { get; set; }
    }
}
