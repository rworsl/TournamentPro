using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for Teams.xaml
    /// </summary>
    public partial class Teams
    {
        List<string> playersA;
        List<string> playersB;
        List<string> playersC;

        List<string> t1 = new List<string>();
        List<string> t2 = new List<string>();
        List<string> t3 = new List<string>();
        List<string> t4 = new List<string>();
        List<string> t5 = new List<string>();
        List<string> t6 = new List<string>();
        List<string> t7 = new List<string>();
        List<string> t8 = new List<string>();

        string t1players = "";
        string t2players = "";
        string t3players = "";
        string t4players = "";
        string t5players = "";
        string t6players = "";
        string t7players = "";
        string t8players = "";


        public Teams(List<string> players1, List<string> players2, List<string> players3)
        {
            playersA = players1;
            playersB = players2;
            playersC = players3;
            InitializeComponent();
            playerAssign();
            printTeams();
        }

        private void playerAssign()
        {

            var random = new Random();
            int index = random.Next(playersA.Count);
            int index2 = random.Next(playersB.Count);
            int index3 = random.Next(playersC.Count);

            t1.Add(playersA[index]);
            playersA.RemoveAt(index);
            t1.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t1.Add(playersC[index3]);
            playersC.RemoveAt(index3);

            index = random.Next(playersA.Count);
            index2 = random.Next(playersB.Count);
            index3 = random.Next(playersC.Count);

            t2.Add(playersA[index]);
            playersA.RemoveAt(index);
            t2.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t2.Add(playersC[index3]);
            playersC.RemoveAt(index3);

            index = random.Next(playersA.Count);
            index2 = random.Next(playersB.Count);
            index3 = random.Next(playersC.Count);

            t3.Add(playersA[index]);
            playersA.RemoveAt(index);
            t3.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t3.Add(playersC[index3]);
            playersC.RemoveAt(index3);

            index = random.Next(playersA.Count);
            index2 = random.Next(playersB.Count);
            index3 = random.Next(playersC.Count);

            t4.Add(playersA[index]);
            playersA.RemoveAt(index);
            t4.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t4.Add(playersC[index3]);
            playersC.RemoveAt(index3);

            index = random.Next(playersA.Count);
            index2 = random.Next(playersB.Count);
            index3 = random.Next(playersC.Count);

            t5.Add(playersA[index]);
            playersA.RemoveAt(index);
            t5.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t5.Add(playersC[index3]);
            playersC.RemoveAt(index3);

            index = random.Next(playersA.Count);
            index2 = random.Next(playersB.Count);
            index3 = random.Next(playersC.Count);

            t6.Add(playersA[index]);
            playersA.RemoveAt(index);
            t6.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t6.Add(playersC[index3]);
            playersC.RemoveAt(index3);

            index = random.Next(playersA.Count);
            index2 = random.Next(playersB.Count);
            index3 = random.Next(playersC.Count);

            t7.Add(playersA[index]);
            playersA.RemoveAt(index);
            t7.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t7.Add(playersC[index3]);
            playersC.RemoveAt(index3);

            index = random.Next(playersA.Count);
            index2 = random.Next(playersB.Count);
            index3 = random.Next(playersC.Count);

            t8.Add(playersA[index]);
            playersA.RemoveAt(index);
            t8.Add(playersB[index2]);
            playersB.RemoveAt(index2);
            t8.Add(playersC[index3]);
            playersC.RemoveAt(index3);
        }

        private void printTeams()
        {
            foreach (var i in t1)
            {
                t1players += i + "\n";
            }
            team1.Text = t1players;

            foreach (var i in t2)
            {
                t2players += i + "\n";
            }
            team2.Text = t2players;

            foreach (var i in t3)
            {
                t3players += i + "\n";
            }
            team3.Text = t3players;

            foreach (var i in t4)
            {
                t4players += i + "\n";
            }
            team4.Text = t4players;

            foreach (var i in t5)
            {
                t5players += i + "\n";
            }
            team5.Text = t5players;

            foreach (var i in t6)
            {
                t6players += i + "\n";
            }
            team6.Text = t6players;

            foreach (var i in t7)
            {
                t7players += i + "\n";
            }
            team7.Text = t7players;

            foreach (var i in t8)
            {
                t8players += i + "\n";
            }
            team8.Text = t8players;
        }
    }
}
