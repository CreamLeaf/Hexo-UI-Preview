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

using Hexo_UI_Preview.Panels;
using Hexo_UI_Preview.Static_Files;

namespace Hexo_UI_Preview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Viewport ViewportPanel;
        Panels.Properties PropertiesPanel;
        IntPtr Hwnd;

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            Left = 0;
            Top = 0;
            Width = (int)SystemParameters.WorkArea.Width;
            Height = (int)SystemParameters.WorkArea.Height;

            
            //window1.Owner = this;
            //window1.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //window1.Show();
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            Hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;

            ViewportPanel = new Viewport();
            WindowMethods.OpenChildWin(ViewportPanel, this, WindowStartupLocation.Manual, new Point(3, 2));

            PropertiesPanel = new Panels.Properties();
            WindowMethods.OpenChildWin(PropertiesPanel, this, WindowStartupLocation.Manual, new Point(400, 400));

            PropertiesPanel.LoadProperties<int>(new Property[1]
            {
                new Property(new object[3]{ new Vector3(4, 50, 3), new Vector3(4, 50, 3), new Vector3(4, 50, 3) }, Property.PropertyType.Transform)
            });

            System.
            
        }
    }
}
