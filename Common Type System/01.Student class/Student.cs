//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name,
//SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
//Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(),
//ToString(), GetHashCode() and operators == and !=.

//Problem 2. IClonable
//Add implementations of the ICloneable interface. The Clone() method should deeply copy 
//all object's fields into a new object of type Student.

//Problem 3. IComparable
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
//    and by social security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Student_class
{
    public class Student : IEquatable<Student>, ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private Speciality specialty;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress,
                    string mobilePhone, string email, int course, Speciality specialty, University university, Faculty faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.permanentAddress = permanentAddress;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
        }

        public Student(string firstName, string middleName, string lastName, int ssn, int course,
            Speciality specialty, University university, Faculty faculty) 
            : this(firstName, middleName, lastName, ssn, null, null, null, course, specialty, university, faculty)
        {

        }

        public Student (string firstName, string middleName, string lastName) 
            : this(firstName, middleName, lastName, 0, 0, 0, 0, 0)
        {

        }

        //Problem 3
        public int CompareTo(Student other)
        {
            List<Student> students = new List<Student>();
            students.Add(this);
            students.Add(other);

            var grouped = students.OrderBy(s => s.Ssn).OrderBy(s => s.LastName).OrderBy(s => s.MiddleName).OrderBy(s => s.FirstName);

            if (this.Equals(other) == true)
            {
                return 0;
            }
            else
            {
                if (grouped.First() == this)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        //Problem 2
        public object Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.PermanentAddress,
                                        this.MobilePhone, this.Email, this.Course,
                                        this.Specialty, this.University, this.Faculty);
            return result;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((firstName != null) ? this.firstName.GetHashCode() : 0);
                result = result * 23 + ((middleName != null) ? this.middleName.GetHashCode() : 0);
                result = result * 23 + ((lastName != null) ? this.lastName.GetHashCode() : 0);
                result = result * 23 + this.ssn.GetHashCode();
                result = result * 23 + ((permanentAddress != null) ? this.permanentAddress.GetHashCode() : 0);
                result = result * 23 + ((mobilePhone != null) ? this.mobilePhone.GetHashCode() : 0);
                result = result * 23 + ((email != null) ? this.email.GetHashCode() : 0);
                result = result * 23 + this.course.GetHashCode();
                result = result * 23 + this.specialty.GetHashCode();
                result = result * 23 + this.university.GetHashCode();
                result = result * 23 + this.faculty.GetHashCode();
                return result;
            }
        }

        public bool Equals(Student other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Equals(this.firstName, other.firstName) &&
                   Equals(this.middleName, other.middleName) &&
                   Equals(this.lastName, other.lastName) &&
                   this.ssn == other.ssn &&
                   Equals(this.permanentAddress, other.permanentAddress) &&
                   Equals(this.mobilePhone, other.mobilePhone) &&
                   Equals(this.email, other.email) &&
                   this.course == other.course &&
                   this.specialty.Equals(other.specialty) &&
                   this.university.Equals(other.university) &&
                   this.faculty.Equals(other.faculty);
        }

        public override bool Equals(object obj)
        {
            Student temp = obj as Student;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        public override string ToString()
        {
            return string.Format(@"firstName: {0}, middleName: {1}, lastName: {2}, ssn: {3}, permanentAddress:
            {4}, mobilePhone: {5}, email: {6}, course: {7}, specialty: {8}, university: {9}, faculty: {10}",
             firstName, middleName, lastName, ssn, permanentAddress, mobilePhone, email, course, specialty, university, faculty);
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int Ssn
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public Speciality Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }
    }
}
