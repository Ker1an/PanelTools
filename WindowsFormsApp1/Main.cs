using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}


		public void LocButtons() // Для перемещения кнопок
		{
			for (int i = 0; i < 10; i++)
			{
				button1.Top -= -10;
				Thread.Sleep(500);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Info ss = new Info();
			ss.Show();
		}

		private void butres_MouseClick(object sender, MouseEventArgs e)
		{
			Process.Start("C://Windows/AA_v3.exe");
		}

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

		private void butAA_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
