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
    /// Interaction logic for PatientRoom.xaml
    /// </summary>
    public partial class PatientRoom : Window
    {
        public PatientRoom()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.nameData.Content = Client.ClientInstance.info.name + " " + Client.ClientInstance.info.sourname;

            string[] arr = Client.ClientInstance.MedClient.GetHospitals();
            this.listbox1.ItemsSource = arr;
        }

        public DateTime dateTime;

        private void selectDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            SelectDoctorTime room = new SelectDoctorTime(dateTime);
            room.Owner = this;
            room.ShowDialog();

            
        }
    }
}
