namespace ConstructionDirector
{
    partial class OptionForm
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
            this.blocksButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.DimGray;
            this.backgroundPanel.Controls.Add(this.blocksButton);
            this.backgroundPanel.Controls.Add(this.quitButton);
            this.backgroundPanel.Controls.Add(this.clearButton);
            this.backgroundPanel.Controls.Add(this.helpButton);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Padding = new System.Windows.Forms.Padding(5);
            this.backgroundPanel.Size = new System.Drawing.Size(330, 250);
            this.backgroundPanel.TabIndex = 0;
            // 
            // blocksButton
            // 
            this.blocksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.blocksButton.BackColor = System.Drawing.Color.DarkGray;
            this.blocksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blocksButton.FlatAppearance.BorderSize = 3;
            this.blocksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blocksButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blocksButton.Location = new System.Drawing.Point(10, 130);
            this.blocksButton.Margin = new System.Windows.Forms.Padding(5);
            this.blocksButton.Name = "blocksButton";
            this.blocksButton.Size = new System.Drawing.Size(310, 50);
            this.blocksButton.TabIndex = 7;
            this.blocksButton.Text = "Количество блоков";
            this.blocksButton.UseVisualStyleBackColor = false;
            this.blocksButton.Click += new System.EventHandler(this.blocksButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.BackColor = System.Drawing.Color.DarkGray;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderSize = 3;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitButton.Location = new System.Drawing.Point(10, 190);
            this.quitButton.Margin = new System.Windows.Forms.Padding(5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(310, 50);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Выйти";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 3;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(10, 70);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(310, 50);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить поле";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackColor = System.Drawing.Color.DarkGray;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderSize = 3;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.Location = new System.Drawing.Point(10, 10);
            this.helpButton.Margin = new System.Windows.Forms.Padding(5);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(310, 50);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Помощь";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 250);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionForm";
            this.Text = "Опции";
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel backgroundPanel;
        private Button quitButton;
        private Button clearButton;
        private Button helpButton;
        private Button blocksButton;
    }
}