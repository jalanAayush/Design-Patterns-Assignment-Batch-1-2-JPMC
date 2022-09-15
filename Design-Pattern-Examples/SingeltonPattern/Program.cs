namespace SingeltonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = Employee.GetEmployee();
            Employee employee2 = Employee.GetEmployee();
            Employee employee3 = Employee.GetEmployee();
            Employee employee4 = Employee.GetEmployee();

            //check if the instances created are same instance
            if( (employee1 == employee2)  && (employee2 == employee3) && (employee3 == employee4) )
            {
             Console.WriteLine("Same Instance - Singelton Works");      
            }

            Employee employees = Employee.GetEmployee();

            for(int i=0;i<20;i++)
            {
                string currentEmployee = employees.EmployeeNames;
                Console.WriteLine("Employee " + currentEmployee + " scored a perfect Score!!!!");
                Console.WriteLine();
            }
        }
    }
}