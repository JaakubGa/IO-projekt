using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Params;
using wypozyczalnia_produkcja.Pages;



namespace wypozyczalnia.DSanak
{

    

    public partial class LogowanieFormularz : Form
    {

        public LogowanieFormularz()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().ButtonsIsVisible = true;

            Singleton.GetInstance().wyszukiwarka.buttonKoszyk.Visible = true;
            Singleton.GetInstance().wyszukiwarka.buttonProfilUzytkownika.Visible = true;
            Singleton.GetInstance().wyszukiwarka.buttonZamowienia.Visible = true;


            try

            {

                SqlConnection con = new SqlConnection(Connect.StringConnection);

                con.Open();

                DataTable dtc = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Uzytkownik where nick= '" + usernametxt.Text + "' and haslo= '" + userpasswordtxt.Text + "'", con);

                sda.Fill(dtc);
                if (dtc.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show($"Brawo, {usernametxt.Text} udało Ci się poprawnie zalogować");
                   
 
                    

                    SqlCommand command = new SqlCommand($"Select id_Uzytkownika from Uzytkownik where nick='{usernametxt.Text}';", con);

                    SqlDataReader reader = command.ExecuteReader();

                    //rader = 0 zwraca id uzytkownika
                    while (reader.Read())
                    {
                        Singleton.GetInstance().IdZalogowanego = (int)reader[0];
                    }
                    this.Hide();

                    con.Close();
                    reader.Close();

                   

                   



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
                this.Hide();
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
