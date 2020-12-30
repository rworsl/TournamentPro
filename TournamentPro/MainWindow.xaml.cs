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

namespace TournamentPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<string> playersA = new List<string>();
        //List<string> playersB = new List<string>();
        //List<string> playersC = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //playersA = CategoryA.Items.Cast<String>().ToList();
            //playersB = CategoryB.Items.Cast<String>().ToList();
            //playersC = CategoryC.Items.Cast<String>().ToList();

            //remove before executable
            List<string> playersA = new List<string>{"Rich", "Freya", "Kevin", "Laura", "Emily", "Velez", "Neil", "Kim"};
            List<string> playersB = new List<string> { "Becky", "Barry", "George", "Katie", "Pierre", "Jude", "Mel", "Sweetcheeks" };
            List<string> playersC = new List<string> { "Lee", "Jason", "Linzi", "Alex", "Alastair", "Ah Dee", "Paul", "Andy" };


            var newForm = new Teams(playersA, playersB, playersC); //create your new form.

            newForm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CategoryA.Items.Remove(CategoryA.SelectedItem);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nameToAdd = CAName.Text;
            CategoryA.Items.Add(nameToAdd);
            CAName.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var nameToAdd = CBName.Text;
            CategoryB.Items.Add(nameToAdd);
            CBName.Clear();
        }

        private void CBRem_Click(object sender, RoutedEventArgs e)
        {
            CategoryB.Items.Remove(CategoryB.SelectedItem);
        }

        private void CCRem_Click(object sender, RoutedEventArgs e)
        {
            CategoryC.Items.Remove(CategoryC.SelectedItem);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var nameToAdd = CCName.Text;
            CategoryC.Items.Add(nameToAdd);
            CCName.Clear();
        }
    }
}
