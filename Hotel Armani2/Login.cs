using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel_Armani2
{
    class Login
    {
        public string l;
        public string p;
        Window1 W1 = new Window1();
        Window2 W2 = new Window2();
        Window3 W3 = new Window3();
        public bool Innn;
        public string c;
        public Login(string L, string P)
        {
            l = L;
            p = P;
            Log();
        }

        public void Log()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=desktop-403shtp\igorsql;Initial Catalog=Users;Integrated Security=True;ConnectRetryCount=2;ConnectRetryInterval=3"))
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Users where Login = '" + l + "' and Pass = '" + p + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome, Sir");
                    // SqlCommand sda = new SqlCommand("SELECT DataF, DataS FROM Info WHERE Apparts = '" + CharC + "' ", connection);
                    SqlCommand CheckInBase = new SqlCommand("SELECT Login FROM Info WHERE InBase = '1' and Login = '" + l + "'", connection);
                    SqlDataReader reader = CheckInBase.ExecuteReader();
                    if (reader.Read())
                    {
                        Innn = true;
                        // MessageBox.Show("U r in Base");
                      
                        W2.Show();
                        //  f2.Show();
                        reader.Close();
                    }
                    else
                    {
                        Innn = false;
                        //      MessageBox.Show(LogChe);
                        MessageBox.Show("First time login? Lets input dannie!");
                        //   f2.Show();
                        W1.Show();
                        W1.Loginn = l;
                    }
                }
                else
                {
                    c="Incorrect Data. Retry, Sir.*";
                }
                if (Innn == true)
                {
                    SqlDataAdapter sda1 = new SqlDataAdapter("Select Name From Info where Login = '" + l + "'", connection);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    MessageBox.Show(Convert.ToString(dt1));
                    W2.Name.Text = Convert.ToString(dt1.Rows[0][0]);
                }
            }
        }
    }
}
