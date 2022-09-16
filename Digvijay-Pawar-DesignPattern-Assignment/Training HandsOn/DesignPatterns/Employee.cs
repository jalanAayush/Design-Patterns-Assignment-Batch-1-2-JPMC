using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Employees
    {
        private static Employees _instance;
        private List<string> _empolyees = new List<string>();
        private Random _random = new Random();  
        
        private static object synclock = new object();



       protected Employees()
        {
            _empolyees.Add("Employee1");
            _empolyees.Add("Employee2");
            _empolyees.Add("Employee3");
            
        }



       public static Employees GetEmployee()
        {
            if(_instance==null)
            {
                lock(synclock)
                {
                    if(_instance ==null)
                    {
                        _instance = new Employees();
                    }
                }               
            }
            return _instance;
        }
        public string Employee
        {
            get
            {
                int r = _random.Next(_empolyees.Count);
                return _empolyees[r].ToString();
            }
        }

    }
}
