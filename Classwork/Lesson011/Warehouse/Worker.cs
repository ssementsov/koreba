using System;

namespace Lesson011.Warehouse
{
    public class Worker
    {
        public string Name { get; private set; }
        public string Signature { get; private set; }

        public Worker(string name, string signature)
        {
            Name = name;
            Signature = signature;
        }
    }
}
