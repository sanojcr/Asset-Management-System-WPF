using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
using PavamWinApp.Models;

namespace PavamWinApp
{
    /// <summary>
    /// Interaction logic for UCLogin.xaml
    /// </summary>
    public partial class UCLogin : UserControl
    {
        public static int UserId;
        readonly PavamDBEntities context = new PavamDBEntities();

        public UCLogin()
        {
            this.Resources["useridColor"] = new SolidColorBrush(Colors.DarkRed);
            InitializeComponent();
        }

        private void Button_WindowClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_WindowMaximize_Click(object sender, RoutedEventArgs e)
        {
            /*if (Application.Current.MainWindow.WindowState.Equals(WindowState.Maximized))
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }*/
        }

        private void Button_WindowMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Application.Current.MainWindow.DragMove();
            }
        }
        private void ButtonSignup_Click(object sender, RoutedEventArgs e)
        {
            UCSignup uCSignup = new UCSignup();
            UCLoginSP.Children.Clear();
            UCLoginSP.Children.Add(uCSignup);
        }

        private void ButtonSignin_Click(object sender, RoutedEventArgs e)
        {
            if (EmailTb.Text!=null && PasswordTb.Password!=null)
            {
                TblUser tblUser = context.TblUsers.FirstOrDefault(u => u.Email == EmailTb.Text && u.Password == PasswordTb.Password);
                if (tblUser != null)
                {
                    UserId = tblUser.Id;
                    UCHome uCHome = new UCHome();
                    UCLoginSP.Children.Clear();
                    UCLoginSP.Children.Add(uCHome);
                }
                else
                {
                    MessageBox.Show("Sorry we could'nt find your account");
                }
            }
            else {
                MessageBox.Show("Enter fields properly");
            }
        }
    }
}
