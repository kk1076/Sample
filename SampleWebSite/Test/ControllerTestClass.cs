using NUnit.Framework;
using SampleWebSite.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebSite.Test
{
    public class ControllerTestClass
    {
        [Test]
        public void TestDepartmentIndex()
        {
            var controller = new SampleController();
            var actResult = controller.Index();
            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }
    }
}