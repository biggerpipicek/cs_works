using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4prace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //před zapnutím programu
            MessageBox.Show("Pro zjištění popisu úkolů/prací. Najedtě na kartu Informace v levém rohu aplikace.", "Oznámení");
        }

        private void práceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //.1. Práce - info
            MessageBox.Show("V 1. Práci budeme zadávat číslo, které nám po stisknutí tlačítka vypíše čísla před zadanou hodnotou v ListBoxu.", "1. Práce");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.práce
            list1.Items.Clear();
            string cislo = zadat1.Text;
            if(!int.TryParse(cislo, out int parse))
            {
                MessageBox.Show("V textovém poli je písmeno nebo jiný znak!\nZkuste to prosím znovu.", "Upozornění!");
            } else
            {
                for(int i = int.Parse(cislo); i >= 0; i--)
                {
                    list1.Items.Add(i);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //2. práce
            list2.Items.Clear();
            Random rnd = new Random();
            int min = 0;
            int max = 7;
            for (int i = 0; i <= 6; i++)
            {
                int gen = rnd.Next(min, max);
                list2.Items.Add(gen);
                if (gen == 6)
                {
                    MessageBox.Show("Padla ti šestka!", "Oznámení");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //4. práce
            int km = 1;
            float mile = 1.60934F;
            float vzorec;
            string hodnota = zadat3.Text;
            if(radioButton3.Checked == true)
            {
                radioButton4.Checked = false;
                if(!int.TryParse(hodnota, out int parse))
                {
                    MessageBox.Show("V textovém poli je písmeno nebo jiný znak!\nZkuste to prosím znovu.", "Upozornění!");
                } else
                {
                    vzorec = float.Parse(hodnota) * mile;
                    label12.Text = Convert.ToString(vzorec) + "Km";
                }
            } else if (radioButton4.Checked == true)
            {
                radioButton3.Checked = false;
                if (!int.TryParse(hodnota, out int parse))
                {
                    MessageBox.Show("V textovém poli je písmeno nebo jiný znak!\nZkuste to prosím znovu.", "Upozornění!");
                }
                else
                {
                    vzorec = float.Parse(hodnota) / mile;
                    label12.Text = Convert.ToString(vzorec) + "Mil";
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //4. práce míle
            label9.Text = "Zadejte Míle:";
        }

        private void práceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //2. práce - info
            MessageBox.Show("Ve 2. Práci budeme háze kostkou, kde se nám zapíše šest hodnot do ListBoxu a jestli se najde '6', tak se to oznámí.", "2. Práce");
        }

        private void práceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //3. práce - info
            MessageBox.Show("Ve 3. Práci se kreslí. Máme možnost si vybrat čtverec nebo krychli, zadáme hodnotu a po stisknutí tlačítka se objeví těleso v Panelu.", "3. Práce");
        }

        private void práceToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //4. práce - info
            MessageBox.Show("Ve 4. Práci převádíme Km na Míle a naopak. Zadáme hodnotu, vybereme si možnost a zjistíme hodnotu.", "4. Práce");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //4. práce km
            label9.Text = "Zadejte Km:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //3. práce
            Graphics plocha = panel1.CreateGraphics();
            panel1.Refresh();
            string hodnota = zadat2.Text;
            if(!int.TryParse(hodnota,out int parse))
            {
                MessageBox.Show("V textovém poli je písmeno nebo jiný znak!\nZkuste to prosím znovu.", "Upozornění!");
            } else
            {
                if(radioButton1.Checked == true)
                {
                    radioButton2.Checked = false;
                    plocha.DrawRectangle(new Pen(Color.Black, 3), 157.5F-(int.Parse(hodnota) / 2), 134-(int.Parse(hodnota) / 2), int.Parse(hodnota), int.Parse(hodnota));
                } else if(radioButton2.Checked == true)
                {
                    radioButton1.Checked = false;
                    plocha.DrawEllipse(new Pen(Color.Black, 3), 157.5F-(int.Parse(hodnota) / 2), 134-(int.Parse(hodnota) / 2), int.Parse(hodnota), int.Parse(hodnota));
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //10x Ahoj
            list3.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                list3.Items.Add("Ahoj");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list3.Items.Clear();
            string hodnota = zadat4.Text;
            //Nx Ahoj
            if (!int.TryParse(hodnota, out int parse))
            {
                MessageBox.Show("V textovém poli je písmeno nebo jiný znak!\nZkuste to prosím znovu.", "Upozornění!");
            }
            else
            {
                for (int i = 0; i < int.Parse(hodnota); i++)
                {
                    list3.Items.Add("Ahoj");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list3.Items.Clear();
            //sudá čísla 0→100
            for (int i = 0; i <= 100; i++)
            {
                list3.Items.Add(i);
                i += 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list3.Items.Clear();
            //mocniny 10→20
            list3.Items.Add("Číslo   |   Druhá mocnina");
            for(int i = 10; i <= 20; i++)
            {
                list3.Items.Add(i + "           " + i * i);
            }
        }

        private void vyčistitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //vyčistit
            label12.Text = "Výsledek";
            zadat1.Clear();
            zadat2.Clear();
            zadat3.Clear();
            zadat4.Clear();
            list1.Items.Clear();
            list2.Items.Clear();
            list3.Items.Clear();
            panel1.Refresh();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void práceToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //5. práce
            MessageBox.Show("V 5. Práci budeme klikat spíše na tlačítka, která dělají:\n• 1. Vypíše 10x 'Ahoj!\n• 2. Zadáme hodnotu a vypíše to tolikrát 'Ahoj'\n• Sudá čísla od 0 do 100\n• Druhá mocnina od 10 do 20", "Oznámení");
        }

        private void vyčistit1PráciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zadat1.Clear();
            list1.Items.Clear();
        }

        private void vyčistit2PráciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list2.Items.Clear();
        }

        private void vyčistit3PráciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            panel1.Refresh();
            zadat2.Clear();
        }

        private void vyčistit4PráciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            zadat3.Clear();
            label12.Text = "Výsledek";
        }

        private void vyčistit5PráciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list3.Items.Clear();
            zadat4.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Zadejte hodnotu pro čtverec:";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Zadejte hodnotu pro kruh:";
        }
    }
}
