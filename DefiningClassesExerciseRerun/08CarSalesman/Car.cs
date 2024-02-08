using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07RawData
{
    public class Car
    {
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private Engine engine;

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}
		private int weight;

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}
		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, string color)
			:this(model, engine)
        {
            Color = color;
        }
        public Car(string model, Engine engine, int weight, string color )
			:this(model, engine, color)
		{
			Weight = weight;
		}

	}
}
