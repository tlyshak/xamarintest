using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest1
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
                    .Android
                    .ApkFile (@"..\..\..\App3\App3.Android\bin\Debug\com.companyname.App3.apk")
                    .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("customLabel").Text("Hello"));
            Assert.IsTrue(results.Any());
        }
    }
}

