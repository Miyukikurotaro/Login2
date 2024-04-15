/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 4/15/2024
 * Time: 1:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void Button1Click(object sender, EventArgs e)
		{
			string a, b, user, pass;
			a="nicole";
			b="cuteko";
			
			user=Convert.ToString(textBox1.Text);
			pass=Convert.ToString(textBox2.Text);
			
			if (user==a && pass==b)
				MessageBox.Show("Login Succesfully");
			if (user!=a && pass==b) 
				MessageBox.Show("Wrong Username");
			if (user==a && pass!=b) 
				MessageBox.Show("Wrong Password");
			if (user!=a && pass!=b) 
				MessageBox.Show("Account does not exist");
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
