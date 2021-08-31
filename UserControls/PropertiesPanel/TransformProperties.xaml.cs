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

namespace Hexo_UI_Preview.UserControls.PropertiesPanel
{
    /// <summary>
    /// Interaction logic for TransformProperties.xaml
    /// </summary>
    public partial class TransformProperties : UserControl
    {
        Panels.Property TransformProperty = new Panels.Property() { Type = Panels.Property.PropertyType.Transform };

        Static_Files.Vector3 Position;
        Static_Files.Vector3 Rotation;
        Static_Files.Vector3 Scale;

        public TransformProperties()
        {
            InitializeComponent();
            Start();
        }

        public TransformProperties(Static_Files.Vector3 Pos)
        {
            InitializeComponent();
            Start();
            Position = Pos;
            Rotation = new Static_Files.Vector3(0, 0, 0);
            Scale = new Static_Files.Vector3(0, 0, 0);
            TransformProperty.Properties = new object[3]
            {
                Position,
                Rotation,
                Scale
            };
        }

        public TransformProperties(Static_Files.Vector3 Pos, Static_Files.Vector3 Rot)
        {
            InitializeComponent();
            Start();
            Position = Pos;
            Rotation = Rot;
            Scale = new Static_Files.Vector3(0, 0, 0);
            TransformProperty.Properties = new object[3]
            {
                Position,
                Rotation,
                Scale
            };
        }

        public TransformProperties(Static_Files.Vector3 Pos, Static_Files.Vector3 Rot, Static_Files.Vector3 scale)
        {
            InitializeComponent();
            Start();
            Position = Pos;
            Rotation = Rot;
            Scale = scale;
            TransformProperty.Properties = new object[3]
            {
                Position,
                Rotation,
                Scale
            };
        }

        public TransformProperties(Static_Files.Vector2 Pos)
        {
            InitializeComponent();
            Start();
            Position.X = Pos.X;
            Position.Y = Pos.Y;
            Position.Z = 0;
            Rotation = new Static_Files.Vector3(0, 0, 0);
            Scale = new Static_Files.Vector3(0, 0, 0);
            TransformProperty.Properties = new object[3]
            {
                Position,
                Rotation,
                Scale
            };
        }

        public void Start()
        {
            TextBlock PositionText = new TextBlock()
            {
                Text = "Position",
                FontSize = 15,
                Width = 90,
            };

            
            
            //TextBlock PosXText = new TextBlock()
            //{
            //    Text = "X",
            //    FontSize = 20,
            //    Width = 20,
            //};
            //TextBlock PosYText = new TextBlock()
            //{
            //    Text = "Y",
            //    FontSize = 20,
            //    Width = 20,
            //};
            
            //TextBlock PosZText = new TextBlock()
            //{
            //    Text = "Z",
            //    FontSize = 20,
            //    Width = 20,
            //};
            

            TextBlock RotationText = new TextBlock()
            {
                Text = "Rotation",
                FontSize = 15,
                Width = 90,
            };
            TextBlock ScaleText = new TextBlock()
            {
                Text = "Scale",
                FontSize = 15,
                Width = 90,
            };

            TextBox PositionXSetter = new TextBox()
            {
                Width = 40,
                FontSize = 20
            };
            TextBox PositionYSetter = new TextBox()
            {
                Width = 40,
                FontSize = 20
            };
            TextBox PositionZSetter = new TextBox()
            {
                Width = 40,
                FontSize = 20
            };

            WrapPanel PosWrap = new WrapPanel();
            TextBoxWText PosXBox = new TextBoxWText()
            {
                Width = PosWrap.Width,
                
            };
            PosXBox.Text.Text = "X";
            TextBoxWText PosYBox = new TextBoxWText()
            {
                Width = PosWrap.Width,
            };
            PosYBox.Text.Text = "Y";
            TextBoxWText PosZBox = new TextBoxWText()
            {
                Width = PosWrap.Width,
            };
            PosZBox.Text.Text = "Z";

            PosWrap.Children.Add(PositionText);
            PosWrap.Children.Add(PosXBox);
            PosWrap.Children.Add(PosYBox);
            PosWrap.Children.Add(PosZBox);
            //
            //PosWrap.Children.Add(PosXText);
            //PosWrap.Children.Add(PositionXSetter);
            ////
            //PosWrap.Children.Add(PosYText);
            //PosWrap.Children.Add(PositionYSetter);
            ////
            //PosWrap.Children.Add(PosZText);
            //PosWrap.Children.Add(PositionZSetter);

            WrapPanel RotWrap = new WrapPanel();
            RotWrap.Children.Add(RotationText);

            WrapPanel ScaleWrap = new WrapPanel();
            ScaleWrap.Children.Add(ScaleText);

            PanelList.Children.Add(PosWrap);
            PanelList.Children.Add(RotWrap);
            PanelList.Children.Add(ScaleWrap);

            //ListView.Items.Add(PositionText);
            //ListView.Items.Add(RotationText);
            //ListView.Items.Add(ScaleText);
        }

       
    }
}
