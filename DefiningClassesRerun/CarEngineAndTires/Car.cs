﻿using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
		private string make;

		public string Make
		{
			get { return make; }
			set { make = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		private double fuelQuantity;

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}
		private double fuelConsumption;

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}

		private Engine engine;

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}
		private Tire[] tires;

		public Tire[] Tires
		{
			get { return tires; }
			set { tires = value; }
		}

		public Car()
		{
			this.Make = "VW";
			this.Model = "Golf";
			this.Year = 2025;
			this.FuelQuantity = 200;
			this.fuelConsumption = 10;
		}

		public Car(string make, string model, int year)
			: this()
		{
            this.Make = make;
            this.Model = model;
            this.Year = year;
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
			: this(make, model, year)
		{
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
		}
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
        public void Drive(double distance)
		{
			if (FuelQuantity - distance / 100 * FuelConsumption > 0)
			{
				FuelQuantity -= distance / 100 * FuelConsumption;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip");
			}
		}

		public string WhoAmI()
		{ 
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"Fuel: {FuelQuantity:F2}");
			return sb.ToString();
        }

	}
}
