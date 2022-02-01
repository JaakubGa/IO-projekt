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
            private void InitializeComponent(/*Sprzet przedmiot*/)
        {
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelNazwaPrzedmiotu = new System.Windows.Forms.Label();
            this.labelNickWlasciciela = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelImieNazwisko = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(589, 377);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(195, 30);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj do koszyka";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonCofnij_Click);
            // 
            // labelNazwaPrzedmiotu
            // 
            this.labelNazwaPrzedmiotu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNazwaPrzedmiotu.Location = new System.Drawing.Point(42, 22);
            this.labelNazwaPrzedmiotu.Name = "labelNazwaPrzedmiotu";
            this.labelNazwaPrzedmiotu.Size = new System.Drawing.Size(540, 27);
            this.labelNazwaPrzedmiotu.TabIndex = 1;
            // 
            // labelNickWlasciciela
            // 
            this.labelNickWlasciciela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNickWlasciciela.Location = new System.Drawing.Point(589, 58);
            this.labelNickWlasciciela.Name = "labelNickWlasciciela";
            this.labelNickWlasciciela.Size = new System.Drawing.Size(184, 29);
            this.labelNickWlasciciela.TabIndex = 2;
            this.labelNickWlasciciela.Text = "nick";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(773, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 17);
            this.labelId.TabIndex = 4;
            this.labelId.Visible = false;
            // 
            // labelCena
            // 
            this.labelCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCena.Location = new System.Drawing.Point(589, 332);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(195, 29);
            this.labelCena.TabIndex = 5;
            this.labelCena.Text = "cena";
            // 
            // labelEmail
            // 
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmail.Location = new System.Drawing.Point(589, 173);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(184, 29);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "email";
            // 
            // labelTelefon
            // 
            this.labelTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTelefon.Location = new System.Drawing.Point(589, 134);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(184, 29);
            this.labelTelefon.TabIndex = 7;
            this.labelTelefon.Text = "tel.";
            // 
            // labelImieNazwisko
            // 
            this.labelImieNazwisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelImieNazwisko.Location = new System.Drawing.Point(589, 96);
            this.labelImieNazwisko.Name = "labelImieNazwisko";
            this.labelImieNazwisko.Size = new System.Drawing.Size(184, 29);
            this.labelImieNazwisko.TabIndex = 8;
            this.labelImieNazwisko.Text = "imie i nazwisko";
            // 
            // labelAdres
            // 
            this.labelAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdres.Location = new System.Drawing.Point(589, 211);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(184, 55);
            this.labelAdres.TabIndex = 9;
            this.labelAdres.Text = "adres";
            // 
            // StronaPrzedmiotu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelImieNazwisko);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNickWlasciciela);
            this.Controls.Add(this.labelNazwaPrzedmiotu);
            this.Controls.Add(this.buttonDodaj);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StronaPrzedmiotu";
            this.Text = "Agregat 3000";
            this.Load += new System.EventHandler(this.StronaPrzedmiotu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private Label labelNazwaPrzedmiotu;
        private Label labelNickWlasciciela;
        private Label labelId;
        private Label labelCena;
        private Label labelEmail;
        private Label labelTelefon;
        private Label labelImieNazwisko;
        private Label labelAdres;
    }
}