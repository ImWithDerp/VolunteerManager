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
    public partial class AdminMenu : BaseMenu
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            nameBox.Items.Add("George Jetson");
            nameBox.Items.Add("John Conner");
            nameBox.Items.Add("Marco Polo");
            nameBox.Items.Add("Bob Morton");
                    }

        public override void OnOpen()
        {
            Populate();
        }

        public override void OnClose()
        {

        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SwitchMenu(new MainMenu());
        }
    }
}
