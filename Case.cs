using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98Cards
{
    abstract class Case
    {
        Card current;
        Card previous;

        public Card Current
        {
            set
            {
                previous = current;
                current = value;
            }
            get
            {
                return current;
            }
        }
        public Card Previous
        {
            get { return previous; }
        }

        public void Undo()
        {
            current=previous;
        }
    }
}
