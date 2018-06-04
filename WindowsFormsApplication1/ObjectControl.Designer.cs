namespace WindowsFormsApplication1
{
    partial class ObjectControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectorComboBox = new System.Windows.Forms.ComboBox();
            this.figureLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.upLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectorComboBox
            // 
            this.SelectorComboBox.FormattingEnabled = true;
            this.SelectorComboBox.Location = new System.Drawing.Point(119, 25);
            this.SelectorComboBox.Name = "SelectorComboBox";
            this.SelectorComboBox.Size = new System.Drawing.Size(121, 21);
            this.SelectorComboBox.TabIndex = 0;
            this.SelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.selectorComboBox_SelectedIndexChanged);
            // 
            // figureLabel
            // 
            this.figureLabel.AutoSize = true;
            this.figureLabel.Location = new System.Drawing.Point(20, 28);
            this.figureLabel.Name = "figureLabel";
            this.figureLabel.Size = new System.Drawing.Size(36, 13);
            this.figureLabel.TabIndex = 1;
            this.figureLabel.Text = "Figure";
            this.figureLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Location = new System.Drawing.Point(20, 86);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(50, 13);
            this.upLabel.TabIndex = 4;
            this.upLabel.Text = "Up Label";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Location = new System.Drawing.Point(20, 114);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(60, 13);
            this.downLabel.TabIndex = 5;
            this.downLabel.Text = "Down label";
            this.downLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.figureLabel);
            this.Controls.Add(this.SelectorComboBox);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(267, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectorComboBox;
        private System.Windows.Forms.Label figureLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label downLabel;
    }
}
