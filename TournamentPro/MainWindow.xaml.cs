﻿using System;
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
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> playersA = CategoryA.Items.
            List<string> playersB = CategoryB.Items.Cast<String>().ToList();
            List<string> playersC = CategoryC.Items.Cast<String>().ToList();

            var newForm = new Teams(playersA, playersB, playersC); //create your new form.
            newForm.Show();
            this.Close();

            /*if (CategoryA.Items.Count != CategoryB.Items.Count || CategoryA.Items.Count != CategoryC.Items.Count)
            {
                TextDebug.Text = "Uneven number of items";
            }
            else
            {
                TextDebug.Text = "Even number of items";
            }*/
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
