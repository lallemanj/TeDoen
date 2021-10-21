using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeDoen
{
    public partial class Form1 : Form
    {

        public delegate void Tonen(object te);

        public Form1()
        {
            InitializeComponent();
            dtp_Datum.Visible = false;

        }

        List<DateTime> datumLijst = new List<DateTime>();
        Rij<TeDoen> TeDoenRij = new Rij<TeDoen>();
        List<TeDoen> TeDoenRijGebruikbaar = new List<TeDoen>();

        List<System.Timers.Timer> timerLijst = new List<System.Timers.Timer>();

        public int krijgTijd()
        {
            TimeSpan wachttijd = dtp_Datum.Value - DateTime.Now;
            System.Threading.Thread.Sleep((int)wachttijd.TotalMinutes);
            return (int)wachttijd.TotalMilliseconds;
        }

        //private void toonInForm(object lijst)
        //{

        //    tbForm.Text = lijst.ToString();

        //}


        //private void toonInMessageBox(object lijst)
        //{

        //    MessageBox.Show(lijst.ToString());

        //}


        private void btn_MessageBox_Click(object sender, EventArgs e)
        {
            if (btn_MessageBox.Text == "MessageBox")
            {
                btn_MessageBox.Text = "Uit";
                btn_MessageBox.BackColor = Color.Red;
                //TeDoenRij.toon -= new Tonen(toonInMessageBox);

            }
            else
            {
                btn_MessageBox.Text = "MessageBox";
                btn_MessageBox.BackColor = Color.Green;
                //TeDoenRij.toon += new Tonen(toonInMessageBox);

            }
        }

        private void btn_Form_Click(object sender, EventArgs e)
        { 
         if (btn_Form.Text == "Toon form")
            {
                btn_Form.Text = "Uit";
                btn_Form.BackColor = Color.Red;
                //TeDoenRij.toon -= new Tonen(toonInForm);

            }
            else
            {
                btn_Form.Text = "Toon form";
                btn_Form.BackColor = Color.Green;
                //TeDoenRij.toon += new Tonen(toonInForm);

            }
        }

        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (dtp_Datum.Value > DateTime.Now)
                {

                    TeDoenRijGebruikbaar.Add(new TeDoen(dtp_Datum.Value, tbTitel.Text, tbOmschrijving.Lines));
                    datumLijst.Add(dtp_Datum.Value);
                    tbTitel.Text = null;
                    tbOmschrijving.Text = null;
                    //tbForm.Text = TeDoenRij.Toon().ToString();


                }
                else
                {
                    MessageBox.Show("Probeer opnieuw! Pik een tijdslot in de toekomst");
                }
                } else
                {

                TeDoenRij.toevoegenInRij(new TeDoen(tbTitel.Text, tbOmschrijving.Lines));
                tbTitel.Text = null;
                tbOmschrijving.Text = null;
                //tbForm.Text = TeDoenRij.Toon().ToString();

                }
            dtp_Datum.Value = DateTime.Now;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            
                dtp_Datum.Visible = true;
            else
                dtp_Datum.Visible = false;
        }

        private void btn_Volgende_Click(object sender, EventArgs e)
        {

            if (btn_Form.Text == "Toon form")
            {
                btn_Form.Text = "Toon form";
                btn_Form.BackColor = Color.Green;
                //TeDoenRij.toon += new Tonen(toonInForm);
                    tbForm.Text = TeDoenRij.Toon().ToString();

            }

            if (btn_Form.Text == "MessageBox")
            {
                btn_Form.Text = "MessageBox";
                btn_Form.BackColor = Color.Green;
                //TeDoenRij.toon += new Tonen(toonInForm);
                MessageBox.Show(TeDoenRij.ToString());

            }
        }

        private void btn_Achteraan_Click(object sender, EventArgs e)
        {
            TeDoenRij.achteraanInRij();
        }

        private void btn_VerwijderTaak_Click(object sender, EventArgs e)
        {
            TeDoenRij.verwijderenInRij();
        }


    }
}
