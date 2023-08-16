namespace MpcXpmExtract
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonLoadDir = new Button();
            TextBoxDir = new TextBox();
            TreeViewKits = new TreeView();
            ButtonExtractAll = new Button();
            TextBoxLog = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonLoadDir
            // 
            ButtonLoadDir.Anchor = AnchorStyles.Left;
            ButtonLoadDir.AutoSize = true;
            ButtonLoadDir.Location = new Point(3, 2);
            ButtonLoadDir.Margin = new Padding(3, 2, 3, 2);
            ButtonLoadDir.Name = "ButtonLoadDir";
            ButtonLoadDir.Size = new Size(96, 25);
            ButtonLoadDir.TabIndex = 0;
            ButtonLoadDir.Text = "Load XPM Dir";
            ButtonLoadDir.UseVisualStyleBackColor = true;
            ButtonLoadDir.Click += ButtonLoadDir_Click;
            // 
            // TextBoxDir
            // 
            TextBoxDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextBoxDir.Location = new Point(105, 3);
            TextBoxDir.Margin = new Padding(3, 2, 3, 2);
            TextBoxDir.Name = "TextBoxDir";
            TextBoxDir.ReadOnly = true;
            TextBoxDir.Size = new Size(794, 23);
            TextBoxDir.TabIndex = 1;
            // 
            // TreeViewKits
            // 
            TreeViewKits.Dock = DockStyle.Fill;
            TreeViewKits.Location = new Point(3, 50);
            TreeViewKits.Margin = new Padding(3, 2, 3, 2);
            TreeViewKits.Name = "TreeViewKits";
            TreeViewKits.Size = new Size(902, 404);
            TreeViewKits.TabIndex = 2;
            // 
            // ButtonExtractAll
            // 
            ButtonExtractAll.AutoSize = true;
            ButtonExtractAll.Location = new Point(3, 2);
            ButtonExtractAll.Margin = new Padding(3, 2, 3, 2);
            ButtonExtractAll.Name = "ButtonExtractAll";
            ButtonExtractAll.Size = new Size(100, 25);
            ButtonExtractAll.TabIndex = 4;
            ButtonExtractAll.Text = "Extract All Kits";
            ButtonExtractAll.UseVisualStyleBackColor = true;
            ButtonExtractAll.Click += ButtonExtractAll_Click;
            // 
            // TextBoxLog
            // 
            TextBoxLog.Dock = DockStyle.Fill;
            TextBoxLog.Location = new Point(3, 506);
            TextBoxLog.Margin = new Padding(3, 2, 3, 2);
            TextBoxLog.Multiline = true;
            TextBoxLog.Name = "TextBoxLog";
            TextBoxLog.ReadOnly = true;
            TextBoxLog.ScrollBars = ScrollBars.Vertical;
            TextBoxLog.Size = new Size(902, 268);
            TextBoxLog.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 489);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 6;
            label1.Text = "Log";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(TextBoxLog, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(TreeViewKits, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(908, 776);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ButtonLoadDir, 0, 0);
            tableLayoutPanel2.Controls.Add(TextBoxDir, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(902, 29);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Kits";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(ButtonExtractAll, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 458);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(106, 29);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 784);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding(4, 4, 4, 4);
            Text = "MpcXpmExtract";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonLoadDir;
        private TextBox TextBoxDir;
        private TreeView TreeViewKits;
        private Button ButtonExtractAll;
        private TextBox TextBoxLog;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}