
namespace WindowsFormsApp1
{
    partial class Forna
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.Proiz = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_poslednji = new System.Windows.Forms.Button();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_prvi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(356, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(50, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(118, 38);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 20);
            this.txt_model.TabIndex = 4;
            // 
            // Proiz
            // 
            this.Proiz.FormattingEnabled = true;
            this.Proiz.Location = new System.Drawing.Point(12, 37);
            this.Proiz.Name = "Proiz";
            this.Proiz.Size = new System.Drawing.Size(100, 21);
            this.Proiz.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 227);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Proizvodjac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Registracija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Godiste";
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Location = new System.Drawing.Point(348, 382);
            this.btn_osvezi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(58, 28);
            this.btn_osvezi.TabIndex = 31;
            this.btn_osvezi.Text = "Refresh";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(16, 382);
            this.btn_obrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(58, 28);
            this.btn_obrisi.TabIndex = 30;
            this.btn_obrisi.Text = "Obrisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Location = new System.Drawing.Point(240, 382);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(58, 28);
            this.btn_izmeni.TabIndex = 29;
            this.btn_izmeni.Text = "Promeni";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(118, 382);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(58, 28);
            this.btn_dodaj.TabIndex = 28;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_poslednji
            // 
            this.btn_poslednji.Location = new System.Drawing.Point(348, 296);
            this.btn_poslednji.Margin = new System.Windows.Forms.Padding(2);
            this.btn_poslednji.Name = "btn_poslednji";
            this.btn_poslednji.Size = new System.Drawing.Size(52, 28);
            this.btn_poslednji.TabIndex = 27;
            this.btn_poslednji.Text = ">>";
            this.btn_poslednji.UseVisualStyleBackColor = true;
            this.btn_poslednji.Click += new System.EventHandler(this.btn_poslednji_Click);
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Location = new System.Drawing.Point(240, 296);
            this.btn_sledeci.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(33, 28);
            this.btn_sledeci.TabIndex = 26;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Location = new System.Drawing.Point(143, 296);
            this.btn_prethodni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(33, 28);
            this.btn_prethodni.TabIndex = 25;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_prvi
            // 
            this.btn_prvi.Location = new System.Drawing.Point(22, 296);
            this.btn_prvi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prvi.Name = "btn_prvi";
            this.btn_prvi.Size = new System.Drawing.Size(52, 28);
            this.btn_prvi.TabIndex = 24;
            this.btn_prvi.Text = "<<";
            this.btn_prvi.UseVisualStyleBackColor = true;
            this.btn_prvi.Click += new System.EventHandler(this.btn_prvi_Click);
            // 
            // Forna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 421);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_poslednji);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_prvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Proiz);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_id);
            this.Name = "Forna";
            this.Text = "Forna";
            this.Load += new System.EventHandler(this.Forna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.ComboBox Proiz;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_osvezi;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_poslednji;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_prvi;
    }
}