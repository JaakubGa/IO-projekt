using System.Windows.Forms;
using wypozyczalnia_produkcja.Models;
using wypozyczalnia_produkcja.Params;

//sabina
namespace wypozyczalnia_produkcja.Pages
{
    partial class StronaPrzedmiotu
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelNazwaPrzedmiotu = new System.Windows.Forms.Label();
            this.labelNickWlasciciela = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelImieNazwisko = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(414, 306);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(174, 24);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj do koszyka";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonCofnij_Click);
            // 
            // labelNazwaPrzedmiotu
            // 
            this.labelNazwaPrzedmiotu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNazwaPrzedmiotu.Location = new System.Drawing.Point(32, 18);
            this.labelNazwaPrzedmiotu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNazwaPrzedmiotu.Name = "labelNazwaPrzedmiotu";
            this.labelNazwaPrzedmiotu.Size = new System.Drawing.Size(380, 22);
            this.labelNazwaPrzedmiotu.TabIndex = 1;
            // 
            // labelNickWlasciciela
            // 
            this.labelNickWlasciciela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNickWlasciciela.Location = new System.Drawing.Point(414, 47);
            this.labelNickWlasciciela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNickWlasciciela.Name = "labelNickWlasciciela";
            this.labelNickWlasciciela.Size = new System.Drawing.Size(166, 24);
            this.labelNickWlasciciela.TabIndex = 2;
            this.labelNickWlasciciela.Text = "nick";
            // 
            // labelCena
            // 
            this.labelCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCena.Location = new System.Drawing.Point(414, 270);
            this.labelCena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(174, 24);
            this.labelCena.TabIndex = 5;
            this.labelCena.Text = "cena";
            // 
            // labelEmail
            // 
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmail.Location = new System.Drawing.Point(414, 141);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(166, 38);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "email";
            // 
            // labelTelefon
            // 
            this.labelTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTelefon.Location = new System.Drawing.Point(414, 109);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(166, 24);
            this.labelTelefon.TabIndex = 7;
            this.labelTelefon.Text = "tel.";
            // 
            // labelImieNazwisko
            // 
            this.labelImieNazwisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelImieNazwisko.Location = new System.Drawing.Point(414, 78);
            this.labelImieNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImieNazwisko.Name = "labelImieNazwisko";
            this.labelImieNazwisko.Size = new System.Drawing.Size(166, 24);
            this.labelImieNazwisko.TabIndex = 8;
            this.labelImieNazwisko.Text = "imie i nazwisko";
            // 
            // labelAdres
            // 
            this.labelAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdres.Location = new System.Drawing.Point(414, 188);
            this.labelAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(166, 45);
            this.labelAdres.TabIndex = 9;
            this.labelAdres.Text = "adres";
            // 
            // StronaPrzedmiotu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelImieNazwisko);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.labelNickWlasciciela);
            this.Controls.Add(this.labelNazwaPrzedmiotu);
            this.Controls.Add(this.buttonDodaj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StronaPrzedmiotu";
            this.Load += new System.EventHandler(this.StronaPrzedmiotu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private Label labelNazwaPrzedmiotu;
        private Label labelNickWlasciciela;
        private Label labelCena;
        private Label labelEmail;
        private Label labelTelefon;
        private Label labelImieNazwisko;
        private Label labelAdres;
    }
}