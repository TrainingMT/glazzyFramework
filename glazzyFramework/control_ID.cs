using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace glazzyFramework
{
	class control_ID
	{

		public static string userName_ControlID = "UserName";//Control ID for Username
		public static string password_ControlID = "Password";//Control ID for Password
		public static string confirmPassword_ControlID = "ConfirmPassword";//Control ID for ConfrimPassword
		public static string submitButton_ControlXpath = "html/body/div/div/div/form/div[2]/div[2]/input";//Control Xpath for Submit button

        public static string menu_ControlTag = "path";//Control Tag for menu button
		public static string loginMenuButton_ControlXpath = "html/body/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div/div/div[1]/div/div[2]/div/a";//Control Xpath for login menu tag
		public static string loginimage_ControlXpath = "html/body/div/div/div/a[1]/img";//Control Xpath for Login Image

        public static string accountInfo_ControlXpath = "html/body/nav/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]/div/div/div[1]/div/ul/li[6]/a";//Control Xpath for account info
		public static string logout_ControlXpath = "html/body/nav/div[2]/div[1]/div/div/div[1]/div/ul/li[5]/a";//Control Xpath for logout menu
		public static string InvalidLoginText_ControlXpath = "html/body/div/div/div/form/div[1]/div[2]/ul/li";//Control Xpath for invalid text to read

        public static string signUPImage_ControlXpath = "html/body/div/div/div/a[2]/img";//Control Xpath for signup image
		public static string signUpUsername_ControlID = "UserName";//Control Xpath for signup USername
		public static string signUpPassword_ControlID = "Password";//Control Xpath for signup Password
		public static string signUpConfirmPassword_ControlID = "ConfirmPassword";//Control Xpath for signup confrim Password
		public static string signUpButton_ControlXpath = "html/body/div/div/div/form/div[2]/div[2]/input";//Control Xpath for signup Password
		public static string donthaveAccountLink_ControlPartialLinkText = "Don't have an account?";//Control Partial link text for I dont have account 
		public static string invalidSignUpText_ControlXpath = "html/body/div/div/div/form/div[1]/div[1]/ul/li[1]"; //Control Xpath for Inlavid Sign up text



        //Update your Profile Control ID
          public static string uname = "UserName";
          public static string firstname = "FirstName";
          public static string lastname = "LastName";
          public static string dob = "datetimepicker1";
          public static string address = "Address";
          public static string state = "StateId";
          public static string city_profile= "CityId";
          public static string zip = "Pincode";
          public static string phone = "PhoneNumber";

        //book the service 
        //select the existing location
        public static string existing_location = "/html/body/div[2]/div[4]/div[1]/div/div[2]/ul/li[1]/a/div";
        //select the exsiting vechile
        public static string existing_vehicle = "/html/body/div[2]/div[4]/div[2]/div/div[2]/ul/li[2]/a/div";
        //select your location if you do't want to use exsiting one
       
        public static string addlocation = "/html/body/div[2]/div[4]/div[1]/div/div[2]/ul/li/a/div";//click on add location
        public static string city = "/html/body/div[2]/div[1]/form/div[1]/div/div[1]/div/select";//click on choose city
        public static string select_city = "/html/body/div[2]/div[1]/form/div[1]/div/div[1]/div/select/option[2]";//select city
        public static string garage= "/html/body/div[2]/div[1]/form/div[1]/div/div[2]/div/select";//click on garage
        public static string select_garage= "/html/body/div[2]/div[1]/form/div[1]/div/div[2]/div/select/option[2]'";//select garage
        public static string save_location = "/html/body/div[2]/div[1]/form/div[2]/div/input";//click on save button
        
        //select your vechile if you dont want to use existing one
        public static string addvehicle = "/html/body/div[2]/div[4]/div[2]/div/div[2]/ul/li/a";//click on add
        public static string display_name = "/html/body/div[2]/div[2]/form/div[1]/div[1]/div/input";//enter display name
        public static string purchase_year = "/html/body/div[2]/div[2]/form/div[1]/div[2]/div[1]/input";//enter purchase year
        public static string make = "Make";//enter make
        public static string license_number = "LicenseNumber";//enter license number
        public static string color = "Color";//enter color
        public static string save_car = "insertNewUserVehicle";//click on save button

        //select serivces
        public static string select_services = "selectServicesBtn";//click on select service
        public static string typeofservices = "/html/body/div[2]/div[3]/ul/li[1]/div[1]";//click on type of service you want
        public static string addservice_button = "/html/body/div[2]/div[3]/ul/li[1]/div[2]/div[2]/a";//add the service
        public static string close_button = "/html/body/div[2]/div[8]/div/div/div[2]/button";//close the service window

        //schedule your service
        public static string wash_frequency = "WashFrequencyID";//click on was frequency
        public static string select_wash_frequency = "/html/body/div[2]/div[4]/div[4]/div/div[2]/form/div[1]/div/select/option[2]";//select wash frequency
        public static string popup = "/html/body/div[2]/div[5]/div/div/div[3]/button";//close small pop window
        public static string select_date = "/html/body/div[2]/div[4]/div[4]/div/div[2]/form/div[3]/div/input";//click on select date 
        public static string date = "/html/body/div[4]/div[1]/table/tbody/tr[5]/td[4]";//select the date for service
        public static string time_slot_option = "/html/body/div[2]/div[4]/div[4]/div/div[2]/form/div[4]/div/ul/li[1]/a/div[1]";//click on time slot option
        public static string time = "/html/body/div[2]/div[4]/div[4]/div/div[2]/form/div[4]/div/ul/li[1]/a/div[2]/div/label[1]/input";//choose morning option
        public static string summary_button = "viewSummary";//click on summary button
        public static string proceed_to_pay_button = "changeDetailsLink";//click on proceed to pay button

        //pay with paypal
        public static string pay_using_paypal = "/html/body/div[3]/div[2]/form/div/div[3]/div[2]/input[7]";//click on pay using paypal









    }
}
