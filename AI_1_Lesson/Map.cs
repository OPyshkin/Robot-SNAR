using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace AI_1_Lesson
{

    class Cell //Class of a cell
    {
        public Rectangle item { get; set; } //rectangle params 
        public bool obstacle { get; set; } //if wall or not
    }

    class Map
    {
        public List<Cell> field = new List<Cell>();
        public int xCoord=0, yCoord=0;
        public void fillMap(int cellSize, int row, int column)
        {
            Random rnd = new Random();

            int rowLen = row * column;
            for (int i=0;i< rowLen; i++)
            {
                field.Add(new Cell { item = new Rectangle(xCoord, yCoord, cellSize, cellSize), obstacle = false});
                if (xCoord< cellSize*(row-1))
                {
                    xCoord += cellSize;
                }
                else
                {
                    yCoord += cellSize;
                    xCoord = 0;
                }
                
                //yCoord += 10;
            }
                  
        }
        
        public void DrawMesh(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.Alignment = PenAlignment.Inset;
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0xff, 0xff, 0x00, 0x00));
            for (int i = 0; i < field.Count; i++)
            {
                g.FillRectangle(blueBrush, field[i].item);
                g.DrawRectangle(pen, field[i].item);
                
            }
        }

    }
}
