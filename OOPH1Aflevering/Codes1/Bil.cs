using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes1
{
    internal class Bil : MotorKøretøj
    {
        public string Mærke { get; set; }
        public string Model { get; set; }
        public int HesteKræfter { get; set; }
    }
}