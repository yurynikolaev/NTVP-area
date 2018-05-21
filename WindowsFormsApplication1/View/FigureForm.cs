using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Figures;

namespace WindowsFormsApplication1
{
    public partial class Figure_Form : Form
    {
        /// <summary>
        /// Is 'Modify Figure' button clicked or not
        /// </summary>
        public bool ModifyButtonClicked { get; private set; }
        /// <summary>
		/// Is need to modify figure or not
		/// </summary>
		private bool _modifyFigure;
        /// <summary>
		/// Figure index in data grid inside main form
		/// </summary>
		private int _figureIndex;
        public Figure_Form()
        {
            InitializeComponent();
            button1.Text = "Add figure";
            ModifyButtonClicked = false;

           
        }

        public IFigure Figure {
            get
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    var circle = new Circle();
                    circle.Radius = Convert.ToDouble(textBox1.Text);
                    return circle;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    var triangle = new Triangle();
                    triangle.Catet = Convert.ToDouble(textBox2.Text);
                    triangle.Height = Convert.ToDouble(textBox1.Text);
                    return triangle;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    var rectangle = new Figures.Rectangle();
                    rectangle.Height = Convert.ToDouble(textBox1.Text);
                    rectangle.Width = Convert.ToDouble(textBox2.Text);
                    return rectangle;
                }
                return null;
            }
            set
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Visible = true;
                textBox1.Visible = true;
                label3.Visible = false;
                textBox2.Visible = false;
                label4.Visible = false;

            }

            if (comboBox1.SelectedIndex == 1)
            {
                label2.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                textBox2.Visible = true;
                textBox1.Visible = true;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
            }
        }

        private void addFigure_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
