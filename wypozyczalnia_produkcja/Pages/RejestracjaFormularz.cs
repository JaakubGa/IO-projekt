using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Params;

namespace wypozyczalnia.DSanak.Rejestracja
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //rejestracja_button
        {

            try

            {

                SqlConnection con = new SqlConnection(Connect.StringConnection);

                con.Open();

                DataTable dtc = new DataTable();

                String czyDuplikat = "select Count(*) from Uzytkownik where nick= '" + login_txt.Text + "' or e_mail = '"+email_txt.Text +"'";// and haslo= '" + password_txt.Text + "'";
                String dodawanie = "INSERT INTO Uzytkownik(nick,haslo,imie,nazwisko,e_mail) " +
                    "VALUES ('" + login_txt.Text + "', '" + password_txt.Text + "', '" + firstname_txt.Text + "', '" + lastname_txt.Text + "','" + email_txt.Text + "')";

                string dodawanie_adresu = "INSERT INTO Adres(miasto,kod_pocztowy,ulica,numer_domu,numer_mieszkania) " +
                    "Values ('" + city_txt.Text + "','" + post_code_txt.Text + "','" + street_txt.Text + "','" + number_txt.Text + "','" + number_of_apart_txt.Text + "')";
                SqlCommand kwerenda1 = new SqlCommand(dodawanie, con);
                SqlCommand kwerenda2 = new SqlCommand(dodawanie_adresu, con);

                SqlDataAdapter sda = new SqlDataAdapter(czyDuplikat, con);
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
                            da1.Fill(dt1);
                            MessageBox.Show("Dodano nowe twarze!");

                        }
                        catch (Exception eax)
                        {
                            MessageBox.Show($"Error:{eax.ToString()}");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Sprawdź czy wypełniłeś wszystkie pola!");

                    }



                }
                else if (dtc.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show("Podane dane już istnieją w bazie danych");
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
                this.Hide();
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
