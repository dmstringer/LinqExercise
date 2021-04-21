using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /* Complete every task using Method OR Query syntax.
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!*/

            //Print the Sum and Average of numbers
            var sum = numbers.Sum();
            var avg = numbers.Average();
            Console.WriteLine($"The Sum of numbers is: {sum}. The Average of numbers is: {avg}.");
            Console.WriteLine("----------------------------------");

            //Order numbers in ascending order and decsending order. Print each to console.
            var ascend = numbers.OrderBy(x => x);
            var descend = numbers.OrderByDescending(x => x);

            foreach (int num in ascend)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            foreach (int num in descend)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            //Print to the console only the numbers greater than 6
            var greater = numbers.Where(num => num > 6);
            foreach (int num in greater)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var ascend2 = numbers.OrderBy(x => x).Take(4);
            foreach (int num in ascend2)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 49;
            var descend2 = numbers.OrderByDescending(x => x);
            foreach (int num in descend2)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            var newEmployList = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName);
            foreach (var emp in newEmployList)
            {
                Console.Write(emp.FullName + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");


            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var nextEmployList = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x => x.FirstName);
            foreach (var emp in nextEmployList)
            {
                Console.Write(emp.FullName + " " + emp.Age + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var anotherEmployList = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10);
            var sum2 = anotherEmployList.Sum(item => item.YearsOfExperience);
            var avg2 = anotherEmployList.Average(item => item.YearsOfExperience);
            Console.WriteLine($"The Sum of YOE is: {sum2}. The Average of YOE is: {avg2}.");
            Console.WriteLine("----------------------------------");

            //Add an employee to the end of the list without using employees.Add()
            var newList = employees.Append(new Employee("Scott", "Stringer", 49, 0)).ToList();
            foreach (var emp in newList)
            {
                Console.Write(emp.FullName + " " + emp.Age + ", ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
