using System;
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
        private Engine engine;
        private Tire[] tires;

        private string make;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        private string model;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private int year;

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
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
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;

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
