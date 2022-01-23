
using System.Windows.Forms;
using wypozyczalnia_produkcja.Sabina.Models;

namespace wypozyczalnia_produkcja.Sabina.Pages
{
    partial class StronaPrzedmiotu
    {
        //Public
        

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
            private void InitializeComponent(/*PrzedmiotModel przedmiot*/)
        {
            this.buttonCofnij = new System.Windows.Forms.Button();
            this.labelNazwaPrzedmiotu = new System.Windows.Forms.Label();
            this.labelNickWlasciciela = new System.Windows.Forms.Label();
            this.labelKategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCofnij
            // 
            this.buttonCofnij.Location = new System.Drawing.Point(50, 305);
            this.buttonCofnij.Name = "buttonCofnij";
            this.buttonCofnij.Size = new System.Drawing.Size(146, 24);
            this.buttonCofnij.TabIndex = 0;
            this.buttonCofnij.Text = "Wróć do wyszukiwarki";
            this.buttonCofnij.UseVisualStyleBackColor = true;
            this.buttonCofnij.Click += new System.EventHandler(this.buttonCofnij_Click);
            // 
            // labelNazwaPrzedmiotu
            // 
            this.labelNazwaPrzedmiotu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNazwaPrzedmiotu.Location = new System.Drawing.Point(50, 50);
            this.labelNazwaPrzedmiotu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNazwaPrzedmiotu.Name = "labelNazwaPrzedmiotu";
            this.labelNazwaPrzedmiotu.Size = new System.Drawing.Size(405, 22);
            this.labelNazwaPrzedmiotu.TabIndex = 1;
            this.labelNazwaPrzedmiotu.Text = "Agregat 3000";
            // 
            // labelNickWlasciciela
            // 
            this.labelNickWlasciciela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNickWlasciciela.Location = new System.Drawing.Point(472, 162);
            this.labelNickWlasciciela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNickWlasciciela.Name = "labelNickWlasciciela";
            this.labelNickWlasciciela.Size = new System.Drawing.Size(76, 19);
            this.labelNickWlasciciela.TabIndex = 2;
            this.labelNickWlasciciela.Text = "nick";
            // 
            // labelKategoria
            // 
            this.labelKategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKategoria.Location = new System.Drawing.Point(50, 18);
            this.labelKategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKategoria.Name = "labelKategoria";
            this.labelKategoria.Size = new System.Drawing.Size(405, 22);
            this.labelKategoria.TabIndex = 3;
            this.labelKategoria.Text = "Agregat 3000";
            // 
            // StronaPrzedmiotu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelKategoria);
            this.Controls.Add(this.labelNickWlasciciela);
            this.Controls.Add(this.labelNazwaPrzedmiotu);
            this.Controls.Add(this.buttonCofnij);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StronaPrzedmiotu";
            this.Text = "Agregat 3000";
            this.Load += new System.EventHandler(this.StronaPrzedmiotu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCofnij;
        private Label labelNazwaPrzedmiotu;
        private Label labelNickWlasciciela;
        private Label labelKategoria;
    }
}