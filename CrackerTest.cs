using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCrackerCentralized;

namespace TestPasswordCrackerCentralized
{
    [TestClass]
    public class CrackerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestOfCrackersConstructor()
        {
            Cracker c1 = new Cracker("testing_dictionary.txt","passwords.txt");
        }
    }
}
