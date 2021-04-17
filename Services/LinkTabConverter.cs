using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GuitarTabPDF.Services
{
    public class LinkTabConverter : ITabConverter
    {
        public string Convert(string link)
        {
            IWebDriver driver = new ChromeDriver(@"C:\\WebDriver\bin");
            driver.Navigate().GoToUrl(link);
            string title = driver.FindElement(By.ClassName("_2ewmI")).Text;
            driver.Quit();
            return title;
        }
    }
}
