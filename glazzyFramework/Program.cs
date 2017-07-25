using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace glazzyFramework
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"C:\Automation testing\Driver"); //Intitiallizing chromewebdriver 
			driver.Url = "http://test-gp.classifiedsolutionsgroup.com/"; //specifying URl
			driver.Manage().Window.Maximize(); //Command to set window maximize

			featureMethod.normalLogin(driver);// Calling function from featuremethod file for valid login
			

			featureMethod.logout(driver);//calling function from featuremethod class file for sucessfull logout

			featureMethod.invalidLogin(driver);//calling function from featuremethod class file for invalid Login

			featureMethod.signup(driver);// Calling  function from featuremethod class file for new Signup by clicking on I dont have account link

			featureMethod.logout(driver); //calling function from featuremethod class file for sucessfull logout

			featureMethod.invalidsignup(driver);//calling function from featuremethod class file for invalid signup 
			
			//Schedule Service
			 //featureMethod.ScheduleService(driver); //calling function from featuremethod class file to schedule a service
		}
	}
}
