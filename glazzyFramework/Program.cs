using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace glazzyFramework
{
	class Program
	{
		static void Main(string[] args)
		{
<<<<<<< HEAD
			IWebDriver driver = new ChromeDriver(@"C:\Automation testing\Driver"); //Intitiallizing chromewebdriver 
			driver.Url = "http://122.160.12.156"; //specifying URl
			driver.Manage().Window.Maximize(); //Command to set window maximize
=======
			IWebDriver driver = new ChromeDriver(@"C:\automation testing\drivers"); //Intitiallizing chromewebdriver 
			driver.Url = "http://122.160.12.156"; //specifying URl
>>>>>>> 42f540f06f8234f861d241dd6eb4279f28b7dbcc

            driver.Manage().Window.Maximize(); //Command to set window maximize
            Thread.Sleep(2000);
           
            featureMethod.normalLogin(driver);// Calling function from featuremethod file for valid login
            featureMethod.logout(driver);//calling function from featuremethod class file for sucessfull logout
            featureMethod.invalidLogin(driver);//calling function from featuremethod class file for invalid Login
            featureMethod.signup(driver);// Calling  function from featuremethod class file for new Signup by clicking on I dont have account link
            featureMethod.logout(driver); //calling function from featuremethod class file for sucessfull logout*/
            featureMethod.invalidsignup(driver);//calling function from featuremethod class file for invalid signup
            featureMethod.book_service(driver);

		}
	}

}
