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

namespace MedClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Client.Path = @"http://192.168.0.158:8085/MedWCF.svc";
            Client.ClientInstance.Login(loginText.Text, password_Text.Password);
            
            if (Client.ClientInstance.Logged)
            {
                Room room = new Room();
                room.Owner = this;
                this.Hide();
                room.Show();
            }
            else
            {
                BangEffect(250);
            }


        }

        private void BangEffect(int millisec)
        {
            double l = this.Left;
            double up = this.Top;
            Random r = new Random();
            for (int i = 0; i < millisec; i++)
            {
                System.Threading.Thread.Sleep(1);
                this.Left = l + r.Next(-5, 5);
                this.Top = up + r.Next(-5, 5);

            }
        }



        



    }
}
