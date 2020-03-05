using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_1_Lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g; // grafika

        Robot r; // robot

        Obstacle o1, o2;

        Map mapObject1;
       
        
        //float x = 100, y = 100;
        float time = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            r = new Robot();
            o1 = new Obstacle { x = 50, y = 50, d= 50};
            o2 = new Obstacle { x = 100, y = 100 , d = 75 };
            
            
            mapObject1 = new Map();

            mapObject1.fillMap(10);

            timer1.Enabled = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            
            mapObject1.Draw(g);
            //g.DrawRectangle(Pens.Black, x++, y, 10, 20);
            r.Draw(g);
            o1.Draw(g);
            o2.Draw(g);
            r.rot_speed = (float)Math.Sin(time * 5);
            
            r.Sim(0.1f);
            time += 0.1f;
            pictureBox1.Refresh();
            //x++;

        }
    }
}
