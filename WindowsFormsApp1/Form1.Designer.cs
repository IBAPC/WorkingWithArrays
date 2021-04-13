namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отсортироватьОтрицательныеЭлементыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массивAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массивBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массивCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(649, 43);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(117, 234);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(649, 43);
            this.dataGridView2.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Вручную";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Случайно";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(310, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод массива";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Из файла";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Массив A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Массив B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаЭлементовToolStripMenuItem,
            this.колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem,
            this.aBToolStripMenuItem,
            this.aBToolStripMenuItem1,
            this.отсортироватьОтрицательныеЭлементыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // суммаЭлементовToolStripMenuItem
            // 
            this.суммаЭлементовToolStripMenuItem.Name = "суммаЭлементовToolStripMenuItem";
            this.суммаЭлементовToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.суммаЭлементовToolStripMenuItem.Text = "Сумма элементов массива";
            this.суммаЭлементовToolStripMenuItem.Click += new System.EventHandler(this.суммаЭлементовToolStripMenuItem_Click);
            // 
            // колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem
            // 
            this.колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem.Name = "колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem";
            this.колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem.Text = "Кол-во элементов кратных заданному числу";
            this.колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem.Click += new System.EventHandler(this.колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem_Click);
            // 
            // aBToolStripMenuItem
            // 
            this.aBToolStripMenuItem.Name = "aBToolStripMenuItem";
            this.aBToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.aBToolStripMenuItem.Text = "mas1 + mas2";
            this.aBToolStripMenuItem.Click += new System.EventHandler(this.aBToolStripMenuItem_Click);
            // 
            // aBToolStripMenuItem1
            // 
            this.aBToolStripMenuItem1.Name = "aBToolStripMenuItem1";
            this.aBToolStripMenuItem1.Size = new System.Drawing.Size(322, 22);
            this.aBToolStripMenuItem1.Text = "mas1 - mas 2";
            this.aBToolStripMenuItem1.Click += new System.EventHandler(this.aBToolStripMenuItem1_Click);
            // 
            // отсортироватьОтрицательныеЭлементыToolStripMenuItem
            // 
            this.отсортироватьОтрицательныеЭлементыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массивAToolStripMenuItem,
            this.массивBToolStripMenuItem,
            this.массивCToolStripMenuItem});
            this.отсортироватьОтрицательныеЭлементыToolStripMenuItem.Name = "отсортироватьОтрицательныеЭлементыToolStripMenuItem";
            this.отсортироватьОтрицательныеЭлементыToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.отсортироватьОтрицательныеЭлементыToolStripMenuItem.Text = "Отсортировать отрицательные элементы";
            // 
            // массивAToolStripMenuItem
            // 
            this.массивAToolStripMenuItem.Name = "массивAToolStripMenuItem";
            this.массивAToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.массивAToolStripMenuItem.Text = "Массив A";
            this.массивAToolStripMenuItem.Click += new System.EventHandler(this.массивAToolStripMenuItem_Click);
            // 
            // массивBToolStripMenuItem
            // 
            this.массивBToolStripMenuItem.Name = "массивBToolStripMenuItem";
            this.массивBToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.массивBToolStripMenuItem.Text = "Массив B";
            this.массивBToolStripMenuItem.Click += new System.EventHandler(this.массивBToolStripMenuItem_Click);
            // 
            // массивCToolStripMenuItem
            // 
            this.массивCToolStripMenuItem.Name = "массивCToolStripMenuItem";
            this.массивCToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.массивCToolStripMenuItem.Text = "Массив C";
            this.массивCToolStripMenuItem.Click += new System.EventHandler(this.массивCToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сумма массивов:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(117, 311);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView3.Size = new System.Drawing.Size(649, 43);
            this.dataGridView3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммаЭлементовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьОтрицательныеЭлементыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem массивAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массивBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массивCToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

