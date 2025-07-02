namespace bibliotekaAdmin
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTytul = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDodajKsiazke = new System.Windows.Forms.Button();
            this.listaKsiazek = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDodajCzytelnika = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaCzytelnikow = new System.Windows.Forms.ListBox();
            this.buttonUsunCzytelnika = new System.Windows.Forms.Button();
            this.buttonUsunKsiazke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTytul
            // 
            this.textBoxTytul.Location = new System.Drawing.Point(112, 117);
            this.textBoxTytul.Name = "textBoxTytul";
            this.textBoxTytul.Size = new System.Drawing.Size(106, 20);
            this.textBoxTytul.TabIndex = 2;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(112, 151);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(106, 20);
            this.textBoxAutor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tytuł książki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Autor książki";
            // 
            // buttonDodajKsiazke
            // 
            this.buttonDodajKsiazke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajKsiazke.Location = new System.Drawing.Point(21, 177);
            this.buttonDodajKsiazke.Name = "buttonDodajKsiazke";
            this.buttonDodajKsiazke.Size = new System.Drawing.Size(218, 28);
            this.buttonDodajKsiazke.TabIndex = 15;
            this.buttonDodajKsiazke.Text = "Dodaj Książke";
            this.buttonDodajKsiazke.UseVisualStyleBackColor = true;
            this.buttonDodajKsiazke.Click += new System.EventHandler(this.buttonDodajKsiazke_Click);
            // 
            // listaKsiazek
            // 
            this.listaKsiazek.FormattingEnabled = true;
            this.listaKsiazek.Location = new System.Drawing.Point(267, 117);
            this.listaKsiazek.Name = "listaKsiazek";
            this.listaKsiazek.Size = new System.Drawing.Size(262, 264);
            this.listaKsiazek.TabIndex = 17;
            this.listaKsiazek.SelectedIndexChanged += new System.EventHandler(this.listaKsiazek_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(348, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lista Książek";
            // 
            // buttonDodajCzytelnika
            // 
            this.buttonDodajCzytelnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajCzytelnika.Location = new System.Drawing.Point(21, 281);
            this.buttonDodajCzytelnika.Name = "buttonDodajCzytelnika";
            this.buttonDodajCzytelnika.Size = new System.Drawing.Size(218, 29);
            this.buttonDodajCzytelnika.TabIndex = 27;
            this.buttonDodajCzytelnika.Text = "Dodaj Czytelnika";
            this.buttonDodajCzytelnika.UseVisualStyleBackColor = true;
            this.buttonDodajCzytelnika.Click += new System.EventHandler(this.buttonDodajCzytelnika_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nazwisko czytelnika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Imię czytelnika";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(133, 255);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(106, 20);
            this.textBoxNazwisko.TabIndex = 24;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(133, 221);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(106, 20);
            this.textBoxImie.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(616, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Lista Czytelników";
            // 
            // listaCzytelnikow
            // 
            this.listaCzytelnikow.FormattingEnabled = true;
            this.listaCzytelnikow.Location = new System.Drawing.Point(535, 117);
            this.listaCzytelnikow.Name = "listaCzytelnikow";
            this.listaCzytelnikow.Size = new System.Drawing.Size(262, 264);
            this.listaCzytelnikow.TabIndex = 28;
            // 
            // buttonUsunCzytelnika
            // 
            this.buttonUsunCzytelnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsunCzytelnika.Location = new System.Drawing.Point(535, 397);
            this.buttonUsunCzytelnika.Name = "buttonUsunCzytelnika";
            this.buttonUsunCzytelnika.Size = new System.Drawing.Size(262, 41);
            this.buttonUsunCzytelnika.TabIndex = 30;
            this.buttonUsunCzytelnika.Text = "Usuń Czytelnika";
            this.buttonUsunCzytelnika.UseVisualStyleBackColor = true;
            this.buttonUsunCzytelnika.Click += new System.EventHandler(this.buttonUsunCzytelnika_Click);
            // 
            // buttonUsunKsiazke
            // 
            this.buttonUsunKsiazke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsunKsiazke.Location = new System.Drawing.Point(267, 397);
            this.buttonUsunKsiazke.Name = "buttonUsunKsiazke";
            this.buttonUsunKsiazke.Size = new System.Drawing.Size(262, 41);
            this.buttonUsunKsiazke.TabIndex = 31;
            this.buttonUsunKsiazke.Text = "Usuń Książke";
            this.buttonUsunKsiazke.UseVisualStyleBackColor = true;
            this.buttonUsunKsiazke.Click += new System.EventHandler(this.buttonUsunKsiazke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsunKsiazke);
            this.Controls.Add(this.buttonUsunCzytelnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaCzytelnikow);
            this.Controls.Add(this.buttonDodajCzytelnika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaKsiazek);
            this.Controls.Add(this.buttonDodajKsiazke);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTytul);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTytul;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDodajKsiazke;
        private System.Windows.Forms.ListBox listaKsiazek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDodajCzytelnika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaCzytelnikow;
        private System.Windows.Forms.Button buttonUsunCzytelnika;
        private System.Windows.Forms.Button buttonUsunKsiazke;
    }
}

