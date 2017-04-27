using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAG
{
    public partial class Form1 : Form
    {
        //TEMPORARY FOR TESTING
        Manager m = new Manager();
        Canvas c = new Canvas();
        Pen p = new Pen(Color.Black);
        public Form1()
        {
            InitializeComponent();

            List<Canvas> canvases = new List<Canvas>();
            c.g = panel2.CreateGraphics();
            canvases.Add(c);
            c = new Canvas();
            c.g = panel3.CreateGraphics();
            canvases.Add(c);
            c = new Canvas();
            c.g = panel4.CreateGraphics();
            canvases.Add(c);
            c = new Canvas();
            c.g = panel5.CreateGraphics();
            canvases.Add(c);
            m.canvases = canvases;
            StateAC.Start(m); //sets manager as static variable in abs state
            new DrawingState().Entry();

            //panel2.Paint += new PaintEventHandler(panel1_Paint);
            




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            c.g = e.Graphics;
            //c.g.DrawRectangle(p, 0, 0, 100, 100);

        }
    }
}
