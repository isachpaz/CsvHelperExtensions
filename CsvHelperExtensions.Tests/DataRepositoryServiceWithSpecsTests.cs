using System.Linq;
using NUnit.Framework;
using Vouzamo.Specification;

namespace CsvHelperExtensions.Tests
{
    [TestFixture]
    public class DataRepositoryServiceWithSpecsTests
    {
        private DataRepositoryService<TreatmentItem, TreatmentItemMapper> _repositoryService = null;

       [SetUp]
        public void SetUp()
        {
            _repositoryService = DataRepositoryService<TreatmentItem, TreatmentItemMapper>.FromText(Resource.testdata_multi_records);
        }

        [Test]
        public void Get_All_Records_Test()
        {
            var all = _repositoryService.GetAll().ToList();
            Assert.AreEqual(8, all.Count);
        }

        [Test]
        public void Get_Records_With_FollowUp_Time_Less_Than_12_Months_Test()
        {
            var records = _repositoryService.Get(new WithMaxFollowUpTimeSpec(12));
            Assert.AreEqual(3, records.Count());
        } 
        
        [Test]
        public void Get_Records_With_FollowUp_Time_Less_Than_12_Months_And_Fractions_LessOrEqual_6_Test()
        {
            var records = _repositoryService.Get(new WithMaxFollowUpTimeSpec(12).And(new WithFractionsLessOrEqualTo(6)));
            foreach (var item in records)
            {
                Assert.Less(item.FollowUpTimeInMonths, 12);
                Assert.LessOrEqual(item.Fractions, 6);
            }

        }
    }
}