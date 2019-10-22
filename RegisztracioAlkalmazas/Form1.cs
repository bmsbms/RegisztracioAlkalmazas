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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Fájlbaírás
            saveFileDialog1.FileOk += (sender, eFile) =>
             {
                 try
                 {
                     string filename = saveFileDialog1.FileName;
                     StreamWriter sw = new StreamWriter(filename);
                     

                     sw.WriteLine("Név: " + nev_TextBox.Text);
                     sw.WriteLine("Szül. Dátum: " + szulDatum_textbox.Text);
                     if (F_radioButton.Checked)
                     {
                         sw.WriteLine("Neme: " + F_radioButton.Text);
                     }
                     else
                     {
                         sw.WriteLine("Neme: " + N_radioButton.Text);
                     }

                     sw.WriteLine("Hobbija: " + hobbi_listBox.SelectedItem.ToString());
                 //    sw.WriteLine("Összes hobbi: " + hobbi_listBox.Items.Cast<String>().ToArray() + ",");
                
                     //nem jól irja ki---------------------------------------------------------------------------------

                     sw.Close();
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Hiba! Nem sikerült a kiírás.");
                     eFile.Cancel = true;
                 }
                 
             };


            //Fájlból beolvasás

            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    
                    nev_TextBox.Text = "";
                    szulDatum_textbox.Text = "";
                    hobbi_listBox.Text = "";
                    string[] beolvasottAdatok = new string[3];
                    string beolvasottak = sr.ReadLine();
                    while (beolvasottak!= null)
                    {
                        beolvasottAdatok = beolvasottak.Split(' ');
                        string nev = beolvasottAdatok[0];
                        string szulDatum = beolvasottAdatok[1];
                        string hobbiListaBox = beolvasottAdatok[2];

                    }
                    nev_TextBox.Text = beolvasottAdatok[0];
                    szulDatum_textbox.Text = beolvasottAdatok[1];
                    hobbi_listBox.Text = beolvasottAdatok[2];
                    //nem tudom beolvasni -----------------------------------------------------
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba! Nem sikerült a fájlt betölteni.");
                }
                
            };



        }

        private void Hozzaad_button_Click(object sender, EventArgs e)
        {
            hobbi_listBox.Items.Add(ujHobbi_textbox.Text);
            ujHobbi_textbox.Text = "";

        }

        private void Mentes_button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void Betoltes_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
