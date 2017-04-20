namespace ColorManege
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.H_value_box = new System.Windows.Forms.NumericUpDown();
			this.S_value_box = new System.Windows.Forms.NumericUpDown();
			this.V_value_box = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ColorSample = new System.Windows.Forms.PictureBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.R_Box = new System.Windows.Forms.TextBox();
			this.B_Box = new System.Windows.Forms.TextBox();
			this.G_Box = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.H_value_box)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.S_value_box)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.V_value_box)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorSample)).BeginInit();
			this.SuspendLayout();
			// 
			// H_value_box
			// 
			this.H_value_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.H_value_box.Location = new System.Drawing.Point(43, 15);
			this.H_value_box.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
			this.H_value_box.Name = "H_value_box";
			this.H_value_box.Size = new System.Drawing.Size(54, 23);
			this.H_value_box.TabIndex = 1;
			this.H_value_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.H_value_box.ValueChanged += new System.EventHandler(this.H_value_box_ValueChanged);
			// 
			// S_value_box
			// 
			this.S_value_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.S_value_box.Location = new System.Drawing.Point(43, 44);
			this.S_value_box.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.S_value_box.Name = "S_value_box";
			this.S_value_box.Size = new System.Drawing.Size(54, 23);
			this.S_value_box.TabIndex = 2;
			this.S_value_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.S_value_box.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.S_value_box.ValueChanged += new System.EventHandler(this.S_value_box_ValueChanged);
			// 
			// V_value_box
			// 
			this.V_value_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.V_value_box.Location = new System.Drawing.Point(43, 73);
			this.V_value_box.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.V_value_box.Name = "V_value_box";
			this.V_value_box.Size = new System.Drawing.Size(54, 23);
			this.V_value_box.TabIndex = 3;
			this.V_value_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.V_value_box.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.V_value_box.ValueChanged += new System.EventHandler(this.V_value_box_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(17, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "H";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(17, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "V";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(17, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "S";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(103, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "[0 ~ 179]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(103, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "[0 ~ 255]";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(103, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "[0 ~ 255]";
			// 
			// ColorSample
			// 
			this.ColorSample.BackColor = System.Drawing.Color.White;
			this.ColorSample.Location = new System.Drawing.Point(184, 30);
			this.ColorSample.Name = "ColorSample";
			this.ColorSample.Size = new System.Drawing.Size(74, 50);
			this.ColorSample.TabIndex = 11;
			this.ColorSample.TabStop = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(26, 161);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(232, 83);
			this.richTextBox1.TabIndex = 12;
			this.richTextBox1.Text = "OpenCVにおけるHSV色空間確認\nH：Hue　色相\nS：Saturation　彩度\nV：Value　明度";
			// 
			// R_Box
			// 
			this.R_Box.BackColor = System.Drawing.Color.Red;
			this.R_Box.ForeColor = System.Drawing.SystemColors.Window;
			this.R_Box.Location = new System.Drawing.Point(43, 120);
			this.R_Box.Name = "R_Box";
			this.R_Box.ReadOnly = true;
			this.R_Box.Size = new System.Drawing.Size(45, 23);
			this.R_Box.TabIndex = 13;
			// 
			// B_Box
			// 
			this.B_Box.BackColor = System.Drawing.Color.Blue;
			this.B_Box.ForeColor = System.Drawing.Color.White;
			this.B_Box.Location = new System.Drawing.Point(213, 120);
			this.B_Box.Name = "B_Box";
			this.B_Box.ReadOnly = true;
			this.B_Box.Size = new System.Drawing.Size(45, 23);
			this.B_Box.TabIndex = 14;
			// 
			// G_Box
			// 
			this.G_Box.BackColor = System.Drawing.Color.Lime;
			this.G_Box.ForeColor = System.Drawing.Color.White;
			this.G_Box.Location = new System.Drawing.Point(130, 120);
			this.G_Box.Name = "G_Box";
			this.G_Box.ReadOnly = true;
			this.G_Box.Size = new System.Drawing.Size(45, 23);
			this.G_Box.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(104, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 19);
			this.label7.TabIndex = 18;
			this.label7.Text = "G";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(187, 122);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 19);
			this.label8.TabIndex = 17;
			this.label8.Text = "B";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label9.Location = new System.Drawing.Point(17, 122);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(19, 19);
			this.label9.TabIndex = 16;
			this.label9.Text = "R";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 255);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.G_Box);
			this.Controls.Add(this.B_Box);
			this.Controls.Add(this.R_Box);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.ColorSample);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.V_value_box);
			this.Controls.Add(this.S_value_box);
			this.Controls.Add(this.H_value_box);
			this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "ColorManage";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.H_value_box)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.S_value_box)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.V_value_box)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorSample)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown H_value_box;
		private System.Windows.Forms.NumericUpDown S_value_box;
		private System.Windows.Forms.NumericUpDown V_value_box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox ColorSample;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox R_Box;
		private System.Windows.Forms.TextBox B_Box;
		private System.Windows.Forms.TextBox G_Box;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}

