using DataLayerClasses;
using DataLayerEntityClasses;
using System;

namespace DataLayerDemo_04_DataLayers_EntityClasses_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //iEmployeeDataLayer edl = new TestDataLayer();
            iEmployeeDataLayer edl = new SqlServerDataLayer("Data Source = (local); Initial Catalog = Northwind; Integrated Security = SSPI;");
            //iEmployeeDataLayer edl = new MySQLDataLayer("Server=localhost;Database=Northwind;Uid=root;Pwd=;");

            var e = edl.getEmployee(1);

            Console.WriteLine(e.ToString());

            Console.WriteLine("\n");

            foreach (Employee ee in edl.getEmployee())
            {
                Console.WriteLine(ee.ToString());
            }

            // keep console window open to see results
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
