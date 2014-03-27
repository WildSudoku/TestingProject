using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCrackerCentralized.util;

namespace TestPasswordCrackerCentralized.util
{
    [TestClass]
    public class DictionaryReaderTest
    {
        [TestMethod]
        public void TestOfConstructor()
        {
            BlockingCollection<string> dictionary = new BlockingCollection<string>();
            new DictionaryReader(dictionary, "testing_dictionary.txt");
            Assert.AreEqual("A",dictionary.Take());
            Assert.AreEqual("Achomawi", dictionary.Take());
            Assert.AreEqual("Achordata", dictionary.Take());
            Assert.AreEqual("Achorion", dictionary.Take());
            Assert.AreEqual("Achras", dictionary.Take());
        }
    }
}
