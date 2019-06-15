using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class XO : Form
    {
        Logic logic = new Logic();

        public XO()
        {
            InitializeComponent();
            StartGame();
        }
        private void StartGame()
        {
            logic.Init();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }

        private void MenuStartPeople_Click(object sender, EventArgs e)
        {
            logic.Init();
            StartGame();
        }

        private void MenuStartAI_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {

        }

        private void MenuHelpPrav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поставить 3 в ряд");
        }

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для развлечения. blattoptera@gmail.com");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MakeMove((PictureBox)sender);
        }

        private void MakeMove(PictureBox sender)
        {
            int x, y;
            string tag = sender.Tag.ToString();
            x = int.Parse(tag.Substring(0, 1));
            y = int.Parse(tag.Substring(1, 1));
            int side = logic.side;
            if (logic.Place(x, y))
            {
                sender.Image = (side == 1) ? Properties.Resources.x : Properties.Resources._0;
                if(logic.finish != "play")
                {
                    GameOver();
                }

            }
        }

        private void GameOver()
        {
            switch (logic.finish)
            {
                case "winx": MessageBox.Show("X win!"); return;
                case "wino": MessageBox.Show("O win!"); return;
                case "draw": MessageBox.Show("DRAW"); return;
                default: return;
            }
        }
    }
}
