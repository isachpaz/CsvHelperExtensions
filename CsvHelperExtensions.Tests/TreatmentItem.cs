namespace CsvHelperExtensions.Tests
{
    public class TreatmentItem
    {
        public string Study { get; set; }
        public double TotalPhysicalDoseInGy { get; set; }
        public double Fractions { get; set; }
        public double LocalControlProbability { get; set; }
        public double FollowUpTimeInMonths { get; set; }
        public string PatientId { get; set; }

        public override string ToString()
        {
            return $"{nameof(Study)}: {Study}, {nameof(TotalPhysicalDoseInGy)}: {TotalPhysicalDoseInGy}, {nameof(Fractions)}: {Fractions}, {nameof(LocalControlProbability)}: {LocalControlProbability}, {nameof(FollowUpTimeInMonths)}: {FollowUpTimeInMonths}";
        }
    }
}