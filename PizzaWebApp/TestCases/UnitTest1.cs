using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Demo
{
    public class Browser_ops
    {
        IWebDriver webDriver;
        public void Init_Browser()
        {
            webDriver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
            webDriver.Manage().Window.Maximize();
        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public void Goto(string url)
        {
            webDriver.Url = url;
        }
        public void Close()
        {
            webDriver.Quit();
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
    }
    


    class Test1_Open
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:1007/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);        
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test2_ViewMenu
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:1007/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@href='/products']"));

            //element.Submit();
            element.Click();

            System.Threading.Thread.Sleep(2000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
    class Test2_ViewVegMenu
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:1007/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@href='/products/veg']"));

            //element.Submit();
            element.Click();

            System.Threading.Thread.Sleep(2000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
    class Test2_ViewNonVegMenu
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:1007/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@href='/products/non_veg']"));

            
            element.Click();

            System.Threading.Thread.Sleep(2000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test3_AddPizza
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:1007/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@href='/products']"));

            //element.Submit();
            element.Click();

            System.Threading.Thread.Sleep(2000);
            Random rnd = new Random();
           
            
            int r,c;
            for (int i = 0; i < 3; i++)
            {
                c = rnd.Next(1, 4);
                brow.Goto(test_url + "products/?p=" + c);
                if (c == 3)
                {
                    r = rnd.Next(1, 3);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
                else if (c == 2)
                {
                    r = rnd.Next(3, 6);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
                else
                {
                    r = rnd.Next(6, 9);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
            }



            System.Threading.Thread.Sleep(10000);
        }
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test4_ViewCart
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:1007/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@href='/products']"));

            //element.Submit();
            element.Click();

            System.Threading.Thread.Sleep(2000);
            Random rnd = new Random();


            int r, c;
            for (int i = 0; i < 3; i++)
            {
                c = rnd.Next(1, 4);
                brow.Goto(test_url + "products/?p=" + c);
                if (c == 3)
                {
                    r = rnd.Next(1, 3);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
                else if (c == 2)
                {
                    r = rnd.Next(3, 6);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
                else
                {
                    r = rnd.Next(6, 9);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
            }

            brow.Goto(test_url + "Cart");

            System.Threading.Thread.Sleep(10000);
        }

        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

    class Test5_CheckOut
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://localhost:1007/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@href='/products']"));

            //element.Submit();
            element.Click();

            System.Threading.Thread.Sleep(2000);
            Random rnd = new Random();


            int r, c;
            for (int i = 0; i < 3; i++)
            {
                c = rnd.Next(1, 4);
                brow.Goto(test_url + "products/?p=" + c);
                if (c == 3)
                {
                    r = rnd.Next(1, 3);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
                else if (c == 2)
                {
                    r = rnd.Next(3, 6);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
                else
                {
                    r = rnd.Next(6, 9);
                    element = driver.FindElement(By.XPath("//*[@id ='" + r + "']"));
                    element.Click();
                }
            }

            brow.Goto(test_url + "Cart");

            driver.FindElement(By.XPath("//*[@class = 'btn btn-primary checkout']")).Click();
         

            System.Threading.Thread.Sleep(10000);
        }

        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }

}