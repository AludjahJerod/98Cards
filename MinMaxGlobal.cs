using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98Cards
{
    public class MinMaxGlobal
    {
        static int globalmin=1;
        static int globalmax=10;

        public static int GlobalMin
        {
            get { return globalmin; }
        }

        public static int GlobalMax
        {
            get { return globalmax; }
        }
    }
}
