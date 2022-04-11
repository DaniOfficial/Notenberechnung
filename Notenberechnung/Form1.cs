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

            //Fächer
            Fach1_Text.Text = Fach1.Text;

            Fach2_Text.Text = Fach2.Text;

            Fach3_Text.Text = Fach3.Text;

            Fach4_Text.Text = Fach4.Text;

            Fach5_Text.Text = Fach5.Text;

            Fach6_Text.Text = Fach6.Text;

            Fach7_Text.Text = Fach7.Text;

            Fach8_Text.Text = Fach8.Text;


            //FACH1

            //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
            //Schulaufgaben
            if (SA1_1.Text == "")
            {
                SA1_1.Text = "0";
            }

            if (SA1_2.Text == "")
            {
                SA1_2.Text = "0";
            }

            if (SA1_3.Text == "")
            {
                SA1_3.Text = "0";
            }

            if (SA1_4.Text == "")
            {
                SA1_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA1_1.Text == "")
            {
                KA1_1.Text = "0";
            }

            if (KA1_2.Text == "")
            {
                KA1_2.Text = "0";
            }

            if (KA1_3.Text == "")
            {
                KA1_3.Text = "0";
            }

            if (KA1_4.Text == "")
            {
                KA1_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            int i = 0;
            
            //SA
            if (Convert.ToDouble(SA1_1.Text) > 0)
            {
                i++;
                i++;
            }
            if(Convert.ToDouble(SA1_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA1_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA1_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA1_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA1_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA1_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA1_4.Text) > 0)
            {
                i++;

            }

            double Fach1_Note_Berechnung = (((Convert.ToDouble(SA1_1.Text)*2) + (Convert.ToDouble(SA1_2.Text)*2) + (Convert.ToDouble(SA1_3.Text)*2) + (Convert.ToDouble(SA1_4.Text)*2) + Convert.ToDouble(KA1_1.Text) + Convert.ToDouble(KA1_2.Text) + Convert.ToDouble(KA1_3.Text) + Convert.ToDouble(KA1_4.Text) )/ i);
            //Ausgabe mit Convertierung Double zu String
            Fach1_Note.Text = Convert.ToString(Fach1_Note_Berechnung);


            if (Fach1_Note_Berechnung > 5.51)
            {

                Fach1_ZGNS.Text = "6";

            }
            else if (Fach1_Note_Berechnung > 4.51)
            {

                Fach1_ZGNS.Text = "5";

            }
            else if (Fach1_Note_Berechnung > 3.51)
            {

                Fach1_ZGNS.Text = "4";

            }
            else if (Fach1_Note_Berechnung > 2.51)
            {

                Fach1_ZGNS.Text = "3";

            }
            else if (Fach1_Note_Berechnung > 1.51)
            {

                Fach1_ZGNS.Text = "2";

            }
            else if (Fach1_Note_Berechnung > 0.51)
            {

                Fach1_ZGNS.Text = "1";
            }

                //FACH2

                //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
                //Schulaufgaben
                if (SA2_1.Text == "")
            {
                SA2_1.Text = "0";
            }

            if (SA2_2.Text == "")
            {
                SA2_2.Text = "0";
            }

            if (SA2_3.Text == "")
            {
                SA2_3.Text = "0";
            }

            if (SA2_4.Text == "")
            {
                SA2_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA2_1.Text == "")
            {
                KA2_1.Text = "0";
            }

            if (KA2_2.Text == "")
            {
                KA2_2.Text = "0";
            }

            if (KA2_3.Text == "")
            {
                KA2_3.Text = "0";
            }

            if (KA2_4.Text == "")
            {
                KA2_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            i = 0;

            //SA
            if (Convert.ToDouble(SA2_1.Text) > 0)
            {
                i++;
                i++;
            }
            if (Convert.ToDouble(SA2_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA2_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA2_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA2_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA2_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA2_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA2_4.Text) > 0)
            {
                i++;

            }

            double Fach2_Note_Berechnung = (((Convert.ToDouble(SA2_1.Text) * 2) + (Convert.ToDouble(SA2_2.Text) * 2) + (Convert.ToDouble(SA2_3.Text) * 2) + (Convert.ToDouble(SA2_4.Text) * 2) + Convert.ToDouble(KA2_1.Text) + Convert.ToDouble(KA2_2.Text) + Convert.ToDouble(KA2_3.Text) + Convert.ToDouble(KA2_4.Text)) / i);
            //Ausgabe mit Convertierung Double zu String
            Fach2_Note.Text = Convert.ToString(Fach2_Note_Berechnung);

            if (Fach2_Note_Berechnung > 5.51)
            {

                Fach2_ZGNS.Text = "6";

            }
            else if (Fach2_Note_Berechnung > 4.51)
            {

                Fach2_ZGNS.Text = "5";

            }
            else if (Fach2_Note_Berechnung > 3.51)
            {

                Fach2_ZGNS.Text = "4";

            }
            else if (Fach2_Note_Berechnung > 2.51)
            {

                Fach2_ZGNS.Text = "3";

            }
            else if (Fach2_Note_Berechnung > 1.51)
            {

                Fach2_ZGNS.Text = "2";

            }
            else if (Fach2_Note_Berechnung > 0.51)
            {

                Fach2_ZGNS.Text = "1";
            }

            //FACH3

            //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
            //Schulaufgaben
            if (SA3_1.Text == "")
            {
                SA3_1.Text = "0";
            }

            if (SA3_2.Text == "")
            {
                SA3_2.Text = "0";
            }

            if (SA3_3.Text == "")
            {
                SA3_3.Text = "0";
            }

            if (SA3_4.Text == "")
            {
                SA3_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA3_1.Text == "")
            {
                KA3_1.Text = "0";
            }

            if (KA3_2.Text == "")
            {
                KA3_2.Text = "0";
            }

            if (KA3_3.Text == "")
            {
                KA3_3.Text = "0";
            }

            if (KA3_4.Text == "")
            {
                KA3_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            i = 0;

            //SA
            if (Convert.ToDouble(SA3_1.Text) > 0)
            {
                i++;
                i++;
            }
            if (Convert.ToDouble(SA3_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA3_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA3_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA3_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA3_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA3_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA3_4.Text) > 0)
            {
                i++;

            }

            double Fach3_Note_Berechnung = (((Convert.ToDouble(SA3_1.Text) * 2) + (Convert.ToDouble(SA3_2.Text) * 2) + (Convert.ToDouble(SA3_3.Text) * 2) + (Convert.ToDouble(SA3_4.Text) * 2) + Convert.ToDouble(KA3_1.Text) + Convert.ToDouble(KA3_2.Text) + Convert.ToDouble(KA3_3.Text) + Convert.ToDouble(KA3_4.Text)) / i);
            //Ausgabe mit Convertierung INT zu String
            Fach3_Note.Text = Convert.ToString(Fach3_Note_Berechnung);

            if (Fach3_Note_Berechnung > 5.51)
            {

                Fach3_ZGNS.Text = "6";

            }
            else if (Fach3_Note_Berechnung > 4.51)
            {

                Fach3_ZGNS.Text = "5";

            }
            else if (Fach3_Note_Berechnung > 3.51)
            {

                Fach3_ZGNS.Text = "4";

            }
            else if (Fach3_Note_Berechnung > 2.51)
            {

                Fach3_ZGNS.Text = "3";

            }
            else if (Fach3_Note_Berechnung > 1.51)
            {

                Fach3_ZGNS.Text = "2";

            }
            else if (Fach3_Note_Berechnung > 0.51)
            {

                Fach3_ZGNS.Text = "1";
            }

            //FACH4

            //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
            //Schulaufgaben
            if (SA4_1.Text == "")
            {
                SA4_1.Text = "0";
            }

            if (SA4_2.Text == "")
            {
                SA4_2.Text = "0";
            }

            if (SA4_3.Text == "")
            {
                SA4_3.Text = "0";
            }

            if (SA4_4.Text == "")
            {
                SA4_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA4_1.Text == "")
            {
                KA4_1.Text = "0";
            }

            if (KA4_2.Text == "")
            {
                KA4_2.Text = "0";
            }

            if (KA4_3.Text == "")
            {
                KA4_3.Text = "0";
            }

            if (KA4_4.Text == "")
            {
                KA4_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            i = 0;

            //SA
            if (Convert.ToDouble(SA4_1.Text) > 0)
            {
                i++;
                i++;
            }
            if (Convert.ToDouble(SA4_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA4_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA4_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA4_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA4_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA4_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA4_4.Text) > 0)
            {
                i++;

            }

            double Fach4_Note_Berechnung = (((Convert.ToDouble(SA4_1.Text) * 2) + (Convert.ToDouble(SA4_2.Text) * 2) + (Convert.ToDouble(SA4_3.Text) * 2) + (Convert.ToDouble(SA4_4.Text) * 2) + Convert.ToDouble(KA4_1.Text) + Convert.ToDouble(KA4_2.Text) + Convert.ToDouble(KA4_3.Text) + Convert.ToDouble(KA4_4.Text)) / i);
            //Ausgabe mit Convertierung INT zu String
            Fach4_Note.Text = Convert.ToString(Fach4_Note_Berechnung);

            if (Fach4_Note_Berechnung > 5.51)
            {

                Fach4_ZGNS.Text = "6";

            }
            else if (Fach4_Note_Berechnung > 4.51)
            {

                Fach4_ZGNS.Text = "5";

            }
            else if (Fach4_Note_Berechnung > 3.51)
            {

                Fach4_ZGNS.Text = "4";

            }
            else if (Fach4_Note_Berechnung > 2.51)
            {

                Fach4_ZGNS.Text = "3";

            }
            else if (Fach4_Note_Berechnung > 1.51)
            {

                Fach4_ZGNS.Text = "2";

            }
            else if (Fach4_Note_Berechnung > 0.51)
            {

                Fach4_ZGNS.Text = "1";
            }

            //FACH5

            //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
            //Schulaufgaben
            if (SA5_1.Text == "")
            {
                SA5_1.Text = "0";
            }

            if (SA5_2.Text == "")
            {
                SA5_2.Text = "0";
            }

            if (SA5_3.Text == "")
            {
                SA5_3.Text = "0";
            }

            if (SA5_4.Text == "")
            {
                SA5_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA5_1.Text == "")
            {
                KA5_1.Text = "0";
            }

            if (KA5_2.Text == "")
            {
                KA5_2.Text = "0";
            }

            if (KA5_3.Text == "")
            {
                KA5_3.Text = "0";
            }

            if (KA5_4.Text == "")
            {
                KA5_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            i = 0;

            //SA
            if (Convert.ToDouble(SA5_1.Text) > 0)
            {
                i++;
                i++;
            }
            if (Convert.ToDouble(SA5_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA5_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA5_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA5_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA5_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA5_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA5_4.Text) > 0)
            {
                i++;

            }

            double Fach5_Note_Berechnung = (((Convert.ToDouble(SA5_1.Text) * 2) + (Convert.ToDouble(SA5_2.Text) * 2) + (Convert.ToDouble(SA5_3.Text) * 2) + (Convert.ToDouble(SA5_4.Text) * 2) + Convert.ToDouble(KA5_1.Text) + Convert.ToDouble(KA5_2.Text) + Convert.ToDouble(KA5_3.Text) + Convert.ToDouble(KA5_4.Text)) / i);
            //Ausgabe mit Convertierung INT zu String
            Fach5_Note.Text = Convert.ToString(Fach5_Note_Berechnung);

            if (Fach5_Note_Berechnung > 5.51)
            {

                Fach5_ZGNS.Text = "6";

            }
            else if (Fach5_Note_Berechnung > 4.51)
            {

                Fach5_ZGNS.Text = "5";

            }
            else if (Fach5_Note_Berechnung > 3.51)
            {

                Fach5_ZGNS.Text = "4";

            }
            else if (Fach5_Note_Berechnung > 2.51)
            {

                Fach5_ZGNS.Text = "3";

            }
            else if (Fach5_Note_Berechnung > 1.51)
            {

                Fach5_ZGNS.Text = "2";

            }
            else if (Fach5_Note_Berechnung > 0.51)
            {

                Fach5_ZGNS.Text = "1";
            }

            //FACH6

            //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
            //Schulaufgaben
            if (SA6_1.Text == "")
            {
                SA6_1.Text = "0";
            }

            if (SA6_2.Text == "")
            {
                SA6_2.Text = "0";
            }

            if (SA6_3.Text == "")
            {
                SA6_3.Text = "0";
            }

            if (SA6_4.Text == "")
            {
                SA6_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA6_1.Text == "")
            {
                KA6_1.Text = "0";
            }

            if (KA6_2.Text == "")
            {
                KA6_2.Text = "0";
            }

            if (KA6_3.Text == "")
            {
                KA6_3.Text = "0";
            }

            if (KA6_4.Text == "")
            {
                KA6_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            i = 0;

            //SA
            if (Convert.ToDouble(SA6_1.Text) > 0)
            {
                i++;
                i++;
            }
            if (Convert.ToDouble(SA6_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA6_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA6_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA6_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA6_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA6_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA6_4.Text) > 0)
            {
                i++;

            }

            double Fach6_Note_Berechnung = (((Convert.ToDouble(SA6_1.Text) * 2) + (Convert.ToDouble(SA6_2.Text) * 2) + (Convert.ToDouble(SA6_3.Text) * 2) + (Convert.ToDouble(SA6_4.Text) * 2) + Convert.ToDouble(KA6_1.Text) + Convert.ToDouble(KA6_2.Text) + Convert.ToDouble(KA6_3.Text) + Convert.ToDouble(KA6_4.Text)) / i);
            //Ausgabe mit Convertierung Double zu String
            Fach6_Note.Text = Convert.ToString(Fach6_Note_Berechnung);

            if (Fach6_Note_Berechnung > 5.51)
            {

                Fach6_ZGNS.Text = "6";

            }
            else if (Fach6_Note_Berechnung > 4.51)
            {

                Fach6_ZGNS.Text = "5";

            }
            else if (Fach6_Note_Berechnung > 3.51)
            {

                Fach6_ZGNS.Text = "4";

            }
            else if (Fach6_Note_Berechnung > 2.51)
            {

                Fach6_ZGNS.Text = "3";

            }
            else if (Fach6_Note_Berechnung > 1.51)
            {

                Fach6_ZGNS.Text = "2";

            }
            else if (Fach6_Note_Berechnung > 0.51)
            {

                Fach6_ZGNS.Text = "1";
            }

            //FACH7

            //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
            //Schulaufgaben
            if (SA7_1.Text == "")
            {
                SA7_1.Text = "0";
            }

            if (SA7_2.Text == "")
            {
                SA7_2.Text = "0";
            }

            if (SA7_3.Text == "")
            {
                SA7_3.Text = "0";
            }

            if (SA7_4.Text == "")
            {
                SA7_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA7_1.Text == "")
            {
                KA7_1.Text = "0";
            }

            if (KA7_2.Text == "")
            {
                KA7_2.Text = "0";
            }

            if (KA7_3.Text == "")
            {
                KA7_3.Text = "0";
            }

            if (KA7_4.Text == "")
            {
                KA7_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            i = 0;

            //SA
            if (Convert.ToDouble(SA7_1.Text) > 0)
            {
                i++;
                i++;
            }
            if (Convert.ToDouble(SA7_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA7_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA7_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA7_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA7_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA7_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA7_4.Text) > 0)
            {
                i++;

            }

            double Fach7_Note_Berechnung = (((Convert.ToDouble(SA7_1.Text) * 2) + (Convert.ToDouble(SA7_2.Text) * 2) + (Convert.ToDouble(SA7_3.Text) * 2) + (Convert.ToDouble(SA7_4.Text) * 2) + Convert.ToDouble(KA7_1.Text) + Convert.ToDouble(KA7_2.Text) + Convert.ToDouble(KA7_3.Text) + Convert.ToDouble(KA7_4.Text)) / i);
            //Ausgabe mit Convertierung Double zu String
            Fach7_Note.Text = Convert.ToString(Fach7_Note_Berechnung);

            if (Fach7_Note_Berechnung > 5.51)
            {

                Fach7_ZGNS.Text = "6";

            }
            else if (Fach7_Note_Berechnung > 4.51)
            {

                Fach7_ZGNS.Text = "5";

            }
            else if (Fach7_Note_Berechnung > 3.51)
            {

                Fach7_ZGNS.Text = "4";

            }
            else if (Fach7_Note_Berechnung > 2.51)
            {

                Fach7_ZGNS.Text = "3";

            }
            else if (Fach7_Note_Berechnung > 1.51)
            {

                Fach7_ZGNS.Text = "2";

            }
            else if (Fach7_Note_Berechnung > 0.51)
            {

                Fach7_ZGNS.Text = "1";
            }

            //FACH8

            //wenn ein Notenfeld leer ist wird es mit 0 gefüllt
            //Schulaufgaben
            if (SA8_1.Text == "")
            {
                SA8_1.Text = "0";
            }

            if (SA8_2.Text == "")
            {
                SA8_2.Text = "0";
            }

            if (SA8_3.Text == "")
            {
                SA8_3.Text = "0";
            }

            if (SA8_4.Text == "")
            {
                SA8_4.Text = "0";
            }

            //Kurzarbeiten
            if (KA8_1.Text == "")
            {
                KA8_1.Text = "0";
            }

            if (KA8_2.Text == "")
            {
                KA8_2.Text = "0";
            }

            if (KA8_3.Text == "")
            {
                KA8_3.Text = "0";
            }

            if (KA8_4.Text == "")
            {
                KA8_4.Text = "0";
            }

            //Überprüfung auf Notenanzahl

            i = 0;

            //SA
            if (Convert.ToDouble(SA8_1.Text) > 0)
            {
                i++;
                i++;
            }
            if (Convert.ToDouble(SA8_2.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA8_3.Text) > 0)
            {
                i++;
                i++;

            }
            if (Convert.ToDouble(SA8_4.Text) > 0)
            {
                i++;
                i++;

            }
            //KA
            if (Convert.ToDouble(KA8_1.Text) > 0)
            {
                i++;
            }
            if (Convert.ToDouble(KA8_2.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA8_3.Text) > 0)
            {
                i++;

            }
            if (Convert.ToDouble(KA8_4.Text) > 0)
            {
                i++;

            }

            double Fach8_Note_Berechnung = (((Convert.ToDouble(SA8_1.Text) * 2) + (Convert.ToDouble(SA8_2.Text) * 2) + (Convert.ToDouble(SA8_3.Text) * 2) + (Convert.ToDouble(SA8_4.Text) * 2) + Convert.ToDouble(KA8_1.Text) + Convert.ToDouble(KA8_2.Text) + Convert.ToDouble(KA8_3.Text) + Convert.ToDouble(KA8_4.Text)) / i);
            //Ausgabe mit Convertierung INT zu String
            Fach8_Note.Text = Convert.ToString(Fach8_Note_Berechnung);

            if (Fach8_Note_Berechnung > 5.51)
            {

                Fach8_ZGNS.Text = "6";

            }
            else if (Fach8_Note_Berechnung > 4.51)
            {

                Fach8_ZGNS.Text = "5";

            }
            else if (Fach8_Note_Berechnung > 3.51)
            {

                Fach8_ZGNS.Text = "4";

            }
            else if (Fach8_Note_Berechnung > 2.51)
            {

                Fach8_ZGNS.Text = "3";

            }
            else if (Fach8_Note_Berechnung > 1.51)
            {

                Fach8_ZGNS.Text = "2";

            }
            else if (Fach8_Note_Berechnung > 0.51)
            {

                Fach8_ZGNS.Text = "1";
            }

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
