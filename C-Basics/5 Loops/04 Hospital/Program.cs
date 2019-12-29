using System;

namespace _04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int patientsDaily;
            int numDoctors = 7;
            int patientsAdmitted = 0;
            int patientsRejected = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    if (patientsRejected > patientsAdmitted)
                    {
                        numDoctors++;
                    }
                }
                patientsDaily = int.Parse(Console.ReadLine());
                if (numDoctors >= patientsDaily)
                {
                    patientsAdmitted = patientsAdmitted + patientsDaily;
                }
                else
                {
                    patientsAdmitted += numDoctors;
                    patientsRejected = patientsRejected + (patientsDaily - numDoctors);
                }
            }
            Console.WriteLine($"Treated patients: {patientsAdmitted}.");
            Console.WriteLine($"Untreated patients: {patientsRejected}.");
        }
    }
}