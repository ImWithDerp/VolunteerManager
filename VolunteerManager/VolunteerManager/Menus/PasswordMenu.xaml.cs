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
    /// Interaction logic for PasswordMenu.xaml
    /// </summary>
    public partial class PasswordMenu : BaseMenu
    {
        public PasswordMenu()
        {
            InitializeComponent();
        }

        public override void OnOpen()
        {

        }

        public override void OnClose()
        {

        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SwitchMenu(new AdminMenu());
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SwitchMenu(new MainMenu());
        }
    }
}
