using DataLayerEntityClasses;
using System.Collections.Generic;

namespace DataLayerClasses
{
    public interface iEmployeeDataLayer
    {
        List<Employee> getEmployee();
        Employee getEmployee(int empID);
    }
}