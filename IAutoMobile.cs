using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_DeBord_Joshua1
{
    internal interface IAutoMobile
    {

        public double Speed { get; } //makes a public double called speed with an auto getter and setter

        public int Wheels { get; } //makes a public integer called Wheels with an auto getter and setter

        public string LicensePlate { get; } //makes a public string called LicensePlate with an auto getter and setter

        public void Stringify();

    }
}
