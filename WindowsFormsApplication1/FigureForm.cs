using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
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
