﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
	public class Car
	{
		private string make;
		private string model;
		private int year;
		private double fuelQuantity;
		private double fuelConsumption;

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public double FuelQuantity { get; set; }
		public double FuelConsumption { get; set; }
		public Car()
		{
			this.Make = "VW";
			this.Model = "Golf";
			this.Year = 2025;
			this.FuelQuantity= 200;
			this.FuelConsumption = 10;
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
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;

		}
        public void Drive(double distance)
		{
			double outcome = fuelQuantity - distance * fuelConsumption;

			if (outcome > 0)
			{
				this.fuelQuantity -= distance * this.fuelConsumption;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
			}
		}

		public string WhoAmI()
		{
			return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
		}
	}
}
