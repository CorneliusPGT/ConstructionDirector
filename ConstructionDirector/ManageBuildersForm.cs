using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionDirector
{
    public partial class ManageBuildersForm : Form
    {
        private Button currentButton;
        private Regex regex = new(@"^установи\s\d{1,}\b", RegexOptions.IgnoreCase);
        private Regex getNum = new(@"\d{1,}");
        private List<Block> blocks;
        public List<Builder> Buildsers { get; private set; } = new();
        public int CountOfDays { get; private set; } = 0;
        public ManageBuildersForm(List<Block> blocks)
        {
            DialogResult = DialogResult.Cancel;
            this.blocks = blocks;
            foreach (Block block in blocks)
            {
                block.DayOfBuild = -1;
            }
            InitializeComponent();
            currentButton = twoBuildersButton;
            backgroundPanel.Controls.Remove(secondStepPanel);
            firstStepPanel.Dock = DockStyle.Fill;
        }

        private void BuildersButton_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = Color.FromArgb(64, 64, 64);
            currentButton.FlatAppearance.BorderSize = 1;
            currentButton = sender as Button;
            currentButton.BackColor = Color.FromKnownColor(KnownColor.DarkGray);
            currentButton.FlatAppearance.BorderSize = 5;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int buildersCount = int.Parse(currentButton.Text);
            Buildsers = new();
            for (int i = 0; i < buildersCount; i++)
            {
                Buildsers.Add(new());
            }
            table.Controls.Clear();
            table.ColumnCount = buildersCount + 1;
            table.RowCount = 6;
            table.ColumnStyles.Clear();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.ColumnStyles.Add(new(SizeType.Percent, 100f / buildersCount));
            }
            table.RowStyles.Clear();
            for (int i = 0; i < table.RowCount; i++)
            {
                table.RowStyles.Add(new(SizeType.Absolute, 50));
            }
            for (int i = 1; i <= buildersCount; i++)
            {
                Label builderLabel = new()
                {
                    Text = "Строитель " + i,
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new("Segoe UI", 20),
                };
                table.Controls.Add(builderLabel, i, 0);
            }
            InitTableRow(1);
            for (int i = 2; i < table.RowCount; i++)
            {
                InitTableRow(i, false);
            }
            backgroundPanel.Controls.Add(secondStepPanel);
            backgroundPanel.Controls.Remove(firstStepPanel);
            secondStepPanel.Dock = DockStyle.Fill;
        }
        private void AddRowToTable()
        {
            int day = table.RowCount;
            table.RowStyles.Add(new(SizeType.Absolute, 50));
            table.RowCount += 1;
            InitTableRow(day);
        }
        private void InitTableRow(int day, bool enabled = true)
        {
            Label dayLabel = new()
            {
                Text = "День " + day,
                Dock = DockStyle.Fill,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new("Segoe UI", 20),
                Enabled = enabled,
            };
            table.Controls.Add(dayLabel, 0, day);
            for (int i = 1; i < table.ColumnCount; i++)
            {
                TextBox commandTextBox = new()
                {

                    Multiline = false,
                    MaxLength = 15,
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    Font = new("Segoe UI", 20),
                    Margin = new(0, 0, 0, 0),
                    Enabled = enabled,
                };
                commandTextBox.Leave += CommandTextBox_Leave;
                commandTextBox.Enter += CommandTextBox_Enter;
                table.Controls.Add(commandTextBox, i, day);
            }
        }
        private void CommandTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Match match = regex.Match(textBox.Text);
            int day = table.GetRow(textBox);
            try
            {
                if (match.Success)
                {
                    int blockOrder = int.Parse(getNum.Match(match.Value).Value);
                    if (blocks.Any(b => b.Order == blockOrder))
                    {
                        Block thisBlock = blocks.First(b => b.Order == blockOrder);
                        if (thisBlock.DayOfBuild != -1)
                        {
                            throw new BlockException($"Блок под номером {blockOrder} уже назначен в {thisBlock.DayOfBuild} день", "Неправильный ввод");
                        }
                        List<int> unbuiltBlocksOrders = new();
                        foreach (Block block in blocks.Where(b => b.Order != blockOrder))
                        {
                            if (thisBlock.IsStayingOn(block) && (block.DayOfBuild >= day || block.DayOfBuild == -1))
                            {
                                unbuiltBlocksOrders.Add(block.Order);
                            }
                        }
                        if (unbuiltBlocksOrders.Count > 0)
                        {
                            throw new BlockException(GetStringForUnbuiltBlocks(unbuiltBlocksOrders), "Нельзя поставить блок");
                        }
                        else
                        {
                            thisBlock.DayOfBuild = day;
                            Buildsers[table.GetColumn(textBox) - 1].AddBlockToSchedule(thisBlock, day);
                        }
                    }
                    else
                    {
                        throw new BlockException($"Блок под номером {blockOrder} не существует", "Неправильный ввод");
                    }
                }
                else if (!string.IsNullOrEmpty(textBox.Text))
                {
                    throw new BlockException("Команда должна содержать слово 'установи' и номер блока", "Неправильный ввод");
                }
            }
            catch (BlockException ex)
            {
                MessageBox.Show(ex.Message, ex.Capture);
                textBox.Focus();
            }
        }
        private string GetStringForUnbuiltBlocks(List<int> unbuiltBlocksOrders)
        {
            string text = "Нельзя построить этот блок пока ";
            if (unbuiltBlocksOrders.Count == 1)
            {
                text += "не построен блок под номером " + unbuiltBlocksOrders.First();
            }
            else
            {
                text += "не построены блоки под номерами ";
                for (int i = 0; i < unbuiltBlocksOrders.Count - 1; i++)
                {
                    text += unbuiltBlocksOrders[i] + ", ";
                }
                text += unbuiltBlocksOrders.Last();
            }
            return text;
        }
        private void СonfirmButton_Click(object sender, EventArgs e)
        {
            foreach (Block block in blocks)
            {
                if (block.DayOfBuild == -1)
                {
                    MessageBox.Show("Не все блоки назначены");
                    return;
                }
            }
            foreach(Block block in blocks)
            {
                if (block.DayOfBuild > CountOfDays)
                {
                    CountOfDays = block.DayOfBuild;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void CommandTextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Match match = regex.Match(textBox.Text);
            if (match.Success)
            {
                int blockOrder = int.Parse(getNum.Match(match.Value).Value);
                if (blocks.Any(b => b.Order == blockOrder))
                {
                    Block block = blocks.First(b => b.Order == blockOrder);
                    bool oneMatch = true;
                    for (int row = 1; row < table.RowCount; row++)
                    {
                        for (int coloumn = 1; coloumn < table.ColumnCount; coloumn++)
                        {
                            TextBox otherTextBox = table.GetControlFromPosition(coloumn, row) as TextBox;
                            Match otherMatch = regex.Match(otherTextBox.Text);
                            if (otherMatch.Success)
                            {
                                int otherBlockOrder = int.Parse(getNum.Match(otherMatch.Value).Value);
                                if (otherBlockOrder == blockOrder && otherTextBox != textBox)
                                {
                                    oneMatch = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (block != null && oneMatch)
                    {
                        UnbuildBlock(block);
                    }
                }
            }
            int tempday = 1;
            try
            {
                int day = table.GetRow(textBox);
                for (tempday = 1; tempday < day; tempday++)
                {
                    bool emptyDay = true;
                    for (int i = 1; i < table.ColumnCount; i++)
                    {
                        if (!string.IsNullOrEmpty(table.GetControlFromPosition(i, tempday).Text))
                        {
                            emptyDay = false;
                            break;
                        }
                    }
                    if (emptyDay)
                    {
                       throw new BlockException($"{tempday} день не может быть пустым", "Нельзя отдыхать!");
                    }
                }
                int nextRow = day + 1;
                if (nextRow == table.RowCount)
                {
                    AddRowToTable();
                }
                else
                {
                    for (int i = 0; i < table.ColumnCount; i++)
                    {
                        table.GetControlFromPosition(i, nextRow).Enabled = true;
                    }
                }
            } catch (BlockException ex)
            {
                MessageBox.Show(ex.Message, ex.Capture);
                table.GetControlFromPosition(1, tempday).Focus();
            }
        }
        private void UnbuildBlock(Block block)
        {
            if (block.DayOfBuild != -1)
            {
                foreach (Block other in blocks.Where(b => b.Order != block.Order))
                {
                    if (block.IsStayingUnder(other))
                    {
                        UnbuildBlock(other);
                    }
                }
                int day = block.DayOfBuild;
                foreach (Builder builder in Buildsers)
                {
                    builder.RemoveFromSheduleIfExist(block);
                }
                block.DayOfBuild = -1;
                for (int coloumn = 1; coloumn < table.ColumnCount; coloumn++)
                {
                    TextBox textBox = table.GetControlFromPosition(coloumn, day) as TextBox;
                    Match match = regex.Match(textBox.Text);
                    if (match.Success)
                    {
                        if (block.Order == int.Parse(getNum.Match(match.Value).Value))
                        {
                            textBox.Text = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
