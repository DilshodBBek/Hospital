using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IPatientHistory
    {
        public string IllnessName { get; set; }
        public DateOnly StartPetienceDate { get; set; }
        public List<IDoctor> Doctors { get; set; }
        public List<string> Recepts { get; set; }
    }
}
