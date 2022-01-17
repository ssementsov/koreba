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
    }
}
