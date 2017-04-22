
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;//Can't initialize here, cant do FindElement here, it has to come after url

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";
        

        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text");

        Thread.Sleep(3000); //keeps browser on for 3000 milliseconds 

        //textBox.Clear();//Deletes text you just input
        //Console.WriteLine(textBox.GetAttribute("value"));//Input Text boxes always go under the string: value(value = whatever is inside the text)
        Console.WriteLine(textBox.GetAttribute("maxlength"));//Finds the max amount of chars allowed
        
        Thread.Sleep(3000);

        driver.Quit();
    }
}

