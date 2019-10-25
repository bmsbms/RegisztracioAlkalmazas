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
                     

                     sw.Write(nev_TextBox.Text+ ";"); //név
                     sw.Write(szulDatum_textbox.Text+ ";"); //szüldatum
                     if (F_radioButton.Checked)
                     {
                         sw.Write(F_radioButton.Text+";"); // Férfi
                     }
                     else
                     {
                         sw.Write(N_radioButton.Text+";"); //nő
                     }

                     sw.Write(hobbi_listBox.SelectedItem.ToString()+";"); //hobbi

                     foreach (var item in hobbi_listBox.Items)
                     {
                         sw.Write(item+","); //lista
                     }
                     
                   //  sw.Write(";");
                     
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
                    string[] beolvasottAdatok = new string[5];
                    string beolvasottak = sr.ReadLine();
                  //  while (beolvasottak!= null)
                    {
                        
                         beolvasottAdatok = beolvasottak.Split(';');
                         string nev = beolvasottAdatok[0];
                         string szulDatum = beolvasottAdatok[1];
                         string radioButton = beolvasottAdatok[2];
                         string kivalasztottHobbi = beolvasottAdatok[3];
                        // string hobbiListaBox = beolvasottAdatok[4];
                         

                        nev_TextBox.Text = nev;
                        szulDatum_textbox.Text = szulDatum;
                        if (radioButton=="F")
                        {
                            F_radioButton.Checked = true;
                        }
                        else
                        {
                            N_radioButton.Checked = true;
                        }
                        ujHobbi_textbox.Text = kivalasztottHobbi;

                        hobbi_listBox.Items.Clear();
                        string[] spliteltHobbik = beolvasottAdatok[4].Split(',');
                        foreach (var item in spliteltHobbik)
                        {
                            hobbi_listBox.Items.Add(item);
                        }
                        

                    }
                    

                    sr.Close();
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
