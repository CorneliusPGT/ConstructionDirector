using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionDirector
{
    public partial class OptionForm : Form
    {
        public GameInfo Info;
        public OptionForm(GameInfo info)
        {
            Info = info;
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Перетащите блоки на поле, назначьте строителей{Environment.NewLine}с помощью команды:{Environment.NewLine}'установи' и номер блока.{Environment.NewLine}Наблюдайте за визуализацией.", "Помощь");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Info.GamePanel.Controls.Clear();
            Info.BlockCounter = 0;
            SetBuildEnable(true);
        }
        private void SetBuildEnable(bool enable)
        {
            foreach (Block block in Info.BlockPanel.Controls)
            {
                block.Enabled = enable;
            }
            Info.ManageButton.Enabled = !enable;
            Info.VisuailizeButton.Enabled = false;
            Info.InfoLabel.Text = "Блоков осталось: " + (Info.CountOfBlocks - Info.BlockCounter);
        }

        private void blocksButton_Click(object sender, EventArgs e)
        {
            using (InputCountForm inputForm = new())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int countOfBlocks = inputForm.InputCount;
                    if(Info.CountOfBlocks != countOfBlocks)
                    {
                        Info.CountOfBlocks = countOfBlocks;
                        if (countOfBlocks < Info.BlockCounter)
                        {
                            Info.GamePanel.Controls.Clear();
                            Info.BlockCounter = 0;
                        }
                    }
                    SetBuildEnable(Info.CountOfBlocks != Info.BlockCounter);
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
