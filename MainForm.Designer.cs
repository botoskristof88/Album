/*
 * Created by SharpDevelop.
 * User: diak
 * Date: 2018. 11. 22.
 * Time: 14:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LovoldozosJatek
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox ufo;
		private System.Windows.Forms.PictureBox urhajo;
		private System.Windows.Forms.Label lovedek;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ufo = new System.Windows.Forms.PictureBox();
			this.urhajo = new System.Windows.Forms.PictureBox();
			this.lovedek = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.urhajo)).BeginInit();
			this.SuspendLayout();
			// 
			// ufo
			// 
			this.ufo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ufo.BackgroundImage")));
			this.ufo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ufo.Location = new System.Drawing.Point(12, 139);
			this.ufo.Name = "ufo";
			this.ufo.Size = new System.Drawing.Size(180, 180);
			this.ufo.TabIndex = 0;
			this.ufo.TabStop = false;
			// 
			// urhajo
			// 
			this.urhajo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urhajo.BackgroundImage")));
			this.urhajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.urhajo.Location = new System.Drawing.Point(846, 192);
			this.urhajo.Name = "urhajo";
			this.urhajo.Size = new System.Drawing.Size(150, 67);
			this.urhajo.TabIndex = 1;
			this.urhajo.TabStop = false;
			this.urhajo.Click += new System.EventHandler(this.UrhajoClick);
			// 
			// lovedek
			// 
			this.lovedek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lovedek.Location = new System.Drawing.Point(830, 218);
			this.lovedek.Name = "lovedek";
			this.lovedek.Size = new System.Drawing.Size(10, 5);
			this.lovedek.TabIndex = 2;
			this.lovedek.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1008, 561);
			this.Controls.Add(this.lovedek);
			this.Controls.Add(this.urhajo);
			this.Controls.Add(this.ufo);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "LovoldozosJatek";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.urhajo)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
