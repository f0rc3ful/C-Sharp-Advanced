using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
		private List<Person> familyMembers = new List<Person>();

		public List<Person> FamilyMembers
		{
			get { return familyMembers; }
			set { familyMembers = value; }
		}

		public void AddMember(Person member)
		{ 
			FamilyMembers.Add(member);
		}
		public Person GetOldestMember()
		{
			FamilyMembers = FamilyMembers.OrderByDescending(m => m.Age).ToList();
			return FamilyMembers[0];
		}

		

	}
}
