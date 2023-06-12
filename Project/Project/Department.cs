using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Department
    {
        private static int _no;
        private readonly int _No;
        private string _name;
        private decimal _workerLimit;
        private decimal _salarylimit;
        private Employee[] _employees;
        private int _employeeCount;

        public decimal Workerlimit
        {
            get { return _workerLimit; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("isci sayi minimum 1 den chox olmalidir");
                }
                else
                {
                    _workerLimit = value;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (Name.Length > 2)
                    Console.WriteLine("Minimum 2 herfden ibaret olmalidir");
                else
                {
                    _name = value;
                }
            }
        }
        public decimal Salarylimit
        {
            get { return _salarylimit; }
            set
            {
                if (Salarylimit > 250)
                {
                    Console.WriteLine("minimum 250 olmalidir");
                }
                else
                {
                    _salarylimit = value;
                }
            }
        }
        public void AddEmployee(Employee employee)
        {
            if (_employeeCount > _employees.Length)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
            }
            _employees[_employeeCount] = employee;
            _employeeCount++;
        }

        public decimal CalcSalaryAverage()
        {
            if (_employeeCount == 0)
            {
                return 0;
            }
            decimal totalSalary = 0;
            for (int i = 0; i < _employeeCount; i++)
            {
                totalSalary += _employees[i].Salary;
            }
            decimal averageSalary = totalSalary / _employeeCount;
            return averageSalary;
        
        }
        static Department()
        {
            _no = 0;
        }
        public Department()
        {
            _no++;
            _No = _no;
        }
    }
}

