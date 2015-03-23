using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School_classes
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
    
        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            Name = name;
            NumberOfExercises = numberOfExercises;
            NumberOfLectures = numberOfLectures;
        }

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            {
                name = value; 
            }
        }

        public int NumberOfLectures
        {
            get 
            { 
                return numberOfLectures; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number must be nonegative");
                }
                numberOfLectures = value; 
            }
        }

        public int NumberOfExercises
        {
            get 
            { 
                return numberOfExercises; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number must be nonegative");
                }
                numberOfExercises = value; 
            }
        }
    }
}
