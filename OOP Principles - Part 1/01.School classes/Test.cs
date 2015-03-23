//Problem 1. School classes

//We are given a school. In the school there are classes of students. 
//Each class has a set of teachers. Each teacher teaches a set of disciplines. 
//Students have name and unique class number. Classes have unique text identifier. 
//Teachers have name. Disciplines have name, number of lectures and number of exercises.
//Both teachers and students are people. Students, classes, teachers and disciplines
//could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
//encapsulate their fields, define the class hierarchy and create
//a class diagram with Visual Studio.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_classes
{
    class Test
    {
        static void Main(string[] args)
        {
            //create a class
            Class classA = new Class('A');
            //create 2 teachers
            Teacher teacher1 = new Teacher("Ivan");
            Teacher teacher2 = new Teacher("Mariika", new List<Discipline> { new Discipline("Mathematics", 30, 60)});
            //add teacher 1 some disciplines
            Discipline sport = new Discipline("Sport", 0, 30);
            Discipline bg = new Discipline("Bulgarian", 50, 30);
            teacher1.Disciplines.Add(sport);
            teacher1.Disciplines.Add(bg);
            //add teachers to class A
            classA.Teachers.Add(teacher1);
            classA.Teachers.Add(teacher2);
            //create some students
            Student gosho = new Student("Gosho", 'A');

            //print the info
            Console.WriteLine("Name: {0} from {1} class", gosho.Name, gosho.ClassID);
            Console.WriteLine("Class teachers:");
            foreach (var teacher in classA.Teachers)
            {
                Console.WriteLine(teacher.Name);
                Console.Write("Disciplines: \n");
                foreach (var discipline in teacher.Disciplines)
                {
                    Console.WriteLine("{0} lectures - {1}, exercises - {2}", 
                        discipline.Name, discipline.NumberOfLectures, discipline.NumberOfLectures);
                }
            }

        }
    }
}
