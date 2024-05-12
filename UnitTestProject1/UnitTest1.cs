using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KPLMOD12TP;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();

            form.CariTandaBilangan(100);
        }
    }
}
