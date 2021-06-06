using Vouzamo.Specification.Interfaces;

namespace CsvHelperExtensions.Tests
{
    public class WithFractionsLessOrEqualTo : ISpecification<TreatmentItem>
    {
        private double _fractions;

        public WithFractionsLessOrEqualTo(double fractions)
        {
            _fractions = fractions;
        }

        public bool IsSatisfiedBy(TreatmentItem subject)
        {
            return subject.Fractions <= _fractions;
        }
    }
}