namespace ConstructionDirector
{
    partial class ManageBuildersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.secondStepPanel = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.manageBuildersLabel = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstStepPanel = new System.Windows.Forms.Panel();
            this.choosingPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.buildersCountLabel = new System.Windows.Forms.Label();
            this.fourBuildersButton = new System.Windows.Forms.Button();
            this.threeBuildersButton = new System.Windows.Forms.Button();
            this.twoBuildersButton = new System.Windows.Forms.Button();
            this.backgroundPanel.SuspendLayout();
            this.secondStepPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.table.SuspendLayout();
            this.firstStepPanel.SuspendLayout();
            this.choosingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backgroundPanel.Controls.Add(this.secondStepPanel);
            this.backgroundPanel.Controls.Add(this.firstStepPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.backgroundPanel.Size = new System.Drawing.Size(874, 350);
            this.backgroundPanel.TabIndex = 0;
            // 
            // secondStepPanel
            // 
            this.secondStepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.secondStepPanel.Controls.Add(this.confirmButton);
            this.secondStepPanel.Controls.Add(this.manageBuildersLabel);
            this.secondStepPanel.Controls.Add(this.tablePanel);
            this.secondStepPanel.Location = new System.Drawing.Point(443, 7);
            this.secondStepPanel.Margin = new System.Windows.Forms.Padding(0);
            this.secondStepPanel.Name = "secondStepPanel";
            this.secondStepPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.secondStepPanel.Size = new System.Drawing.Size(388, 266);
            this.secondStepPanel.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.BackColor = System.Drawing.Color.DarkGray;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 3;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Location = new System.Drawing.Point(270, 219);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(0);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(108, 39);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Готово";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.СonfirmButton_Click);
            // 
            // manageBuildersLabel
            // 
            this.manageBuildersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageBuildersLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageBuildersLabel.Location = new System.Drawing.Point(8, 8);
            this.manageBuildersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.manageBuildersLabel.Name = "manageBuildersLabel";
            this.manageBuildersLabel.Size = new System.Drawing.Size(372, 38);
            this.manageBuildersLabel.TabIndex = 1;
            this.manageBuildersLabel.Text = "Управление строителями";
            this.manageBuildersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablePanel.Controls.Add(this.table);
            this.tablePanel.Location = new System.Drawing.Point(10, 48);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(368, 158);
            this.tablePanel.TabIndex = 0;
            // 
            // table
            // 
            this.table.AutoScroll = true;
            this.table.BackColor = System.Drawing.Color.Silver;
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.table.Controls.Add(this.textBox1, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.table.Size = new System.Drawing.Size(368, 158);
            this.table.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.CommandTextBox_Enter);
            this.textBox1.Leave += new System.EventHandler(this.CommandTextBox_Leave);
            // 
            // firstStepPanel
            // 
            this.firstStepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.firstStepPanel.Controls.Add(this.choosingPanel);
            this.firstStepPanel.Location = new System.Drawing.Point(8, 8);
            this.firstStepPanel.Margin = new System.Windows.Forms.Padding(0);
            this.firstStepPanel.Name = "firstStepPanel";
            this.firstStepPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.firstStepPanel.Size = new System.Drawing.Size(359, 250);
            this.firstStepPanel.TabIndex = 0;
            // 
            // choosingPanel
            // 
            this.choosingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosingPanel.Controls.Add(this.nextButton);
            this.choosingPanel.Controls.Add(this.buildersCountLabel);
            this.choosingPanel.Controls.Add(this.fourBuildersButton);
            this.choosingPanel.Controls.Add(this.threeBuildersButton);
            this.choosingPanel.Controls.Add(this.twoBuildersButton);
            this.choosingPanel.Location = new System.Drawing.Point(8, 8);
            this.choosingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.choosingPanel.Name = "choosingPanel";
            this.choosingPanel.Size = new System.Drawing.Size(344, 235);
            this.choosingPanel.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.DarkGray;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 3;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(236, 196);
            this.nextButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(108, 39);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // buildersCountLabel
            // 
            this.buildersCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildersCountLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buildersCountLabel.Location = new System.Drawing.Point(-16, 41);
            this.buildersCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.buildersCountLabel.Name = "buildersCountLabel";
            this.buildersCountLabel.Size = new System.Drawing.Size(377, 38);
            this.buildersCountLabel.TabIndex = 0;
            this.buildersCountLabel.Text = "Количество строителей";
            this.buildersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourBuildersButton
            // 
            this.fourBuildersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourBuildersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fourBuildersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fourBuildersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourBuildersButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fourBuildersButton.Location = new System.Drawing.Point(250, 98);
            this.fourBuildersButton.Margin = new System.Windows.Forms.Padding(0);
            this.fourBuildersButton.Name = "fourBuildersButton";
            this.fourBuildersButton.Size = new System.Drawing.Size(78, 75);
            this.fourBuildersButton.TabIndex = 2;
            this.fourBuildersButton.Text = "4";
            this.fourBuildersButton.UseVisualStyleBackColor = false;
            this.fourBuildersButton.Click += new System.EventHandler(this.BuildersButton_Click);
            // 
            // threeBuildersButton
            // 
            this.threeBuildersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeBuildersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.threeBuildersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeBuildersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeBuildersButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeBuildersButton.Location = new System.Drawing.Point(133, 98);
            this.threeBuildersButton.Margin = new System.Windows.Forms.Padding(0);
            this.threeBuildersButton.Name = "threeBuildersButton";
            this.threeBuildersButton.Size = new System.Drawing.Size(78, 75);
            this.threeBuildersButton.TabIndex = 1;
            this.threeBuildersButton.Text = "3";
            this.threeBuildersButton.UseVisualStyleBackColor = false;
            this.threeBuildersButton.Click += new System.EventHandler(this.BuildersButton_Click);
            // 
            // twoBuildersButton
            // 
            this.twoBuildersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoBuildersButton.BackColor = System.Drawing.Color.DarkGray;
            this.twoBuildersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoBuildersButton.FlatAppearance.BorderSize = 5;
            this.twoBuildersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoBuildersButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twoBuildersButton.Location = new System.Drawing.Point(16, 98);
            this.twoBuildersButton.Margin = new System.Windows.Forms.Padding(0);
            this.twoBuildersButton.Name = "twoBuildersButton";
            this.twoBuildersButton.Size = new System.Drawing.Size(78, 75);
            this.twoBuildersButton.TabIndex = 0;
            this.twoBuildersButton.Text = "2";
            this.twoBuildersButton.UseVisualStyleBackColor = false;
            this.twoBuildersButton.Click += new System.EventHandler(this.BuildersButton_Click);
            // 
            // ManageBuildersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 350);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageBuildersForm";
            this.Text = "Управление строителями";
            this.backgroundPanel.ResumeLayout(false);
            this.secondStepPanel.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.firstStepPanel.ResumeLayout(false);
            this.choosingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel backgroundPanel;
        private Panel firstStepPanel;
        private Label buildersCountLabel;
        private Panel choosingPanel;
        private Button fourBuildersButton;
        private Button threeBuildersButton;
        private Button twoBuildersButton;
        private Button nextButton;
        private Panel secondStepPanel;
        private Panel tablePanel;
        private Label manageBuildersLabel;
        private TableLayoutPanel table;
        private TextBox textBox1;
        private Button confirmButton;
    }
}