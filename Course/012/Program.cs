using System;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("ASCII");
                char H = '\x48', e = '\x65', l = '\x6c', o =  '\x6f', space = '\x20', w = '\x57', r = '\x72', d = '\x64', mark = '\x21';

                int sum = H + e + l + l + o + space + w + o + r + l + d + mark;

                Console.WriteLine($"{H,-5} {e,-5} {l,-5} {l,-5} {o,-5} {space,-5} {w,-5} {o,-5} {r,-5} {l,-5} {d,-5} {mark,-5}");
                Console.WriteLine($"{(int) H} + {(int) e} + {(int) l} + {(int) l} + {(int) o} + {(int) space}  +  " +
                    $"{(int) w} + {(int) o} + {(int) r} + {(int) l} + {(int) d} + {(int) mark} = {sum}");
            }

            {
                Console.WriteLine("\nUNICODE");
                char H = '\u0048', e = '\u0065', l = '\u006c', o = '\u006f', space = '\u0020', w = '\u0057', r = '\u0072', d = '\u0064', mark = '\u0021';

                int sum = H + e + l + l + o + space + w + o + r + l + d + mark;

                Console.WriteLine($"{H,-5} {e,-5} {l,-5} {l,-5} {o,-5} {space,-5} {w,-5} {o,-5} {r,-5} {l,-5} {d,-5} {mark,-5}");
                Console.WriteLine($"{(int) H} + {(int) e} + {(int) l} + {(int) l} + {(int) o} + {(int) space}  +  " +
                    $"{(int) w} + {(int) o} + {(int) r} + {(int) l} + {(int) d} + {(int) mark} = {sum}");
            }

            Console.ReadKey();
        }
    }
}
