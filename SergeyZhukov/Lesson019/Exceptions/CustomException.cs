﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson019.Exceptions
{
    internal class CustomException : ApplicationException
    {
        public CustomException(string message) 
            : base(message) 
        { }
    }
}
