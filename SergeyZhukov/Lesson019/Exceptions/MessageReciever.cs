using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson019.Exceptions
{
    internal class MessageReciever
    {
        public void Print(string s)
        {
            if (s == string.Empty)
            {
                throw new CustomException("Message is empty");
            }
            Console.WriteLine(s);
        }
    }
}
