using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "3";//the number of the checkbox

        


        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        //checkbox.Click(); //Clicks the checkbox, can do this for logging in

        //Thread.Sleep(5000);


        if (checkBox.GetAttribute("checked") == "true")//when the check box is checked, html will say checked
        {
            Console.WriteLine("Checkbox is checked!");
        }
        else
        {
            Console.WriteLine("The checkbox is NOT checked");

        }

        driver.Quit();


    }
}

