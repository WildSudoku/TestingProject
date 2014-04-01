using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCrackerCentralized.util;

namespace TestPasswordCrackerCentralized.util
{   [TestClass]
    public class StringUtilitiesTest
    {
        [TestMethod]
        public void TestOfCapitalize()
        {
            string str;
            str = StringUtilities.Capitalize("cal");
            Assert.AreEqual("Cal", str);

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
        

        [TestMethod]
           public void TestOfReverse()
        {
            string str;
            str = StringUtilities.Reverse("abcd");
            Assert.AreEqual("dcba",str);
            try
            {
                StringUtilities.Reverse(null);
                Assert.Fail();
            }
            catch (ArgumentNullException e)
            {

                //Assert.AreEqual("no", e);
            }
        }

    [TestMethod]
    //encrypted produce a byterate
        public void TestAddDigitsToBegin()
    {// ref help to change the value insdide the method and 
        string word = "";
        int number=4;
        List<string> list=new List<string>();
       StringUtilities.AddDigitsToBegin("ana",number, list);
        Assert.AreEqual(2, list.Count);
        try
        {
           // StringUtilities.AddDigitsToBegin();
            Assert.Fail();
        }
        catch (ArgumentNullException e)
        {

            //Assert.AreEqual("no", e);
        }
        //int begin;
        //StringUtilities stringU = StringUtilities.AddDigitsToBegin("12maria",2,List<word>);

    }
    }
}
