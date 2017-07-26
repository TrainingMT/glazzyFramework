using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using OpenQA.Selenium.Support.Events;
using System.Threading;


namespace glazzyFramework
{
	class coreMethod
	{
		public static void dropDownSelect(IWebDriver driver, String controlType, String ControlID, String value)//Coremethod for Dropdown select
		{
			try
			{
				if (controlType.Equals("Id"))// Finding element from ID
					new SelectElement(driver.FindElement(By.Id(ControlID))).SelectByValue(value);
				if (controlType.Equals("xpath"))// Finding element from Xpath
					new SelectElement(driver.FindElement(By.XPath(ControlID))).SelectByValue(value);

			}
			catch
			{
				System.Console.WriteLine("Element is not visible and test failed");//Throw exception if elemnt is not visible
				screenshotCapture(driver);
			}
		}
		
		public static void checkBoxSelect(IWebDriver driver, String controlType, String ControlID)//Coremethod for checkbox select
		{
			try
			{
				if (controlType.Equals("Id"))// Finding element from ID
					driver.FindElement(By.Id(ControlID)).Click();
				if (controlType.Equals("xpath"))// Finding element from Xpath
					driver.FindElement(By.XPath(ControlID)).Click();
			}
			catch
			{
				System.Console.WriteLine("Element is not visible and test failed");//Throw exception if elemnt is not visible
				screenshotCapture(driver);
			}

		}


		//textbox enter
		public static void textboxenter(IWebDriver driver, String ControlType, String ControlID, String Value)//Coremethod for textbox entry
		{
			try
			{
				if (ControlType.Equals("Id"))// Finding element from ID
					driver.FindElement(By.Id(ControlID)).SendKeys(Value);
				if (ControlType.Equals("Name"))// Finding element from Xpath
					driver.FindElement(By.Name(ControlID)).SendKeys(Value);
				if (ControlType.Equals("Xpath"))// Finding element from Xpath
					driver.FindElement(By.XPath(ControlID)).SendKeys(Value);

			}
			catch
			{
				System.Console.WriteLine("Element is not visible and test failed");//Throw exception if elemnt is not visible
				screenshotCapture(driver);
			}
		}

		//buttonclick
		public static void buttonclick(IWebDriver driver, String ControlType, String ControlID)//Coremethod for button click
		{
			try
			{
				if (ControlType.Equals("Id"))// Finding element from ID
					driver.FindElement(By.Id(ControlID)).Click();
				if (ControlType.Equals("CssSelector"))// Finding element from CSS selector
					driver.FindElement(By.CssSelector(ControlID)).Click();
				if (ControlType.Equals("Xpath"))// Finding element from Xpath
					driver.FindElement(By.XPath(ControlID)).Click();
				if (ControlType.Equals("PartialLinkText"))// Finding element from Partial link text
					driver.FindElement(By.PartialLinkText(ControlID)).Click();
				if (ControlType.Equals("TagName"))// Finding element from Tag name
					driver.FindElement(By.TagName(ControlID)).Click();
			}
			catch
			{
				System.Console.WriteLine("Element is not visible and test failed");//Throw exception if elemnt is not visible
				screenshotCapture(driver);

			}

		}
		public static string gettext(IWebDriver driver, String ControlType, String ControlID)//Gettext method to read the text from the field
		{
			string readText;//defining  a variable to get the value of read text
			if (ControlType.Equals("Id"))//Finding elemnt by id
			{
				readText = driver.FindElement(By.Id(ControlID)).Text;
				return readText;
			}
			if (ControlType.Equals("CssSelector"))//Finding elemnt by CSS selector
			{
				readText = driver.FindElement(By.CssSelector(ControlID)).Text;
				return readText;
			}
			if (ControlType.Equals("Xpath"))//finding elemnt by Xpath
			{
				readText = driver.FindElement(By.XPath(ControlID)).Text;
				return readText;
			}
			else
				return ("Novalue");//if not able to find return no value
		}
		public static Boolean verifyText(IWebDriver driver, string check_controlelementtype, string check_control, string compareString)//Verifying text for comparision.

		{
			string text;//defining  a variable to get the value of read text
			text = coreMethod.gettext(driver, check_controlelementtype, check_control);//Calling get text method to read text from given place.
			if (text.Equals(compareString))//comparing read text with expected
				return true;
			else
				return false;
		}
		public static Boolean verifyTitle(IWebDriver driver, string compareString)//Verifying tite

		{
			string text;
			text = driver.Title;
			if (text.Equals(compareString))
				return true;
			else
				return false;
		}

		public static void screenshotCapture(IWebDriver driver)

		{
			Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
			DateTime thisDay = DateTime.Today;
			int i = 0;
			string filename = "error_" + thisDay.ToString("D") + "_"+i;
			Thread.Sleep(2000);
			i++;
			ss.SaveAsFile(@"C:\Screenshot\"+ filename+".png", ScreenshotImageFormat.Png);
		}
	}
}
