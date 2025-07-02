namespace BibliotekaUzytkownik
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listaDostepnychKsiazek = new System.Windows.Forms.ListBox();
            this.listaWypozyczonychKsiazek = new System.Windows.Forms.ListBox();
            this.buttonZwrocKsiazke = new System.Windows.Forms.Button();
            this.buttonWypozyczKsiazke = new System.Windows.Forms.Button();
            this.listaCzytelnikow = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(231, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biblioteka Czytelnik";
            // 
            // listaDostepnychKsiazek
            // 
            this.listaDostepnychKsiazek.FormattingEnabled = true;
            this.listaDostepnychKsiazek.Location = new System.Drawing.Point(30, 65);
            this.listaDostepnychKsiazek.Name = "listaDostepnychKsiazek";
            this.listaDostepnychKsiazek.Size = new System.Drawing.Size(282, 264);
            this.listaDostepnychKsiazek.TabIndex = 2;
            // 
            // listaWypozyczonychKsiazek
            // 
            this.listaWypozyczonychKsiazek.FormattingEnabled = true;
            this.listaWypozyczonychKsiazek.Location = new System.Drawing.Point(331, 64);
            this.listaWypozyczonychKsiazek.Name = "listaWypozyczonychKsiazek";
            this.listaWypozyczonychKsiazek.Size = new System.Drawing.Size(448, 290);
            this.listaWypozyczonychKsiazek.TabIndex = 3;
            // 
            // buttonZwrocKsiazke
            // 
            this.buttonZwrocKsiazke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZwrocKsiazke.Location = new System.Drawing.Point(409, 378);
            this.buttonZwrocKsiazke.Name = "buttonZwrocKsiazke";
            this.buttonZwrocKsiazke.Size = new System.Drawing.Size(281, 60);
            this.buttonZwrocKsiazke.TabIndex = 4;
            this.buttonZwrocKsiazke.Text = "Zwróć Książke";
            this.buttonZwrocKsiazke.UseVisualStyleBackColor = true;
            this.buttonZwrocKsiazke.Click += new System.EventHandler(this.buttonZwrocKsiazke_Click);
            // 
            // buttonWypozyczKsiazke
            // 
            this.buttonWypozyczKsiazke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWypozyczKsiazke.Location = new System.Drawing.Point(30, 378);
            this.buttonWypozyczKsiazke.Name = "buttonWypozyczKsiazke";
            this.buttonWypozyczKsiazke.Size = new System.Drawing.Size(282, 60);
            this.buttonWypozyczKsiazke.TabIndex = 5;
            this.buttonWypozyczKsiazke.Text = "Wypożycz Książke";
            this.buttonWypozyczKsiazke.UseVisualStyleBackColor = true;
            this.buttonWypozyczKsiazke.Click += new System.EventHandler(this.buttonWypozyczKsiazke_Click);
            // 
            // listaCzytelnikow
            // 
            this.listaCzytelnikow.FormattingEnabled = true;
            this.listaCzytelnikow.Location = new System.Drawing.Point(30, 351);
            this.listaCzytelnikow.Name = "listaCzytelnikow";
            this.listaCzytelnikow.Size = new System.Drawing.Size(282, 21);
            this.listaCzytelnikow.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(73, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista dostępnych książek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(457, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista wypożyczonych książek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wybór Czytelnika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaCzytelnikow);
            this.Controls.Add(this.buttonWypozyczKsiazke);
            this.Controls.Add(this.buttonZwrocKsiazke);
            this.Controls.Add(this.listaWypozyczonychKsiazek);
            this.Controls.Add(this.listaDostepnychKsiazek);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaDostepnychKsiazek;
        private System.Windows.Forms.ListBox listaWypozyczonychKsiazek;
        private System.Windows.Forms.Button buttonZwrocKsiazke;
        private System.Windows.Forms.Button buttonWypozyczKsiazke;
        private System.Windows.Forms.ComboBox listaCzytelnikow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

