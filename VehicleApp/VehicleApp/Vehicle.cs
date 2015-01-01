using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        private string vehicleName ;
        private string vehicleRegistration;

        private double minSpeed;
        private double maxSpeed;
        public int count;
        public double sum;

        public Vehicle(string name,string registration)
        {
            VehicleName = name;
            VehicleRegistration = registration;
            MaxSpeed = 0;
            MinSpeed = 0;
            sum = 0;
            count = 0;
        }

        private double MinSpeed
        {
            get { return minSpeed; }
            set
            {
                if (value < minSpeed)
                {
                    minSpeed = value;
                }
            }
        }

        private double MaxSpeed
        {
            get { return maxSpeed; }

            set
            {
                if (value > maxSpeed)
                {
                    maxSpeed = value;
                }
            }
        }

        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }

        public string VehicleRegistration
        {
            get { return vehicleRegistration; }
            set { vehicleRegistration = value; }
        }

        public  void AddSpeed(double speed)
        {
            count++;
            MaxSpeed = speed;
            MinSpeed = speed;
            sum += speed;

        }

        public double AvgSpeed()
        {
            return sum/count;
        }

        public double MinSpeedReturn()
        {
            return MinSpeed;
        }
        public double MaxSpeedReturn()
        {
            return MaxSpeed;
        }
    }
}
