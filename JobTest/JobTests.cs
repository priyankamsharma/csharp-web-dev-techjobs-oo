using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTest
{
    [TestClass]
    public class JobTests
    {
        Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

    [TestInitialize]

    [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            //tests ID values are not the same
            Assert.IsFalse(testJob1.Equals(testJob2));

            //tests ID values differ by 1
            Assert.AreEqual((testJob2.Id - 1), (testJob1.Id));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //tests that the constructor correctly assigns Name to "Product tester"
            Assert.IsTrue(testJob.Name == "Product tester");

            //tests that the constructor correctly assigns EmployerName to "ACME"
            Assert.IsTrue(testJob.EmployerName.Value == "ACME");

            //tests that the constructor correctly assigns EmployerLocation to "Desert"
            Assert.IsTrue(testJob.EmployerLocation.Value == "Desert");

            //tests that the constructor correctly assigns JobType to "Quality control"
            Assert.IsTrue(testJob.JobType.Value == "Quality control");

            //tests that the constructor correctly assigns JobCoreCompetency to "Persistence"
            Assert.IsTrue(testJob.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //tests id values are not the same
            Assert.IsFalse(testJob.Equals(testJob3));
        }

        //Test both requirements
        //When passed a Job object, it should return a string that contains a blank line before and after the job information.
        //The string should contain a label for each field, followed by the data stored in that field.Each field should be on its own line.
        
        [TestMethod]
        public void TestToStringMethodForBlankLineAndContainsCorrectLabelsAndData()
        {
            string testInputStr = testJob.ToString();
            string testOutputStr = $"ID: {testJob.Id} \nName: {testJob.Name} \nEmployer: {testJob.EmployerName.Value} \nLocation: {testJob.EmployerLocation.Value} \nPosition Type: {testJob.JobType.Value} \nCore Competency: {testJob.JobCoreCompetency.Value}";

            Assert.AreEqual(testOutputStr, testInputStr);
        }

        //test if a field is empty, the method should add, “Data not available” after the label.

        [TestMethod]
        public void TestToStringMethodIfNoDataAvaiable()
        {
            Job testJob4 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string testInput2 = testJob4.ToString();
            string testOutput2 = $"ID: {testJob4.Id} \nName: Data not available \nEmployer: Data not available \nLocation: Data not available \nPosition Type: Data not available \nCore Competency: Data not available";

            Assert.AreEqual(testOutput2, testInput2);
        }
    }
}

