﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

    }
}
