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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBirthDate.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            lstLetters.Items.Clear();
            string firstname, lastname, birthdate;
            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            birthdate = txtBirthDate.Text;
            DateTime bday = DateTime.Now; //sets it to the current date and time at tthis exact moment
            bday = Convert.ToDateTime(birthdate);

            string fullname = firstname + " " + lastname;
            foreach (var letter in fullname)
            {
                lstLetters.Items.Add(letter);
            }
            string message = $"{ fullname} born on {bday.DayOfWeek}, \n Thank you for submitting!";

            MessageBox.Show(message);

        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
