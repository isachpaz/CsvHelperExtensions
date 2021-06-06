using CsvHelper.Configuration;

namespace CsvHelperExtensions.Tests
{
    public class TreatmentItemMapper : ClassMap<TreatmentItem>
    {
        public TreatmentItemMapper()
        {
            Map(t => t.PatientId).Name("Patient Id");
            Map(t => t.Study).Name("Study");
            Map(t => t.FollowUpTimeInMonths).Name("FollowUpTime(Months)");
            Map(t => t.Fractions).Name("Fractions");
            Map(t => t.TotalPhysicalDoseInGy).Name("TotalPhysicalDose(Gy)");
            Map(t => t.LocalControlProbability).Name("Local Control Probability");
            
            
        }
    }
}