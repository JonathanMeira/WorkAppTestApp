using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerApp.Entities
{
    class HourContract
    {
        //Creating variables;

        public DateTime Date
        {
            get;
            set;
        }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }


        //Creating Constructors
        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }


        //Creating methods


        public double totalValue()
        {
            return this.Hours * this.ValuePerHour;
        }





    }
}
