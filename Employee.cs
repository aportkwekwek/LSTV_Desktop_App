using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSTV_Desktop_App
{
    public static class Employee
    {
        private static string xemployeeCode;
        private static string xemployeeFullname;
        private static string xemployeeBday;
        private static string xemployeeStatus;
        private static string xemployeeGender;
        private static string xemployeeSalary;


        //Employee Code
        public static string getEmployeeCode() {
            return xemployeeCode;
        }
        public static void setEmployeeCode(string value) {
            xemployeeCode = value;
        }

        // Employee Fullname
        public static string getEmployeeFullName()
        {
            return xemployeeFullname;
        }
        public static void setEmployeeFullName(string value)
        {
            xemployeeFullname = value;
        }

        //Emmployee Bday

        public static string getEmployeeBday()
        {
            
            return xemployeeBday;
        }
        public static void setEmployeeBday(string value)
        {
            xemployeeBday = value;
        }

        //Employee Status

        public static string getEmployeeStatus()
        {
            return xemployeeStatus;
        }
        public static void setEmployeeStatus(string value)
        {
            xemployeeStatus = value;
        }

        //Employee Gender

        public static string getEmployeeGender()
        {
            return xemployeeGender;
        }
        public static void setEmployeeGender(string value)
        {
            xemployeeGender = value;
        }

        //Employee Salary
        public static string getEmployeeSalary()
        {
            var formattedSalary = xemployeeSalary;
            formattedSalary = formattedSalary.Replace(",", "");

            return formattedSalary;
        }
        public static void setEmployeeSalary(string value)
        {
            xemployeeSalary = value;
        }

    }
}
