namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFiguresTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFiguresTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataFiguresTable = new System.Windows.Forms.DataGridView();
            this.typeOfFigure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFirgureButton = new System.Windows.Forms.Button();
            this.DeleteFigureButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiguresTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFiguresTableToolStripMenuItem,
            this.loadFiguresTableToolStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItem_Click);
            // 
            // saveFiguresTableToolStripMenuItem
            // 
            this.saveFiguresTableToolStripMenuItem.Name = "saveFiguresTableToolStripMenuItem";
            this.saveFiguresTableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveFiguresTableToolStripMenuItem.Text = "Save figures table";
            this.saveFiguresTableToolStripMenuItem.Click += new System.EventHandler(this.saveFiguresTableToolStripMenuItem_Click);
            // 
            // loadFiguresTableToolStripMenuItem
            // 
            this.loadFiguresTableToolStripMenuItem.Name = "loadFiguresTableToolStripMenuItem";
            this.loadFiguresTableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadFiguresTableToolStripMenuItem.Text = "Load figures table";
            this.loadFiguresTableToolStripMenuItem.Click += new System.EventHandler(this.loadFiguresTableToolStripMenuItem_Click);
            // 
            // dataFiguresTable
            // 
            this.dataFiguresTable.AllowUserToAddRows = false;
            this.dataFiguresTable.AllowUserToDeleteRows = false;
            this.dataFiguresTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFiguresTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeOfFigure,
            this.area});
            this.dataFiguresTable.Location = new System.Drawing.Point(12, 27);
            this.dataFiguresTable.Name = "dataFiguresTable";
            this.dataFiguresTable.ReadOnly = true;
            this.dataFiguresTable.Size = new System.Drawing.Size(318, 176);
            this.dataFiguresTable.TabIndex = 1;
            this.dataFiguresTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFiguresTable_CellContentClick);
            // 
            // typeOfFigure
            // 
            this.typeOfFigure.HeaderText = "Type of figure";
            this.typeOfFigure.Name = "typeOfFigure";
            this.typeOfFigure.ReadOnly = true;
            // 
            // area
            // 
            this.area.HeaderText = "Area of figure";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // AddFirgureButton
            // 
            this.AddFirgureButton.Location = new System.Drawing.Point(12, 257);
            this.AddFirgureButton.Name = "AddFirgureButton";
            this.AddFirgureButton.Size = new System.Drawing.Size(75, 37);
            this.AddFirgureButton.TabIndex = 2;
            this.AddFirgureButton.Text = "Add Figure";
            this.AddFirgureButton.UseVisualStyleBackColor = true;
            this.AddFirgureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteFigureButton
            // 
            this.DeleteFigureButton.Location = new System.Drawing.Point(255, 257);
            this.DeleteFigureButton.Name = "DeleteFigureButton";
            this.DeleteFigureButton.Size = new System.Drawing.Size(75, 37);
            this.DeleteFigureButton.TabIndex = 5;
            this.DeleteFigureButton.Text = "Delete Figure";
            this.DeleteFigureButton.UseVisualStyleBackColor = true;
            this.DeleteFigureButton.Click += new System.EventHandler(this.DeleteFigureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 314);
            this.Controls.Add(this.DeleteFigureButton);
            this.Controls.Add(this.AddFirgureButton);
            this.Controls.Add(this.dataFiguresTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AreaCounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiguresTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.DataGridView dataFiguresTable;
        private System.Windows.Forms.Button AddFirgureButton;
        private System.Windows.Forms.Button DeleteFigureButton;
        private System.Windows.Forms.ToolStripMenuItem saveFiguresTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFiguresTableToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfFigure;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}

