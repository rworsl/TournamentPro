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
        List<string> CategoryAPlayers = new List<string>();
        List<string> CategoryBPlayers = new List<string>();
        List<string> CategoryCPlayers = new List<string>();
        public MainWindow()
        {
            Info.Text = "This is primarily set up to handle 24 players. The hope is that it will be able to handle more or less without throwing any erros, but don't get your hopes up.";
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CategoryA.Items.Count != CategoryB.Items.Count || CategoryA.Items.Count != CategoryC.Items.Count)
            {
                TextDebug.Text = "Uneven number of items";
            }
            else
            {
                TextDebug.Text = "Even number of items";
            }
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
            var nameToAdd = CAName.Text;
            CategoryB.Items.Add(nameToAdd);
            CAName.Clear();
        }
    }
}
