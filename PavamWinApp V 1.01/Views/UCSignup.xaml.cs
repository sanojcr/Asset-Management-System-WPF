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
using PavamWinApp.Models;

namespace PavamWinApp
{
    /// <summary>
    /// Interaction logic for UCSignup.xaml
    /// </summary>
    /// Now i am focusing more on design and fumctionality.
    ///
    public partial class UCSignup : UserControl
    {
        readonly PavamDBEntities context = new PavamDBEntities();
        public UCSignup()
        {
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

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            if (PrivacyCb.IsChecked==true)
            {
                if (PasswordTb.Password.Equals(CPasswordTb.Password))
                {
                    TblUser tblUser = new TblUser()
                    {
                        Name = NameTb.Text,
                        Email = EmailTb.Text,
                        Password = PasswordTb.Password,
                        Amount = 0,
                    };
                    try
                    {
                        context.TblUsers.Add(tblUser);
                        context.SaveChanges();
                        MessageBox.Show("You can signin using " + EmailTb.Text);
                        UCLogin uCLogin = new UCLogin();
                        UCSignupSP.Children.Clear();
                        UCSignupSP.Children.Add(uCLogin);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Password are not matching");
                }
            }
            else
            {
                MessageBox.Show("You forget to check privacy policy");
            }
        }

        private void ButtonSignin_Click(object sender, RoutedEventArgs e)
        {
            UCLogin uCLogin = new UCLogin();
            UCSignupSP.Children.Clear();
            UCSignupSP.Children.Add(uCLogin);
        }
    }
}
