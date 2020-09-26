using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YS.CodeImage.WebApi;

namespace Hello.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = Attribute.IsDefined(typeof(QrCodeController), typeof(ControllerAttribute), true);
            var b = Attribute.IsDefined(typeof(QrCodeController), typeof(ControllerAttribute), false);
            var c = Attribute.IsDefined(typeof(QrCodeController), typeof(ControllerAttribute));
        }
    }
}
