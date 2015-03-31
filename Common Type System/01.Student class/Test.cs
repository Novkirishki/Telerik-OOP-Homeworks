using System;
using System.Linq;

namespace _01.Student_class
{
    class Test
    {
        static void Main(string[] args)
        {
            //Problem 1 test
            Console.WriteLine("Problem 1 testing");

            Student student1 = new Student("Andrei", "Petrov", "Ivanov", 666, 2,
                                            Speciality.Maths, University.SofiaUniversity, Faculty.Mathematics);
            Student student2 = new Student("Andrei", "Petrov", "Ivanov", 666, 2,
                                            Speciality.Maths, University.SofiaUniversity, Faculty.Mathematics);

            Console.WriteLine("Are they equal - {0}", student1 == student2);

            //Problem 2 test
            Console.WriteLine("Problem 2 testing");

            Student student3 =(Student) student1.Clone();
            student3.Ssn = 665;

            Console.WriteLine("If they are not deeply cloned it will be 665: {0}", student1.Ssn);

            //Problem 3 test
            Console.WriteLine("Problem 3 testing");

            Student student4 = new Student("Borislav", "Petrov", "Ivanov", 666, 2,
                                            Speciality.Maths, University.SofiaUniversity, Faculty.Mathematics);

            Console.WriteLine(student1.CompareTo(student3));
            Console.WriteLine(student1.CompareTo(student4));
            Console.WriteLine(student1.CompareTo(student2));
        }
    }
}
