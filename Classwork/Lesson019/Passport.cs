using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson019
{
    internal record Passport
    {
        public Passport(string firstName, string lastName) =>
            (FirstName, LastName) = (firstName, lastName);
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}
