using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public class Repair: IRepair
    {
        public string PartName { get; }
        public int HoursWorked { get; }

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
