using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_DeBord_Joshua1
{
    internal class Truck : IAutoMobile
    {
        public double Speed { get; private set; } //makes a public double called speed with an auto getter and setter

        public int Wheels { get; private set; } //makes a public integer called Wheels with an auto getter and setter

        public string LicensePlate { get; private set; } //makes a public string called LicensePlate with an auto getter and setter

        public double Weight { get; } //make a public double called Weight with an autogetter 

        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam; //make Speed the same as speedParam
            Weight = weightParam;
            LicensePlate = licenseNum;

            if(Weight < 400) //if statement. If 400 is more than Weight, it'll make Wheels = 8
            {
                Wheels = 8;
            }
            else //else statement going off the if statement above. If 400 is less than Weight, it'll make Wheels = 12
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
            Console.WriteLine($"The truck is traveling at a speed of {Speed} on {Wheels} wheels, with a license plate number of {LicensePlate}");
        }

        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }

}
