using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _98Cards
{
    public partial class Game : Form
    {    
        Dictionary<int,BoardCase> boardList= new Dictionary<int, BoardCase>();
        Collection<Pile> pileList = new Collection<Pile>();
        //Pile pu1 = new Pile(true);
        //Pile pu2 = new Pile(true);
        //Pile pd1 = new Pile(false);
        //Pile pd2 = new Pile(false);
        bool slct = false;
        Deck cards= new Deck();
        Label onuse;
        Label onplace;
        Label lastuse;
        int indexb;
        int indexp=0;
        int count = 0;

        public Game()
        {
            InitializeComponent();
            timer.Start();
            pileList.Add(new Pile(true));
            pileList.Add(new Pile(true));
            pileList.Add(new Pile(false));
            pileList.Add(new Pile(false));
            foreach (Label lbl in pnlboard.Controls)
            {
                SpawnCard(lbl);
                btnundo.Enabled= false;
            }
            lblcardsleft.Text = (MinMaxGlobal.GlobalMax - MinMaxGlobal.GlobalMin+1).ToString();
            lblpileup1.Text = (MinMaxGlobal.GlobalMin - 1).ToString();
            lblpileup2.Text = (MinMaxGlobal.GlobalMin - 1).ToString();
            lblpiledwn1.Text = (MinMaxGlobal.GlobalMax + 1).ToString();
            lblpiledwn2.Text = (MinMaxGlobal.GlobalMax + 1).ToString();
            cards.SecondTurn += new Deck.SecondTurnEventHandler(OnTurnTwo);
        }

        private void SpawnCard(Label l)
        {
            Random rnd = new Random();
            int x;
            int y=Int32.Parse(l.Tag.ToString());
            do { x = rnd.Next(MinMaxGlobal.GlobalMin, MinMaxGlobal.GlobalMax+1); }
            while (cards.MyDeck[x] == false);
            cards.MyDeck[x] = false;
            BoardCase bc = new BoardCase(x);
            if (boardList.ContainsKey(y))
                boardList[y] = bc;
            else boardList.Add(y,bc);
            l.Text = x.ToString();
            l.BackColor = bc.Current.BColor;
        }
        private void Clean()
        {
            slct = false;
            foreach (Label lbl in pnlboard.Controls)
            {
                lbl.BorderStyle = BorderStyle.None;
            }
        }

        private int BoardCount()
        {
            int x=0;
            foreach(BoardCase bc in boardList.Values)
            {
                if (bc.Current != null)
                    x++;
            }
            return x;
        }

        private void lblbrd_Click(object sender, EventArgs e)
        {
            Clean();
            onuse = sender as Label;
            onuse.BorderStyle = BorderStyle.Fixed3D;
            slct = true;
        }

        private void lblpile_Click(object sender, EventArgs e)
        {
            if (slct) {
                onplace = sender as Label;
                indexp = Int32.Parse(onplace.Tag.ToString());

                if (pileList[indexp].CardPlaced(new Card(Int32.Parse(onuse.Text))))
                {
                    onuse.Enabled = false;
                    lastuse = onuse;
                    indexb = Int32.Parse(onuse.Tag.ToString());
                    //cards.MyDeck[Int32.Parse(onuse.Text)]=false;
                    onplace.Text = onuse.Text;
                    onplace.BackColor = onuse.BackColor;
                    btnundo.Enabled = true;
                    onuse.Text = "";
                    onuse.BackColor=Color.Gray;
                    boardList[indexb].CardRemoved();
                    TestSaturated();
                    cards.Turn++;
                    lblcardsleft.Text = (cards.Remaining()+BoardCount()).ToString();
                }
                Clean();
            }
        }

        private void Game_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void OnTurnTwo()
        {
            btnundo.Enabled = false;
            foreach (Label l in pnlboard.Controls)
            {
                if (l.Text == "" )
                {
                    SpawnCard(l);
                    l.Enabled = true;
                }
            }            
        }

        private void TestSaturated()
        {
            int n = 0;
            int x = 0;
            foreach (BoardCase bc in boardList.Values)
            {
                if (bc.Current!=null)
                {
                    n++;
                    if (bc.Current.Value < Math.Min(pileList[0].Current.Value, pileList[1].Current.Value)
                        && bc.Current.Value > Math.Max(pileList[2].Current.Value, pileList[3].Current.Value))
                        x++;
                }
            }
            if (x == n )
            {
                if (n == 0)
                    cards.GameOver += new Deck.GameOverEventHandler(GameWon);
                if (n != 0)
                    cards.GameOver += new Deck.GameOverEventHandler(GameLost);
                cards.Saturated = true;
            }
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            lastuse.Enabled = true;
            lastuse.Text = onplace.Text;
            lastuse.BackColor = onplace.BackColor;
            onplace.Text = pileList[indexp].Previous.Value.ToString();
            onplace.BackColor = pileList[indexp].Previous.BColor;
            cards.Undo();
            btnundo.Enabled = false;
            pileList[indexp].Undo();
            boardList[indexb].Undo();
            lblcardsleft.Text = (cards.Remaining() + BoardCount()).ToString();
        }
        private void GameWon()
        {
            timer.Stop();
            MessageBox.Show("Congratulation you won!\nYour score:" + count.ToString());
            StreamWriter sw=null;
            try
            {
                sw = new StreamWriter("D:\\Projects\\98Cards\\scores.txt", true);
                sw.WriteLine(count.ToString() + DateTime.Now.ToString("s on: dd-MM-yyyy H:mm"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                if (sw != null)
                    sw.Close();sw.Dispose();
                Close();
            }
        }
        private void GameLost()
        {
            timer.Stop();
            MessageBox.Show("Hard luck\nGAME OVER");
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count++;
            lblscore.Text = count.ToString();
        }
    }
}
