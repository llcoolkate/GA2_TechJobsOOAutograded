using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TechJobsOO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechJobsOOAutograded;
using TechJobsTest;

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
        [TestMethod]//toString 1// when passed an Job object, it should return a string that contains a blank line before and after the job information.  
        public void TestToStringStartsAndEndsWithNewLine() 
        {
            TechJob testJob1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string tester = testJob1.ToString();

            Assert.IsTrue(tester.StartsWith("\n"));
            Assert.IsTrue(tester.EndsWith("\n"));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            TechJob testJob1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string expectedString = $"\n\nID: {testJob1.Id}\nName: {testJob1.Name}\nEmployer: {testJob1.EmployerName}\nLocation: {testJob1.EmployerLocation}\nPosition Type: {testJob1.JobType}\nCore Competency: {testJob1.JobCoreCompetency}\n\n";

            Assert.AreEqual(expectedString, testJob1.ToString(),"Test strings did not equal each other");
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            TechJob testJob1 = new TechJob("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string expectedString = $"\n\nID: {testJob1.Id}\nName: {testJob1.Name}\nEmployer: Data not available \nLocation: {testJob1.EmployerLocation}\nPosition Type: {testJob1.JobType}\nCore Competency: {testJob1.JobCoreCompetency}\n\n";

            Assert.AreEqual(expectedString, testJob1.ToString(), "Test strings did not equal each other");
        }
    
    
    }


}
