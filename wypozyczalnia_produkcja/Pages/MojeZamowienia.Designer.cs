
using System.Collections.Generic;
using wypozyczalnia_produkcja.Models;
using wypozyczalnia_produkcja.Params;

namespace wypozyczalnia_produkcja.Pages
{
    partial class MojeZamowienia
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
            this.listBoxZamowienia = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxZamowienia
            // 
            this.listBoxZamowienia.FormattingEnabled = true;
            this.listBoxZamowienia.ItemHeight = 16;
            this.listBoxZamowienia.Location = new System.Drawing.Point(38, 59);
            this.listBoxZamowienia.Name = "listBoxZamowienia";
            this.listBoxZamowienia.Size = new System.Drawing.Size(721, 356);
            this.listBoxZamowienia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moje zamówienia";
            // 
            // MojeZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxZamowienia);
            this.Name = "MojeZamowienia";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private void WyswietlListeZamowien()
        {
            List<int> lista = Singleton.ZwrocZamowienia();
            foreach (int id in lista)
            {
                Zamowienie zamowienie = new Zamowienie(id);
                listBoxZamowienia.Items.Add(zamowienie.ToString());
            }
        }

        private System.Windows.Forms.ListBox listBoxZamowienia;
        private System.Windows.Forms.Label label1;
    }
}