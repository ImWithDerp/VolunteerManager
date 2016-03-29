using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VolunteerManager.Menus
{
    public abstract partial class BaseMenu : UserControl
    {
        public abstract void OnOpen();
        public abstract void OnClose();

    }
}
