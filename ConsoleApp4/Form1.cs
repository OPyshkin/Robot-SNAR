using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int CellWid, CellHgt;
        Graphics g;
        Maze inMaze;
        Bitmap inBm = new Bitmap(1, 1);

        float time = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            picMaze.Image = new Bitmap(picMaze.Width, picMaze.Height);
            g = Graphics.FromImage(picMaze.Image);
            inMaze = new Maze(11, 11);
            inMaze.CreateMaze();
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PicMaze_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            inMaze.DrawGrid(g,20);
            time += 0.1f;
            picMaze.Refresh();
        }
        
    }
}
