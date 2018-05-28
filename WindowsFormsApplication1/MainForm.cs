using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;
using WindowsFormsApplication1.Figures;
using Newtonsoft.Json;


namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private List<IFigure> figures;

        public string type { get; set; }
        public string areaCount { get; set; }
        private List<IFigure> _figures { get; set; } = new List<IFigure>();

        public MainForm(List<IFigure> figures)
        {
            this.figures = figures;
            InitializeComponent();
        }

        public MainForm()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            FigureForm figureForm = new FigureForm();
            var dialogResult = figureForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var figure = figureForm.Figure;
                dataFiguresTable.Rows.Add(figure.ToString().Split('.').Last(), figure.Area);
                _figures.Add(figure);
            }
        }
        private void dataFiguresTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFigureButton_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataFiguresTable.CurrentRow.Index;
            dataFiguresTable.Rows.Remove(dataFiguresTable.Rows[CurrentRow]);
        }

       
        private void saveFiguresTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    string fileName = saveFileDialog.FileName;
                    writeDataToFile(fileName, _figures);
                    myStream.Close();
                }
            }
        }
        private void writeDataToFile(string fileName, List<IFigure> figures)
        {

            try
            {
                using (FileStream fs = File.Open(fileName + ".json", FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer()
                    {
                        TypeNameHandling = TypeNameHandling.All,
                        NullValueHandling = NullValueHandling.Include,
                        Formatting = Formatting.Indented
                    };
                    
                    serializer.Serialize(jw, figures);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Error while writing file. Please contact IT department for immediate assist!");

            }
        }

        private void loadFiguresTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            JsonSerializer serializer = new JsonSerializer()
            {
                TypeNameHandling = TypeNameHandling.All,
                NullValueHandling = NullValueHandling.Include,
                Formatting = Formatting.Indented
            };
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Trim() != string.Empty)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        
                        var obj = serializer.Deserialize(reader, typeof(List<IFigure>));
                        _figures = (List<IFigure>) obj;
                    }

                }
                dataFiguresTable.Rows.Clear();
                foreach (var figure in _figures)
                {
                    dataFiguresTable.Rows.Add(figure.ToString().Split('.').Last(), figure.Area);
                }
            }
        }
    }
        
}

