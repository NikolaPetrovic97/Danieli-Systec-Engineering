/*
 * Created by SharpDevelop.
 * User: Petrovići
 * Date: 06.05.2021.
 * Time: 15:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button_comma;
		private System.Windows.Forms.Button button_division;
		private System.Windows.Forms.Button button_plus;
		private System.Windows.Forms.Button button_minus;
		private System.Windows.Forms.Button button_multiplication;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button button_equal;
		private System.Windows.Forms.TextBox textBox_result;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.button_comma = new System.Windows.Forms.Button();
			this.button_division = new System.Windows.Forms.Button();
			this.button_plus = new System.Windows.Forms.Button();
			this.button_minus = new System.Windows.Forms.Button();
			this.button_multiplication = new System.Windows.Forms.Button();
			this.button_clear = new System.Windows.Forms.Button();
			this.button_equal = new System.Windows.Forms.Button();
			this.textBox_result = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(63, 184);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 45);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(114, 184);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 45);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(12, 133);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(45, 45);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(63, 133);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(45, 45);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(114, 133);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(45, 45);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(12, 82);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(45, 45);
			this.button7.TabIndex = 7;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(63, 82);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(45, 45);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(114, 82);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(45, 45);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button0.Location = new System.Drawing.Point(12, 235);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(96, 45);
			this.button0.TabIndex = 0;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button_comma
			// 
			this.button_comma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_comma.Location = new System.Drawing.Point(114, 235);
			this.button_comma.Name = "button_comma";
			this.button_comma.Size = new System.Drawing.Size(45, 45);
			this.button_comma.TabIndex = 10;
			this.button_comma.Text = ".";
			this.button_comma.UseVisualStyleBackColor = true;
			this.button_comma.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button_division
			// 
			this.button_division.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_division.Location = new System.Drawing.Point(165, 82);
			this.button_division.Name = "button_division";
			this.button_division.Size = new System.Drawing.Size(45, 45);
			this.button_division.TabIndex = 14;
			this.button_division.Text = "/";
			this.button_division.UseVisualStyleBackColor = true;
			this.button_division.Click += new System.EventHandler(this.OperatorClick);
			// 
			// button_plus
			// 
			this.button_plus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_plus.Location = new System.Drawing.Point(165, 235);
			this.button_plus.Name = "button_plus";
			this.button_plus.Size = new System.Drawing.Size(45, 45);
			this.button_plus.TabIndex = 11;
			this.button_plus.Text = "+";
			this.button_plus.UseVisualStyleBackColor = true;
			this.button_plus.Click += new System.EventHandler(this.OperatorClick);
			// 
			// button_minus
			// 
			this.button_minus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_minus.Location = new System.Drawing.Point(165, 184);
			this.button_minus.Name = "button_minus";
			this.button_minus.Size = new System.Drawing.Size(45, 45);
			this.button_minus.TabIndex = 12;
			this.button_minus.Text = "-";
			this.button_minus.UseVisualStyleBackColor = true;
			this.button_minus.Click += new System.EventHandler(this.OperatorClick);
			// 
			// button_multiplication
			// 
			this.button_multiplication.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_multiplication.Location = new System.Drawing.Point(165, 133);
			this.button_multiplication.Name = "button_multiplication";
			this.button_multiplication.Size = new System.Drawing.Size(45, 45);
			this.button_multiplication.TabIndex = 13;
			this.button_multiplication.Text = "*";
			this.button_multiplication.UseVisualStyleBackColor = true;
			this.button_multiplication.Click += new System.EventHandler(this.OperatorClick);
			// 
			// button_clear
			// 
			this.button_clear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_clear.Location = new System.Drawing.Point(216, 82);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(45, 96);
			this.button_clear.TabIndex = 16;
			this.button_clear.Text = "C";
			this.button_clear.UseVisualStyleBackColor = true;
			this.button_clear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// button_equal
			// 
			this.button_equal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_equal.Location = new System.Drawing.Point(216, 184);
			this.button_equal.Name = "button_equal";
			this.button_equal.Size = new System.Drawing.Size(45, 96);
			this.button_equal.TabIndex = 15;
			this.button_equal.Text = "=";
			this.button_equal.UseVisualStyleBackColor = true;
			this.button_equal.Click += new System.EventHandler(this.Button_equalClick);
			// 
			// textBox_result
			// 
			this.textBox_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_result.Location = new System.Drawing.Point(12, 37);
			this.textBox_result.Name = "textBox_result";
			this.textBox_result.Size = new System.Drawing.Size(249, 26);
			this.textBox_result.TabIndex = 17;
			this.textBox_result.Text = "0";
			this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 292);
			this.Controls.Add(this.textBox_result);
			this.Controls.Add(this.button_equal);
			this.Controls.Add(this.button_clear);
			this.Controls.Add(this.button_multiplication);
			this.Controls.Add(this.button_minus);
			this.Controls.Add(this.button_plus);
			this.Controls.Add(this.button_division);
			this.Controls.Add(this.button_comma);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
