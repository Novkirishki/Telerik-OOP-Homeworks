//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

//Problem 10. Student groups extensions
//Implement the previous using the same query expressed with extension methods.

//Problem 11. Extract students by email
//Extract all students that have email in abv.bg.
//Use string methods and LINQ.

//Problem 12. Extract students by phone
//Extract all students with phones in Sofia.
//Use LINQ.

//Problem 13. Extract students by marks
//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
//Use LINQ.

//Problem 14. Extract students with two marks
//Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

//Problem 15. Extract marks
//Extract all Marks of the students that enrolled in 2006. 
//(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

//Problem 18. Grouped by GroupNumber
//Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//Use LINQ.

//Problem 19. Grouped by GroupName extensions
//Rewrite the previous using extension methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19.StudentGroups
{
    class StudentGroups
    {
        static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //list with students
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Tihomirov", 615403, "02655967", @"ivan_tihomirov@abv.bg", new List<int>() { 3, 5, 3, 4 }, 1));
            students.Add(new Student("Angel", "Borisov", 614306, "092549708", @"angel.borisov@abv.bg", new List<int>() { 2, 3, 2, 5 }, 4));
            students.Add(new Student("Borislav", "Jelqzkov", 617803, "02655967", @"bobi@gmail.com", new List<int>() { 6, 5, 4, 6 }, 2));
            students.Add(new Student("Petur", "Krachunov", 615504, "02655967", @"krachunov@yahoo.com", new List<int>() { 3, 5, 6, 4 }, 3));
            students.Add(new Student("Nikolai", "Ivanov", 611206, "092655967", @"niki@yahoo.com", new List<int>() { 6, 6, 6, 6 }, 2));

            //problem 9
            Console.WriteLine("Students form group 2, ordered by first name with LINQ and with extension methods:");
            var studentsFromGroup2 = from student in students
                                     where (student.GroupNumber == 2)
                                     orderby student.FirstName
                                     select student;
            Print(studentsFromGroup2);

            //problem 10
            var studentsFromGroup2EM = students
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);
            Print(studentsFromGroup2EM);

            //problem 11
            Console.WriteLine("Students with email in abv.bg");
            var studentsWithABV = from st in students
                                  where (st.Email.Contains("abv.bg"))
                                  select st;
            Print(studentsWithABV);

            //problem 12
            Console.WriteLine("All students with phones in Sofia");
            var studentsWithPhoneInSofia = from st in students
                                           where (st.Tel.Substring(0, 2) == "02")
                                           select st;
            Print(studentsWithPhoneInSofia);

            //problem 13
            Console.WriteLine("Students with at least one 6");
            var studentsWith6 = from st in students
                                where (st.Marks.Contains(6))
                                select new
                                {
                                    FullName = st.FirstName + " " + st.LastName,
                                    Marks = st.Marks
                                };
            foreach (var item in studentsWith6)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("{");
                builder.Append(item.FullName);
                builder.Append(", (");
                string marks = String.Join(",", item.Marks);
                builder.Append(marks);
                builder.Append(")");
                builder.Append("}");

                Console.WriteLine(builder);
            }
            Console.WriteLine();

            //problem 14
            Console.WriteLine("Students with two 2");
            var studentsWith22 = students.Where(student => student.Marks.Count(x => x == 2) == 2);
            Print(studentsWith22);

            //problem 15
            Console.WriteLine("All marks of students from 2006");
            var studentsFrom2006 = from st in students
                                   where ((st.FN % 10 == 6) && ((st.FN / 10) % 10 == 0))
                                   select st.Marks;
            foreach (var item in studentsFrom2006)
            {
                Console.Write(String.Join(" ", item) + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //problem 16
            Console.WriteLine("Students from mathematics department: ");
            var groupsArray = new Group[]
            {
                new Group(1, "Mathematics"),
                new Group(2, "Mathematics"),
                new Group(3, "Physics"),
                new Group(4, "Biology")
            };

            var studentsFromMathematicsDepartment = from gr in groupsArray
                                                    where gr.DepartmentName == "Mathematics"
                                                    join st in students on gr.GroupNumber equals st.GroupNumber
                                                    select st;
            Print(studentsFromMathematicsDepartment);

            //problem 18
            Console.WriteLine("Students by groups (LINQ)");
            var groups = from st in students
                         group st by st.GroupNumber into stGroup
                         select stGroup;
            foreach (var group in groups)
            {
                Console.WriteLine("Group: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine();
            //problem 19
            Console.WriteLine("Students by groups (extension methods)");
            var groups2 = students.GroupBy(x => x.GroupNumber);

            // Example of iterating...
            foreach (var group in groups2)
            {
                Console.WriteLine("Group: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
