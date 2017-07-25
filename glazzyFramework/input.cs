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
		public static string usernamerandom = "Jack" + randomInt;//Adding random int to get new email everytime
		public static string userName_Value = "email@gmail.com";//Entering already registered username
		public static string password_Value = "Pass123";//Entering already registered Password
		public static string invalid_UserName_Value = "wrong@gmail.com";//Entering wrong username
		public static string invalid_Password_Value = "Pass123";//Entering wrong Password

		public static string signUpUserName_Value = usernamerandom + "@gmail.com";//Entering new username using random int
		public static string signUpPassword_Value = "Test@123";//Entering password for new sign up
		public static string invalidSignUpUserName_Value = usernamerandom;// Entering invalid email


<<<<<<< HEAD
=======

>>>>>>> 2629e544a8cf2093191723f1de0d7a1ee5709ae5
		        //Update your profile Values
        public static string username = "Tester@gmail.com";
	//Enter Firstname
        public static string firstname = "John";
	//Enter LastName
        public static string lastname = "Doe";
	//Select DOB
        public static string dob = "06/26/1986";
	//Enter Address
        public static string address = "TesterDr";
	//Select State
        public static string state = "CA";
	//Select City
        public static string city = "San Diego";
	//Enter Zip
        public static string zip = "92117";
	//Enter Phone Number
        public static string phone = "2211234567";

        

	//Click Save Button
        public static string save = "buttonclick";

<<<<<<< HEAD
=======
	
>>>>>>> 2629e544a8cf2093191723f1de0d7a1ee5709ae5
	}
}
