using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Root;
using System.Data;


namespace RootTest
{
    [TestClass]
    public class NewtonMethodTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void NewtonTestPossitive()
        {
            double number = 144;
            int power = 2;
            double accurancy = 0.95;
            double expextedResult = 12;
            double actualResult = NewtonsMethod.RootOfNthDegreeByNewton(number, power, accurancy);
            double interval = expextedResult * (1 - accurancy);
            Assert.IsTrue(actualResult >= expextedResult - interval && actualResult <= expextedResult + interval);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","|DataDirectory|\\DataRootTest.xml","TestCase",DataAccessMethod.Sequential)]
        [DeploymentItem("RootTest\\DataRootTest.xml")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NewtonTestNegative()
        {
                double number = Convert.ToDouble(TestContext.DataRow["number"]);
                int power = Convert.ToInt32(TestContext.DataRow["power"]);
                double accurancy = Convert.ToDouble(TestContext.DataRow["accurancy"]);
                double actualResult = NewtonsMethod.RootOfNthDegreeByNewton(number,power,accurancy);
          
        }
        
    }
}

