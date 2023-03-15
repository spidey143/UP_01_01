using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Electronic_Journal
{
    /// <summary>
    /// Логика взаимодействия для GroupWindow.xaml
    /// </summary>
    public partial class GroupWindow : Window
    {
        public GroupWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            disciplines.Items.Clear();
            using (var db = new Entities())
            {
                Session.CurrentGroup.Log
                    .Where(j => j.Group1 == Session.CurrentGroup)
                    .ToList().ForEach(j => disciplines.Items.Add(j.Discipline1));
                Session.CurrentGroup.Student.ToList().ForEach(s => students.Items.Add(s));
            }

        }
    }
}
