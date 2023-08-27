using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Dávejte si pozor na TextBox č. 2: Souřadnice Y!\nPokud zadáte hodnotu a poté vymažete, program spadne.", "Upozornění!");
        }

        public void yc_TextChanged(object sender, EventArgs e)
        {
            Graphics plocha = panel1.CreateGraphics();
            Random rnd = new Random();
            try
            {
                var barvy = new List<Color>
                {
                    Color.Black,
                    Color.Orange,
                    Color.Red,
                    Color.Beige,
                    Color.Violet,
                    Color.Tomato,
                    Color.Blue,
                    Color.Green,
                    Color.Gold
                };
                int x = 0;
                int y = 0;
                y = int.Parse(yc.Text);
                x = int.Parse(xc.Text);
                panel1.Refresh();
                SolidBrush brush = new SolidBrush(Color.Black);
                //int i = 0;

                for (int i = 0; i < barvy.Count; i++)
                {
                    plocha.FillEllipse(brush, x, y, 25, 25);
                    plocha.DrawLine(new Pen(barvy[i], 3), 0, 0, x + 12.5F, y + 12.5F);
                    plocha.DrawLine(new Pen(barvy[i], 3), 350, 0, x + 12.5F, y + 12.5F);
                    plocha.DrawLine(new Pen(barvy[i], 3), 0, 350, x + 10, y + 12.5F);
                    plocha.DrawLine(new Pen(barvy[i], 3), 350, 350, x + 12.5F, y + 24);
                    i = rnd.Next(1, barvy.Count);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Souřadnice Y je 0!", "Upozornění!");
            }
        }

        public void vyčistitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xc.Clear();
            yc.Clear();
            panel1.Refresh();
            Application.Restart();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
