using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game2048
{
    public delegate void DelegateShow(int x, int y, int number);
    public partial class Game2048 : Form
    {
        static int size = 4;
        Label[,] box;
        Dictionary<int, Color> backColors;
        Logic logic;
        public Game2048()
        {
            InitializeComponent();
            InitBackColors();
            InitLabels();

            logic = new Logic(size, Show);
            logic.InitGame();
        }

        private void InitBackColors()
        {
            backColors = new Dictionary<int, Color>();
            backColors.Add(0, BackColor);
            byte r = 255;
            byte g = 224;
            byte b = 192;
            for (int j = 1; j < 65536*4096; j*=2)
            {
                backColors.Add(j, Color.FromArgb(r,g,b));
                r -= 8;
                g -= 16;
                b -= 24;
            }
        }

        private void box_Click(object sender, EventArgs e)
        {

        }
        private void InitLabels()
        {
            int w = panel1.Width / size;
            int h = panel1.Height / size;
            box = new Label[size,size];
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    box[x, y] = CreateLabel();
                    box[x, y].Size = new Size(w-10,h-10);
                    box[x, y].Location = new Point(x * w + 10, y * h + 10);
                    panel1.Controls.Add(box[x, y]);
                    //tableLayoutPanel1.Controls.Add(box[x,y], x,y);
                }
            }
        }
        private Label CreateLabel()
        {
            Label label = new Label();
            label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            //label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.Margin = new Padding(10);
            label.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.Text = "-";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.Click += new System.EventHandler(this.box_Click);
            return label;
        }
        public void Show(int x,int y,int number)
        {
            box[x, y].Text = number > 0 ? number.ToString() : "";
            box[x, y].BackColor = backColors[number];
        }

        private void Game2048_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left: logic.ShiftLeft(); break;
                case Keys.Right: logic.ShiftRight(); break;
                case Keys.Up: logic.ShiftUp(); break;
                case Keys.Down: logic.ShiftDown(); break;
                case Keys.Escape: logic.InitGame(); break;
                default: break;
            }
            if (logic.GameOver())
            {
                MessageBox.Show("GAMEOVER");
                logic.InitGame();
            }
        }
    }
}
