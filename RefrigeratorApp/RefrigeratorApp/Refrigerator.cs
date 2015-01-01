using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double fullcapacity;
        private double currentCapacity;

        public double FullCapacity
        {
            get { return fullcapacity; }
            set { fullcapacity = value; }
        }

        public double CurrentCapacity
        {
            get { return currentCapacity; }

            set
            {
                if (currentCapacity + value <= FullCapacity)
                {
                    currentCapacity += value;
                }
                else throw new Exception("You cannot add more Weight than Capacity");

            }
        }


        public Refrigerator(double capacity)
        {
            FullCapacity = capacity;
            CurrentCapacity = 0;
        }

        public void Addweight(double weight)
        {
            CurrentCapacity = weight;
        }
    }
}
