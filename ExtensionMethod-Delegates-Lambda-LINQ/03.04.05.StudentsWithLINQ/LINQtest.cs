//Problem 3. First before last
//Write a method that from a given array of students finds all students whose first
//name is before its last name alphabetically.
//Use LINQ query operators.

//Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//Problem 5. Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the
//students by first name and last name in descending order.
//Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04._05.StudentsWithLINQ
{
    class LINQtest
    {
        static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //array of students 
            var students = new[] 
            {
                new {
                        firstName = "Ivan", lastName = "Boikov", age = 19
                    },
                new {
                        firstName = "Aleksandur", lastName = "Petrov", age = 23
                    },
                new {
                        firstName = "Bobi", lastName = "Mihailov", age = 54
                    },
                new {
                        firstName = "Zahari", lastName = "Iordanov", age = 34
                    },
                new {
                        firstName = "Bobi", lastName = "Stoikov", age = 32
                    }
            };

            //problem 3
            Console.WriteLine("Problem 3");
            var firstNameBeforeLast = from student in students
                                      where (student.firstName.CompareTo(student.lastName) < 0)
                                      select student;

            Print(firstNameBeforeLast);

            //problem 4
            Console.WriteLine("Problem 4");
            var agedBethween = from student in students
                                    where (student.age >= 18 && student.age <= 24)
                                    select new {student.firstName, student.lastName};

            Print(agedBethween);

            //problem 5
            Console.WriteLine("Problem 3");
            Console.WriteLine("Sorted wtih Lambda:");
            var descendingOrder = students.OrderBy(student => student.firstName).ThenBy(student => student.lastName);
            Print(descendingOrder);

            Console.WriteLine("Sorted with LINQ");
            var descendingOrder2 = from student in students
                                   orderby student.lastName
                                   orderby student.firstName                                   
                                   select student;
            Print(descendingOrder2);
        }
    }
}
