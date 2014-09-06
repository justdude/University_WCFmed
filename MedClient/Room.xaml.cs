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

using System.Collections.ObjectModel;

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
            
            var pacients = new List<Pacient>();
            var ppp = new ServiceReference1.peoples();
            ppp.id = 1;
            ppp.name = "ivan";
            ppp.sourname = "Albantov";
            ppp.hospitals_id = 1;

            pacients.Add(new Pacient(ppp, "Hospital1", "desease1", "doctor"));
            pacients.Add(new Pacient(ppp, "Hospital2", "desease1", "doctor"));
            pacients.Add(new Pacient(ppp, "Hospital3", "desease1", "doctor"));

            this.pacients.ItemsSource = pacients;

            FillDataAbout();
        }

        private void FillDataAbout()
        {
           /* this.name.Text = Client.ClientInstance.info.name;
            this.sourname.Text = Client.ClientInstance.info.sourname;
            this.age.Content = Client.ClientInstance.info.age.ToString();*/

            this.name.Text = "Ivan";
            this.sourname.Text = "Albantov";
            this.age.Content = "21";
            //this.hospital_name.Content = Client.ClientInstance. Client.ClientInstance.info.hospitals_id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
