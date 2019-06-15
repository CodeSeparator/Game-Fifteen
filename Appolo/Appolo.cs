using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appolo
{
    public partial class Appolo : Form
    {
        Ship ship;
        public Appolo()
        {
            InitializeComponent();
            ship = new Ship();
        }

        private void labelShip_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (ship.status)
            {
                case ShipStatus.wait: return;
                case ShipStatus.play:
                    ship.MoveShip((float)timer.Interval / 1000);
                    ShowShip();
                    return;
                case ShipStatus.landing:
                    ShowLanding();
                    return;
                case ShipStatus.crash:
                    ShowCrash();
                    return;
                case ShipStatus.flyout:
                    ShowFlyOut();
                    return;
            }
        }

        private void ShowFlyOut()
        {
            labelFinish.Visible = true;
            labelFinish.Text = "Улетел :(";
            ship.Finish();
        }

        private void ShowCrash()
        {
            labelFinish.Visible = true;
            labelFinish.Text = "Разбился :(";
            labelShip.BackColor = Color.Orange;
            ship.Finish();
        }

        private void ShowLanding()
        {
            labelFinish.Visible = true;
            labelFinish.Text = "Успех";
            ship.Finish();
        }

        private void ShowShip()
        {
            labelEngine.Text = ship.fuel.ToString("0.0");
            int y = labelmoon.Location.Y - Convert.ToInt16(ship.height) - labelShip.Size.Height;
            labelShip.Location = new Point(
                labelShip.Location.X,
                y);
            Fair.Location = new Point(Fair.Location.X, y + labelShip.Size.Height);
            Fair.Visible = ship.power;
            labelmoon.Text = ship.speed.ToString("0.0");
        }

        private void labelEngine_MouseDown(object sender, MouseEventArgs e)
        {
            labelEngine.BackColor = Color.Red;
     
            if (ship.status == ShipStatus.play)
                ship.PowerOn();
        }

        private void labelEngine_MouseUp(object sender, MouseEventArgs e)
        {
            labelEngine.BackColor = Color.Gray;
            ship.PowerOff();
        }

        private void labelFinish_Click(object sender, EventArgs e)
        {
            labelFinish.Visible = false;
            ship.Start();
            labelShip.BackColor = Color.Gray;
        }
    }
}
