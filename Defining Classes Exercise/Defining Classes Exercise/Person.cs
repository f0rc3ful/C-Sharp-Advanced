using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Exercise
{
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

		public Person() 
		{
			name = "unknown";
			age = 0;
		}
		
		public Person(string name, int age)
		{ 
			this.name = name;
			this.age = age;
		}
	}
}
