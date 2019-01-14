using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeTestWithHook
{
    class Hooks
    {
        public static IWebDriver _driver;

        [BeforeSuite]
        public void Initialize()
        {
            _driver = new ChromeDriver();
        }

        [AfterSuite]
        public void AfterSuite()
        {
            _driver?.Quit();
        }
        public static IWebDriver WebDriver
        {
            get { return _driver; }
        }
    }
}
