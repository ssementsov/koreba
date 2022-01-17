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

            Console.WriteLine(employees[0].Positions[0].From);
            Console.ReadKey();
        }
    }
}
