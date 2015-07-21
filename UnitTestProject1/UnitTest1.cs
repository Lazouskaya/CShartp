using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Root;
using System.Data;


namespace RootTest
{
    [TestClass]
    public class NewtonMethodTest
    {
        //private TestContext testContextInstance;
        //public TestContext TestContext {
        //    get{return testContextInstance;}
        //    set{testContextInstance = value;}
        //}

        [TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        //    "|DataDirectory|\\RotTestData.xml", "TestData",
        //    DataAccessMethod.Sequential)]
        //[DeploymentItem("RootTestData.xml")]
        public void NewtonTestPossitive()
        {

            //double number = Convert.ToDouble(TestContext.DataRow["Number"]);
            //double power = Convert.ToDouble(TestContext.DataRow["Power"]);
            //double accuracy = Convert.ToDouble(TestContext.DataRow["Accuracy"]);
            //double expextedResult = Convert.ToDouble(TestContext.DataRow["ExpectedResult"]);
            double number = 144;
            double power = 2;
            double accuracy = 0.95;
            double expextedResult = 12;
            double actualResult = NewtonsMethod.RootOfNthDegreeByNewton(number, power, accuracy);
            double interval = expextedResult * (1 - accuracy);
            Assert.IsTrue(actualResult >= expextedResult - interval && actualResult <= expextedResult + interval);
        }
        
    }
}

