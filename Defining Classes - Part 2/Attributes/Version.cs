using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct |
                       System.AttributeTargets.Interface |
                       System.AttributeTargets.Method |
                       System.AttributeTargets.Enum,
                       AllowMultiple = false)
    ]
    class Version : System.Attribute
    {
        public Version()
        {
            this.Major = 1;
            this.Minor = 0;
        }

        public Version(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; set; }
        public int Minor { get; set; }
    }
}
