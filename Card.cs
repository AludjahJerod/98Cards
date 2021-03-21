using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _98Cards
{
    class Card
    {
        int val;
        Color color= Color.White;
        int min=MinMaxGlobal.GlobalMin;
        int max=MinMaxGlobal.GlobalMax;

        public int Value
        {
            get { return val; }
        }
        public Color BColor
        {
            get { return color; }
        }

        public Card(int v)
        {
            if (v <= max+1 && v >= min-1)
            { val = v;
                if (v == min-1)
                    color = Color.Gray;
                else if (v < (int)Math.Round((double)max/6))
                    color = Color.LightYellow;
                else if (v < (int)Math.Round((double)2*max / 6))
                    color = Color.Yellow;
                else if (v < (int)Math.Round((double)3*max / 6))
                    color = Color.Orange;
                else if (v < (int)Math.Round((double)4*max / 6))
                    color = Color.DarkOrange;
                else if (v < (int)Math.Round((double)5*max / 6))
                    color = Color.OrangeRed;
                else if (v == max+1)
                    color = Color.Gray;
                else color = Color.Red;
            }
            else MessageBox.Show("Invalid Cards value");
        }

        //public Card(int v,int mx, int mn)
        //{
        //    if (mx >= mn + 7)
        //    {
        //        max = mx;
        //        min = mn;
        //        if (v <= max + 1 && v >= min - 1)
        //        {
        //            val = v;
        //            if (v == min - 1)
        //                color = Color.Gray;
        //            else if (v < (int)Math.Round((double)max / 6))
        //                color = Color.LightYellow;
        //            else if (v < (int)Math.Round((double)2 * max / 6))
        //                color = Color.Yellow;
        //            else if (v < (int)Math.Round((double)3 * max / 6))
        //                color = Color.Orange;
        //            else if (v < (int)Math.Round((double)4 * max / 6))
        //                color = Color.DarkOrange;
        //            else if (v < (int)Math.Round((double)5 * max / 6))
        //                color = Color.OrangeRed;
        //            else if (v == max + 1)
        //                color = Color.Gray;
        //            else color = Color.Red;
        //        }
        //        else throw new Exception("Invalid card value");
        //    }
        //    else throw new Exception("Invalid max and min values");
        //}
    }
}
