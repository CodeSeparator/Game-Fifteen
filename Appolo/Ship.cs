using System;

namespace Appolo
{
    public enum ShipStatus
    {
        wait,
        play,
        crash,
        flyout,
        landing
    }
    class Ship
    {
        public float height { get; private set; }
        public float speed { get; private set; }
        public float fuel { get; private set; }
        public bool power { get; private set; }//вкл. движка
        public ShipStatus status { get; private set; }

        readonly float moon_g = -10f;
        readonly float ship_a = 50.0f;
        readonly float speed_f = 90f;

        public Ship()
        {
            status = ShipStatus.wait;
        }

        public void Start()
        {
            height = 330;
            speed = -5;
            fuel = 400;
            status = ShipStatus.play;
        }
        public void PowerOn()
        {
            if (fuel > 0)
                power = true;
            else power = false;
        }
        public void PowerOff()
        {
            power = false;
        }
        public void MoveShip(float ms)
        {
            if (status != ShipStatus.play) return;
            if (power)
            {
                speed += ms * ship_a;
                fuel -= speed_f * ms;
                if(fuel <= 0)
                {
                    fuel = 0;
                    power = false;
                }
            }
            else speed += ms * moon_g;
            height += ms * speed;
            if (height <= 0)
            {
                if(Math.Abs(speed) < 20)
                {
                    status = ShipStatus.landing;
                }else status = ShipStatus.crash;
                PowerOff();
            }
            if(height > 500)
            {
                status = ShipStatus.flyout;
                PowerOff();
            }
        }

        internal void Finish()
        {
            status = ShipStatus.wait;
        }
    }
}
