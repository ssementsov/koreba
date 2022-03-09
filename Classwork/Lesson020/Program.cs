using System.Text.RegularExpressions;

namespace Lesson020
{
    class Program
    {
        static void Main()
        {
            //object obj1 = new String("str");
            //object obj2 = new String("str");
            //string str1 = new String("str");
            //string str2 = new String("Str");

            //Console.WriteLine($"Objects is equals - {obj1 == obj2}");
            //Console.WriteLine($"Strings is equals - {str1 == str2}");

            //--------------- REGEX -------------------

            //string s = "погода автопад мобиль Автомобиль гора гораАвтомат";
            //Regex reg = new Regex(@"(\w*)(а|А)вто(\w*)");

            //var match = reg.Matches(s);

            //foreach (var m in match)
            //{
            //    Console.WriteLine(m);
            //}

            //------------- FILESTREAM -------------------
            var s = new StreamExample();
            s.DoWork();
        }
    }
}