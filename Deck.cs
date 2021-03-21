using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98Cards
{
    class Deck
    {
        public delegate void SecondTurnEventHandler();
        public event SecondTurnEventHandler SecondTurn;
        public delegate void GameOverEventHandler();
        public event GameOverEventHandler GameOver;
        Dictionary<int, bool> myDeck = new Dictionary<int, bool>();
        int turn = 0;
        bool saturated;
        int min = MinMaxGlobal.GlobalMin;
        int max = MinMaxGlobal.GlobalMax;

        public Deck()
        {
            for (int i = min; i <= max; i++)
            {
                myDeck.Add(i, true);
            }
        }

        //public Deck(int mn, int mx)
        //{
        //    if (mx >= mn + 7)
        //    {
        //        max = mx;
        //        min = mn;
        //        for (int i = min; i <= max; i++)
        //        {
        //            myDeck.Add(i, true);
        //        }
        //    }
        //}

        public int Turn
        {
            set { turn =value;
                turn=turn%2;
                if(turn==0 && Remaining()>0)
                    SecondTurn();
                if (saturated)
                {
                    GameOver();
                }
            }
            get { return turn; }
        }
        public void Undo()
        {
            turn = Math.Abs(turn - 1) % 2;
            //myDeck[x] = true;
        }

        public Dictionary<int, bool> MyDeck
        {
            set { myDeck = value; }
            get { return myDeck; }
        }

        public Boolean Saturated
        {
            set { saturated = value; }
        }

        public int Remaining()
        {
            int x = 0;
            foreach (bool b in myDeck.Values)
            {
                if (b == true)
                    x++;
            }
            return x;
        }
    }
}
