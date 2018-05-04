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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddFirgureButton = new System.Windows.Forms.Button();
            this.ViewFigureButton = new System.Windows.Forms.Button();
            this.ModifyFirgureButton = new System.Windows.Forms.Button();
            this.DeleteFigureButton = new System.Windows.Forms.Button();
            this.CleanTableButton = new System.Windows.Forms.Button();
            this.RandomDataButton = new System.Windows.Forms.Button();
            this.FindFigureButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // loadFiguresTableToolStripMenuItem
            // 
            this.loadFiguresTableToolStripMenuItem.Name = "loadFiguresTableToolStripMenuItem";
            this.loadFiguresTableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadFiguresTableToolStripMenuItem.Text = "Load figures table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 273);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddFirgureButton
            // 
            this.AddFirgureButton.Location = new System.Drawing.Point(12, 306);
            this.AddFirgureButton.Name = "AddFirgureButton";
            this.AddFirgureButton.Size = new System.Drawing.Size(75, 37);
            this.AddFirgureButton.TabIndex = 2;
            this.AddFirgureButton.Text = "Add Figure";
            this.AddFirgureButton.UseVisualStyleBackColor = true;
            this.AddFirgureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewFigureButton
            // 
            this.ViewFigureButton.Location = new System.Drawing.Point(93, 306);
            this.ViewFigureButton.Name = "ViewFigureButton";
            this.ViewFigureButton.Size = new System.Drawing.Size(75, 37);
            this.ViewFigureButton.TabIndex = 3;
            this.ViewFigureButton.Text = "View Figure";
            this.ViewFigureButton.UseVisualStyleBackColor = true;
            this.ViewFigureButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModifyFirgureButton
            // 
            this.ModifyFirgureButton.Location = new System.Drawing.Point(174, 306);
            this.ModifyFirgureButton.Name = "ModifyFirgureButton";
            this.ModifyFirgureButton.Size = new System.Drawing.Size(75, 37);
            this.ModifyFirgureButton.TabIndex = 4;
            this.ModifyFirgureButton.Text = "Modify Figure";
            this.ModifyFirgureButton.UseVisualStyleBackColor = true;
            // 
            // DeleteFigureButton
            // 
            this.DeleteFigureButton.Location = new System.Drawing.Point(255, 306);
            this.DeleteFigureButton.Name = "DeleteFigureButton";
            this.DeleteFigureButton.Size = new System.Drawing.Size(75, 37);
            this.DeleteFigureButton.TabIndex = 5;
            this.DeleteFigureButton.Text = "Delete Figure";
            this.DeleteFigureButton.UseVisualStyleBackColor = true;
            // 
            // CleanTableButton
            // 
            this.CleanTableButton.Location = new System.Drawing.Point(12, 349);
            this.CleanTableButton.Name = "CleanTableButton";
            this.CleanTableButton.Size = new System.Drawing.Size(75, 48);
            this.CleanTableButton.TabIndex = 6;
            this.CleanTableButton.Text = "Clean Table";
            this.CleanTableButton.UseVisualStyleBackColor = true;
            // 
            // RandomDataButton
            // 
            this.RandomDataButton.Location = new System.Drawing.Point(93, 349);
            this.RandomDataButton.Name = "RandomDataButton";
            this.RandomDataButton.Size = new System.Drawing.Size(75, 48);
            this.RandomDataButton.TabIndex = 7;
            this.RandomDataButton.Text = "Random Data";
            this.RandomDataButton.UseVisualStyleBackColor = true;
            this.RandomDataButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // FindFigureButton
            // 
            this.FindFigureButton.Location = new System.Drawing.Point(255, 349);
            this.FindFigureButton.Name = "FindFigureButton";
            this.FindFigureButton.Size = new System.Drawing.Size(75, 48);
            this.FindFigureButton.TabIndex = 8;
            this.FindFigureButton.Text = "Find Figure";
            this.FindFigureButton.UseVisualStyleBackColor = true;
            this.FindFigureButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 409);
            this.Controls.Add(this.FindFigureButton);
            this.Controls.Add(this.RandomDataButton);
            this.Controls.Add(this.CleanTableButton);
            this.Controls.Add(this.DeleteFigureButton);
            this.Controls.Add(this.ModifyFirgureButton);
            this.Controls.Add(this.ViewFigureButton);
            this.Controls.Add(this.AddFirgureButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AreaCounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddFirgureButton;
        private System.Windows.Forms.Button ViewFigureButton;
        private System.Windows.Forms.Button ModifyFirgureButton;
        private System.Windows.Forms.Button DeleteFigureButton;
        private System.Windows.Forms.Button CleanTableButton;
        private System.Windows.Forms.Button RandomDataButton;
        private System.Windows.Forms.Button FindFigureButton;
        private System.Windows.Forms.ToolStripMenuItem saveFiguresTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFiguresTableToolStripMenuItem;
    }
}

