/*
using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsTests;


namespace TechJobsOOTests
{
    //Task 4 Tests to verify students' unit tests.  Tests are numbered.


    [TestClass] //1
    public class TestTask4
    {
        [TestMethod]
        public void Test_TestSettingJobIdExists()
        {
            //setup
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestSettingJobId";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestSettingJobId' not created");
        }


        [TestMethod] //2
        public void Test_TestJobConstructorSetsAllFields()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestJobConstructorSetsAllFields";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestJobConstructorSetsAllFields' not found");
        }


        [TestMethod] //3
        public void Test_TestJobsForEquality()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestJobsForEquality";
            string existsCheck = "";


            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }
            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestJobsForEquality' not found");
        }


        [TestMethod] //4
        public void Test_TestToStringStartsAndEndsWithNewLine()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestToStringStartsAndEndsWithNewLine";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";

                    break;
                }
            }
            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestToStringStartsAndEndsWithNewLine' not found");
        }


        [TestMethod] //5
        public void Test_TestToStringContainsCorrectLabelsAndData()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestToStringContainsCorrectLabelsAndData";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestToStringContainsCorrectLabelsAndData' not found");
        }


        [TestMethod] //6
        public void Test_TestToStringHandlesEmptyField()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestToStringHandlesEmptyField";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }
            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestToStringHandlesEmptyField' not found");
        }

    }
}
*/

