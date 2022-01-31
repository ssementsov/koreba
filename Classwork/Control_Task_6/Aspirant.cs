namespace Control_Task_6
{
    internal class Aspirant : Student
    {
        public string ScientificWork { get; private set; }

        public Aspirant(string firstName, string lastName, string group, double avarageMark, string scientificWork) 
            : base(firstName, lastName, group, avarageMark)
        {
            ScientificWork = scientificWork;    
        }

        public override string GetScholarship()
        {
            return AvarageMark >= 5 ? "200 BYN" : "180 BYN";
        }
    }
}
