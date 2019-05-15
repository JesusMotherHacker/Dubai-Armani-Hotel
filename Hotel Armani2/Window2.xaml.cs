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
using System.Windows.Shapes;

namespace Hotel_Armani2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Window3 w3 = new Window3();
        public string[] Pikcha = new string[4] { @"C:\All sthukes\Курсач\B1.jpg", @"C:\All sthukes\Курсач\B1.jpg", @"C:\All sthukes\Курсач\B1.jpg", @"C:\All sthukes\Курсач\B1.jpg" };
        public double i;
        public int doCount;
        public int ii;
        public double Move;
        public double chekking;
        public int aa = 2;
        public bool asa = true;
        public Window2()
        {
            InitializeComponent();
        }

        private void Lux1_MouseEnter(object sender, MouseEventArgs e)
        {
            //   TextR.Text = "Nize apparts: \n -For 2 people\n -1 Bed\n -Nise WindowView";      
            P1.Opacity = 1;
            P2.Opacity = 1;
            Be1.Opacity = 1;
            Lux1.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\111.png"));
            SlidesR.Source= new BitmapImage(new Uri(@"C:\All sthukes\Курсач\G1.jpg"));
        }      
        private void Lux1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            w3.Show();
        }
        
            private void Lux1_MouseLeave(object sender, MouseEventArgs e)
        {
            P1.Opacity = 0;
            P2.Opacity = 0;
            Be1.Opacity = 0;
            Lux1.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\Lux1.png"));
            SlidesR.Source = null;
         //   TextR.Text =null;
        }

        private void Lux2_MouseEnter(object sender, MouseEventArgs e)
        {
            P1.Opacity = 1;
            P2.Opacity = 1;
            P3.Opacity = 1;
            Be1.Opacity = 1;
            Be2.Opacity = 1;
            SlidesR.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\G2.jpg"));
          //  TextR.Text = "Top apparts: \n -For 3 people\n -3 Beds\n -Great WindowView";
            Lux2.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\111.png"));
        }

        private void Lux2_MouseLeave(object sender, MouseEventArgs e)
        {
            P1.Opacity = 0;
            P2.Opacity = 0;
            P3.Opacity = 0;
            Be1.Opacity = 0;
            Be2.Opacity = 0;
            SlidesR.Source = null;
         //   TextR.Text = null;
            Lux2.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\Lux1.png"));
        }

        private void C1_MouseEnter(object sender, MouseEventArgs e)
        {
            P1.Opacity = 1;
            P2.Opacity = 1;
            P3.Opacity = 1;
            P4.Opacity = 1;
            Be1.Opacity = 1;
            Be2.Opacity = 1;
            Be3.Opacity = 1;
            //   TextR.Text = "Not Bed Apparts: \n -For Family\n -2 Adult,1 Child\n -2 Bed\n -Nise WindowView";
            C1.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\C11.png"));
            SlidesR.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\B1.jpg"));
        }
        private void C1_MouseLeave(object sender, MouseEventArgs e)
        {
            P1.Opacity = 0;
            P2.Opacity = 0;
            P3.Opacity = 0;
            P4.Opacity = 0;
            Be1.Opacity = 0;
            Be2.Opacity = 0;
            Be3.Opacity = 0;
            //    TextR.Text = null;
            C1.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\C1.png"));
            SlidesR.Source =null;
        }

        private void C2_MouseEnter(object sender, MouseEventArgs e)
        {
            P1.Opacity = 1;
            P2.Opacity = 1;
            P3.Opacity = 1;
            P4.Opacity = 1;
            Be1.Opacity = 1;
            Be2.Opacity = 1;
            //   TextR.Text = "Not Bed Apparts: \n -For Family\n -2 Adult,1 Child\n -2 Bed\n -Nise WindowView";
            C2.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\C11.png"));
            SlidesR.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\G1.jpg"));
        }
        private void C2_MouseLeave(object sender, MouseEventArgs e)
        {
            P1.Opacity = 0;
            P2.Opacity = 0;
            P3.Opacity = 0;
            P4.Opacity = 0;
            Be1.Opacity = 0;
            Be2.Opacity = 0;
            //    TextR.Text = null;
            C2.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\C1.png"));
            SlidesR.Source = null;
        }

        private void B1_MouseEnter(object sender, MouseEventArgs e)
        {
            P1.Opacity = 1;
            P2.Opacity = 1;
            P3.Opacity = 1;
            P4.Opacity = 1;
            P5.Opacity = 1;
            Be1.Opacity = 1;
            Be2.Opacity = 1;
            Be3.Opacity = 1;
            Be4.Opacity = 1;
            Be5.Opacity = 1;
            //   TextR.Text = "Not Bed Apparts: \n -For Family\n -2 Adult,1 Child\n -2 Bed\n -Nise WindowView";
            B1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Igor\Pictures\564.jpg"));
            SlidesR.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\G1.jpg"));
        }
        private void B1_MouseLeave(object sender, MouseEventArgs e)
        {
            P1.Opacity = 0;
            P2.Opacity = 0;
            P3.Opacity = 0;
            P4.Opacity = 0;
            P5.Opacity = 0;
            Be1.Opacity = 0;
            Be2.Opacity = 0;
            Be3.Opacity = 0;
            Be4.Opacity = 0;
            Be5.Opacity = 0;
            //   TextR.Text = null;
            B1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Igor\Pictures\565.png"));
            SlidesR.Source = null;
        }

        private void B2_MouseEnter(object sender, MouseEventArgs e)
        {
            P1.Opacity = 1;
            P2.Opacity = 1;
            Be1.Opacity = 1;
            //    TextR.Text = "Not Bed Apparts: \n -For Family\n -2 Adult,1 Child\n -2 Bed\n -Nise WindowView";
            B2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Igor\Pictures\564.jpg"));
            SlidesR.Source = new BitmapImage(new Uri(@"C:\All sthukes\Курсач\B1.jpg"));
        }
        private void B2_MouseLeave(object sender, MouseEventArgs e)
        {
            P1.Opacity = 0;
            P2.Opacity = 0;
            Be1.Opacity = 0;
            //    TextR.Text = null;
            B2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Igor\Pictures\565.png"));
            SlidesR.Source = null;
        }
        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //  MessageBox.Show("Y");
            if (asa == true)
            {
                Moving();
            }
            else
                Moving0();
        }

        async void Moving()
        {
            for (Move = 350; Move > 0; Move = Move - 10)
            {
                Profile.Margin = new Thickness(Move, 0, 0, 0);
                await Task.Delay(2);
                if (Move < 300)
                {
                    chekking = Move;
                    for (Move = chekking; Move > 0; Move = Move - 10)
                    {
                        Profile.Margin = new Thickness(Move, 0, 0, 0);
                        await Task.Delay(4);

                    }
                }
                if (Move <= 0)
                {
                    for(double ss = 0; ss <= 1; ss = ss + 0.05)
                    {
                        ProfileInfo.Opacity = ss;
                        await Task.Delay(40);
                    }
                }

            }
            asa = false;
        }
        async void Moving0()
        {
            for (Move = 10; Move < 350; Move = Move + 10)
            {
                Profile.Margin = new Thickness(Move, 0, 0, 0);
                await Task.Delay(2);
                if (Move > 300)
                {
                    chekking = Move;
                    for (Move = chekking; Move < 350; Move = Move + 10)
                    {
                        Profile.Margin = new Thickness(Move, 0, 0, 0);
                        await Task.Delay(4);

                    }
                }
                if (Move == 10)
                {
                    for (double ss = 1; ss >=0 ; ss = ss - 0.05)
                    {
                        ProfileInfo.Opacity = ss;
                        await Task.Delay(40);
                        ProfileInfo.Opacity = ss - 0.05;
                    }
                }
            }
            asa = true;
        }

    }
}
