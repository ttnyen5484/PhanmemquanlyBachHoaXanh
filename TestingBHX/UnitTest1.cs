using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;

namespace TestingBHX
{
    [TestClass]
    public class UnitTest1
    {
        BangGiaBLL bg = new BangGiaBLL();
        [TestMethod]
        public void Test1()
        {
            bool Result_Actual = bg.Insert("",0,0,DateTime.Now,"");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except,Result_Actual);
        }
        [TestMethod]
        public void Test2()
        {
            bool Result_Actual = bg.Insert("SP001", -1, -1, DateTime.Now, "NV001");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void Test3()
        {
            bool Result_Actual = bg.Insert("SP001", 23000, 20000, DateTime.Now, null);
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void Test4()
        {
            bool Result_Actual = bg.Insert("SP001", 23000, 20000, DateTime.Now, "NV001");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }

    }
}
