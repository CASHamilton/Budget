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

using Budget.Model;

using Budget.ViewModel;

namespace Budget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly MainViewModel mvm;
        public MainWindow()
        {
            InitializeComponent();
            mvm = DataContext as MainViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var ent = new DataEntities())
                {
                    var item = (from a in ent.user where a.username == username.Text select a).FirstOrDefault();

                    if(item == null)
                    {
                        //this is a new user
                        //add the new user
                        item = new user();
                        item.username = username.Text;
                        item.password = password.Text;
                        item.email = email.Text;

                        ent.user.Add(item);
                        ent.SaveChanges();
                    }
                    else
                    {
                        username.Text = "ERROR";
                        password.Text = "ERROR";
                        email.Text = "ERROR";
                    }
                }
            }
            catch(Exception ex)
            {
                //TODO later
            }
        }
    }
}
