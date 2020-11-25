using System;
using System.Collections.Generic;
using System.Text;
using WorkerApp.Entities;
using WorkerApp.WorkFlowProgramCS;
using System.Globalization;
namespace WorkerApp.WorkFlowProgramCS
{
    class IncomeCalculation
    {
        //IncomeMethod


        public static void TotalIncome(Worker work)
        {

            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYear = DefaultTexts.SetIncomeMonth();

            int month = int.Parse(monthAndYear.Substring(0, 2));

            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {work.WorkerName}");
            Console.WriteLine($"Department: {work.Department.DepartmentName}");
            Console.Write($"Income for: {monthAndYear}: ");
            Console.Write(work.Income(year, month).ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
