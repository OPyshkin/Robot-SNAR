using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI_1_Lesson
{
    class Map
    {
        public List<Rectangle> field = new List<Rectangle>();
        public int xCoord=10, yCoord=0, xRib=20, yRib=20;
        //public int rowLen = 10;
        //public Rectangle rect;
        public void fillMap(int rowLen)
        {
            for (int i=0;i< rowLen; i++)
            {
                //rect = new Rectangle(xCoord+10, yCoord+10, xRib, yRib);
                field.Add(new Rectangle(xCoord, yCoord, xRib, yRib));
                xCoord += 10;
                //yCoord += 10;
            }
                  
        }
        public void Draw(Graphics g)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            for (int i = 0; i < field.Count; i++)
                g.FillRectangle(blueBrush, field[i]); 
            


        }

    }
}
