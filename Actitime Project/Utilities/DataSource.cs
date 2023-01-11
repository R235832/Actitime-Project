using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Utilities
{
    public class DataSource
    {
        public static object[] ValidLoginData()
        {
            string[] dataset1 = new string[3];
            dataset1[0] = "admin";
            dataset1[1] = "manager";
            dataset1[2] = "https://demo.actitime.com/login.do";

            object[] dataset = new object[1];
            dataset[0]= dataset1;
            return dataset;
        }
        public static object[] InvalidLoginData()
        {
            string[] dataset1 = new string[3];
            dataset1[0] = "jolex";
            dataset1[1] = "sinex";
            dataset1[2] = "Username or Password is invalid. Please try again.";

            string[] dataset2 = new string[3];
            dataset2[0] = "admin";
            dataset2[1] = "pqres";
            dataset2[2] = "Username or Password is invalid. Please try again.";

            string[] dataset3 = new string[3];
            dataset3[0] = "virat";
            dataset3[1] = "manager";
            dataset3[2] = "Username or Password is invalid. Please try again.";

            string[] dataset4 = new string[3];
            dataset4[0] = "viruska";
            dataset4[1] = "rcb";
            dataset4[2] = "Username or Password is invalid. Please try again.";

            object[]alldataset= new object[4];
            alldataset[0]= dataset1;
            alldataset[1]= dataset2;
            alldataset[2]= dataset3;
            alldataset[3]= dataset4;
            return alldataset;
        }

        public static object[] createTypeofWorkData()
        {
            object[] dataset = Excelutils.GetSheetIntoObjectArray(@"C:\\Users\\rakeshro\\Desktop\\C# SESSION\\MavericAutomation\\Actitime Project\\TestData\\Actitime_data.xlsx", "createTypeofWorkTest");
            return dataset;
        }
        public static object[] ValidUserData()
        {
            object[] datset = Excelutils.GetSheetIntoObjectArray("C:\\Users\\rakeshro\\Desktop\\C# SESSION\\MavericAutomation\\Actitime Project\\TestData\\Actitime_data.xlsx", "ValidUserTest");
            return datset;
        }

    }
}
