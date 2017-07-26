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
																						  
			if (coreMethod.verifyText(driver, "Xpath", control_ID.InvalidLoginText_ControlXpath, "Invalid login attempt.").Equals(true))//Verify the message
				System.Console.WriteLine("Invalid login successfull");//Print the result in console
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
            {
                System.Console.WriteLine("Invalid signup successfull");//Print the result in console
            }
            else
            {
                System.Console.WriteLine("Invalid signup fail");//Print the result in console
            }
           
		}
		
        public static void book_service(IWebDriver driver)
        {
            
            //select existing location
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.existing_location);//calling coremethod button  to click on existing location
            //select exsiting vehicle
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.existing_vehicle);// calling coremethod button  to click on existing vechile


            //add location if you don't want to select exsiting one
            /* coreMethod.buttonclick(driver, "Xpath", control_ID.addlocation);
            coreMethod.buttonclick(driver, "Xpath", control_ID.city);
            coreMethod.buttonclick(driver, "Xpath", control_ID.select_city);
            coreMethod.buttonclick(driver, "Xpath", control_ID.garage);
            coreMethod.buttonclick(driver, "Xpath", control_ID.select_garage);
            coreMethod.buttonclick(driver, "Xpath", control_ID.save_location);

            //select the vechile if you don't want to select exsiting one
            coreMethod.buttonclick(driver, "Xpath", control_ID.addvehicle);
            Thread.Sleep(2000);
            coreMethod.textboxenter(driver, "Xpath", control_ID.display_name, input.displayname_value);
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/form/div[1]/div[1]/div/input")).SendKeys("gsdhsdg");
            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/form/div[1]/div[2]/div[1]/input")).SendKeys("11");
           coreMethod.textboxenter(driver, "Xpath", control_ID.purchase_year,input.purchaseyear_value);
            coreMethod.textboxenter(driver, "Name", control_ID.make, input.make_value);
            coreMethod.textboxenter(driver, "Name", control_ID.license_number, input.licensenumber_value);
            coreMethod.textboxenter(driver, "Name", control_ID.color, input.color_value);
            coreMethod.buttonclick(driver, "Id", control_ID.save_car);*/

            //select services
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Id", control_ID.select_services);//calling coremethod button  to click on select service button
            Thread.Sleep(2000);

            coreMethod.buttonclick(driver, "Xpath", control_ID.typeofservices);//calling coremethod button to click  on type of service
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.addservice_button);//calling coremethod button to click  on add service button
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.close_button);//calling coremethod button to click close small pop up window
            Thread.Sleep(2000);

            //schedule your service
            coreMethod.buttonclick(driver, "Id", control_ID.wash_frequency);//calling coremethod button to click on wash frequency
            Thread.Sleep(2000);
           coreMethod.buttonclick(driver, "Xpath", control_ID.select_wash_frequency);//calling coremethod button to select wash fequency
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.popup);////calling coremethod button to click close small pop up window
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.select_date);//calling coremethod button to click on date
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.date);//calling coremethod button to select date
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.time_slot_option);//calling coremethod button to select time slot frequency
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.time);////calling coremethod button to select time
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Id", control_ID.summary_button);////calling coremethod button to click on summary button
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Id", control_ID.proceed_to_pay_button);//calling coremethod button to click on proceed button
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Xpath", control_ID.pay_using_paypal);//calling coremethod button to click on pay
            Thread.Sleep(2000);
             driver.Close();

        }
		public static void iHaveAnAccountLogin(IWebDriver driver)
		{
			coreMethod.buttonclick(driver, "Xpath", control_ID.iHaveAnAccount_ControlXpath);
			coreMethod.textboxenter(driver, "Id", control_ID.userName_ControlID, input.userName_Value);//Calling coremethod enterText method for entering Username.
			coreMethod.textboxenter(driver, "Id", control_ID.password_ControlID, input.password_Value);//Calling coremethod enterText method for entering password.
			coreMethod.buttonclick(driver, "Xpath", control_ID.submitButton_ControlXpath);//Calling coremethod buttonclick method to click submit button.
		}

    }
}
