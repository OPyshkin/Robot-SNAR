using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI_1_Lesson
{
    class Obstacle
    {
        public float x, y, d;
        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Green, x - d / 2, y - d / 2, d,d);
        }
    }
}
