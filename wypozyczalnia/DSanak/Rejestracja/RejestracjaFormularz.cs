﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wypozyczalnia.DSanak.Rejestracja
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //rejestracja_button
        {

            try

            {

                String str = "server=LAPTOP-9SUIHG4A;database= Wypozyczalnia;Trusted_Connection = True;";
                SqlConnection con = new SqlConnection(str);

                con.Open();

                DataTable dtc = new DataTable();

                String czyDuplikat = "select Count(*) from Urzytkownicy where user_login= '" + login_txt.Text + "' and user_haslo= '" + password_txt.Text + "'";
                String dodawanie = "INSERT INTO Urzytkownicy(user_login,user_haslo,user_imie,user_nazwisko,user_miasto,user_ulica,user_numerDomu,user_email) " +
                    "VALUES ('" + login_txt.Text + "', '" + password_txt.Text + "', '" + firstname_txt.Text + "', '" + lastname_txt.Text + "','" + city_txt.Text + "','" + street_txt.Text + "','" + number_txt.Text + "','" + email_txt.Text + "')";

                string dodawanie2 = "INSERT INTO Urzytkownicy(user_login,user_haslo,user_imie,user_nazwisko,user_miasto,user_ulica,user_numerDomu,user_email) Values ('Przyklad10','Przyklad20','Przyklad30','Przyklad40','Przyklad10','Przyklad02','Prz0yklad3','Pr0zyklad4')";
                string select = "Select *  from Urzytkownicy";
                SqlCommand kwerenda1 = new SqlCommand(dodawanie, con);

                SqlDataAdapter sda = new SqlDataAdapter(czyDuplikat, con)
                {

                };
                sda.Fill(dtc);
                if (dtc.Rows[0][0].ToString() == "0")
                {
                    if (login_txt.Text != "" && password_txt.Text != "" && email_txt.Text != "")
                    {

                        try
                        {
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(kwerenda1);
                            da.Fill(dt);
                            MessageBox.Show("Dodano nowe twarze!");

                        }
                        catch (Exception eax)
                        {
                            MessageBox.Show("Podany login/email już istnieje w bazie", eax.ToString());
                        }


                    }
                    else
                    {
                        MessageBox.Show("Sprawdź czy wypełniłeś wszystkie pola!");

                    }



                }




            }
            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }


        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "What are you doing?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Clean all", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (Control c in box_rejestracja.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }


    }
}
