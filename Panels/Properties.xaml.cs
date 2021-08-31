using System;
using System.Collections.Generic;
using System.Collections;
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
using System.Windows.Shapes;

using Hexo_UI_Preview.UserControls.PropertiesPanel;

namespace Hexo_UI_Preview.Panels
{
    /// <summary>
    /// Interaction logic for Properties.xaml
    /// </summary>
    public partial class Properties : Window
    {
        public List<Property> Values = new List<Property>();

        public Properties()
        {
            InitializeComponent();
        }

        public void LoadProperties<T>(Property[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                Values.Add(values[i]);
                switch (values[i].Type)
                {
                    case Property.PropertyType.Transform:
                        PropertyList.Items.Add(new TransformProperties((Static_Files.Vector3)values[i].Properties[0],
                            (Static_Files.Vector3)values[i].Properties[1], (Static_Files.Vector3)values[i].Properties[2]));
                        break;
                }
                
            }
            //Values = values;
        }
    }

    public class Property
    {
        public object[] Properties;

        public Property()
        {

        }

        public Property(object[] Args, PropertyType type)
        {
            Properties = Args;
            Type = type;
        }

        public enum PropertyType
        {
            Transform,
            Rendering,
            Default
        };
        public PropertyType Type;

    }
}
