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
    /// Interaction logic for SelectDoctorTime.xaml
    /// </summary>
    public partial class SelectDoctorTime : Window
    {
        private DateTime dateTime;
        public SelectDoctorTime(DateTime dateTime)
        {
            InitializeComponent();
            this.dateTime = dateTime;
        }

        private void SelectDoctorTime1_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 24; i++)
                this.hours.Items.Add("" + i);

            for (int i = 0; i < 60; i++)
                this.minutes.Items.Add("" + i);
        }

        private void selectDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            double hours = 0;
            double minutes = 0;
            dateTime.AddHours(hours);
            dateTime.AddMinutes(minutes);

            string mess = Client.ClientInstance.MedClient.AddToJournal(0, Client.ClientInstance.info.id, dateTime);
        }
    }
}
