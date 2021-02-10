using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakKolokvijum1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string OtvoriFajl(string ImeFajla)
        {
            string SadrzajFajla = "";
            try
            {
                StreamReader sr = new StreamReader(ImeFajla);
                SadrzajFajla = sr.ReadToEnd();
                sr.Close();
                return SadrzajFajla;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }
        }

        public bool SnimiFajl(string ImeFajla, string Sadrzaj)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ImeFajla);
                sw.Write(txtSadrzaj.Text);
                sw.Flush();
                sw.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void btnZavrsiProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnOtvoriFajl_Click(object sender, EventArgs e)
        {
            dlgOpen.Title = "Otvori fajl";
            dlgOpen.Filter = "Tekst fajlovi|*.txt|CSV fajlovi|*.csv";
            if (dlgOpen.ShowDialog() == DialogResult.Cancel) return;
            txtSadrzaj.Text = OtvoriFajl(dlgOpen.FileName);
        }

        private void btnSnimiFajl_Click(object sender, EventArgs e)
        {
            dlgSave.Title = "Snimi fajl";
            dlgSave.Filter = "Tekst fajlovi|*.txt|CSV fajlovi|*.csv";
            if (dlgSave.ShowDialog() == DialogResult.Cancel) return;
            SnimiFajl(dlgSave.FileName, txtSadrzaj.Text);
            MessageBox.Show("Snimljeno", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPronadjiZameni_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSadrzaj.Text == "")
                {
                    MessageBox.Show("Ne postoji tekst koji bi mogao da se zameni!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPronadji.Text == "")
                {
                    MessageBox.Show("Morate uneti tekst u polje za pretragu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtZameni.Text == "")
                {
                    MessageBox.Show("Morate uneti tekst u polje za zamenu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txtSadrzaj.Text.Contains(txtPronadji.Text) == false)
                {
                    MessageBox.Show("Tekst za pretragu koji ste uneli ne postoji u fajlu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtSadrzaj.Text = txtSadrzaj.Text.Replace(txtPronadji.Text, txtZameni.Text);
                    MessageBox.Show("Uspesno zamenjeno!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}