using wypozyczalnia_produkcja.Models;

//hubert
namespace wypozyczalnia_produkcja.Pages
{
    partial class ProfilUzytkownika
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
        private void InitializeComponent(/*int id*/)
        {
            Uzytkownik userOId1 = new Uzytkownik(2);

            //elementy formularza
            this.imie = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imie.Location = new System.Drawing.Point(72, 98);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(180, 23);
            this.imie.TabIndex = 1;
            this.imie.Text = userOId1.Imie;
            // 
            // nazwisko
            // 
            this.nazwisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nazwisko.Location = new System.Drawing.Point(72, 139);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(180, 23);
            this.nazwisko.TabIndex = 2;
            this.nazwisko.Text = userOId1.Nazwisko;
            
            // 
            // telefon
            // 
            this.telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefon.Location = new System.Drawing.Point(72, 184);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(180, 23);
            this.telefon.TabIndex = 3;
            this.nazwisko.Text = userOId1.Telefon;
            
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(72, 228);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(180, 23);
            this.email.TabIndex = 4;
            this.email.Text = userOId1.Email;
            
            // 
            // adres
            // 
            this.adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adres.Location = new System.Drawing.Point(72, 273);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(180, 23);
            this.adres.TabIndex = 5;
            if(userOId1.Adres != null)
            {
                this.adres.Text = userOId1.Adres.ToString();
            }
            
            // 
            // ProfilUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Name = "ProfilUzytkownika";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProfilUzytkownika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label adres;
    }
}