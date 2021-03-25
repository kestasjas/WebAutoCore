using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace WebAutoCore
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver chrome = new ChromeDriver(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), new ChromeOptions());

            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://www.google.com/");
            chrome.Quit();


        }


    }
}
