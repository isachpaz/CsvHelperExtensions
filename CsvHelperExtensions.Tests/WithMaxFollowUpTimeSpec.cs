using Vouzamo.Specification.Interfaces;

namespace CsvHelperExtensions.Tests
{
    public class WithMaxFollowUpTimeSpec : ISpecification<TreatmentItem>
    {
        public double MaxFollowUpTimeCutOff { get; }

        public WithMaxFollowUpTimeSpec(double maxFollowUpTimeCutOff)
        {
            MaxFollowUpTimeCutOff = maxFollowUpTimeCutOff;
        }

        public bool IsSatisfiedBy(TreatmentItem subject)
        {
            return subject.FollowUpTimeInMonths < MaxFollowUpTimeCutOff;
        }
    }
}