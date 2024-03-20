
using Online_Rezervacija_hotela_MAIN;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Online_rezervacija_hotela_MAIN
{
    public partial class SobaForm : Form
    {

        PodatkovniKontekst kontekst;
        List<Soba> sobaPrikaz = new List<Soba>();
        public SobaForm()
        {
            InitializeComponent();
            this.kontekst = new PodatkovniKontekst();

        }



        private void DodajButton_Click(object sender, EventArgs e)
        {
            new Dodaj_soba().Show();

        }

        private void UrediButton_Click(object sender, EventArgs e)
        {
            new Uredi().Show();
        }

        private void RefreshSobe()
        {
            ListBoxSoba.Items.Clear();


            List<Soba> soba = this.kontekst.UcitajSobu();

            if (sobaPrikaz.Count>0)
            {
                foreach (Soba s in sobaPrikaz)
                {
                    ListBoxSoba.Items.Add(s);
                }
            }
            else
            {
                foreach (Soba s in soba)
                {
                    ListBoxSoba.Items.Add(s);
                }
            }
        }
        private void Soba_Load(object sender, EventArgs e)
        {

            RefreshSobe();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshSobe();

        }

        private void SearchSoba_TextChanged(object sender, EventArgs e)
        {
            
            sobaPrikaz.Clear();
            List<Soba> sobaKomplet = this.kontekst.UcitajSobu();

            foreach (Soba s in sobaKomplet)
                if(s.TipSobe.Contains(SearchSoba.Text.ToLower())) sobaPrikaz.Add(s);

            RefreshSobe() ;
        }

        private void FilterSoba_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}