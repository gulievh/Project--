using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class HumanResourceManager : IHumanResourceManager
    {
        private readonly Department[] _departments;
        private int _departmentCount;

        public HumanResourceManager()
        {
            _departments = new Department[0];
        }
        public Department[] Departments
        {
            get
            {
                return _departments;
            }
        }

        public void AddDepartment(Department department)
        {
            if (_departmentCount < _departments.Length)
            {
                _departments[_departmentCount] = department;
                _departmentCount++;
            }
            else
            {
                Console.WriteLine("qebul olunmadi") ;
            }
        }

        public void AddEmployee(string DepartmentName, Employee employee)
        {
            throw new NotImplementedException();
        }

        public void EditDepartaments(string DepartmentName, string NewDepartmentName)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(string DepartmentName, int EmployeeNumber, string FullName, decimal salary, string position, Department department)
        {
            for (int i = 0; i < _departmentCount; i++)
            {
                /////////////////////////////////////////////////////////
            }
        }

        public void GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(string DepartmentName, int EmployeeNumber)
        {
            throw new NotImplementedException();
        }
    }
}
