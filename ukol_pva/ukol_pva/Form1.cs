using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_pva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int cislo = int.Parse(textBox1.Text);
                for(int i = 0; i < cislo; i++)
                {
                    listBox1.Items.Add("ahoj");
                }
            } catch
            {
                MessageBox.Show("špatně zadaná hodnota!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("ahoj");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Číslo       Druhá mocnina");
            for (int i = 10; i <= 20; i++)
            {
                listBox1.Items.Add(i + "       "+ i*i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] hodnoty = new int[10];
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(hodnoty[i] = rnd.Next(1, 7));
            }
            var sest = hodnoty.Count(c => c == 6);
            listBox1.Items.Add("Počet padnutých 6 je: " + sest);
        }
    }
}
