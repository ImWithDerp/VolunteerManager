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

namespace VolunteerManager.Menus
{
    /// <summary>
    /// Interaction logic for SignInMenu.xaml
    /// </summary>
    public partial class SignInMenu : BaseMenu
    {
        public SignInMenu()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            nameBox.Items.Add("George Jetson");
            nameBox.Items.Add("John Conner");
            nameBox.Items.Add("Marco Polo");
            nameBox.Items.Add("Bob Morton");

            areaBox.Items.Add("Animal Support");
            areaBox.Items.Add("Cats");
            areaBox.Items.Add("Dog Walking");
            areaBox.Items.Add("Pet Barn");
        }

        public override void OnOpen()
        {
            date.Content = "For " + DateTime.Now.ToShortDateString();

            Populate();
        }

        public override void OnClose()
        {

        }

        private void signinTimeButton_Click(object sender, RoutedEventArgs e)
        {
            signinDate.Text = DateTime.Now.ToShortTimeString();
        }

        private void signoutTimeButton_Click(object sender, RoutedEventArgs e)
        {
            signoutDate.Text = DateTime.Now.ToShortTimeString();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SwitchMenu(new MainMenu());
        }
    }
}
