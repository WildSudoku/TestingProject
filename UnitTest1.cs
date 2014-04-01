using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCrackerCentralized.util;

namespace TestPasswordCrackerCentralized
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodcapitalized()
        {
            string s;
            s = StringUtilities.Capitalize("");
            Assert.AreEqual<string>(" ", s);

            //try
            //{
            //    s = null;
            //    Assert.Fail();
            //}
            //catch (ArgumentException ex)
            //{

            //    Assert.AreEqual("its low letter : ", ex.Message);
            //}
        }
    }
}
