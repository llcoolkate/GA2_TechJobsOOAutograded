using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System.Reflection;
using System.Collections.Generic;

namespace TechJobsOOTests
{
    // Testing how students setup the Location, CoreCompetency, and PositionType classes.

    [TestClass]
    public class TestTask2
    {

    // Testing Location --------------------------------------------------------

        [TestMethod] //1
        public void Test_Second_Location_Constructor_Exists()
        { 
            Type locType = typeof(Location);
            ConstructorInfo[] constructorInfos = locType.GetConstructors();
            List<string> conNames = new List<string>();
            string nameCheck = "Second Constructor";
            string existsCheck = "";

            foreach (var name in constructorInfos)
            {
                conNames.Add(name.ToString());

            }

            foreach (string name in conNames)
            {
                if (name.Equals("Void .ctor(System.String)"))
                {
                    existsCheck += "Second Constructor";
                    break;
                }
            }

            //verify
            Assert.AreEqual(existsCheck, nameCheck, "No Second Constructor exists");
        }


        [TestMethod] //2
        public void Test_Second_Location_Constructor_Initializes_Value()
        {
            //setup
            Location testLocation = new Location("Desert");

            //verify
            Assert.AreEqual("Desert", testLocation.Value, "Is Value set at time of declaration?");
            Assert.AreEqual("St. Louis", testLocation.Value = "St. Louis", "Not able to update value");
        }


        [TestMethod] //3
        public void Test_Second_Location_Constructor_Initializes_Id()
        {
            //setup
            Location testLocation = new Location("Desert");
            Console.WriteLine(testLocation.Id);

            //verify
            Assert.AreEqual(2, testLocation.Id, "Second constructor not able to update Id");
            Assert.IsFalse(testLocation.Id == 4, "Second constructor passes value to Id. Is this desirable?");
        }

        // Testing CoreCompetency --------------------------------------------------------

        [TestMethod] //4
        public void Test_CoreCompetency_Accessor_SetUp()
        {
            //setup
            CoreCompetency testComp = new CoreCompetency("Persistence");
            CoreCompetency testComp2 = new CoreCompetency("Persistence");

            Type ccType = typeof(CoreCompetency); 
            MemberInfo[] memberInfos = ccType.GetMembers();
            string nameCheck = "get_Id";
            string existsCheck = "";
            
            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            //verify
            Assert.AreEqual("Persistence", testComp.Value, "CoreComp has no set-able Value");
            Assert.AreEqual("true", existsCheck, "CoreComp getter does not exist");
            Assert.AreNotEqual(testComp.Id, testComp2.Id, "Not able to get ids for CoreComp objects");
        }

        [TestMethod] //5
        public void Test_CoreCompetency_Has_No_Id_Setter_SetUp()
        {
            Type ccType = typeof(CoreCompetency);
            MemberInfo[] memberInfos = ccType.GetMembers();
            string nameCheck = "set_Id";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name != nameCheck)
                {
                    existsCheck += "false";
                    break;
                }
            }

            //verify
            Assert.AreEqual("false", existsCheck, "CoreComp should not have a setter");
        }

        // Testing PositionType --------------------------------------------------------

        [TestMethod] //6
        public void Test_PositionType_Equals_Method_SetUp()
        {
            // set up
            PositionType testPosition = new PositionType("Quality Control");
            PositionType testPosition2 = new PositionType("Quality Control");

            MethodInfo mInfo = typeof(PositionType).GetMethod("Equals");
            MethodBody mBody = mInfo.GetMethodBody();

            int lviCount = mBody.LocalVariables.Count;
            string mName = mInfo.ReflectedType.Name;
            string mGBD = mInfo.GetBaseDefinition().ReflectedType.Name;

            //verify setup
            Assert.AreNotEqual(mName, mGBD, "Equals method belongs to PositionType class");
            Assert.AreEqual(lviCount, 2, "Equals method has 2 local variables");

            //verify output
            Assert.AreEqual(testPosition, testPosition, "Objects with Same ID are not Equal");
            Assert.AreNotEqual(testPosition, testPosition2, "Objects with different ID Equal?");
        }


        [TestMethod] //7
        public void Test_PositionType_HashCode_SetUp()
        {
            // set up
            PositionType testPosition = new PositionType("Quality Control");
            PositionType testPosition2 = new PositionType("Quality Control");

            MethodInfo mInfo = typeof(PositionType).GetMethod("GetHashCode");
            MethodBody mBody = mInfo.GetMethodBody();
            int localCount = mBody.LocalVariables.Count;

            //verify setup
            Assert.IsTrue(localCount > 0, "No GetHashCode method setup");

            //verify output
            Assert.AreNotEqual(testPosition.GetHashCode(), testPosition2.GetHashCode(), "GetHashCode output test failed");
        }


        [TestMethod] //8
        public void Test_PositionType_ToString_SetUp()
        {
            //setup
            PositionType testPosition = new PositionType("Quality Control");

            MethodInfo mInfo = typeof(PositionType).GetMethod("ToString");
            MethodBody mBody = mInfo.GetMethodBody();
            int localCount = mBody.LocalVariables.Count;

            //verify setup
            Assert.IsTrue(localCount > 0, "ToString method has no local variables");

            //verify output
            Assert.AreEqual(testPosition.Value.ToString(), "Quality Control", "ToString does not return same output as set value");
        }
    }
}

