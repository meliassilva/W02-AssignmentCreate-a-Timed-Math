﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class NameChangeEventArgs : EventArgs
    {
        public  string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
