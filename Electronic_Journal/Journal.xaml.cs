using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Electronic_Journal
{
    /// <summary>
    /// Логика взаимодействия для Journal.xaml
    /// </summary>
    public partial class Journal : Window
    {
        public Journal()
        {
            InitializeComponent();
            using (var db = new Entities())
            {
                Session.CurrentUser.Log.ToList().ForEach(g => groups.Items.Add(g.Group1));
            }
        }

        private void filter_groups(object sender, TextChangedEventArgs e)
        {
            groups.Items.Clear();
            using (var db = new Entities())
            {
                Session.CurrentUser.Log.ToList().ForEach(i =>
                {
                    if (i.Group1.Code.Contains(filter.Text)) groups.Items.Add(i.Group1);
                });
            }

        }

        private void groups_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Session.CurrentGroup = groups.SelectedItem as Group;
            GroupWindow groupWindow = new GroupWindow();
            Hide();
            groupWindow.ShowDialog();
            Show();
        }
    }
}
