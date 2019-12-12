using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumType
{
    public class TestVO
    {
        //private int no;
        //private string name;
        //private int age;
        //private bool gender;

        //public int No { get; }
        //public string Name { get; set; }
        //public int Age { get; set; }
        //public bool Gender { get; set; }

        public int No { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        public TestVO()
        {
        }

        public TestVO(int no, string name, int age, bool gender)
        {
            No = no;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override bool Equals(object obj)
        {
            var vO = obj as TestVO;
            return vO != null &&
                   No == vO.No &&
                   Name == vO.Name &&
                   Age == vO.Age &&
                   Gender == vO.Gender;
        }

        public override int GetHashCode()
        {
            var hashCode = 1520802924;
            hashCode = hashCode * -1521134295 + No.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Gender.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{{{nameof(No)}={No}, {nameof(Name)}={Name}, {nameof(Age)}={Age}, {nameof(Gender)}={Gender}}}";
        }
    }
}
