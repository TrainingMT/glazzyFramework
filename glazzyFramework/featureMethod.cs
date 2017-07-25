using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glazzyFramework
{
	class featureMethod
	{
 public static void ScheduleService(IWebDriver driver)
        {
            coreMethod.buttonclick(driver, "Id", control_Id.Schedulenowbutton);
            coreMethod.buttonclick(driver, "Id", control_Id.newLocation_Click);
            coreMethod.checkBoxSelect(driver,"CssSelector", control_Id.garagesCityList);
            coreMethod.checkBoxSelect(driver, "CssSelector", control_Id.garagesList);
            coreMethod.buttonclick(driver, "Id", control_Id.saveLocation_Click);
		
	}
}
