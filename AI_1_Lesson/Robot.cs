using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI_1_Lesson
{
    class Robot
    {
        public float x, y, a, w, h; // robot params
        public float speed, rot_speed;  //robot motion params


        public Robot()
        {
            x = 100;
            y = 0;
            a = 1;
            w = 50;
            h = 100;

            speed = 120;
            rot_speed = 1;
        }

        public void Draw(Graphics g)
        {
            var t = g.Transform;
            g.TranslateTransform(x, y);
            g.RotateTransform(a * 180 / (float)Math.PI);
            DrawCentredRect(g, Pens.Black,  0,0, h, w);
            DrawCentredRect(g, Pens.Violet, h/2, 0, h/5, w/5);
            //g.DrawRectangle(Pens.Black, 0 - h / 2, 0 - w / 2, h, w);
            g.Transform = t;
        }

        public void Sim(float dt)
        {
            float s = (float)Math.Sin(a);
            float c = (float)Math.Cos(a);
            x += speed * c * dt;
            y += speed * s * dt;

            a += rot_speed*dt;

        }
         
        public static void DrawCentredRect(Graphics g, Pen p, float x, float y, float h, float w )
        {
            g.DrawRectangle(Pens.Black, x - h / 2, y - w / 2, h, w);
        }
    }
}
