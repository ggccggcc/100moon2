﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex010
    {
        public void Run()
        {
            String strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber);
            int parseNumber = Int32.Parse(strNumber);

            Console.WriteLine("{0}+{1}+{2}", convertNumber, parseNumber, convertNumber+parseNumber);

        }
    }
}
