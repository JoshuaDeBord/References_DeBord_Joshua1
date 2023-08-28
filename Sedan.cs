using System.Security.Cryptography.X509Certificates;

namespace References_DeBord_Joshua1
{
    internal class Sedan : IAutoMobile
    {
        public double Speed { get; private set; } //makes a public double called speed with an auto getter and setter

        public int Wheels { get; private set; } //makes a public integer called Wheels with an auto getter and setter

        public string LicensePlate { get; private set; } //makes a public string called LicensePlate with an auto getter and setter

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        public void Stringify()
        {
            Console.WriteLine($"The sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a license plate number of {LicensePlate}");

            
            
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
