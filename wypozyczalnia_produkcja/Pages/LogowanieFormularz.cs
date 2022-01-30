﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wypozyczalnia.DSanak
{
    public partial class LogowanieFormularz : Form
    {
        public LogowanieFormularz()
        {
            InitializeComponent();
        }

        public Rejestracja.Rejestracja rejestracja = new Rejestracja.Rejestracja();

        private void button1_Click(object sender, EventArgs e)
        {


            try

            {
                //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;
                //Integrated Security=True;Connect Timeout=30;Encrypt=False;
                //TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
                String str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wypozyczalnia;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                    "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(str);

                con.Open();

                DataTable dtc = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Uzytkownik where nick= '" + usernametxt.Text + "' and haslo= '" + userpasswordtxt.Text + "'", con);

                sda.Fill(dtc);
                if (dtc.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Brawo, udało Ci się poprawnie zalogować");
                    this.Hide();
                    rejestracja.Show();

                }
                else
                {
                    MessageBox.Show("Niestety, sprawdź swoje dane");
                }



            }
            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }


        }





        private void LogowanieFormularz_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "What are you doing?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Clean all", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                usernametxt.Text = "";
                userpasswordtxt.Text = "";
            }
        }
    }
}