using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace wpfMultiSolar
{
    internal class Planet
    {
        Ellipse? body;
        const double x0 = 500;
        const double y0 = 500;
        double x;
        double y;
        double radius;
        double angle;
        double speed;

        Action setCoords;

        public Planet(Ellipse body, double radius, double speed)
        {
            this.body = body;
            this.radius = radius;
            this.speed = (speed / 10) / 3;
            setCoords += SetXY;
        }

        public void MovePlanet1(object? sender, EventArgs e)
        {
            if (angle >= 360)
                angle = 0.0;

            x = CalcX(radius, angle, x0);
            y = CalcY(radius, angle, y0);

            try
            {
                App.Current.Dispatcher.Invoke(setCoords);
                //setCoords.Invoke();
            }
            catch (Exception ex) { }

            angle += speed;
        }

        public void MovePlanet2(object? state)
        {
            if (angle >= 360)
                angle = 0.0;

            x = CalcX(radius, angle, x0);
            y = CalcY(radius, angle, y0);

            try
            {
                App.Current.Dispatcher.Invoke(setCoords);
                //setCoords.Invoke();
            }
            catch (Exception ex) { }

            angle += speed;
        }

        void SetXY()
        {
            Canvas.SetLeft(body, x);
            Canvas.SetTop(body, y);
        }

        double CalcX(double radius, double angle, double x0)
        {
            return radius * Math.Cos(angle) + x0;
        }

        double CalcY(double radius, double angle, double y0)
        {
            return radius * Math.Sin(angle) + y0;
        }
    }
}
