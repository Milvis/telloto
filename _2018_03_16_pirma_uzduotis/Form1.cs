using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_03_16_pirma_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textZ1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            
            List<int> M = generuoja_kamuoliukus(1,16,5);
            List<int> J = generuoja_kamuoliukus(16, 31,5);
            List<int> R = generuoja_kamuoliukus(31, 46,5);
            List<int> G = generuoja_kamuoliukus(46, 61,5);
            List<int> Z = generuoja_kamuoliukus(61, 76,5);

            int[] masyvo = M.ToArray();
            textM1.Text = Convert.ToString(masyvo[0]);
            textM2.Text = Convert.ToString(masyvo[1]);
            textM3.Text = Convert.ToString(masyvo[2]);
            textM4.Text = Convert.ToString(masyvo[3]);
            textM5.Text = Convert.ToString(masyvo[4]);

            int[] masyJ = J.ToArray();
            textJ1.Text = Convert.ToString(masyJ[0]);
            textJ2.Text = Convert.ToString(masyJ[1]);
            textJ3.Text = Convert.ToString(masyJ[2]);
            textJ4.Text = Convert.ToString(masyJ[3]);
            textJ5.Text = Convert.ToString(masyJ[4]);

            int[] masyvoR = R.ToArray();
            textR1.Text = Convert.ToString(masyvoR[0]);
            textR2.Text = Convert.ToString(masyvoR[1]);
            textR3.Text = Convert.ToString(masyvoR[2]);
            textR4.Text = Convert.ToString(masyvoR[3]);
            textR5.Text = Convert.ToString(masyvoR[4]);

            int[] masyvoG = G.ToArray();
            textG1.Text = Convert.ToString(masyvoG[0]);
            textG2.Text = Convert.ToString(masyvoG[1]);
            textG3.Text = Convert.ToString(masyvoG[2]);
            textG4.Text = Convert.ToString(masyvoG[3]);
            textG5.Text = Convert.ToString(masyvoG[4]);

            int[] masyvoZ = Z.ToArray();
            textZ1.Text = Convert.ToString(masyvoZ[0]);
            textZ2.Text = Convert.ToString(masyvoZ[1]);
            textZ3.Text = Convert.ToString(masyvoZ[2]);
            textZ4.Text = Convert.ToString(masyvoZ[3]);
            textZ5.Text = Convert.ToString(masyvoZ[4]);
        }


        //kuriam metoda
        private List<int> generuoja_kamuoliukus(int a, int b,int kiekis)
        {
            List<int> darbui = new List<int>();
            Random rng = new Random();
            
            int ieskau = kiekis;

            while (ieskau != 0)
            {
                int temp = rng.Next(a, b);
                int flag = 0;
                foreach (int kam in darbui)
                {
                    if (kam == temp)
                    {
                        flag++; //kartojasi kamuoliukas
                    }
                }
                if (flag == 0)
                {
                    darbui.Add(temp); //nesikartoja
                    ieskau--;
                }
            }
            return darbui;

        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            List<int> zaidimas = generuoja_kamuoliukus(1, 76, 49); //auksinis kamuoliukas 49tas

           // isvedimas.Text = zaidimas.First().ToString();
            foreach (int temp in zaidimas)
            {
                chec_if_number(temp);
                isvedimas.Text += " " + temp.ToString();
            }
            
        }

        //kuriam metoda kuris patikrintu skaicius ir nuspalvintu atspetus skaicius
        private void chec_if_number(int sk)
        {
            if (sk<16)
            {
                if (sk.ToString()==textM1.Text)
                {
                    textM1.BackColor = Color.Green;
                }
                if (sk.ToString() == textM2.Text)
                {
                    textM2.BackColor = Color.Green;
                }
                if (sk.ToString() == textM3.Text)
                {
                    textM3.BackColor = Color.Green;
                }
                if (sk.ToString() == textM4.Text)
                {
                    textM4.BackColor = Color.Green;
                }
            }
            else if (sk>15&&sk<31)
            {
                if (sk.ToString() == textJ1.Text)
                {
                    textJ1.BackColor = Color.Green;
                }
                if (sk.ToString() == textJ2.Text)
                {
                    textJ2.BackColor = Color.Green;
                }
                if (sk.ToString() == textJ3.Text)
                {
                    textJ3.BackColor = Color.Green;
                }
                if (sk.ToString() == textJ4.Text)
                {
                    textJ4.BackColor = Color.Green;
                }
                if (sk.ToString() == textJ5.Text)
                {
                    textJ5.BackColor = Color.Green;
                }
            }

            else if (sk>30&&sk<46)
            {
                if (sk.ToString() == textR1.Text)
                {
                    textR1.BackColor = Color.Green;
                }
                if (sk.ToString() == textR2.Text)
                {
                    textR2.BackColor = Color.Green;
                }
                if (sk.ToString() == textR3.Text)
                {
                    textR3.BackColor = Color.Green;
                }
                if (sk.ToString() == textR4.Text)
                {
                    textR4.BackColor = Color.Green;
                }
                if (sk.ToString() == textR5.Text)
                {
                    textR5.BackColor = Color.Green;
                }
            }

            else if (sk>45&&sk<61)
            {
                if (sk.ToString() == textG1.Text)
                {
                    textG1.BackColor = Color.Green;
                }
                if (sk.ToString() == textG2.Text)
                {
                    textG2.BackColor = Color.Green;
                }
                if (sk.ToString() == textG3.Text)
                {
                    textG3.BackColor = Color.Green;
                }
                if (sk.ToString() == textG4.Text)
                {
                    textG4.BackColor = Color.Green;
                }
                if (sk.ToString() == textG5.Text)
                {
                    textG5.BackColor = Color.Green;
                }
            }

            else if (sk>60&&sk<76)
            {
                if (sk.ToString() == textZ1.Text)
                {
                    textZ1.BackColor = Color.Green;
                }
                if (sk.ToString() == textZ2.Text)
                {
                    textZ2.BackColor = Color.Green;
                }
                if (sk.ToString() == textZ3.Text)
                {
                    textZ3.BackColor = Color.Green;
                }
                if (sk.ToString() == textZ4.Text)
                {
                    textZ4.BackColor = Color.Green;
                }
                if (sk.ToString() == textZ5.Text)
                {
                    textZ5.BackColor = Color.Green;
                }
            }
        }
    }     
}
