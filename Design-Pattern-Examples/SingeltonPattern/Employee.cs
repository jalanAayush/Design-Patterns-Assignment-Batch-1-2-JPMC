using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    internal class Employee
    {
        private static Employee _employeeInstance;
        private Random _random = new Random();
        private List<String> _employeesNames = new List<string>();
        private static object _syncLock = new object();

        protected Employee()
        {
            _employeesNames.Add("Manank");
            _employeesNames.Add("Kartik");
            _employeesNames.Add("Ashish");
            _employeesNames.Add("Aryan");
        }

        public static Employee GetEmployee()
        {
            if( _employeeInstance == null)
            {
                lock ( _syncLock )
                {
                    if( _employeeInstance == null)
                    {
                        _employeeInstance = new Employee();
                    }
                }
            }
            return _employeeInstance;
        }

        public string EmployeeNames
        {
            get
            {
                int randomIndex = _random.Next(_employeesNames.Count);
                string randomName = _employeesNames[randomIndex];
                return randomName;
            }
        }
    }
}
