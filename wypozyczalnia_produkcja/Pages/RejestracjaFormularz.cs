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

                String str =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wypozyczalnia;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                    "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(str);

                con.Open();

                DataTable dtc = new DataTable();

                String czyDuplikat = "select Count(*) from Uzytkownik where nick= '" + login_txt.Text + "' and haslo= '" + password_txt.Text + "'";
                String dodawanie = "INSERT INTO Uzytkownik(nick,haslo,imie,nazwisko,nr_telefonu,e_mail) " +
                    "VALUES ('" + login_txt.Text + "', '" + password_txt.Text + "', '" + firstname_txt.Text + "', '" + lastname_txt.Text + "','" + city_txt.Text + "','" + street_txt.Text + "','" + number_txt.Text + "','" + email_txt.Text + "')";

                string dodawanie_adresu = "INSERT INTO Adres(miasto,kod_pocztowy,ulica,numer_domu,numer_mieszkania) " +
                    "Values ('"+city_txt.Text+"','"+post_code_txt.Text+"','"+street_txt.Text+"','"+number_txt.Text+"',,'"+number_of_apart_txt.Text+"')";
                string select = "Select *  from Urzytkownicy";
                SqlCommand kwerenda1 = new SqlCommand(dodawanie, con);
                SqlCommand kwerenda2 = new SqlCommand(dodawanie_adresu, con);

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
                            DataTable dt1 = new DataTable();
                            SqlDataAdapter da1 = new SqlDataAdapter(kwerenda2);
                            da.Fill(dt1);
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

        private void post_code_Click(object sender, EventArgs e)
        {

        }

        private void box_rejestracja_Enter(object sender, EventArgs e)
        {

        }
    }
}