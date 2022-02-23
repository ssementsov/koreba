namespace Lesson019
{
    class Program
    {
        static void Main()
        {
            //MyClass structA = new() { Value = 1 }, structB = new() { Value = 1 };
            //Console.WriteLine($"structA.Equals(structB) == {structA.Equals(structB)}");

            //MyRecord recordA = new() { Value = 1 }, recordB = new() { Value = 1 };
            //Console.WriteLine($"recordA.Equals(recordB) == {recordA.Equals(recordB)}");

            //AnImmutableType inst1 = new(), inst2 = new();
            //inst1.value = 22;
            //Console.WriteLine(inst1.Equals(inst2));

            //string text = new string("Hello");
            //Console.WriteLine(text.GetHashCode());
            //text += " world!";
            //Console.WriteLine(text.GetHashCode());
            //text = "Goodbye!";
            //Console.WriteLine(text.GetHashCode());

            //Console.WriteLine(new string('-', 25));

            //string word1 = "book";
            //string word2 = "book";
            //Console.WriteLine(word1.GetHashCode());
            //Console.WriteLine(word2.GetHashCode());

            //MyCustomType inst1 = new(), inst2 = new();

            //Console.WriteLine(inst1.GetHashCode());
            //Console.WriteLine(inst2.GetHashCode());
            //Console.WriteLine(inst1.Equals(inst2));

            //Console.WriteLine(new String('-', 25));

            //inst1.value = 22;
            //Console.WriteLine(inst1.GetHashCode());
            //Console.WriteLine(inst2.GetHashCode());
            //Console.WriteLine(inst1.Equals(inst2));

            //string str1 = "hello", str2 = "hello";
            //Console.WriteLine($"str1 is a str2 = {object.ReferenceEquals(str1, str2)}");

            //MyCustomType inst1 = new(), inst2 = new();
            //Console.WriteLine($"str1 is a str2 = {object.ReferenceEquals(inst1, inst2)}");

            //Console.WriteLine(inst1.GetHashCode());
            //Console.WriteLine(inst2.GetHashCode());

            //Console.WriteLine(inst1.Equals(inst2));

            //inst1.value = 22;
            //Console.WriteLine(inst1.GetHashCode());
            //Console.WriteLine(inst2.GetHashCode());
            //Console.WriteLine(inst1.Equals(inst2));

            Passport passport1 = new("E", "K");
            Console.WriteLine(passport1);

            Passport passport2 = new("S", "S");
            Console.WriteLine(passport2);

            string newLastName = passport2.LastName + "-" + passport1.LastName;
            Passport passport3 = passport2 with { LastName = newLastName };
            Console.WriteLine(passport3);
        }
    }

    struct MyStruct { public int Value { get; set; } }
    class MyType { public int Value { get; set; } }
    record MyRecord { public int Value { get; set; } }
}