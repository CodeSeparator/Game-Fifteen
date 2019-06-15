using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifteen
{
    public partial class FormFifteen : Form
    {
        Game game;
        int size = 3;
        Image[,] img;
        PictureBox[,] box;
        public FormFifteen()
        {
            InitializeComponent();
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
          
        }
        

        private void FormFifteen_Load(object sender, EventArgs e)
        {
            StartGame();
        }
        private void menuStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame() {
            game = new Game(size);
            CropImg();
            InitPics();
            game.Start();
           
            for (int j = 0; j < size*size*10; j++)
            {
                game.shiftRand();
            }
           
            refresh();
        }

        private void CropImg()
        {
            img = new Image[size, size];
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    img[x, y] = GetImgPart(x, y);
                }
            }
        }

        private Bitmap GetImgPart(int x, int y)
        {
            Bitmap bmp = Properties.Resources.castle1;
            int w, h;
            w = bmp.Width / size;
            h = bmp.Height / size;
            Rectangle croppart = new Rectangle(x * w,y * h, w, h);
            Bitmap target = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(target);
            g.DrawImage(bmp, new Rectangle(0, 0, target.Width, target.Height), croppart, GraphicsUnit.Pixel);
            return target;
        }
        private void InitPics()
        {
            int w, h;
            w = panel1.Width / size;
            h = panel1.Height / size;

            panel1.Controls.Clear();
            box = new PictureBox[size, size];
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    PictureBox pb = new PictureBox();

                    pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pb.Location = new System.Drawing.Point(x*w,y*h);
                    pb.Size = new System.Drawing.Size(w,h);
                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pb.Tag = y * size + x;
                    pb.Click += new System.EventHandler(this.pictureBox1_Click);

                    panel1.Controls.Add(pb);
                    box[x,y] = pb;
                }
            }
        }

        private void refresh()
        {
            for (int position = 0; position < size * size; position++)
            {
                int nr = game.GetNumber(position);
                if (nr == -1) box[position % size, position / size].Visible = (nr >= 0);
                if(nr >= 0)
                    box[position % size, position / size].Image = img[nr % size, nr / size];
            }
        }

        private void menuLevel3_Click(object sender, EventArgs e)
        {
            size = 3;
            StartGame();
        }

        private void menuLevel4_Click(object sender, EventArgs e)
        {
            size = 4;
            StartGame();
        }

        private void menuLevel5_Click(object sender, EventArgs e)
        {
            size = 5;
            StartGame();
        }

        private void menuLevel6_Click(object sender, EventArgs e)
        {
            size = 6;
            StartGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((PictureBox)sender).Tag);
            game.Shift(position);
            refresh();
            if (game.checkNums())
            {
                MessageBox.Show("WIN");
                StartGame();
            }

        }
    }
}
