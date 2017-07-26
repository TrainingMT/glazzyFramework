using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glazzyFramework
{
	class input
	{
		public static Random randomGenartor = new Random();//Initializing Random Generator
		public static int randomInt = randomGenartor.Next(100);//getting random int from random generator
		public static string username = "Jack" + randomInt;//Adding random int to get new email everytime
		public static string userName_Value = "glazy@gmail.com";//Entering already registered username
		public static string password_Value = "glazy123";//Entering already registered Password

        public static string invalid_UserName_Value = "wrong@gmail.com";//Entering wrong username
		public static string invalid_Password_Value = "Pass123";//Entering wrong Password

		public static string signUpUserName_Value = username+"@gmail.com";//Entering new username using random int
		public static string signUpPassword_Value = "Test@123";//Entering password for new sign up
		public static string invalidSignUpUserName_Value = username;// Entering invalid email

        //Update your profile Values
         public static string uname_value= "Tester@gmail.com";
          public static string firstname_value = "John";
          public static string lastname_value = "Doe";
          public static string dob_value = "06/26/1986";
          public static string address_value = "TesterDr";
          public static string state_value = "CA";
        public static string city_value = "San Diego";
          public static string zip_value= "92117";
          public static string phone_value = "2211234567";
          public static string save_value = "buttonclick";


        //book the service
        public static string displayname_value = "ford";//enter display name 
        public static string purchaseyear_value = "2000";//enter purchase year
        public static string make_value = "2010";//enter make
        public static string licensenumber_value = "11111";//enter license number
        public static string color_value = "Red";//enter color

       







    }
}
