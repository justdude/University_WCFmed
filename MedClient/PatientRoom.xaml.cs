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


            var des = Client.ClientInstance.MedClient.GetDeseases();

            deseasesCombo.ItemsSource = des;

            FillDataAbout();
            targetDate.Text = DateTime.Today.ToShortDateString();

            for (int i = 0; i < 24; i++)
                targetTime.Items.Add(i.ToString());
            targetTime.SelectedIndex = 12;
        }

        private void FillDataAbout()
        {
            this.name.Text = Client.ClientInstance.info.name;
            this.sourname.Text = Client.ClientInstance.info.sourname;
            this.age.Content = Client.ClientInstance.info.age.ToString();
            //this.hospital_name.Content = Client.ClientInstance. Client.ClientInstance.info.hospitals_id;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            List<Hospital> hospitals = new List<Hospital>();
            var hash = Client.ClientInstance.MedClient.GetHospitalsListBy(this.deseasesCombo.SelectedIndex);
           
            foreach (var el in hash)
            {
                Hospital hosp = new Hospital();
                hosp.hospital = el.Key.ToString();
                hosp.doctor = el.Value.ToString()+"asd";
                hospitals.Add(hosp);
            }
            this.doctorsListBox.ItemsSource = hospitals;
        }

        private void Assign_Click(object sender, RoutedEventArgs e)
        {
            if (doctorsListBox.Items.Count > 0 && doctorsListBox.SelectedIndex>-1)
            {
                //doctorsListBox.SelectedIndex
            }
        }
    }
}
