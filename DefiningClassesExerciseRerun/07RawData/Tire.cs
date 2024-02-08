using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07RawData
{
    public class Tire
    {
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		private double pressure;

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}
		public Tire(int age, double pressure)
		{
			Age = age;
			Pressure = pressure;
		}
	}
}
