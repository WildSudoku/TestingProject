using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCrackerCentralized.util;

namespace TestPasswordCrackerCentralized.util
{
    [TestClass]
    public class PassCheckerTest
    {
        [TestMethod]
        public void TestCompareBytes()
        {
            string str;
          //  str = PassChecker.Check(userinfo,posiblepass);
          //  Assert.AreEqual("Cal", str);

            try
            {
                StringUtilities.Capitalize(null);
                Assert.Fail();
            }
            catch (ArgumentNullException e)
            {

                //Assert.AreEqual("no", e);
            }
        }
    }
}
