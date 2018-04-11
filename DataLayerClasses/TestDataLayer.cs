using DataLayerEntityClasses;
using System;
using System.Collections.Generic;

namespace DataLayerClasses
{
    public class TestDataLayer : iEmployeeDataLayer
    {
        public List<Employee> getEmployee()
        {
            List<Employee> eList = new List<Employee>();

            Employee e1 = new Employee();
            e1.EmployeeID = 1;
            e1.FirstName = "Joe";
            e1.LastName = "Johnson";
            e1.Title = "Supervisor";

            eList.Add(e1);

            return eList;
        }

        public Employee getEmployee(int empID)
        {
            Employee e = new Employee();
            e.EmployeeID = empID;
            switch (empID)
            {
                case 1:
                    e.FirstName = "Joe";
                    e.LastName = "Johnson";
                    e.Title = "Supervisor";
                    break;
                default:
                    throw new Exception("Employee not found");
            }

            return e;
        }
    }
}
