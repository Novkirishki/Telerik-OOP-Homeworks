using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19.StudentGroups
{
    class Group
    {
        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
    }
}
