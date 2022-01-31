namespace Control_Task_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student aspirant = new Aspirant("Evgeny", "Koreba", "PS-52", 9.2d, "OOP");
            Student student = new Student("Andrey", "Ivanov", "PS-42", 7.5d);

            var students = new Student[]
            {
                aspirant,
                student
            };

            foreach (var item in students)
            {
                Console.WriteLine(item.GetScholarship());
            }
        }
    }
}
