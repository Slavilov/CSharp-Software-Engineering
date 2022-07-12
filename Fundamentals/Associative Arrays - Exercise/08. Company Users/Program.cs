using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;


namespace AssociativeArraysExercise

{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeesAndCompanyInfo = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                List<string> inputList = input.Split(" -> ").ToList();
                string company = inputList[0];
                string employeeId = inputList[1];

                if (employeesAndCompanyInfo.ContainsKey(company))
                {
                    if (employeesAndCompanyInfo[company].Contains(employeeId))
                    {
                        continue;
                    }
                    else
                    {
                        employeesAndCompanyInfo[company].Add(employeeId);
                    }
                }
                else
                {
                    employeesAndCompanyInfo.Add(company, new List<string>());
                    employeesAndCompanyInfo[company].Add(employeeId);
                }
            }

            foreach (var company in employeesAndCompanyInfo)
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}