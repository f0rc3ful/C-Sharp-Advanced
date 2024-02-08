using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SpeedRacing
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
			set { travelledDistance = value; }
		}

		public Car(string model, double fuelAmount, double conumptionPerKm)
		{
			Model = model;
			FuelAmount= fuelAmount;
			FuelConsumptionPerKilometer = conumptionPerKm;
			TravelledDistance = 0;
		}

		public void DriveCheck(double distance)
		{
			if (FuelAmount - distance * fuelConsumptionPerKilometer < 0)
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
			else
			{ 
				FuelAmount -= distance * fuelConsumptionPerKilometer;
				TravelledDistance += distance;
			}
		}
	}
}
