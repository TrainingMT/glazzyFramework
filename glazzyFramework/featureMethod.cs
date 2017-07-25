using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace glazzyFramework
{
	class featureMethod
	{
		public static void normalLogin(IWebDriver driver)//This is Valid login method for sucessfully logging into application and verifying the title.
		{
			coreMethod.buttonclick(driver, "TagName", control_ID.menu_ControlTag);//Calling coremethod buttonclick method for menu.
			coreMethod.buttonclick(driver, "Xpath", control_ID.loginMenuButton_ControlXpath);//Calling coremethod buttonclick method for login menu button.
			coreMethod.buttonclick(driver, "Xpath", control_ID.loginimage_ControlXpath);//Calling coremethod buttonclick method for login image.
			coreMethod.textboxenter(driver, "Id", control_ID.userName_ControlID, input.userName_Value);//Calling coremethod enterText method for entering Username.
			coreMethod.textboxenter(driver, "Id", control_ID.password_ControlID, input.password_Value);//Calling coremethod enterText method for entering password.
			coreMethod.buttonclick(driver, "Xpath", control_ID.submitButton_ControlXpath);//Calling coremethod buttonclick method to click submit button.
			if (coreMethod.verifyTitle(driver, "CarUsersDev - My ASP.NET Application")) // verifying the title
				System.Console.WriteLine("Login is successfull, login test is pass"); // Print the result in console
			else
				System.Console.WriteLine("Login is not successfull,Login test is fail"); // Print the result in console
		}
		public static void invalidLogin(IWebDriver driver)//This is Invalid login method to check message is displayed for invalid login
		{
			coreMethod.textboxenter(driver, "Id", control_ID.userName_ControlID, input.invalid_UserName_Value);//Calling coremethod enterText method for entering invalid Username.
			coreMethod.textboxenter(driver, "Id", control_ID.password_ControlID, input.invalid_Password_Value);//Calling coremethod enterText method for entering invalid Password.
			coreMethod.buttonclick(driver, "Xpath", control_ID.submitButton_ControlXpath);//Calling coremethod buttonclick method to click submit button.
																						  
			if (coreMethod.verifyText(driver, "Xpath", control_ID.InvalidLoginText_ControlXpath, "Inavlid login successfull").Equals(true))//Verify the message
				System.Console.WriteLine("Inavlid login successfull");//Print the result in console
			else
				System.Console.WriteLine("Inavlid login fail");//Print the result in console
		}
		public static void logout(IWebDriver driver)//This is Successfull logout method
		{
			coreMethod.buttonclick(driver, "TagName", control_ID.menu_ControlTag);//Calling coremethod buttonclick method to click menu button.
			coreMethod.buttonclick(driver, "Xpath", control_ID.accountInfo_ControlXpath);//Calling coremethod buttonclick method to click account info menu list.
			coreMethod.buttonclick(driver, "Xpath", control_ID.logout_ControlXpath);//Calling coremethod buttonclick method to click logout button.

		}
		public static void signup(IWebDriver driver)// This method is for valid sign up 
		{
			coreMethod.buttonclick(driver, "PartialLinkText", control_ID.donthaveAccountLink_ControlPartialLinkText);//Calling coremethod buttonclick method to click I dont have account link.
			coreMethod.textboxenter(driver, "Id", control_ID.signUpUsername_ControlID, input.signUpUserName_Value);//Calling coremethod enterText method for entering valid Username
			coreMethod.textboxenter(driver, "Id", control_ID.signUpPassword_ControlID, input.signUpPassword_Value);//Calling coremethod enterText method for entering valid Password
			coreMethod.textboxenter(driver, "Id", control_ID.signUpConfirmPassword_ControlID, input.signUpPassword_Value);//Calling coremethod enterText method for entering again Password
			coreMethod.buttonclick(driver, "Xpath", control_ID.submitButton_ControlXpath);//Calling coremethod buttonclick method to click submit button.
		}

		public static void invalidsignup(IWebDriver driver)
		{
			coreMethod.buttonclick(driver, "PartialLinkText", control_ID.donthaveAccountLink_ControlPartialLinkText);//Calling coremethod buttonclick method to click I dont have account link.
			coreMethod.textboxenter(driver, "Id", control_ID.signUpUsername_ControlID, input.invalidSignUpUserName_Value);//Calling coremethod enterText method for entering invalid Username
			coreMethod.textboxenter(driver, "Id", control_ID.signUpPassword_ControlID, input.signUpPassword_Value);//Calling coremethod enterText method for entering invalid Password
			coreMethod.textboxenter(driver, "Id", control_ID.signUpConfirmPassword_ControlID, input.signUpUserName_Value);//Calling coremethod enterText method for entering again Password
			coreMethod.buttonclick(driver, "Xpath", control_ID.submitButton_ControlXpath);//Calling coremethod buttonclick method to click submit button.
			if (coreMethod.verifyText(driver, "Xpath", control_ID.invalidSignUpText_ControlXpath, "The Email field is not a valid e-mail address.").Equals(true))//Verify the text message for invalid credentials
				System.Console.WriteLine("Inavlid signup successfull");//Print the result in console
			else
				System.Console.WriteLine("Inavlid signup fail");//Print the result in console
		}
		

	}
}
