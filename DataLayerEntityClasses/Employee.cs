namespace DataLayerEntityClasses
{
    public class Employee
    {
        public Employee()
        {
            EmployeeID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Title = string.Empty;
        }

        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return this.EmployeeID.ToString() + "/" + this.LastName + ", " + this.FirstName + "/" + this.Title;
        }
    }
}