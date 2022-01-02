using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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


            try

            {

                String str = "server=LAPTOP-9SUIHG4A;database= Wypozyczalnia;Trusted_Connection = True;";
                SqlConnection con = new SqlConnection(str);

                con.Open();

                DataTable dtc = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Urzytkownicy where user_login= '" + usernametxt.Text + "' and user_haslo= '" + userpasswordtxt.Text + "'", con);

                sda.Fill(dtc);
                if (dtc.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Brawo, udało Ci się poprawnie zalogować");
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
    }
}
