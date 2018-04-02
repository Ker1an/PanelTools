namespace WindowsFormsApp1
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button1 = new System.Windows.Forms.Button();
			this.butAA = new System.Windows.Forms.Button();
			this.gif = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "Инфо";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// butAA
			// 
			this.butAA.Location = new System.Drawing.Point(103, 12);
			this.butAA.Name = "butAA";
			this.butAA.Size = new System.Drawing.Size(85, 37);
			this.butAA.TabIndex = 1;
			this.butAA.Text = "AA";
			this.butAA.UseVisualStyleBackColor = true;
			this.butAA.Click += new System.EventHandler(this.butAA_Click);
			this.butAA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butres_MouseClick);
			// 
			// gif
			// 
			this.gif.BackColor = System.Drawing.SystemColors.Control;
			this.gif.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gif.Image = ((System.Drawing.Image)(resources.GetObject("gif.Image")));
			this.gif.Location = new System.Drawing.Point(0, 0);
			this.gif.Name = "gif";
			this.gif.Size = new System.Drawing.Size(808, 391);
			this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gif.TabIndex = 2;
			this.gif.TabStop = false;
			this.gif.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 391);
			this.Controls.Add(this.butAA);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gif);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Панель управления";
			((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button butAA;
		private System.Windows.Forms.PictureBox gif;
	}
}