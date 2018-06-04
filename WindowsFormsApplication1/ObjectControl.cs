using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Figures;
using Rectangle = WindowsFormsApplication1.Figures.Rectangle;

namespace WindowsFormsApplication1
{
    public partial class ObjectControl : UserControl
    {

        public ObjectControl()
        {
            InitializeComponent();
        }

        public IFigure Figure
        {
            
            get
            {
                if (SelectorComboBox.SelectedIndex == 0)
                {
                    var circle = new Circle();
                    circle.Radius = Convert.ToDouble(textBox1.Text);
                    return circle;
                }
                if (SelectorComboBox.SelectedIndex == 1)
                {
                    var triangle = new Triangle();
                    triangle.Catet = Convert.ToDouble(textBox2.Text);
                    triangle.Height = Convert.ToDouble(textBox1.Text);
                    return triangle;
                }
                if (SelectorComboBox.SelectedIndex == 2)
                {
                    var rectangle = new Rectangle();
                    rectangle.Height = Convert.ToDouble(textBox1.Text);
                    rectangle.Width = Convert.ToDouble(textBox2.Text);
                    return rectangle;
                }
                return null;

            }
            set
            {
                if (value is Circle)
                {
                    var circle = value as Circle;
                    SelectorComboBox.SelectedIndex = 0;
                    textBox1.Text = circle.Radius.ToString();
                }
                if (value is Triangle)
                {
                    var triangle = value as Triangle;
                    SelectorComboBox.SelectedIndex = 0;
                    textBox1.Text = triangle.Height.ToString();
                    textBox2.Text = triangle.Catet.ToString();
                }
                if (value is Rectangle)
                {
                    var rectangle = value as Rectangle;
                    SelectorComboBox.SelectedIndex = 0;
                    textBox1.Text = rectangle.Height.ToString();
                    textBox2.Text = rectangle.Width.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
