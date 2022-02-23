using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
	public partial class Form1 : Form
	{
		Graphics g;
		Pen p;
		Brush b;
		int x1 = 100, x2 = 250; //for wheels
		int x1a = 50, x2a = 100;

		public Form1()
		{
			InitializeComponent();
			this.Height = 500;
			this.Width = 500;
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			g = e.Graphics;
			p = new Pen(Color.Black);
			b = new SolidBrush(Color.Gray);

			g.DrawRectangle(p, x1a, 100, 100, 50);
			g.FillRectangle(b, x1a, 100, 100, 50);
			g.DrawRectangle(p, x2a, 100, 200, 150);
			g.FillRectangle(b, x2a, 100, 200, 150);

			g.DrawArc(p, x1, 230, 50, 50, 0, 360);
			g.DrawArc(p, x2, 230, 50, 50, 0, 360);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			x1 = x1 + 3;
			x2 = x2 + 3;

			x1a = x1a + 3;
			x2a = x2a + 3;

			if (x1 > pictureBox1.Width && x2 > pictureBox1.Width && x1a > pictureBox1.Width && x2a > pictureBox1.Width)
			{
				x1 = 100;
				x2 = 250;
				x1a = 50;
				x2a = 100;
			}
			

			this.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
		}
	}
}
