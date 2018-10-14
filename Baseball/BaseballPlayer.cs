﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class BaseballPlayer
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void TakeTurn(IBaseballBat typeOfBat)
        {
            typeOfBat.Swing();
        }
    }
}
