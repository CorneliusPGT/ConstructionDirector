namespace ConstructionDirector
{
    partial class Block
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
            this.main = new System.Windows.Forms.Panel();
            this.orderLabel = new System.Windows.Forms.Label();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.White;
            this.main.Controls.Add(this.orderLabel);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Enabled = false;
            this.main.Location = new System.Drawing.Point(5, 5);
            this.main.Margin = new System.Windows.Forms.Padding(0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(140, 140);
            this.main.TabIndex = 0;
            // 
            // orderLabel
            // 
            this.orderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderLabel.Enabled = false;
            this.orderLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderLabel.Location = new System.Drawing.Point(0, 0);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(140, 140);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "0";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Block
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.main);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Block";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel main;
        private Label orderLabel;
    }
}
