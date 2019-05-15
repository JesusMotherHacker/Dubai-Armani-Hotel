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

namespace Hotel_Armani2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string L;
        public string P;
        public string C;
        public SolidColorBrush Fill;
        public int i;
        public int ii;
        public int Timer;
        public int Timer2;
        public string[] Transp = new string[11] { "#FF632626", "#E5632626", "#E5632626", "#B2632626", "#99632626", "#7F632626", "#66632626", "#4C632626", "#33632626", "#19632626", "#00632626" };
        public string[] Pikcha = new string[4] { @"C:\All sthukes\Курсач\lobby1.jpg", @"C:\All sthukes\Курсач\lobby2.jpg", @"C:\All sthukes\Курсач\lobby3.jpg", @"C:\All sthukes\Курсач\Armani.jpg" };
        public bool cancel;
        public bool LangC=true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //LogChe = metroTextBox1.Text;
            if ((loginTextBox.Text != "") && (passwordTextBox.Text != ""))
            {
                L = loginTextBox.Text;
                P = passwordTextBox.Text;
                Login Start = new Login(L, P);
                Checker.Text = Start.c;
                using (SqlConnection c = new SqlConnection(@"Data Source=desktop-403shtp\igorsql;Initial Catalog=Users;Integrated Security=True;ConnectRetryCount=2;ConnectRetryInterval=3"))
                {
                    c.Open();
                    SqlCommand CheckInBase = new SqlCommand("SELECT Login FROM Users WHERE Root = '1' and Login = '" + L + "'", c);
                    SqlDataReader reader = CheckInBase.ExecuteReader();
                    if (reader.Read())
                    {
                        //              MessageBox.Show("U r in Base");
                        //  MessageBox.Show("Admin");

                    }
                    else
                    {
                        //  MessageBox.Show("NeAdmin");
                    }
                }

            }
            else
            {
                Checker.Text = "Input something.*          ";
            }          
        }

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            if ((loginTextBox.Text != "") && (passwordTextBox.Text != ""))
            {
                L = loginTextBox.Text;
                P = passwordTextBox.Text;
                Registration RStart = new Registration(L, P);
                Checker.Text = RStart.c;

            }
        }

        public void TestT(object sender, MouseEventArgs e)
        {

        }
        async void TimerT()
        {
            cancel = true;
            Random random = new Random();
            for (ii = 0; ii < 4; ii++)
            {
                
                BackGorund.Source = new BitmapImage(new Uri(Pikcha[random.Next(0, 4)]));
                for (i = 10; i >= 0; i--)
                {
                    BackGorund.OpacityMask = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Transp[i]));
                    if (i == 0)
                    {
                        await Task.Delay(1000);
                    }
                    await Task.Delay(50);
                }
                for (i = 0; i < 11; i++)
                {
                    BackGorund.OpacityMask = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Transp[i]));
                    await Task.Delay(50);
                }
                if (ii == 3)
                    ii = 0;
            }
        }

        private void BackGorund_MouseEnter(object sender, MouseEventArgs e)
        {
            if(cancel==false)
            TimerT();
            else
                BackGorund.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\Armani.jpg"));
        }

        private void BackGorund_MouseLeave(object sender, MouseEventArgs e)
        {
            cancel = true;        
        }
       
        private void Lanf_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (LangC == true)
            {
                ENG();
                LangC = false;
                goto TheEnd;
            }
            if (LangC == false)
            {
                RUS();
                LangC = true;
                goto TheEnd;
            }
            TheEnd:;

        }
        public void ENG()
        {
              
                loginTextBox.Text = "Login";
                passwordTextBox.Text = "Password";
                loginButton.Content =        "        Login        ";
                registrationButton.Content = "   Registration   ";


              //  MessageBox.Show("ENG");
        }
        public void RUS()
        {
           
            loginTextBox.Text = "Логин";
            passwordTextBox.Text = "Пароль";
            loginButton.Content =            "        Вход         ";
            registrationButton.Content =     "  Регистрация  ";   
           // MessageBox.Show("RUS");
            
        }

        private void loginButton_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
