using ClassLibrary;
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
            using (var db = new ApplicationContext())
            {
                db.Groups.ToList().ForEach(g => groups.Items.Add(g));
            }
        }

        private void filter_groups(object sender, TextChangedEventArgs e)
        {
            groups.Items.Clear();
            using (var db = new ApplicationContext())
            {
                db.Groups.ToList().ForEach(i =>
                {
                    if (i.Code.Contains(filter.Text)) groups.Items.Add(i);
                });
            }

        }
    }
}
