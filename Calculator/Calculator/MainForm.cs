using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	
	public partial class MainForm : Form
	{
		Double firstnumber;
		Double secondnumber;
		String operation=""; 
		
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void ButtonClick(object sender, EventArgs e)
		{
			Button button=(Button) sender;
			if(textBox_result.Text=="0")
			{
				textBox_result.Text="";
			}
			
			if(button.Text==".")
			{
				if(!textBox_result.Text.Contains("."))
				{
					textBox_result.Text=textBox_result.Text + button.Text;
				}
			}
			
			else
			{
				textBox_result.Text=textBox_result.Text + button.Text;
			}	
		}
		
		
		void OperatorClick(object sender, EventArgs e)
		{
			Button button=(Button)sender;
			firstnumber=Double.Parse(textBox_result.Text);
			operation=button.Text;
			textBox_result.Text="";
		}
		
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			textBox_result.Text="0";
		}
		
		
		void Button_equalClick(object sender, EventArgs e)
		{
			secondnumber=double.Parse(textBox_result.Text);
			switch (operation) 
			{
					case "+": 
						textBox_result.Text=Convert.ToString(firstnumber + secondnumber);
						break;
					case "-": 
						textBox_result.Text=Convert.ToString(firstnumber - secondnumber);
						break;
					case "*": 
						textBox_result.Text=Convert.ToString(firstnumber * secondnumber);
						break;
					case "/": 
						textBox_result.Text=Convert.ToString(firstnumber / secondnumber);
						 break;
					default:
						break;
					
			}
		}
	}
}
