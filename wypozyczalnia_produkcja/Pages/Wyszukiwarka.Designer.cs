//sabina
using wypozyczalnia_produkcja.Params;

namespace wypozyczalnia_produkcja.Pages
{
    partial class Wyszukiwarka
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
            this.labelPoleWyszukiwania = new System.Windows.Forms.Label();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.buttonProfilUzytkownika = new System.Windows.Forms.Button();
            this.buttonLogowanie = new System.Windows.Forms.Button();
            this.buttonRejestracja = new System.Windows.Forms.Button();
            this.buttonZamowienia = new System.Windows.Forms.Button();
            this.buttonKoszyk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPoleWyszukiwania
            // 
            this.labelPoleWyszukiwania.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPoleWyszukiwania.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPoleWyszukiwania.Location = new System.Drawing.Point(23, 63);
            this.labelPoleWyszukiwania.Name = "labelPoleWyszukiwania";
            this.labelPoleWyszukiwania.Size = new System.Drawing.Size(340, 23);
            this.labelPoleWyszukiwania.TabIndex = 0;
            this.labelPoleWyszukiwania.Text = "Wpisz czego szukasz";
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Location = new System.Drawing.Point(369, 63);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonWyszukaj.TabIndex = 1;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProfilUzytkownika
            // 
            this.buttonProfilUzytkownika.Location = new System.Drawing.Point(23, 12);
            this.buttonProfilUzytkownika.Name = "buttonProfilUzytkownika";
            this.buttonProfilUzytkownika.Size = new System.Drawing.Size(115, 23);
            this.buttonProfilUzytkownika.TabIndex = 2;
            this.buttonProfilUzytkownika.Text = "Profil Uzytkownika";
            this.buttonProfilUzytkownika.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProfilUzytkownika.UseVisualStyleBackColor = true;
            this.buttonProfilUzytkownika.Visible = Singleton.GetInstance().ButtonsIsVisible;
            this.buttonProfilUzytkownika.Click += new System.EventHandler(this.buttonProfilUzytkownika_Click);
            // 
            // buttonLogowanie
            // 
            this.buttonLogowanie.Location = new System.Drawing.Point(386, 12);
            this.buttonLogowanie.Name = "buttonLogowanie";
            this.buttonLogowanie.Size = new System.Drawing.Size(115, 23);
            this.buttonLogowanie.TabIndex = 3;
            this.buttonLogowanie.Text = "Zaloguj się";
            this.buttonLogowanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogowanie.UseVisualStyleBackColor = true;
            // 
            // buttonRejestracja
            // 
            this.buttonRejestracja.Location = new System.Drawing.Point(507, 12);
            this.buttonRejestracja.Name = "buttonRejestracja";
            this.buttonRejestracja.Size = new System.Drawing.Size(115, 23);
            this.buttonRejestracja.TabIndex = 4;
            this.buttonRejestracja.Text = "Zarejestruj się";
            this.buttonRejestracja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRejestracja.UseVisualStyleBackColor = true;
            // 
            // buttonZamowienia
            // 
            this.buttonZamowienia.Location = new System.Drawing.Point(144, 12);
            this.buttonZamowienia.Name = "buttonZamowienia";
            this.buttonZamowienia.Size = new System.Drawing.Size(115, 23);
            this.buttonZamowienia.TabIndex = 5;
            this.buttonZamowienia.Text = "Moje zamówienia";
            this.buttonZamowienia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonZamowienia.UseVisualStyleBackColor = true;
            this.buttonZamowienia.Visible = Singleton.GetInstance().ButtonsIsVisible;
            // 
            // buttonKoszyk
            // 
            this.buttonKoszyk.Location = new System.Drawing.Point(265, 12);
            this.buttonKoszyk.Name = "buttonKoszyk";
            this.buttonKoszyk.Size = new System.Drawing.Size(115, 23);
            this.buttonKoszyk.TabIndex = 6;
            this.buttonKoszyk.Text = "Koszyk";
            this.buttonKoszyk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKoszyk.UseVisualStyleBackColor = true;
            this.buttonKoszyk.Visible = Singleton.GetInstance().ButtonsIsVisible;
            // 
            // Wyszukiwarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.buttonKoszyk);
            this.Controls.Add(this.buttonZamowienia);
            this.Controls.Add(this.buttonRejestracja);
            this.Controls.Add(this.buttonLogowanie);
            this.Controls.Add(this.buttonProfilUzytkownika);
            this.Controls.Add(this.buttonWyszukaj);
            this.Controls.Add(this.labelPoleWyszukiwania);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Wyszukiwarka";
            this.Text = "Wypożyczalnia narzędzi";
            this.Load += new System.EventHandler(this.Wyszukiwarka_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPoleWyszukiwania;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.Button buttonProfilUzytkownika;
        private System.Windows.Forms.Button buttonLogowanie;
        private System.Windows.Forms.Button buttonRejestracja;
        private System.Windows.Forms.Button buttonZamowienia;
        private System.Windows.Forms.Button buttonKoszyk;
    }
}