﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string RandomString()
        {
            if(Count == 0)
            {
                return "";
            }
            return this[random.Next(0, this.Count)];
        }
    }
}
