using BusinessObjects;
using DataAccessLayer;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseManagement
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            CourseManagementDbContext db = new CourseManagementDbContext();
            if (txtUserName.Text == "" || txtPassword.Password == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            else
            {
                string username = txtUserName.Text;
                string password = txtPassword.Password;
                AccountMember accountMember = AccountMemberDAO.CheckExist(username, password);
                if (accountMember == null)
                {
                    MessageBox.Show("Username or Password incorrect!");
                }
                else
                {
                    Home home = new Home(accountMember);
                    home.Show();
                    this.Close();
                }
            }
        }

    }
}
