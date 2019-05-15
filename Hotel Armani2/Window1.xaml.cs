using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Threading;
using System.Data;

namespace Hotel_Armani2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public double si=1;
        public string Loginn;
        public string a1;
        public string a2;
        public string a3;
        public string a4;
        public bool a5;
        public string nnn;
        public int i;          
        public double opacity0=1;
        public int ii;
        public double opacity1=0;
        public int iii;
        public double opacity2=0;
        ChangeTheme CT1;
        ChangeTheme CT2;
        ChangeTheme CT3;
        MainWindow MW = new MainWindow();
        public Window1()
        {
            InitializeComponent();
        }

        async void Anim1()
        {
            
            /*     IImage.Visibility = Visibility.Hidden;
                 IName.Visibility = Visibility.Hidden;
                 IPhone.Visibility = Visibility.Hidden;
                 IThemeMini.Visibility = Visibility.Hidden;
                 Lanf.Visibility = Visibility.Hidden;
                 Ques.Visibility = Visibility.Hidden; */
            for (int i = 0; i <10; i++)
            {
                opacity0 = opacity0 - 0.1;
                await Task.Delay(40);
                IImage.Opacity = opacity0;
                IName.Opacity = opacity0;
                IPhone.Opacity = opacity0; 
                IThemeMini.Opacity = opacity0;
                Lanf.Opacity = opacity0;
                Ques.Opacity = opacity0;
                //  MessageBox.Show(Convert.ToString(i));
                if (i == 9)
                {
                    //MessageBox.Show("S");
                    CTBack.IsEnabled = true;
                    Theme1.IsEnabled = true;
                    Theme2.IsEnabled = true;
                    Theme3.IsEnabled = true;
                    for (ii = 0; ii < 10; ii++)
                    {
                        opacity1 = opacity1 + 0.1;
                        CTBack.Opacity = opacity1;
                        if (ii == 9)
                        {
                            for (iii = 0; iii < 10; iii++)
                            {
                                opacity2 = opacity2 + 0.1;
                                Theme1.Opacity = opacity2;
                                Theme2.Opacity = opacity2;
                                Theme3.Opacity = opacity2;
                                await Task.Delay(40);
                            }
                        }
                        await Task.Delay(40);
                    }
                }
;            }
           
        }

        private void IThemeMini_MouseDown(object sender, MouseButtonEventArgs e)
        {
           // MessageBox.Show("A");
            Anim1();
        }


        private void Theme2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTheme.Source = new BitmapImage(new Uri(@"C:\Users\Igor\Pictures\Theme2.jpg"));
            CTBack.IsEnabled = false;
            Theme1.IsEnabled = false;
            Theme2.IsEnabled = false;
            Theme3.IsEnabled = false;
            opacity0 = 1;
            opacity1 = 0;
            opacity2 = 0;
            CTBack.Opacity = 0;
            Theme1.Opacity = 0;
            Theme2.Opacity = 0;
            Theme3.Opacity = 0;
            IImage.Opacity = 1;
            IName.Opacity = 1;
            IPhone.Opacity = 1;
            IThemeMini.Opacity = 1;
            Lanf.Opacity = 1;
            Ques.Opacity = 1;
        }

        private void Theme1_MouseDown(object sender, MouseButtonEventArgs e)
        {
           MainTheme.Source=new BitmapImage(new Uri(@"C:\Users\Igor\Pictures\Theme3.jpg"));
            CTBack.IsEnabled = false;
            Theme1.IsEnabled = false;
            Theme2.IsEnabled = false;
            Theme3.IsEnabled = false;
            opacity0 = 1;
            opacity1 = 0;
            opacity2 = 0;
            CTBack.Opacity = 0;
            Theme1.Opacity = 0;
            Theme2.Opacity = 0;
            Theme3.Opacity = 0;
            IImage.Opacity = 100;
            IName.Opacity = 100;
            IPhone.Opacity = 100;
            IThemeMini.Opacity = 100;
            Lanf.Opacity = 100;
            Ques.Opacity = 100;
        }

        private void Theme3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainTheme.Source = new BitmapImage(new Uri(@"C:\Users\Igor\Pictures\Theme1.jpg"));
            CTBack.IsEnabled = false;
            Theme1.IsEnabled = false;
            Theme2.IsEnabled = false;
            Theme3.IsEnabled = false;
            opacity0 = 1;
            opacity1 = 0;
            opacity2 = 0;
            CTBack.Opacity = 0;
            Theme1.Opacity = 0;
            Theme2.Opacity = 0;
            Theme3.Opacity = 0;
            IImage.Opacity = 1;
            IName.Opacity = 1;
            IPhone.Opacity = 1;
            IThemeMini.Opacity = 1;
            Lanf.Opacity = 1;
            Ques.Opacity = 1;
        }

        private void IImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DynamResize();
        }
        async void DynamResize()
        {
            ScaleTransform KST = new ScaleTransform();
            TransformGroup NTG = new TransformGroup();
            NTG.Children.Add(KST);
            IImage.RenderTransform = NTG;
            for (int tt = 0; tt < 20; tt++)
            {
                si = si - 0.05;
                KST.ScaleX = si;
                KST.ScaleY = si;
                await Task.Delay(25);
                if (tt == 19)
                {
                    asas.ImageSource = new BitmapImage(new Uri(@"C:\Users\Igor\source\repos\p33\p33\Image\Dai.png"));
                    si = 0;
                    await Task.Delay(500);
                    for(int ttt = 0; ttt < 20; ttt++)
                    {
                        si = si + 0.05;
                        KST.ScaleX = si;
                        KST.ScaleY = si;
                        await Task.Delay(25);
                    }
                }
            }
        }

        private void Ques_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DynamResize();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }
    
        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            A11.Foreground = Brushes.Green;
            IName.Text = Name.Text;
        }

        private void SurName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            A12.Foreground = Brushes.Green;
        }

        private void Phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            A13.Foreground = Brushes.Green;
            IPhone.Text = Phone.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            a1 = Name.Text;
            a2 = SurName.Text;
            a3 = Phone.Text;
            a4 = null;
            a5 = true;
            Window2 W2 = new Window2();
            if ((Name.Text != "") && (SurName.Text != "") && (Phone.Text != ""))
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=desktop-403shtp\igorsql;Initial Catalog=Users;Integrated Security=True;ConnectRetryCount=2;ConnectRetryInterval=3"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Info (Login, Name, Surname, Phone,InBase) " +
                        "VALUES(@Login, @Name, @Surname, @Phone, @InBase)", connection);
                    command.Parameters.AddWithValue("Login", Loginn);
                    command.Parameters.AddWithValue("Name", a1);
                    command.Parameters.AddWithValue("Surname", a2);
                    command.Parameters.AddWithValue("Phone", a3);
                    command.Parameters.AddWithValue("InBase", a5);
                    
                    MessageBox.Show("Registration is over, Sir");
                    command.ExecuteNonQuery();
                    W2.Show();
                    SqlDataAdapter sda1 = new SqlDataAdapter("Select Name From Info where Login = '" + Loginn + "'", connection);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    MessageBox.Show(Convert.ToString(dt1));
                    W2.Name.Text = Convert.ToString(dt1.Rows[0][0]);
                    
                    this.Close();
                    
                }
            }
            else if (Name.Text == "")
            {
                A11.Foreground = Brushes.Red;
            }
            else if (SurName.Text == "")
            {
                A12.Foreground = Brushes.Red;
            }
            else if (Phone.Text == "")
            {
                A13.Foreground = Brushes.Red;
            }

        }
    }
}
