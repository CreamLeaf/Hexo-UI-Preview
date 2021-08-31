using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hexo_UI_Preview.Static_Files
{
    public class WindowMethods
    {
        public static void OpenChildWin(Window ChildWindow, Window ParentWindow)
        {
            ChildWindow.Topmost = false;
            ChildWindow.Owner = ParentWindow;
            ChildWindow.Show();
        }

        public static void OpenChildWin(Window ChildWindow, Window ParentWindow, WindowStartupLocation StartupLocation)
        {
            ChildWindow.Topmost = false;
            ChildWindow.Owner = ParentWindow;
            ChildWindow.WindowStartupLocation = StartupLocation;
            ChildWindow.Show();
        }

        public static void OpenChildWin(Window ChildWindow, Window ParentWindow, WindowStartupLocation StartupLocation, Point Location)
        {
            ChildWindow.Topmost = false;
            ChildWindow.Owner = ParentWindow;
            ChildWindow.WindowStartupLocation = StartupLocation;
            ChildWindow.Top = Location.Y;
            ChildWindow.Left = Location.X;
            ChildWindow.Show();
        }
    }

    public class PropertyMethods
    {
        public static void LoadProperties(object[] Properties, Panels.Properties Panel)
        {
            //Panel.LoadProperties()
        }
    }
}
