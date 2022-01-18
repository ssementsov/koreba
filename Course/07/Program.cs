using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task_07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"..\..\Data.json";
            string json = File.ReadAllText(path);

            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(json);

            BoubleSort(employees);
            PrintList(employees);

            Console.ReadKey();
        }

        private static void BoubleSort(List<Employee> employees)
        {
            for (int i = employees.Count - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (employees[j - 1].GetTotalWorkDays() > employees[j].GetTotalWorkDays())
                    {
                        Swap(employees, j - 1, j);
                    }
                }
            }
        }

        private static void Swap(List<Employee> employees, int i, int j)
        {
            Employee temp = employees[i];
            employees[i] = employees[j];
            employees[j] = temp;
        }

        private static void PrintList(List<Employee> list)
        {
            foreach (Employee employee in list)
            {
                string template = $"name: {employee.Name + ",", -20} totalWorkDays: {employee.GetTotalWorkDays()}";
                Console.WriteLine(template);
            }
        }
    }
}
