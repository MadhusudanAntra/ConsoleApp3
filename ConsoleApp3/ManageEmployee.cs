using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entities;
namespace ConsoleApp3
{
     class ManageEmployee
    {
        public void Demo()
        { 
          List<string> employees = new List<string>();
            employees.Add("Peter");
            employees.Add("Nick");
            employees.Add("sarah");
            employees.Add("Jane");
            employees.Add("Pam");
            int length = employees.Count();
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(employees[i]);
            //}

            employees.Remove("Jane");
            employees.RemoveAt(1);
            employees.Insert(2, "William");
            

            foreach (string item in employees)
            { 
                Console.WriteLine(item);
            }
                
        }

        List<Employee> empCollection;
        public ManageEmployee()
        {
            //empCollection = new List<Employee>();
            empCollection = new(); //known type object
        }
        public void AddEmployee()
        {
            Employee e = new Employee();
            e.Id = 1;
            e.Name = "Smith";
            e.Salary = 5600;
            e.DeptId = 1;
            e.Age = 35;

            Employee e1 = new Employee() {
                Id = 2,
                Name ="William",
                Salary=4500,
                DeptId=1,
                Age=28
            };

            empCollection.Add(e);
            empCollection.Add(e1);
            empCollection.Add(new Employee() { Id=3, Name="Sarah", Salary=4900,DeptId=2,Age=27 });
            empCollection.Add(new Employee() { Id = 4, Name = "Kate", Salary = 5200, DeptId = 2, Age = 29 });

            
        }

        public void PrintEmployees()
        {
            foreach (var item in empCollection)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Age} \t {item.Salary} \t{item.DeptId}");
            }
        }
    }
}
