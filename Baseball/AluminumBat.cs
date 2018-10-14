using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class AluminumBat: IBaseballBat
    {
        public int WeightInGrams { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void Swing()
        {
            Console.WriteLine("TING!");
        }
    }
}
