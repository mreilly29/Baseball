﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballPlayer dude = new BaseballPlayer();
            WoodenBat woodenBat = new WoodenBat();
            AluminumBat alum = new AluminumBat();
            dude.TakeTurn(woodenBat);
            dude.TakeTurn(alum);
        }
    }
}
