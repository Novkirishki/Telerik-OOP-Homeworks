using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School_classes
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;
        public Teacher(string name) : this(name, new List<Discipline>())
        {
            
        }

        public Teacher(string name, List<Discipline> disciplines) : base(name)
        {
            this.Disciplines = disciplines;
        }
    
        public List<Discipline> Disciplines
        {
            get
            { 
                return this.disciplines;
            }
            private set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
