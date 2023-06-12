using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Employee
    {
        //private static int _no;
        //private readonly int _No;
        private int _No;
        private string _fullName;
        private string _position;
        private decimal _salary;
        private string _departmentName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("FullName bos qala bilmez");
                else
                {
                    _fullName = value;
                }

            }

        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 250)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    Salary = value;
                }
            }
        }
        public string DepartmentName
        {
            get { return _departmentName; }
            set
            {
                if (string.IsNullOrEmpty(_departmentName))
                    Console.WriteLine("DepartmentName bos qala bilmez");
                else
                {
                    _departmentName = value;
                }
            }
        }
        public string Position
        {
            get { return _position; }
            set
            {
                if (value.Length < 2)
                    Console.WriteLine("minimum 2 herfden ibaret olmalidir");
                else
                {
                    _position = value;
                }
            }
        }
        public int No
        {
            get { return _No; }
            set
            {

            }
        }
        
    } 
   
}
