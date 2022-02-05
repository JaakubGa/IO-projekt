//sabina
using wypozyczalnia_produkcja.Params;
using wypozyczalnia_produkcja.Pages;

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
            this.components = new System.ComponentModel.Container();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.buttonProfilUzytkownika = new System.Windows.Forms.Button();
            this.buttonLogowanie = new System.Windows.Forms.Button();
            this.buttonRejestracja = new System.Windows.Forms.Button();
            this.buttonZamowienia = new System.Windows.Forms.Button();
            this.buttonKoszyk = new System.Windows.Forms.Button();
            this.listBoxWyszukiwanie = new System.Windows.Forms.ListBox();
            this.checkedListBoxKategorie = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonWyczyscKategorie = new System.Windows.Forms.Button();
            this.textBoxWyszukiwarka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Location = new System.Drawing.Point(386, 63);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(100, 23);
            this.buttonWyszukaj.TabIndex = 1;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
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
            this.buttonProfilUzytkownika.Visible = false;
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
            this.buttonLogowanie.Click += new System.EventHandler(this.buttonLogowanie_Click);
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
            this.buttonRejestracja.Click += new System.EventHandler(this.buttonRejestracja_Click);
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
            this.buttonZamowienia.Visible = false;
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
            this.buttonKoszyk.Visible = false;
            //this.buttonKoszyk.Click += new System.EventHandler(this.buttonKoszyk_Click);
            // 
            // listBoxWyszukiwanie
            // 
            this.listBoxWyszukiwanie.FormattingEnabled = true;
            this.listBoxWyszukiwanie.Location = new System.Drawing.Point(23, 98);
            this.listBoxWyszukiwanie.Name = "listBoxWyszukiwanie";
            this.listBoxWyszukiwanie.Size = new System.Drawing.Size(463, 251);
            this.listBoxWyszukiwanie.TabIndex = 7;
            this.listBoxWyszukiwanie.SelectedIndexChanged += new System.EventHandler(this.listBoxWyszukiwanie_SelectedIndexChanged);
            // 
            // checkedListBoxKategorie
            // 
            this.checkedListBoxKategorie.FormattingEnabled = true;
            this.checkedListBoxKategorie.Location = new System.Drawing.Point(507, 63);
            this.checkedListBoxKategorie.Name = "checkedListBoxKategorie";
            this.checkedListBoxKategorie.Size = new System.Drawing.Size(115, 244);
            this.checkedListBoxKategorie.TabIndex = 9;
            this.checkedListBoxKategorie.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxKategorie_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonWyczyscKategorie
            // 
            this.buttonWyczyscKategorie.Location = new System.Drawing.Point(507, 328);
            this.buttonWyczyscKategorie.Name = "buttonWyczyscKategorie";
            this.buttonWyczyscKategorie.Size = new System.Drawing.Size(115, 23);
            this.buttonWyczyscKategorie.TabIndex = 12;
            this.buttonWyczyscKategorie.Text = "Wyczysc Kategorie";
            this.buttonWyczyscKategorie.UseVisualStyleBackColor = true;
            this.buttonWyczyscKategorie.Click += new System.EventHandler(this.buttonWyczyscKategorie_Click);
            // 
            // textBoxWyszukiwarka
            // 
            this.textBoxWyszukiwarka.Location = new System.Drawing.Point(23, 63);
            this.textBoxWyszukiwarka.Name = "textBoxWyszukiwarka";
            this.textBoxWyszukiwarka.Size = new System.Drawing.Size(357, 20);
            this.textBoxWyszukiwarka.TabIndex = 13;
            this.textBoxWyszukiwarka.Text = "Wyszukaj czego szukasz";
            // 
            // Wyszukiwarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.textBoxWyszukiwarka);
            this.Controls.Add(this.buttonWyczyscKategorie);
            this.Controls.Add(this.checkedListBoxKategorie);
            this.Controls.Add(this.listBoxWyszukiwanie);
            this.Controls.Add(this.buttonKoszyk);
            this.Controls.Add(this.buttonZamowienia);
            this.Controls.Add(this.buttonRejestracja);
            this.Controls.Add(this.buttonLogowanie);
            this.Controls.Add(this.buttonProfilUzytkownika);
            this.Controls.Add(this.buttonWyszukaj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Wyszukiwarka";
            this.Text = "Wypożyczalnia narzędzi";
            this.Load += new System.EventHandler(this.Wyszukiwarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.Button buttonProfilUzytkownika;
        private System.Windows.Forms.Button buttonLogowanie;
        private System.Windows.Forms.Button buttonRejestracja;
        private System.Windows.Forms.Button buttonZamowienia;
        private System.Windows.Forms.Button buttonKoszyk;
        private System.Windows.Forms.ListBox listBoxWyszukiwanie;
        private System.Windows.Forms.CheckedListBox checkedListBoxKategorie;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonWyczyscKategorie;
        private System.Windows.Forms.TextBox textBoxWyszukiwarka;
    }
}