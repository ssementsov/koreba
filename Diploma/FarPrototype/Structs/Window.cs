using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarPrototype.WindowStructures
{
    internal class Window
    {
        public Header Header { get; set; }
        public View[] Views { get; set; }
        public Footer Footer { get; set; }


        public void UpdateState()
        {

        }
    }
}
