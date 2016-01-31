using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            progressbar.IsIndeterminate = true;
            Thread t = new Thread(FetchUsers);
            t.Start();
            
        }

        private void FetchUsers()
        {
            using (var db = new DataModel())
            {
                
                var users = from u in db.UsersVF select u;
                System.Threading.Thread.Sleep(5000);
                this.Dispatcher.Invoke((Action)(() =>
                {
                    foreach(UsersVF user in users)
                    {
                        listView.Items.Add(user);
                    }
                    progressbar.IsIndeterminate = false;
                }));
            }
        }
    }
}
