
namespace WindowsFormsApp1
{
    partial class Automobili
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.Grid_Ocene = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Od = new System.Windows.Forms.DateTimePicker();
            this.Do = new System.Windows.Forms.DateTimePicker();
            this.Jmbg = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Proizvodjac = new System.Windows.Forms.ComboBox();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.Cena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(472, 20);
            this.textBox2.TabIndex = 62;
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(131, -13);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_datum.TabIndex = 61;
            this.lbl_datum.Text = "Datum";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(461, -13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 60;
            this.lbl_id.Text = "ID";
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Location = new System.Drawing.Point(4, -19);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(41, 13);
            this.lbl_godina.TabIndex = 54;
            this.lbl_godina.Text = "Godina";
            // 
            // Grid_Ocene
            // 
            this.Grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocene.Location = new System.Drawing.Point(7, 235);
            this.Grid_Ocene.Name = "Grid_Ocene";
            this.Grid_Ocene.Size = new System.Drawing.Size(472, 236);
            this.Grid_Ocene.TabIndex = 53;
            this.Grid_Ocene.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocene_CellContentClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(404, 106);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 52;
            this.btn_Delete.Text = "Brisi";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(404, 77);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 51;
            this.btn_Update.Text = "Izmeni";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(404, 46);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 50;
            this.btn_Insert.Text = "Dodaj";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(404, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(75, 20);
            this.txt_id.TabIndex = 49;
            // 
            // Od
            // 
            this.Od.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Od.Location = new System.Drawing.Point(233, 46);
            this.Od.Name = "Od";
            this.Od.Size = new System.Drawing.Size(121, 20);
            this.Od.TabIndex = 48;
            // 
            // Do
            // 
            this.Do.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Do.Location = new System.Drawing.Point(233, 103);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(121, 20);
            this.Do.TabIndex = 63;
            // 
            // Jmbg
            // 
            this.Jmbg.Location = new System.Drawing.Point(12, 162);
            this.Jmbg.Name = "Jmbg";
            this.Jmbg.Size = new System.Drawing.Size(100, 20);
            this.Jmbg.TabIndex = 64;
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(12, 46);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 20);
            this.Ime.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "JMBG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Uzet od";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Uzet do";
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.FormattingEnabled = true;
            this.Proizvodjac.Location = new System.Drawing.Point(118, 162);
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.Size = new System.Drawing.Size(109, 21);
            this.Proizvodjac.TabIndex = 72;
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(12, 108);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(100, 20);
            this.Prezime.TabIndex = 73;
            // 
            // Cena
            // 
            this.Cena.Location = new System.Drawing.Point(233, 163);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(73, 20);
            this.Cena.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Cena";
            // 
            // Automobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cena);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Proizvodjac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.Jmbg);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.Grid_Ocene);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.Od);
            this.Name = "Automobili";
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.Automobili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.DataGridView Grid_Ocene;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DateTimePicker Od;
        private System.Windows.Forms.DateTimePicker Do;
        private System.Windows.Forms.TextBox Jmbg;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Proizvodjac;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.TextBox Cena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}