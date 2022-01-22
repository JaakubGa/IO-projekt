
using System.Windows.Forms;

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
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelNazwaPrzedmiotu = new System.Windows.Forms.Label();
            this.labelNickWlasciciela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wróć do wyszukiwarki";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNazwaPrzedmiotu
            // 
            this.labelNazwaPrzedmiotu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNazwaPrzedmiotu.Location = new System.Drawing.Point(67, 45);
            this.labelNazwaPrzedmiotu.Name = "labelNazwaPrzedmiotu";
            this.labelNazwaPrzedmiotu.Size = new System.Drawing.Size(614, 27);
            this.labelNazwaPrzedmiotu.TabIndex = 1;
            // 
            // labelNickWlasciciela
            // 
            this.labelNickWlasciciela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNickWlasciciela.Location = new System.Drawing.Point(629, 199);
            this.labelNickWlasciciela.Name = "labelNickWlasciciela";
            this.labelNickWlasciciela.Size = new System.Drawing.Size(100, 23);
            this.labelNickWlasciciela.TabIndex = 2;
            this.labelNickWlasciciela.Text = "nick";
            // 
            // StronaPrzedmiotu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNickWlasciciela);
            this.Controls.Add(this.labelNazwaPrzedmiotu);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StronaPrzedmiotu";
            this.Text = "{Nazwa przedmiotu z bazy}";
            this.Load += new System.EventHandler(this.StronaPrzedmiotu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Label labelNazwaPrzedmiotu;
        private Label labelNickWlasciciela;
    }
}