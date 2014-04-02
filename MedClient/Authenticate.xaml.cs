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
            Client.Path = @"http://25.110.206.54:8085/MedWCF.svc";
            Client.ClientInstance.Login(loginText.Text, password_Text.Password);
            
            if (Client.ClientInstance.Logged)
            {

                if (doctorType.IsChecked.Value)
                {

                    Room room = new Room();
                    room.Owner = this;
                    this.Hide();
                    room.Show();
                }
                else if (pacientType.IsChecked.Value)
                {
                    PatientRoom room = new PatientRoom();
                    room.Owner = this;
                    this.Hide();
                    room.Show();
                }
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

        private double sizeX = 0;
        private double sizeY = 0;
        private bool started = false;

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!started)
            {
                started = true;
                return;
            }

            if (tabControl.SelectedIndex == 0)
            {
                this.Width = sizeX;
                this.Height = sizeY;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                this.Width = 485;
                this.Height = 425;
                if (Client.ClientInstance.Logged)
                    return;

                string[] arr = Client.ClientInstance.MedClient.GetHospitals();
                this.hospitals.ItemsSource = arr;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sizeX = this.Width;
            sizeY = this.Height;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Client.ClientInstance.Logged)
            {
                if (isDoctor.IsChecked.Value)
                {
                    sbyte sex = 0;
                    Client.ClientInstance.MedClient.RegDoctor(sourname.Text,
                                          password.Text,
                                          name.Text,
                                          hospitals.SelectedIndex,
                                          sex,
                                          int.Parse(age.Text),
                                          "decease",
                                          "state",
                                          3);
                }
                else
                {
                    sbyte sex = 0;
                    //pass, name, hospitalId, sex, age, decease, state);
                    Client.ClientInstance.MedClient.RegPatien(sourname.Text,
                                                              password.Text,
                                                              name.Text,
                                                              hospitals.SelectedIndex,
                                                              sex,
                                                              int.Parse(age.Text),
                                                              "decease",
                                                              "state");
                }

            }
        }



        



    }
}
