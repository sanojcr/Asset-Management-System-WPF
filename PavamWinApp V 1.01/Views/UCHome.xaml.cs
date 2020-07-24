using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PavamWinApp.Models;
using PavamWinApp.Views;

namespace PavamWinApp
{
    /// <summary>
    /// Interaction logic for UCHome.xaml
    /// </summary>
    public partial class UCHome : UserControl
    {
        readonly PavamDBEntities context = new PavamDBEntities();
        public TblUser tblUser;
        public string myName;
        public string MyName {
            get
            {
                return myName;
            } 
            set {
            } 
        }
        public UCHome()
        {
            tblUser = context.TblUsers.Find(UCLogin.UserId);
            myName = tblUser.Name;
            DataContext = this;
            InitializeComponent();
            UCCatagories uCCatagories = new UCCatagories();
            MenuSP.Children.Clear();
            MenuSP.Children.Add(uCCatagories);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Application.Current.MainWindow.DragMove();
            }
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void Signout_Click(object sender, RoutedEventArgs e)
        {
            UCLogin uCLogin = new UCLogin();
            UCHomeSP.Children.Clear();
            UCHomeSP.Children.Add(uCLogin);
        }
    }
}
