using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using NUnit.Framework;

namespace CsvHelperExtensions.Tests
{
    [TestFixture]
    public class DataRepositoryServiceTests
    {

        [Test]
        public void With_Empty_CsvData_Test()
        {
            var repoService = DataRepositoryService<TreatmentItem, TreatmentItemMapper>
                .FromText("");

            Assert.AreEqual(0, repoService.GetAll().ToList().Count);
        }

        [Test]
        public void CSV_Delimiter_Comma_With_One_Record_Test()
        {
            var repoService = DataRepositoryService<TreatmentItem, TreatmentItemMapper>
                .FromText(Resource.treatment_data);

            var firstItem = repoService.GetAll().FirstOrDefault();
            Assert.AreEqual("1",firstItem?.PatientId);
            Assert.AreEqual("high dose", firstItem?.Study);
            Assert.AreEqual(12, firstItem?.FollowUpTimeInMonths);
            Assert.AreEqual(1, firstItem?.Fractions);
            Assert.AreEqual(30, firstItem?.TotalPhysicalDoseInGy);
            Assert.AreEqual(0.88, firstItem?.LocalControlProbability);
        }

        [Test]
        public void CSV_Delimiter_Semicolon_With_One_Record_Test()
        {
            var config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                Delimiter = ";",
                Encoding = Encoding.UTF8
            };

            var repoService = DataRepositoryService<TreatmentItem, TreatmentItemMapper>
                .FromText(Resource.testdata_semicolon, config);

            var firstItem = repoService.GetAll().FirstOrDefault();
            Assert.AreEqual("1",firstItem?.PatientId);
            Assert.AreEqual("high dose", firstItem?.Study);
            Assert.AreEqual(12, firstItem?.FollowUpTimeInMonths);
            Assert.AreEqual(1, firstItem?.Fractions);
            Assert.AreEqual(30, firstItem?.TotalPhysicalDoseInGy);
            Assert.AreEqual(0.88, firstItem?.LocalControlProbability);
        }
    }
}
