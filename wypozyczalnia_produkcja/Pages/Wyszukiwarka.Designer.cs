//sabina
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonProfilUzytkownika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz czego szukasz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyszukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProfilUzytkownika
            // 
            this.buttonProfilUzytkownika.Location = new System.Drawing.Point(473, 12);
            this.buttonProfilUzytkownika.Name = "buttonProfilUzytkownika";
            this.buttonProfilUzytkownika.Size = new System.Drawing.Size(115, 23);
            this.buttonProfilUzytkownika.TabIndex = 2;
            this.buttonProfilUzytkownika.Text = "Profil Uzytkownika";
            this.buttonProfilUzytkownika.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProfilUzytkownika.UseVisualStyleBackColor = true;
            this.buttonProfilUzytkownika.Click += new System.EventHandler(this.buttonProfilUzytkownika_Click);
            // 
            // Wyszukiwarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonProfilUzytkownika);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Wyszukiwarka";
            this.Text = "Wypożyczalnia narzędzi";
            this.Load += new System.EventHandler(this.Wyszukiwarka_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonProfilUzytkownika;
    }
}