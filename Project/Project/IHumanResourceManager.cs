using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal interface IHumanResourceManager
    {
        Department[] Departments { get; }

        void AddDepartment(Department department);

        void GetDepartments();

        void EditDepartaments(string DepartmentName , string NewDepartmentName);

        void AddEmployee(string DepartmentName, Employee employee);

        void RemoveEmployee(string DepartmentName , int EmployeeNumber);

        void EditEmployee(string DepartmentName , int EmployeeNumber , string FullName , decimal salary ,string position);
    }
}
