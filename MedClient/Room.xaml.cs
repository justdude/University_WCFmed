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

namespace MedClient
{
    /// <summary>
    /// Interaction logic for Room.xaml
    /// </summary>
    public partial class Room : Window
    {
        public Room()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {          
            this.name.Text = Client.ClientInstance.info.name;
            this.sourname.Text = Client.ClientInstance.info.sourname;
            this.age.Text = Client.ClientInstance.info.age.ToString();
            //this.hospital_name.Content = Client.ClientInstance. Client.ClientInstance.info.hospitals_id;

            string[] arr = Client.ClientInstance.MedClient.GetHospitals();
            foreach (string st in arr)
                this.hospitals.Items.Add(st);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
