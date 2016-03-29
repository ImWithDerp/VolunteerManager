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
using VolunteerManager.Menus;

namespace VolunteerManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow rootWindow = null;

        public MainWindow()
        {
            InitializeComponent();
            rootWindow = this;

            SwitchMenu(new MainMenu());
        }

        public static void SwitchMenu(BaseMenu menu)
        {
            if (rootWindow.Content as BaseMenu != null)
                (rootWindow.Content as BaseMenu).OnClose();

            rootWindow.Content = menu;

            if (rootWindow.Content as BaseMenu != null)
                (rootWindow.Content as BaseMenu).OnOpen();
        }
    }
}
