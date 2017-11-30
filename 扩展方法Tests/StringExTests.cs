using Microsoft.VisualStudio.TestTools.UnitTesting;
using 扩展方法;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 扩展方法.Tests
{
    [TestClass()]
    public class StringExTests
    {
        [TestMethod()]
        public void IsCellPhoneTest()
        {
            Console.WriteLine("13111211355".IsCellPhone());
            Console.WriteLine("123".IsCellPhone());
            Console.WriteLine("111111111111".IsCellPhone());
        }
    }
}