
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using TechJobsOOAutograded;

namespace TechJobsOOTests
{
    [TestClass]
    public class TestTask6
    {
        //task 5 tests should verify if students properly used inheritance once code is refactored. 
        //task 6 tests will verify that the refactoring changed the number of class members and info regarding JobField.  Tests have been numbered.


        [TestMethod] //1
        public void Test_Attributes_Of_JobField()
        {
            //setup 
            Type jFType = typeof(JobField);
            var expected = jFType.Attributes.ToString().Contains("Abstract") ? "true" : "false";

            //verify
            Assert.AreEqual(expected, "true", "JobField is not an abstract class");
        }


        [TestMethod]  //2
        public void Test_DRY_Employer()
        {
            //setup
            Type empType = typeof(Employer);
            ConstructorInfo[] constructorInfos = empType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = empType.GetMethods();
            int methodLength = methodInfos.Length;

            //verify
            Assert.AreEqual(1, conLength, "Employer class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "Employer class methods not properly refactored");

        }


        [TestMethod] //3
        public void Test_DRY_Location()
        {
            //setup
            Type locType = typeof(Location);
            ConstructorInfo[] constructorInfos = locType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = locType.GetMethods();
            int methodLength = methodInfos.Length;

            //verify
            Assert.AreEqual(1, conLength, "Location class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "Location class methods not properly refactored");
        }


        [TestMethod] //4
        public void Test_DRY_Position()
        {
            //setup
            Type posType = typeof(PositionType);
            ConstructorInfo[] constructorInfos = posType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = posType.GetMethods();
            int methodLength = methodInfos.Length;

            //verify
            Assert.AreEqual(1, conLength, "PositionType class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "PositionType class methods not properly refactored");
        }


        [TestMethod] //5
        public void Test_DRY_CoreCompetency()
        {
            //setup
            Type ccType = typeof(CoreCompetency);
            ConstructorInfo[] constructorInfos = ccType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = ccType.GetMethods();
            int methodLength = methodInfos.Length;

            //verify
            Assert.AreEqual(1, conLength, "CoreCompetency class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "CoreCompetency class methods not properly refactored");
        }

    }
}
