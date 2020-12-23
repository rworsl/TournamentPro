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
using System.Windows.Shapes;

namespace TournamentPro
{
    /// <summary>
    /// Interaction logic for GroupStage.xaml
    /// </summary>
    public partial class GroupStage : Window
    {
        public GroupStage(List<string> t1, List<string> t2, List<string> t3, List<string> t4, List<string> t5, List<string> t6, List<string> t7, List<string> t8)
        {
            InitializeComponent();
        }
    }
}
