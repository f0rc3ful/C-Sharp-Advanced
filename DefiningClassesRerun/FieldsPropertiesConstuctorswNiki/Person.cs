using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsPropertiesConstructorswNiki
{
    public enum Season
    { 
        Spring, Summer, Autumn, Winter
    }
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string nameValue, int ageValue)
        {
            if (char.IsLower(nameValue[0]))
            {
                Name = char.ToUpper(nameValue[0]) + nameValue.Substring(1);
            }
            else
            {
                Name = nameValue;
            }
            if (ageValue < 0 || ageValue > 140)
            {
                Age = 0;
            }
            else
            {
                Age = ageValue;
            }
        }

    }
}
