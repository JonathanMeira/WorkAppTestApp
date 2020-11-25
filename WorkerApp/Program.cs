using System;
using WorkerApp.WorkFlowProgramCS;
using WorkerApp.Entities;
using WorkerApp.Entities.Enums;
using System.Collections.Generic;

namespace WorkerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating Worker informations

            Department dept = new Department(DefaultTexts.SetDepartmentName());

            Console.WriteLine("Enter worker data:");

            string name = DefaultTexts.SetWorkerName();

            WorkerLevel level = DefaultTexts.SetWorkerLevel();

            double baseSalary = DefaultTexts.SetBaseSalary();

            //Creating Worker object

            Worker testWork = new Worker(name, level, baseSalary, dept);

            //Creating x contracts for worker;

            Contracts.CreateContractLoop(testWork);

            //Calculating total worker income based on month & year

            IncomeCalculation.TotalIncome(testWork);

            Console.ReadLine();
        }



    }
}
