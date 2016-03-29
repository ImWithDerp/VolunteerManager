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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class MainMenu : BaseMenu
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public override void OnOpen()
        {

        }

        public override void OnClose()
        {

        }

        private void signinButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SwitchMenu(new SignInMenu());
        }

        private void adminButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SwitchMenu(new PasswordMenu());
        }
    }
}
