using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ConstructionDirector
{
    public partial class Block : UserControl
    {
        private int order = 0;
        private int strokeThickness = 5;

        public int Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
                orderLabel.Text = order.ToString();
                orderLabel.Visible = order > 0;
            }
        }
        public int StrokeThickness
        {
            get
            {
                return strokeThickness;
            }
            set
            {
                strokeThickness = value;
                Padding = new(strokeThickness, strokeThickness, strokeThickness, strokeThickness);
            }
        }
        public virtual bool IsStayingOn(Block block)
        {
            if (Top + Height + 1 > block.Top && Top + Height / 2 < block.Top + block.Height && Left + Width > block.Left && Left < block.Left + block.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool IsStayingUnder(Block block)
        {
            if (Top + Height / 2 > block.Top && Top - 1 < block.Top + block.Height && Left + Width > block.Left && Left < block.Left + block.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int DayOfBuild { get; set; } = -1;
        public Block()
        {
            Cursor = Cursors.Hand;
            InitializeComponent();
        }
        public void Fall(int timeInterval)
        {
            Task.Factory.StartNew(() =>
            {
                bool isfalling = true;
                while (isfalling)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() =>
                        {
                            Top += 1;
                            int fallOfset = FallOfset();
                            if (fallOfset > 0)
                            {
                                isfalling = false;
                                Top -= fallOfset;
                            }

                        }));
                    }
                    Thread.Sleep(timeInterval);
                }
            });
        }
        private int FallOfset()
        {
            if (Top + Height > Parent.Height)
            {
                return Top + Height - Parent.Height;
            }
            foreach (Block block in Parent.Controls)
            {
                if (block != this)
                {
                    if (Top + Height > block.Top && Top < block.Top + block.Height && Left + Width > block.Left && Left < block.Left + block.Width)
                    {
                        return Top + Height - block.Top;
                    }
                }
            }
            return 0;
        }
        public void Build(int time)
        {

            if (InvokeRequired)
            {
                int targetTop = Top;
                int length = Parent.Height;
                int startTop = Top - length;
                Invoke(() => {
                    Top = startTop;
                    Visible = true;
                });
                for (int i = 0; i < time; i += 20)
                {
                    Invoke(() => Top = startTop + (int)(length * i * 1.0f / time));
                    Thread.Sleep(20);
                }
                Invoke(() => Top = targetTop);
            }
        }
        public void PaintToColor(Color color)
        {
            if (InvokeRequired)
            {
                Invoke(() =>
                {
                    BackColor = Color.Black;
                    orderLabel.Visible = false;
                    main.Enabled = true;
                    main.BackColor = color;
                });
            }
            else
            {
                BackColor = Color.Black;
                orderLabel.Visible = false;
                main.Enabled = true;
                main.BackColor = color;
            }
        }
    }
}
