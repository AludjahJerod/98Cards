using System;
using System.Collections.Generic;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnnewgame_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
        }

        private void btnscores_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText("D:\\Projects\\98Cards\\scores.txt");
                try
                {
                    MessageBox.Show("Score:\n" + sr.ReadToEnd());
                }
                catch { }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (sr != null)
                    sr.Close();sr.Dispose();
            }
        }
    }
}
