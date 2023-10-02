using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XML_kolekcije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
