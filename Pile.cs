using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98Cards
{
    class Pile:Case
    {
        public delegate bool PutCard(Card c);
        bool updown;

        public Pile(bool b)
        {
            updown = b;
            if (b)
            {
                Current = new Card(MinMaxGlobal.GlobalMin-1);
                Current = new Card(MinMaxGlobal.GlobalMin-1);
            }
            else
            {
                Current = new Card(MinMaxGlobal.GlobalMax+1);
                Current = new Card(MinMaxGlobal.GlobalMax + 1);
            }
        }
        public bool ValidPut(Card c)
        {
            Current = c;
            return true;
        }

        public bool InvalidPut(Card c)
        {
            return false;
        }

        public bool CardPlaced(Card c)
        {
            PutCard p;
            bool condition;
            if (updown == true)
                condition = c.Value > Current.Value || c.Value == Current.Value - 10;
            else condition = c.Value < Current.Value || c.Value == Current.Value + 10;
            if (condition)
                p = new PutCard(ValidPut);
            else p = new PutCard(InvalidPut);
            Boolean returnVal= p(c);
            return returnVal;
        }
    }
}
