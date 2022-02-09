using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolekcijaPodaci
{
    public partial class Form1 : Form
    {
        List<Podatci> podatci = new List<Podatci>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Podatci podatak = new Podatci(txtPodatak1.Text, txtPodatak2.Text,txtPodatak3.Text, cmbPodatak4.Text);
                podatci.Add(podatak);
                txtPodatak1.Clear();
                txtPodatak2.Clear();
                txtPodatak3.Clear();
               
               
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos!\r\n" +
                    greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txtPodatak1 == null)
            {
                MessageBox.Show("Pogrešan unos!\r\n" + "Greška",null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            rtbIspis.Text = "Podatak1 " + "\t\tPodatak2" + "\t\tPodatak3"+ "\t\t Podatak4"+ "\t\t Dodatak\r\n";
            foreach (Podatci podatak in podatci)
            {
                rtbIspis.AppendText(podatak.ToString() + "\r\n");

            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach (Podatci podatak in podatci)
            {
                if (podatak.Podatak4 == "M")
                {
                    podatak.Podatak4= "Ima brkove";
                }

                else
                {
                    podatak.Podatak4 = "Nema brkove";
                }
                
            
            }
/*
            rtbIspis.AppendText("------- Obrada--------\r\n");
            foreach (Podatci podatak in podatci)
            {
                rtbIspis.AppendText(podatak.ToString() + "\r\n");

            }
*/
        }
    }
}

