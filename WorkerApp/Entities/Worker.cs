using System;
using System.Collections.Generic;
using System.Text;
using WorkerApp.Entities.Enums;



namespace WorkerApp.Entities
{
    class Worker
    {
        //Creating variables

        public string WorkerName { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        private List<HourContract> Contracts { get; set; } = new List<HourContract>();




        //Creating constructors
        public Worker()
        {
        }
        public Worker(string workerName, WorkerLevel level, double baseSalary, Department department)
        {
            WorkerName = workerName;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Creating methods
        //#1

        public void AddContract(HourContract contract)
        {
            this.Contracts.Add(contract);

        }

        //#2

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);

        }


        //#3

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in this.Contracts)
            {

                if (contract.Date.Year == year && contract.Date.Month == month)
                {

                    sum += contract.totalValue();

                }
            }

            return sum;
        }




    }
}
