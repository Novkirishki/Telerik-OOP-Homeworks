using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19.StudentGroups
{
    class Student
    {
        public Student(string FirstName, string LastName, int FN, string Tel, string Email, List<int> Marks, int GroupNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FN = FN;
            this.Tel = Tel;
            this.Email = Email;
            this.Marks = Marks;
            this.GroupNumber = GroupNumber;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{");
            builder.Append(this.FirstName);
            builder.Append(", " + this.LastName);
            builder.Append(", " + this.FN);
            builder.Append(", " + this.Tel);
            builder.Append(", " + this.Email);
            builder.Append(", (");
            string marks = String.Join(",", Marks);
            builder.Append(marks);
            builder.Append("), " + this.GroupNumber);
            builder.Append("}");

            return builder.ToString();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

    }
}
