using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace glazzyFramework
{
	class Program
	{
		static void Main(string[] args)
		{
			
	IWebDriver driver = new ChromeDriver(@"C:\AutomationTesting\Driver");

            driver.Url = @"http://test-gp.classifiedsolutionsgroup.com/";
            featureMethod.ScheduleService(driver);

		}
	}
}
