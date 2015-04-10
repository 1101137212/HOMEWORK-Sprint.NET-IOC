using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    class NewEmployeeDao :IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> Employeees = new List<Employee>();

            Employee Employee1 = new Employee();
            Employee1.Id = "tuttle";
            Employee1.Name = "陳玠任";
            Employee1.Age = 20;
            Employeees.Add(Employee1);

            Employee Employee2 = new Employee();
            Employee2.Id = "KUAS";
            Employee2.Name = "高雄應用科技大學";
            Employee2.Age = 20;
            Employeees.Add(Employee2);

            return Employeees;
        }

        public Employee GetEmployeeById(string id)
        {

            Employee Employee = null;

            if ("tuttle".Equals(id))
            {
                Employee = new Employee();
                Employee.Id = "tuttle";
                Employee.Name = "陳玠任";
                Employee.Age = 20;
            }

            return Employee;
        }
    }
}
