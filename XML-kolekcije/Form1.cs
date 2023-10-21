using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XML_kolekcije
{
    public partial class Form1 : Form
    {
        List<Vozilo> vozila = new List<Vozilo>();
        Motocikl motor;
        Automobil auto;
        Kamion kamion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var file = new FileInfo(@"baza\vozila.xml");
            if(file.Length>0)
            {

            }

        }

        private void Load_XML()
        {
            var document = XDocument.Load(@"baza\vozila.xml");

            var vozila = document.Root.Descendants("Vozilo")
                .Select(x=>new Vozilo
                {
                    Model = x.Element("Model").Value,
                    BrKotaca = Convert.ToInt32(x.Element("BrKotaca").Value),

                })
            
        }

        private void Main_Close(object sender, EventArgs e)
        {
            StvoriXML();
        }

        private void StvoriXML()
        {
            XDocument document = XDocument.Load(@"baza\vozila.xml");

            var dokumentXmlVozila = new XDocument(new XElement("Vozila",
                from vozilo in vozila
                select new XElement("Vozilo",
                    new XElement("Model", vozilo.Model),
                    new XElement("BrKotaca", vozilo.BrKotaca),
                    new XElement("Godina", vozilo.Godina),
                    new XElement("Kategorija", vozilo.Kategorija)
                    )));

            document.Save(Convert.ToString(dokumentXmlVozila));

        }

        private void txtGod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtGod.Text, "[^0-9]"))
                {
                    txtGod.Text = txtGod.Text.Remove(txtGod.Text.Length - 1);
                    MessageBox.Show("Molim upisite samo brojeve.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (FormatException ex) { }
        }

        private void txtKotac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtKotac.Text, "[^0-9]"))
                {
                    txtKotac.Text = txtKotac.Text.Remove(txtKotac.Text.Length - 1);
                    MessageBox.Show("Molim upisite samo brojeve.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (Convert.ToInt32(txtKotac.Text) % 2 != 0)
                {
                    txtKotac.Text = null;
                    MessageBox.Show("Molim upisite parni broj.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException ex) { }
        }

        private void txtIspisClicked(object sender, EventArgs e)
        {
            this.ActiveControl= null;
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtKotac.Text) == 2)
                {
                    this.motor = new Motocikl(txtModel.Text, Convert.ToInt32(txtKotac.Text), Convert.ToInt64(txtGod.Text));
                }
                else if (Convert.ToInt32(txtKotac.Text) == 4)
                {
                    this.auto = new Automobil(txtModel.Text, Convert.ToInt32(txtKotac.Text), Convert.ToInt64(txtGod.Text));
                }
                else if (Convert.ToInt32(txtKotac.Text) > 4)
                {
                    this.kamion = new Kamion(txtModel.Text, Convert.ToInt32(txtKotac.Text), Convert.ToInt64(txtGod.Text));
                }
            }
            catch (FormatException ex) { }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtKotac.Text) == 2)
                {
                    vozila.Add(motor);
                }
                else if (Convert.ToInt32(txtKotac.Text) == 4)
                {
                    vozila.Add(auto);
                }
                else if (Convert.ToInt32(txtKotac.Text) > 4)
                {
                    vozila.Add(kamion);
                }

                txtModel.Clear();
                txtGod.Clear();
                txtKotac.Clear();
            }
            catch (FormatException ex) { }

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            foreach(var vozilo in vozila)
            {
                txtIspis.AppendText(vozilo.ToString());
            }
        }


    }
}
