using GenericClass.Classes;
using GenericClass.Entites;
using System;

namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emplIslemleri = new EmployeeIslemleri();

            Employee emp = new Employee
            {

            };
            emplIslemleri.Add(emp);

            ////////////////////////////////////////
            var userIslemleri = new UserIslemleri();

            User user = new User
            {

            };
            userIslemleri.Add(user);           
        }
    }
}
