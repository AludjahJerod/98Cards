using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98Cards
{
    class BoardCase : Case
    {
        public void CardRemoved()
        {
            Current = null;
        }

        public BoardCase(int v)
        {
            Current = new Card(v);
        }

    }
}
