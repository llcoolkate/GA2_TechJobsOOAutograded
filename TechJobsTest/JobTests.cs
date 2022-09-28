using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]//1
        public void TestSettingJobId()
        {
            TechJob testJob1 = new TechJob();
            TechJob testJob2 = new TechJob();

            Assert.AreNotEqual(testJob1, testJob2, "Unique Id Test");
            Assert.AreEqual(testJob2, testJob2, "Should have same Id");
        }
    }
}
