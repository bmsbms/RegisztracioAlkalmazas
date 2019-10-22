namespace RegisztracioAlkalmazas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nev_label = new System.Windows.Forms.Label();
            this.szulDatum_label = new System.Windows.Forms.Label();
            this.neme_label = new System.Windows.Forms.Label();
            this.kedvencHobbi_label = new System.Windows.Forms.Label();
            this.ujHobbi_label = new System.Windows.Forms.Label();
            this.hobbi_listBox = new System.Windows.Forms.ListBox();
            this.nev_TextBox = new System.Windows.Forms.TextBox();
            this.szulDatum_textbox = new System.Windows.Forms.TextBox();
            this.ujHobbi_textbox = new System.Windows.Forms.TextBox();
            this.F_radioButton = new System.Windows.Forms.RadioButton();
            this.N_radioButton = new System.Windows.Forms.RadioButton();
            this.hozzaad_button = new System.Windows.Forms.Button();
            this.mentes_button = new System.Windows.Forms.Button();
            this.betoltes_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nev_label
            // 
            this.nev_label.AutoSize = true;
            this.nev_label.Location = new System.Drawing.Point(6, 27);
            this.nev_label.Name = "nev_label";
            this.nev_label.Size = new System.Drawing.Size(30, 13);
            this.nev_label.TabIndex = 0;
            this.nev_label.Text = "Név:";
            // 
            // szulDatum_label
            // 
            this.szulDatum_label.AutoSize = true;
            this.szulDatum_label.Location = new System.Drawing.Point(6, 59);
            this.szulDatum_label.Name = "szulDatum_label";
            this.szulDatum_label.Size = new System.Drawing.Size(86, 13);
            this.szulDatum_label.TabIndex = 1;
            this.szulDatum_label.Text = "Születési Dátum:";
            // 
            // neme_label
            // 
            this.neme_label.AutoSize = true;
            this.neme_label.Location = new System.Drawing.Point(6, 90);
            this.neme_label.Name = "neme_label";
            this.neme_label.Size = new System.Drawing.Size(32, 13);
            this.neme_label.TabIndex = 2;
            this.neme_label.Text = "Nem:";
            // 
            // kedvencHobbi_label
            // 
            this.kedvencHobbi_label.AutoSize = true;
            this.kedvencHobbi_label.Location = new System.Drawing.Point(490, 27);
            this.kedvencHobbi_label.Name = "kedvencHobbi_label";
            this.kedvencHobbi_label.Size = new System.Drawing.Size(81, 13);
            this.kedvencHobbi_label.TabIndex = 3;
            this.kedvencHobbi_label.Text = "Kedvent Hobbi:";
            // 
            // ujHobbi_label
            // 
            this.ujHobbi_label.AutoSize = true;
            this.ujHobbi_label.Location = new System.Drawing.Point(16, 26);
            this.ujHobbi_label.Name = "ujHobbi_label";
            this.ujHobbi_label.Size = new System.Drawing.Size(49, 13);
            this.ujHobbi_label.TabIndex = 4;
            this.ujHobbi_label.Text = "Új hobbi:";
            // 
            // hobbi_listBox
            // 
            this.hobbi_listBox.FormattingEnabled = true;
            this.hobbi_listBox.Location = new System.Drawing.Point(493, 54);
            this.hobbi_listBox.Name = "hobbi_listBox";
            this.hobbi_listBox.Size = new System.Drawing.Size(276, 199);
            this.hobbi_listBox.TabIndex = 5;
            // 
            // nev_TextBox
            // 
            this.nev_TextBox.Location = new System.Drawing.Point(107, 24);
            this.nev_TextBox.Name = "nev_TextBox";
            this.nev_TextBox.Size = new System.Drawing.Size(100, 20);
            this.nev_TextBox.TabIndex = 6;
            // 
            // szulDatum_textbox
            // 
            this.szulDatum_textbox.Location = new System.Drawing.Point(107, 56);
            this.szulDatum_textbox.Name = "szulDatum_textbox";
            this.szulDatum_textbox.Size = new System.Drawing.Size(100, 20);
            this.szulDatum_textbox.TabIndex = 7;
            // 
            // ujHobbi_textbox
            // 
            this.ujHobbi_textbox.Location = new System.Drawing.Point(66, 23);
            this.ujHobbi_textbox.Name = "ujHobbi_textbox";
            this.ujHobbi_textbox.Size = new System.Drawing.Size(100, 20);
            this.ujHobbi_textbox.TabIndex = 8;
            // 
            // F_radioButton
            // 
            this.F_radioButton.AutoSize = true;
            this.F_radioButton.Location = new System.Drawing.Point(107, 90);
            this.F_radioButton.Name = "F_radioButton";
            this.F_radioButton.Size = new System.Drawing.Size(31, 17);
            this.F_radioButton.TabIndex = 9;
            this.F_radioButton.TabStop = true;
            this.F_radioButton.Text = "F";
            this.F_radioButton.UseVisualStyleBackColor = true;
            // 
            // N_radioButton
            // 
            this.N_radioButton.AutoSize = true;
            this.N_radioButton.Location = new System.Drawing.Point(174, 90);
            this.N_radioButton.Name = "N_radioButton";
            this.N_radioButton.Size = new System.Drawing.Size(33, 17);
            this.N_radioButton.TabIndex = 10;
            this.N_radioButton.TabStop = true;
            this.N_radioButton.Text = "N";
            this.N_radioButton.UseVisualStyleBackColor = true;
            // 
            // hozzaad_button
            // 
            this.hozzaad_button.Location = new System.Drawing.Point(91, 49);
            this.hozzaad_button.Name = "hozzaad_button";
            this.hozzaad_button.Size = new System.Drawing.Size(75, 23);
            this.hozzaad_button.TabIndex = 11;
            this.hozzaad_button.Text = "Hozzáad";
            this.hozzaad_button.UseVisualStyleBackColor = true;
            this.hozzaad_button.Click += new System.EventHandler(this.Hozzaad_button_Click);
            // 
            // mentes_button
            // 
            this.mentes_button.Location = new System.Drawing.Point(19, 111);
            this.mentes_button.Name = "mentes_button";
            this.mentes_button.Size = new System.Drawing.Size(75, 23);
            this.mentes_button.TabIndex = 12;
            this.mentes_button.Text = "Mentés";
            this.mentes_button.UseVisualStyleBackColor = true;
            this.mentes_button.Click += new System.EventHandler(this.Mentes_button_Click);
            // 
            // betoltes_button
            // 
            this.betoltes_button.Location = new System.Drawing.Point(100, 111);
            this.betoltes_button.Name = "betoltes_button";
            this.betoltes_button.Size = new System.Drawing.Size(75, 23);
            this.betoltes_button.TabIndex = 13;
            this.betoltes_button.Text = "Betöltés";
            this.betoltes_button.UseVisualStyleBackColor = true;
            this.betoltes_button.Click += new System.EventHandler(this.Betoltes_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nev_label);
            this.groupBox1.Controls.Add(this.szulDatum_label);
            this.groupBox1.Controls.Add(this.neme_label);
            this.groupBox1.Controls.Add(this.nev_TextBox);
            this.groupBox1.Controls.Add(this.N_radioButton);
            this.groupBox1.Controls.Add(this.szulDatum_textbox);
            this.groupBox1.Controls.Add(this.F_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 178);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ujHobbi_label);
            this.groupBox2.Controls.Add(this.ujHobbi_textbox);
            this.groupBox2.Controls.Add(this.betoltes_button);
            this.groupBox2.Controls.Add(this.hozzaad_button);
            this.groupBox2.Controls.Add(this.mentes_button);
            this.groupBox2.Location = new System.Drawing.Point(493, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 146);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hobbi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hobbi_listBox);
            this.Controls.Add(this.kedvencHobbi_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label nev_label;
        private System.Windows.Forms.Label szulDatum_label;
        private System.Windows.Forms.Label neme_label;
        private System.Windows.Forms.Label kedvencHobbi_label;
        private System.Windows.Forms.Label ujHobbi_label;
        private System.Windows.Forms.ListBox hobbi_listBox;
        private System.Windows.Forms.TextBox nev_TextBox;
        private System.Windows.Forms.TextBox szulDatum_textbox;
        private System.Windows.Forms.TextBox ujHobbi_textbox;
        private System.Windows.Forms.RadioButton F_radioButton;
        private System.Windows.Forms.RadioButton N_radioButton;
        private System.Windows.Forms.Button hozzaad_button;
        private System.Windows.Forms.Button mentes_button;
        private System.Windows.Forms.Button betoltes_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

