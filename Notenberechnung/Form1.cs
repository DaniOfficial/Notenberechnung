using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notenberechnung
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button Click Programm

            if(SA1_1.Text == "")
            {
                SA1_1.Text = "0";
            }
            else
            {

            }
            if (SA1_2.Text == "")
            {
                SA1_2.Text = "0";
            }
            else
            {

            }

            //Fach1
            Fach1_Text.Text = Fach1.Text;
            
            //Überprüfung auf Notenanzahl
            int i = 0;
            if (Convert.ToDouble(SA1_1.Text) > 0)
            {
                i++;
            }
            if(Convert.ToDouble(SA1_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(SA1_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(SA1_4.Text) > 0)
            {
                i++;

            }
            double Fach1_Note_Berechnung = (Convert.ToDouble(SA1_1.Text) + Convert.ToDouble(SA1_2.Text) + Convert.ToDouble(SA1_3.Text) + Convert.ToDouble(SA1_4.Text)) / i;
            //Ausgabe mit Convertierung INT zu String
            Fach1_Note.Text = Convert.ToString(Fach1_Note_Berechnung);





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Trenner_Click(object sender, EventArgs e)
        {

        }

        private void Schulaufgabe_Text_Click(object sender, EventArgs e)
        {

        }

        private void Kurzarbeit_Text_Click(object sender, EventArgs e)
        {

        }

        private void Note1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
