using System;
using System.Collections.Generic;

namespace Task_07
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<Position> Positions { get; private set; }

        public Employee(int id, string name, List<Position> positions)
        {
            Id = id;
            Name = name;
            Positions = positions;
        }

        public int GetTotalWorkDays()
        {
            int totalWorkDays = 0;

            foreach (Position position in Positions)
            {
                totalWorkDays += position.GetWorkDays();
            }

            return totalWorkDays;
        }
    }
}
