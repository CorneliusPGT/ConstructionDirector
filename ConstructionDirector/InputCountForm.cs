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
    public partial class InputCountForm : Form
    {
        public int InputCount { get; set; } = 0;
        public InputCountForm()
        {
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                InputCount = int.Parse(textBox1.Text);
                if (InputCount <= 0)
                {
                    textBox1.Text = string.Empty;
                    textBox1.Focus();
                    MessageBox.Show("Число должно быть положительным", "Неправильный ввод");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                textBox1.Text = string.Empty;
                textBox1.Focus();
                MessageBox.Show("Введите натуральное число","Неправильный ввод");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Close();
            }
            else
            {

                MessageBox.Show("Введите количество блоков", "Неправильный ввод");
            }
        }
    }
}
