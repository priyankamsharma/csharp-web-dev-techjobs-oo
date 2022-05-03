using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job Job1 = new Job();
            Job Job2 = new Job();

            //tests ID values are not the same
            Assert.IsFalse(Job1.Equals(Job2));

            //tests ID values differ by 1
            Assert.AreEqual((Job2.Id - 1), (Job1.Id));
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job Job3 = new Job(1, "Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //tests that the constructor correctly assigns Name to "Product tester"
            Assert.IsTrue(Job3.Name == "Product tester");

            //tests that the constructor correctly assigns EmployerName to "ACME"
            Assert.IsTrue(Job3.EmployerName.Value == "ACME");

            //tests that the constructor correctly assigns EmployerLocation to "Desert"
            Assert.IsTrue(Job3.EmployerLocation.Value == "Desert");

            //tests that the constructor correctly assigns JobType to "Quality control"
            Assert.IsTrue(Job3.JobType.Value == "Quality control");

            //tests that the constructor correctly assigns JobCoreCompetency to "Persistence"
            Assert.IsTrue(Job3.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job Job4 = new Job(1, "Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job Job5 = new Job(2, "Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //tests id values are not the same
            Assert.IsFalse(Job4.Equals(Job5));
        }


    } 
}
