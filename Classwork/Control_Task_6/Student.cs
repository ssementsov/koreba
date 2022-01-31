namespace Control_Task_6
{
    internal class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Group { get; private set; }
        public double AvarageMark { get; private set; }

        public Student(string firstName, string lastName, string group, double avarageMark)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            AvarageMark = avarageMark;
        }

        public virtual string GetScholarship()
        {
            return AvarageMark >= 5 ? "100 BYN" : "80 BYN";
        }
    }
}
