
namespace ConstructionDirector
{
    public partial class GameForm : Form
    {
        private int countOfBlocks = 3;
        private int blockCounter = 0;
        private Block currentBlock;
        private Point prevCursorPosition;
        private Point prevPanelPosition;
        private bool isDroppedBlockSuit = false;
        private bool isDragging = false;
        private List<Block> blocks = new();
        private List<Builder> builders = new();
        private int countOfDays = 0;
        private List<Color> colors = new()
        {
            Color.Green, Color.Blue, Color.Yellow, Color.Red
        };
        public GameForm()
        {
            using(InputCountForm inputForm = new())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    countOfBlocks = inputForm.InputCount;
                }
            }
            currentBlock = new();
            currentBlock.Visible = false;
            Controls.Add(currentBlock);
            InitializeComponent();
            DayLabel.Text = "Блоков осталось: " + countOfBlocks;
        }

        private void Block_MouseDown(object sender, MouseEventArgs e)
        {
            {
                isDragging = true;
                Block block = sender as Block;
                prevPanelPosition = block.GetLocationRelativeTo(this);
                prevCursorPosition = Cursor.Position;
                {
                    currentBlock.Height = block.Height;
                    currentBlock.Width = block.Width;
                    currentBlock.Order = block.Order;
                    currentBlock.StrokeThickness = block.StrokeThickness;
                    currentBlock.BackColor = block.BackColor;
                    currentBlock.Location = prevPanelPosition.Add(Cursor.Position.Subtract(prevCursorPosition));
                }
                
                currentBlock.Visible = true;
            }
        }
        private void Block_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                currentBlock.Location = prevPanelPosition.Add(Cursor.Position.Subtract(prevCursorPosition));
                Point gamePanelLocation = gamePanel.GetLocationRelativeTo(this);
                if (currentBlock.Left > gamePanelLocation.X &&
                    currentBlock.Left + currentBlock.Width < gamePanelLocation.X + gamePanel.Width &&
                    currentBlock.Top > gamePanelLocation.Y &&
                    currentBlock.Top + currentBlock.Height < gamePanelLocation.Y + gamePanel.Height)
                {
                    isDroppedBlockSuit = true;
                    Point localCBLocation = currentBlock.Location.Subtract(gamePanel.GetLocationRelativeTo(this));
                    foreach (Block block in blocks)
                    {
                        if (localCBLocation.X + currentBlock.Width > block.Left && localCBLocation.X < block.Left + block.Width &&
                            localCBLocation.Y + currentBlock.Height > block.Top && localCBLocation.Y < block.Top + block.Height)
                        {
                            isDroppedBlockSuit = false;
                            break;
                        }
                        
                    }
                }
                else
                {
                    isDroppedBlockSuit = false;
                }
                currentBlock.BackColor = isDroppedBlockSuit ? Color.Green : Color.Red;
            }
        }
        private void Block_MouseUp(object sender, MouseEventArgs e)
        {
            currentBlock.Visible = false;
            isDragging = false;
            if (isDroppedBlockSuit)
            {
                isDroppedBlockSuit = false;
                {
                    Block block = new()
                    {
                        Location = currentBlock.Location.Subtract(gamePanel.GetLocationRelativeTo(this)),
                        Width = currentBlock.Width,
                        Height = currentBlock.Height,
                        StrokeThickness = currentBlock.StrokeThickness,
                        Order = ++blockCounter,
                        BackColor = currentBlock.BackColor,
                        Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                    };
                    gamePanel.Controls.Add(block);
                    blocks.Add(block);
                    block.Fall(10);
                    DayLabel.Text = "Блоков осталось: " + (countOfBlocks - blockCounter);
                }
                if (blockCounter == countOfBlocks)
                {
                    manageButton.Enabled = true;
                    foreach(Block block in scrollPanel.Controls)
                    {
                        block.Enabled = false;
                    }
                }
            }
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            using(ManageBuildersForm buildersForm = new(blocks))
            {
                if (buildersForm.ShowDialog() == DialogResult.OK)
                {
                    builders = buildersForm.Buildsers;
                    countOfDays = buildersForm.CountOfDays;
                    visualizationButton.Enabled = true;
                    for(int i = 0; i < builders.Count; i++)
                    {
                        builders[i].BuildingColor = colors[i];
                    }
                }
            }
            
        }

        private void VisualizationButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            foreach(Block block in blocks)
            {
                block.Visible = false;
            }
            foreach(Builder builder in builders)
            {
              builder.WorkedDays = 0;
            }
            Task.Factory.StartNew(() =>
            {
                List<Task> tasks = new();
                for (int i = 0; i < countOfDays; i++)
                {
                    if (InvokeRequired) Invoke(() => DayLabel.Text = "Стройка: день " + (i + 1));
                    foreach (Builder builder in builders)
                    {
                        Task task = new(() => builder.WorkOneDay());
                        tasks.Add(task);
                        task.Start();
                    }
                    foreach (Task task in tasks)
                    {
                        task.Wait();
                    }
                }
                if (InvokeRequired) Invoke(() =>
                {
                    Enabled = true;
                });
                MessageBox.Show($"Понадобилось {countOfDays} дней", "Постройка завершена");
            });
        }

        private void DayLabel_ForeColorChanged(object sender, EventArgs e)
        {
            DayLabel.ForeColor = Color.Black;
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            GameInfo info = new() { BlockCounter = blockCounter, BlockPanel = scrollPanel, GamePanel = gamePanel, CountOfBlocks = countOfBlocks, ManageButton = manageButton, VisuailizeButton = visualizationButton, InfoLabel = DayLabel };
            using (OptionForm options = new(info))
            {
                DialogResult result = options.ShowDialog();
                switch (result)
                {
                    case DialogResult.Cancel:
                        blockCounter = options.Info.BlockCounter;
                        countOfBlocks = options.Info.CountOfBlocks;
                        blocks.Clear();
                        foreach(Block block in info.GamePanel.Controls)
                        {
                            blocks.Add(block);
                        }
                        break;
                    case DialogResult.Abort:
                        Close();
                        break;
                }
            }
        }
    }
}