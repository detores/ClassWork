﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_18_05.Animals;

namespace Task2_18_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammals = new Mammal[]
            {
                new Aquatic(1),
                new Aquatic(1),
                new Arboreal(1),
                new Arboreal(1),
                new Arial(1),
                new Subterranean(1),
                new Subterranean(1),
                new Terrestrial(1),
                new Terrestrial(1)
            };
            Feeder feeder = new Feeder();
            feeder.Feed(mammals);
        }
    }
}
