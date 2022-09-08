/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using TechJobsOOAutograded;
using TechJobsTests;

namespace TechJobsOOTests
{
    [TestClass]
    public class TestTask5
    {
        //Task 5 Tests used to verify that students are testing their custom ToString method.  Uses jobs from the TechJobs class.  Tests are numbered.

        
        [TestMethod]  //1
        public void TestToStringStartsAndEndsWithNewLineExists()
        {
            //test to verify that TestToStringStartsAndEndsWithNewLine exisits 

            //setup
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
            Assert.AreEqual("true", existsCheck, "'TestToStringStartsAndEndsWithNewLine' not created");

        }


        [TestMethod]  //2
        public void Test_TestToString_Starts_And_Ends_With_NewLine()
        {
            //setup
            //comparing output to a text file.  id numbers may get a little wonky
            string text = System.IO.File.ReadAllText("StartsAndEndsWithNewLine.txt").ToString();

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var techJobs = new TechJobs();
            techJobs.RunProgram();

            var output = stringWriter.ToString();

            //verify
           Assert.AreEqual(text, output, "New Line issue");
        }



        [TestMethod]  //3
        public void TestToStringContainsCorrectLabelsAndData_Exists()
        {
            //test to verify that TestToStringContainsCorrectLabelsAndData exisits

            //setup
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
            Assert.AreEqual("true", existsCheck, "'TestToStringContainsCorrectLabelsAndData' not created");
        }


        [TestMethod]  //4
        public void Test_TestToStringContainsCorrectLabelsAndData()
        {
            //setup
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var techJobs = new TechJobs();
            techJobs.RunProgram();

            var output = stringWriter.ToString();

            //verify
            //this one is very hard coded but it doesn't give away the solution?
            Assert.IsTrue(output.Contains($"Name: Product tester") && output.Contains("Employer: ACME") && output.Contains("Location: Desert") && output.Contains("Position Type: Quality control") && output.Contains("Core Competency: Persistence"));
        }


        [TestMethod] //5
        public void TestToStringHandlesEmptyField_Exists()
        {
            ////test to verify that TestToStringHandlesEmptyField exisits

            //setup
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
            Assert.AreEqual("true", existsCheck, "'TestToStringHandlesEmptyField' not created");

        }


        [TestMethod] //6
        public void Test_TestToStringHandlesEmptyField()
        {
                        //setup
            //comparing output to a text file.  id numbers may get a little wonky
            string text = System.IO.File.ReadAllText("EmptyFieldTest.txt").ToString();

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var techJobs = new TechJobs();
            techJobs.RunProgram();

            var output = stringWriter.ToString();

            //verify
            Assert.AreEqual(text, output, "Empty string handling error");
        }
    }
}
*/
