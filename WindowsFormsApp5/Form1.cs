using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucet = 0;
            int pocet_zapornych_cisel = 0;
            bool test = false;
            foreach (string line in textBox1.Lines)
            {
                try
                {
                    int cislo = int.Parse(line);
                    if (cislo < 0)
                    {
                        checked { soucet += cislo; }
                        pocet_zapornych_cisel++;
                    }
                }
                catch (OverflowException er)
                {
                    MessageBox.Show("prosime o zadání menších čísel\n" + er.Message);
                    test = true;
                    break;
                }
                catch (FormatException)
                {
                    soucet += 0;
                }
            }
            try
            {
                if(test == false)
                {
                    float finish = 0f;
                    checked { finish = ((float)soucet / (float)pocet_zapornych_cisel); }
                    MessageBox.Show("soucet všech lichých čísel je: " + soucet + "\n pocet cisel je: " + pocet_zapornych_cisel + "\n\n a artimeticky prumer je: " + finish);
                }
            }
            catch(DivideByZeroException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
