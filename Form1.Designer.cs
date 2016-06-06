namespace EncodingConverter
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultListView = new System.Windows.Forms.ListView();
            this.pathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oldEncodingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.subdirCheck = new System.Windows.Forms.CheckBox();
            this.analyzeBtn = new System.Windows.Forms.Button();
            this.convertBtn = new System.Windows.Forms.Button();
            this.encodingSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldLineEndingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lineEndingSelector = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultListView
            // 
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pathHeader,
            this.oldEncodingHeader,
            this.oldLineEndingHeader,
            this.actionHeader});
            this.resultListView.Location = new System.Drawing.Point(12, 138);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(687, 288);
            this.resultListView.TabIndex = 0;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // pathHeader
            // 
            this.pathHeader.Text = "Путь";
            this.pathHeader.Width = 300;
            // 
            // oldEncodingHeader
            // 
            this.oldEncodingHeader.Text = "Кодировка";
            this.oldEncodingHeader.Width = 150;
            // 
            // actionHeader
            // 
            this.actionHeader.Text = "Действие";
            this.actionHeader.Width = 100;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(111, 31);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(518, 20);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Location = new System.Drawing.Point(638, 29);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(61, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Обзор...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь";
            // 
            // subdirCheck
            // 
            this.subdirCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subdirCheck.AutoSize = true;
            this.subdirCheck.Checked = true;
            this.subdirCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subdirCheck.Location = new System.Drawing.Point(581, 106);
            this.subdirCheck.Name = "subdirCheck";
            this.subdirCheck.Size = new System.Drawing.Size(118, 17);
            this.subdirCheck.TabIndex = 4;
            this.subdirCheck.Text = "В поддиректориях";
            this.subdirCheck.UseVisualStyleBackColor = true;
            this.subdirCheck.CheckedChanged += new System.EventHandler(this.subdirCheck_CheckedChanged);
            // 
            // analyzeBtn
            // 
            this.analyzeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.analyzeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyzeBtn.ForeColor = System.Drawing.Color.Blue;
            this.analyzeBtn.Location = new System.Drawing.Point(84, 432);
            this.analyzeBtn.Name = "analyzeBtn";
            this.analyzeBtn.Size = new System.Drawing.Size(119, 48);
            this.analyzeBtn.TabIndex = 5;
            this.analyzeBtn.Text = "Анализ";
            this.analyzeBtn.UseVisualStyleBackColor = true;
            this.analyzeBtn.Click += new System.EventHandler(this.analyzeBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convertBtn.Enabled = false;
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertBtn.ForeColor = System.Drawing.Color.Red;
            this.convertBtn.Location = new System.Drawing.Point(483, 432);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(146, 48);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Конвертировать";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // encodingSelector
            // 
            this.encodingSelector.FormattingEnabled = true;
            this.encodingSelector.Location = new System.Drawing.Point(111, 67);
            this.encodingSelector.Name = "encodingSelector";
            this.encodingSelector.Size = new System.Drawing.Size(121, 21);
            this.encodingSelector.TabIndex = 7;
            this.encodingSelector.SelectedIndexChanged += new System.EventHandler(this.encodingSelector_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Новая кодировка";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(65, 103);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(506, 20);
            this.filterTextBox.TabIndex = 9;
            this.filterTextBox.Text = "*.txt|*.cpp|*.hpp|*.c|*.h|*.inl|*.inc|*.asm|*.cs|*.glsl|*.hlsl";
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Фильтр";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // oldLineEndingHeader
            // 
            this.oldLineEndingHeader.Text = "Конец строки";
            this.oldLineEndingHeader.Width = 100;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Конец строки";
            // 
            // lineEndingSelector
            // 
            this.lineEndingSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineEndingSelector.FormattingEnabled = true;
            this.lineEndingSelector.Location = new System.Drawing.Point(561, 69);
            this.lineEndingSelector.Name = "lineEndingSelector";
            this.lineEndingSelector.Size = new System.Drawing.Size(138, 21);
            this.lineEndingSelector.TabIndex = 12;
            this.lineEndingSelector.SelectedIndexChanged += new System.EventHandler(this.lineEndingSelector_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lineEndingSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encodingSelector);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.analyzeBtn);
            this.Controls.Add(this.subdirCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Преобразователь кодировок";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader pathHeader;
        private System.Windows.Forms.ColumnHeader oldEncodingHeader;
        private System.Windows.Forms.ColumnHeader actionHeader;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox subdirCheck;
        private System.Windows.Forms.Button analyzeBtn;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.ComboBox encodingSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader oldLineEndingHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lineEndingSelector;
    }
}

