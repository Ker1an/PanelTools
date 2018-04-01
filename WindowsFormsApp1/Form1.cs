using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox2.Text == "Ker1an" & textBox1.Text == "1qw23er4q")
			{
				this.Hide();
				Main ss = new Main();
				ss.Show();
				MessageBox.Show("Вход в панель успешно выполнен как Ker1an");
			}
			else if (textBox2.Text == "Nikolay" & textBox1.Text == "hfwrth228")
			{
				this.Hide();
				Main ss = new Main();
				ss.Show();
				MessageBox.Show("Вход в панель успешно выполнен как Nikolay");
			}
			else
				MessageBox.Show("Попробуйте вести пароль ещё раз");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
