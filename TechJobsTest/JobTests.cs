using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]//1
        public void TestSettingJobId()
        {
            TechJob testerJob1 = new TechJob();
            TechJob testerJob2 = new TechJob();

            Assert.AreNotEqual(testerJob1.Id, testerJob2.Id, "Unique Id Test");
            Assert.IsTrue(testerJob2.Id - testerJob1.Id == 1, "Should be difference of 1");
        }
        [TestMethod] //2
        public void TestJobConstructorSetsAllFields()
        {
            TechJob testJob1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(testJob1.Name, "Product tester", "Testing Job Name");
            Assert.AreEqual(testJob1.EmployerName.ToString(), "ACME", "Testing EmployerName Value");
            Assert.AreEqual(testJob1.EmployerLocation.ToString(), "Desert", "Testing EmployerLocation Value");
            Assert.AreEqual(testJob1.JobType.ToString(), "Quality control", "Testing JobType Value");
            Assert.AreEqual(testJob1.JobCoreCompetency.ToString(), "Persistence", "Testing JobCoreCompetency Value");
        }
        [TestMethod]//3
        public void TestJobsForEquality()
        {
            TechJob testJob1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            TechJob testJob2 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(testJob1.Equals(testJob2), "Objects with different ID are not equal");
        }
    }
}
