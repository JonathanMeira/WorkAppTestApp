using System;
using System.Collections.Generic;
using System.Text;
using WorkerApp.WorkFlowProgramCS;
using WorkerApp.Entities;

namespace WorkerApp.WorkFlowProgramCS
{
    class Contracts
    {

        //ContractCreation;

        public static void CreateContractLoop(Worker work)
        {

            Console.Write("How Many contracts to this worker? ");
            int repeatX = DefaultTexts.UserInput();

            for (int i = 1; i <= repeatX; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");

                work.AddContract(ContractData());

            }


        }

        public static HourContract ContractData()
        {
            Console.Write("Enter Date (DD/MM/YYYY): ");
            DateTime date = DefaultTexts.SetDate();
            Console.Write("Value per hour: ");
            double valuePerHour = DefaultTexts.SetValuePerHour();
            Console.Write("Duration(hours): ");
            int hours = DefaultTexts.UserInput();

            HourContract constract = new HourContract(date, valuePerHour, hours);


            return constract;

        }









    }
}
