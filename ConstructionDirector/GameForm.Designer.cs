namespace ConstructionDirector
{
    partial class GameForm
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
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.optionButton = new System.Windows.Forms.Button();
            this.DayLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.blocksPanel = new System.Windows.Forms.Panel();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.block5 = new ConstructionDirector.Block();
            this.block4 = new ConstructionDirector.Block();
            this.block3 = new ConstructionDirector.Block();
            this.block2 = new ConstructionDirector.Block();
            this.block1 = new ConstructionDirector.Block();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.visualizationButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.backgroundPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.blocksPanel.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Controls.Add(this.rightPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(571, 414);
            this.backgroundPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 414);
            this.panel2.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.Controls.Add(this.gamePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 47);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.mainPanel.Size = new System.Drawing.Size(377, 367);
            this.mainPanel.TabIndex = 1;
            // 
            // gamePanel
            // 
            this.gamePanel.AutoSize = true;
            this.gamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(8, 8);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(361, 351);
            this.gamePanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.optionButton);
            this.panel3.Controls.Add(this.DayLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 47);
            this.panel3.TabIndex = 2;
            // 
            // optionButton
            // 
            this.optionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optionButton.BackColor = System.Drawing.Color.DarkGray;
            this.optionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionButton.FlatAppearance.BorderSize = 3;
            this.optionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionButton.Location = new System.Drawing.Point(7, 5);
            this.optionButton.Margin = new System.Windows.Forms.Padding(0);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(77, 37);
            this.optionButton.TabIndex = 2;
            this.optionButton.Text = "Опции";
            this.optionButton.UseVisualStyleBackColor = false;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // DayLabel
            // 
            this.DayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DayLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayLabel.Location = new System.Drawing.Point(171, 0);
            this.DayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.DayLabel.Size = new System.Drawing.Size(206, 47);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "Осталось блоков: ";
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.DimGray;
            this.rightPanel.Controls.Add(this.blocksPanel);
            this.rightPanel.Controls.Add(this.buttonsPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(377, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(194, 414);
            this.rightPanel.TabIndex = 0;
            // 
            // blocksPanel
            // 
            this.blocksPanel.Controls.Add(this.scrollPanel);
            this.blocksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blocksPanel.Location = new System.Drawing.Point(0, 0);
            this.blocksPanel.Margin = new System.Windows.Forms.Padding(0);
            this.blocksPanel.Name = "blocksPanel";
            this.blocksPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.blocksPanel.Size = new System.Drawing.Size(194, 302);
            this.blocksPanel.TabIndex = 1;
            // 
            // scrollPanel
            // 
            this.scrollPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scrollPanel.Controls.Add(this.block5);
            this.scrollPanel.Controls.Add(this.block4);
            this.scrollPanel.Controls.Add(this.block3);
            this.scrollPanel.Controls.Add(this.block2);
            this.scrollPanel.Controls.Add(this.block1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(8, 8);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.scrollPanel.Size = new System.Drawing.Size(178, 286);
            this.scrollPanel.TabIndex = 0;
            // 
            // block5
            // 
            this.block5.BackColor = System.Drawing.Color.Black;
            this.block5.DayOfBuild = -1;
            this.block5.Location = new System.Drawing.Point(8, 176);
            this.block5.Margin = new System.Windows.Forms.Padding(0);
            this.block5.Name = "block5";
            this.block5.Order = 0;
            this.block5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block5.Size = new System.Drawing.Size(163, 56);
            this.block5.StrokeThickness = 5;
            this.block5.TabIndex = 4;
            this.block5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Block_MouseDown);
            this.block5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Block_MouseMove);
            this.block5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Block_MouseUp);
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.Black;
            this.block4.DayOfBuild = -1;
            this.block4.Location = new System.Drawing.Point(78, 75);
            this.block4.Margin = new System.Windows.Forms.Padding(0);
            this.block4.Name = "block4";
            this.block4.Order = 0;
            this.block4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block4.Size = new System.Drawing.Size(93, 90);
            this.block4.StrokeThickness = 5;
            this.block4.TabIndex = 3;
            this.block4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Block_MouseDown);
            this.block4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Block_MouseMove);
            this.block4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Block_MouseUp);
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.Black;
            this.block3.DayOfBuild = -1;
            this.block3.Location = new System.Drawing.Point(8, 75);
            this.block3.Margin = new System.Windows.Forms.Padding(0);
            this.block3.Name = "block3";
            this.block3.Order = 0;
            this.block3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block3.Size = new System.Drawing.Size(58, 90);
            this.block3.StrokeThickness = 5;
            this.block3.TabIndex = 2;
            this.block3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Block_MouseDown);
            this.block3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Block_MouseMove);
            this.block3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Block_MouseUp);
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Black;
            this.block2.DayOfBuild = -1;
            this.block2.Location = new System.Drawing.Point(78, 8);
            this.block2.Margin = new System.Windows.Forms.Padding(0);
            this.block2.Name = "block2";
            this.block2.Order = 0;
            this.block2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block2.Size = new System.Drawing.Size(93, 56);
            this.block2.StrokeThickness = 5;
            this.block2.TabIndex = 1;
            this.block2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Block_MouseDown);
            this.block2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Block_MouseMove);
            this.block2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Block_MouseUp);
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Black;
            this.block1.DayOfBuild = -1;
            this.block1.Location = new System.Drawing.Point(8, 8);
            this.block1.Margin = new System.Windows.Forms.Padding(0);
            this.block1.Name = "block1";
            this.block1.Order = 0;
            this.block1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block1.Size = new System.Drawing.Size(58, 56);
            this.block1.StrokeThickness = 5;
            this.block1.TabIndex = 0;
            this.block1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Block_MouseDown);
            this.block1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Block_MouseMove);
            this.block1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Block_MouseUp);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.visualizationButton);
            this.buttonsPanel.Controls.Add(this.manageButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 302);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(194, 112);
            this.buttonsPanel.TabIndex = 0;
            // 
            // visualizationButton
            // 
            this.visualizationButton.BackColor = System.Drawing.Color.DarkGray;
            this.visualizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualizationButton.Enabled = false;
            this.visualizationButton.FlatAppearance.BorderSize = 3;
            this.visualizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizationButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.visualizationButton.Location = new System.Drawing.Point(8, 60);
            this.visualizationButton.Margin = new System.Windows.Forms.Padding(0);
            this.visualizationButton.Name = "visualizationButton";
            this.visualizationButton.Size = new System.Drawing.Size(179, 45);
            this.visualizationButton.TabIndex = 1;
            this.visualizationButton.Text = "Стройка";
            this.visualizationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.visualizationButton.UseVisualStyleBackColor = false;
            this.visualizationButton.Click += new System.EventHandler(this.VisualizationButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.BackColor = System.Drawing.Color.DarkGray;
            this.manageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageButton.Enabled = false;
            this.manageButton.FlatAppearance.BorderSize = 3;
            this.manageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageButton.Location = new System.Drawing.Point(8, 8);
            this.manageButton.Margin = new System.Windows.Forms.Padding(0);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(179, 45);
            this.manageButton.TabIndex = 0;
            this.manageButton.Text = "Управление строителями";
            this.manageButton.UseVisualStyleBackColor = false;
            this.manageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 414);
            this.Controls.Add(this.backgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(587, 413);
            this.Name = "GameForm";
            this.Text = "Директор строительства";
            this.backgroundPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.blocksPanel.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel backgroundPanel;
        private Panel mainPanel;
        private Panel gamePanel;
        private Panel rightPanel;
        private Panel blocksPanel;
        private Panel scrollPanel;
        private Panel buttonsPanel;
        private Button visualizationButton;
        private Button manageButton;
        private Block block1;
        private Block block3;
        private Block block2;
        private Block block4;
        private Block block5;
        private Label DayLabel;
        private Panel panel2;
        private Panel panel3;
        private Button optionButton;
    }
}