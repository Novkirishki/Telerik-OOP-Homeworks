using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School_classes
{
    public class Class
    {
        private char id;
        private List<Teacher> teachers;
    
        public Class(char id) : this(id, new List<Teacher>())
        {

        }

        public Class(char id, List<Teacher> teachers)
        {
            this.Id = id;
            this.Teachers = teachers;
        }

        public char Id
        {
            get { return id; }
            private set { id = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            private set { teachers = value; }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }
    }
}
