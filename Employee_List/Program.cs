using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee firEmp = new Employee();
            firEmp.Id = 100;
            firEmp.Name = "AA";
            firEmp.Salary = 10000.30;

            Employee secEmp = new Employee()
            {
                Id = 200,
                Name = "BB",
                Salary = 20000.30
            };

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 300, Name = "CC", Salary = 30000.21 });
            employees.Add(firEmp);
            employees.Add(secEmp);
            employees.Add(new Employee { Id = 400, Name = "DD", Salary = 40000.21 });


            Console.WriteLine("Total Employee Count : " + employees.Count);


            Employee singleResult = employees[0];

            Console.WriteLine($"Id : {singleResult.Id}\nName : {singleResult.Name}\nSalary : {singleResult.Salary}");

            Console.WriteLine();

            employees.Where(e=>e.Salary>=20000);

            foreach (var result in employees)
            {
                if (result.Salary >= 20000)
                {
                    Console.WriteLine($"Id : {result.Id}\nName : {result.Name}\nSalary : {result.Salary}");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int Id;
        public string Name;
        public Double Salary;
    }
}
