namespace Udemy;
using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //var driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        var driver = GetChromeDriver();
        driver.Navigate().GoToUrl("http://www.ultimateqa.com");

    }

    private IWebDriver GetChromeDriver()
    {
        //this line will direct us to the directory of the exectuable.  This is going to go to the finder and find the path of
        //the chrome driver that I added into this project. Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); this allows
        //anyone with this project to find a path on their machine. Dynamic code where it can work on either computer.
        var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //return us a new chrome driver with the path to the chrome driver that we have now the binary
        return new ChromeDriver(outPutDirectory);
    }
}