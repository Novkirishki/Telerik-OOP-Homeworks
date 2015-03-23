using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Students_and_workers
{
    class Test
    {
        static void Main(string[] args)
        {
            //students
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Ivanov", 2),
                new Student("Petur", "Iliev", 4),
                new Student("Vanesa", "Petrova", 5.50),
                new Student("Kiro", "Tonchev", 3.25),
                new Student("Iliq", "Goshev", 4.70),
                new Student("Vasil", "Vasilev", 6),
                new Student("Gabriela", "Hristova", 6),
                new Student("Aleks", "Petrov", 2.40),
                new Student("Krasimir", "Stefanov", 5.20),
                new Student("Stanimir", "Angelov", 3.67)
            };

            var studentsByGrade = from st in students
                                  orderby st.Grade
                                  select st;
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();

            //workers
            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan", "Peshev", 220, 8),
                new Worker("Simeon", "Iliev", 500, 8),
                new Worker("Aleksandra", "Petrova", 130, 4),
                new Worker("Ivan", "Tihomirov", 1000, 6),
                new Worker("Tihomir", "Ivanov", 470, 12),
                new Worker("Boril", "Krustev", 700, 4),
                new Worker("Krasimira", "Stefanova", 600, 12),
                new Worker("Hristo", "Hristov", 240, 3),
                new Worker("Vasil", "Georgiev", 2500, 5),
                new Worker("Georgi", "Tankov", 7000, 14)
            };

            var workersByMoneyPerHour = from worker in workers
                                        orderby worker.MoneyPerHour() descending
                                        select worker;
            foreach (var worker in workersByMoneyPerHour)
            {
                Console.WriteLine(worker.ToString());
            }

            Console.WriteLine();

            //join list
            var joined = students.Cast<Human>()
                .Union(workers.Cast<Human>())
                .OrderBy(item => item.LastName)
                .OrderBy(item => item.FirstName);
            foreach (var human in joined)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
