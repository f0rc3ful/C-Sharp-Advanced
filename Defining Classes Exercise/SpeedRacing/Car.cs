using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private double fuelAmount;

		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}
		private double fuelConsumptionPerKilometer;

		public double FuelConsumptionPerKilometer
		{
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}
		private double travelledDistance;

		public double TravelledDistance
		{
			get { return travelledDistance; }
			set { travelledDistance = 0; }
		}

		public Car(string model, double fuel, double consumption)
		{
			this.model = model;
			this.fuelAmount = fuel;
			this.fuelConsumptionPerKilometer= consumption;
		}
		public void DriveCheck(string model, double distance)
		{
			if (FuelAmount - distance * FuelConsumptionPerKilometer < 0)
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
			else
			{ 
				FuelAmount -= distance * FuelConsumptionPerKilometer;
				TravelledDistance += distance;
			}
		}
	}
}
