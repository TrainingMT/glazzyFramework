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
		public static string userName_Value = "email@gmail.com";//Entering already registered username
		public static string password_Value = "Pass123";//Entering already registered Password
		public static string invalid_UserName_Value = "wrong@gmail.com";//Entering wrong username
		public static string invalid_Password_Value = "Pass123";//Entering wrong Password

		public static string signUpUserName_Value = username+"@gmail.com";//Entering new username using random int
		public static string signUpPassword_Value = "Test@123";//Entering password for new sign up
		public static string invalidSignUpUserName_Value = username;// Entering invalid email

	}
}
