﻿/*
 * Created by SharpDevelop.
 * User: diak
 * Date: 2018. 11. 22.
 * Time: 14:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LovoldozosJatek
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int ufoseb=1,golyoseb=10;
		
		
		
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void urhajoClick(object sender, EventArgs e)
		{
			
		}
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar=='i') {
				urhajo.Top-=10;
			}
			
			if (e.KeyChar=='m') {
				urhajo.Top+=10;
			}
			
			if (e.KeyChar=='j') {
				
				lovedek.Visible=true;
			}
		}
		void UrhajoClick(object sender, EventArgs e)
		{
	
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			ufo.Top+=ufoseb;
			if (ufo.Top==380) {
				ufoseb=-1;
			}
			
			if (ufo.Top==0) {
				ufoseb=1;
			}
			
			if (lovedek.Left>190) {
				if (lovedek.Visible) {
					lovedek.Left-=golyoseb;
				}
			}
			
			if (lovedek.Left<=190) {
				lovedek.Visible=false;
				lovedek.Left=830;
			}
		}
	}
}
