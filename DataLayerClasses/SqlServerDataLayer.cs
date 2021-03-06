﻿using DataLayerEntityClasses;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayerClasses
{
    public class SqlServerDataLayer : iEmployeeDataLayer
    {
        public SqlServerDataLayer(string connectionString)
        {
            ConnectionString = connectionString;
        }

        string ConnectionString { get; set; }

        public List<Employee> getEmployee()
        {
            List<Employee> eList = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT EmployeeID, FirstName, LastName, Title FROM Employees";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee e = new Employee();
                            e.EmployeeID = (int)reader[0];
                            e.FirstName = (string)reader[1];
                            e.LastName = (string)reader[2];
                            e.Title = (string)reader[3];
                            eList.Add(e);
                        }
                    }
                }
            }
            return eList;
        }

        public Employee getEmployee(int empID)
        {
            Employee e = new Employee();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT EmployeeID, FirstName, LastName, Title FROM EMPLOYEES WHERE EmployeeID = " + empID.ToString();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            e.EmployeeID = (int)reader[0];
                            e.FirstName = (string)reader[1];
                            e.LastName = (string)reader[2];
                            e.Title = (string)reader[3];
                        }
                    }
                }
            }
            return e;
        }
    }
}
