using System;
using ClassDemoTest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDummy
{
    [TestClass]
    public class UnitTest1
    {
        //test methods
        [TestMethod]
        public void TestMethod2()
        {
            Dummy dum = new Dummy();
            
            dum.SomeNumber = 1;
            Assert.AreEqual(1, dum.SomeNumber);
            
        }

        [TestMethod]
        public void TestMethod1()
        {
            Dummy dum = new Dummy();
            try
            {
                dum.SomeNumber = 0;
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {
                
                // ok
            }


        }

        [TestMethod]
        public void TestMethod3()
        {
            Dummy dum = new Dummy();
            
                dum.SomeNumber = 4;
                Assert.AreEqual(4, dum.SomeNumber);
           

        }

        [TestMethod]
        public void TestMethod4()
        {
            Dummy dum = new Dummy();
            try
            {
                dum.SomeNumber = 5;
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {

                // ok
            }


        }
    }
}
