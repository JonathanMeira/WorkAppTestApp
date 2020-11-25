using System;
using System.Collections.Generic;
using System.Text;
using WorkerApp.Entities;
using WorkerApp.Entities.Enums;
using System.Globalization;

namespace WorkerApp.WorkFlowProgramCS
{
    class DefaultTexts
    {

        //Default Sets

        public static string SetDepartmentName()
        {
            Console.Write("Enter department's name:");
            return Console.ReadLine();
        }

        public static string SetWorkerName()
        {
            Console.Write("Enter Name:");
            return Console.ReadLine();
        }

        public static WorkerLevel SetWorkerLevel()
        {
            Console.Write("Enter worker level(Junior/MidLevel/Senior): ");
            return Enum.Parse<WorkerLevel>(Console.ReadLine());
        }

        public static double SetBaseSalary()
        {
            Console.Write("Enter base salary: ");

            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static double SetValuePerHour()
        {
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static DateTime SetDate()
        {
            return DateTime.Parse(Console.ReadLine());
        }


        public static int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }

        public static string SetIncomeMonth()
        {

            return Console.ReadLine();
        }

    }
}
