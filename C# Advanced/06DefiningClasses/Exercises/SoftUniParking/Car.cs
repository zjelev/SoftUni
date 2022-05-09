using System;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Make: {this.Make}").AppendLine();
            sb.Append($"Model: {this.Model}").AppendLine();
            sb.Append($"HorsePower: {this.HorsePower}").AppendLine();
            sb.Append($"RegistrationNumber: {this.RegistrationNumber}");

            return $"{sb}";
        }
    }
}
