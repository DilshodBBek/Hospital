using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class PatientHistory : IPatientHistory
    {
        public string IllnessName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateOnly StartPetienceDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IDoctor> Doctors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Recepts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
