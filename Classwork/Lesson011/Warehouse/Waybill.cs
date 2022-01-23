using System;

namespace Lesson011.Warehouse
{
    public class Waybill
    {
        public uint Id { get; private set; }
        public DateTime DateOfCreation { get; private set; }
        public Worker From { get; private set; }
        public Worker To { get; private set; }

    }
}
