using System;
namespace ConsoleApp3
{
    class Program {
        public static void Main(string[] args) { 
       // Comparer<string> c = new Comparer<string>();
           // bool result = c.CheckEquality("antra","hogar");

            ManageEmployee manageEmployee = new ManageEmployee();
            //manageEmployee.Demo();
            manageEmployee.AddEmployee();
            manageEmployee.PrintEmployees();

        }
    }
}