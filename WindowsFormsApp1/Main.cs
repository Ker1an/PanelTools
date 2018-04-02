using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
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
    }
}
