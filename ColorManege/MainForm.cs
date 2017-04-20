using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorManege
{
	public partial class MainForm : Form
	{
		public ColorContainer CContainer;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CContainer = new ColorContainer();
			HSV_Read();
		}

		private void H_value_box_ValueChanged(object sender, EventArgs e)
		{
			HSV_Read();
		}

		private void S_value_box_ValueChanged(object sender, EventArgs e)
		{
			HSV_Read();
		}		

		private void V_value_box_ValueChanged(object sender, EventArgs e)
		{
			HSV_Read();
		}

		private void HSV_Read()
		{
			CContainer.setHSV((int)(H_value_box.Value),(int)(S_value_box.Value),(int)(V_value_box.Value));
			ColorSample.BackColor = CContainer.getColor();
			R_Box.Text = CContainer.getR().ToString();
			G_Box.Text = CContainer.getG().ToString();
			B_Box.Text = CContainer.getB().ToString();
		}

	}

	public class ColorContainer
	{
		private int[] HSV = new int[3]; //[180,256,256]
		private int[] RGB = new int[3]; //[256,256,256]
		private Color SampleColor;

		public void HSV2RGB()
		{
			float rgb_max, rgb_min;
			float delta;

			rgb_max = HSV[2];
			rgb_min = rgb_max - (((float)HSV[1] / 255) * rgb_max);
			delta = rgb_max - rgb_min;

			if (HSV[0] >= 0 && HSV[0] < 60)
			{
				RGB[0] = (int)rgb_max;
				RGB[1] = (int)(rgb_min + (HSV[0] * delta) / 60.0);
				RGB[2] = (int)rgb_min;
			}
			else if (HSV[0] >= 60 && HSV[0] < 120)
			{
				RGB[0] = (int)(rgb_min + ((120.0 - HSV[0]) * delta) / 60.0);
				RGB[1] = (int)rgb_max;
				RGB[2] = (int)rgb_min;
			}
			else if (HSV[0] >= 120 && HSV[0] < 180)
			{
				RGB[0] = (int)rgb_min;
				RGB[1] = (int)rgb_max;
				RGB[2] = (int)(rgb_min + ((HSV[0] - 120.0) * delta) / 60.0);
			}
			else if (HSV[0] >= 180 && HSV[0] < 240)
			{
				RGB[0] = (int)rgb_min;
				RGB[1] = (int)(rgb_min + ((240.0 - HSV[0]) * delta) / 60.0);
				RGB[2] = (int)rgb_max;
			}
			else if (HSV[0] >= 240 && HSV[0] < 300)
			{
				RGB[0] = (int)(rgb_min + ((HSV[0] - 240.0) * delta) / 60.0);
				RGB[1] = (int)rgb_min;
				RGB[2] = (int)rgb_max;
			}
			else if (HSV[0] >= 300 && HSV[0] < 360)
			{
				RGB[0] = (int)rgb_max;
				RGB[1] = (int)rgb_min;
				RGB[2] = (int)(rgb_min + ((360.0 - HSV[0]) * delta) / 60.0);
			}

		}

		public void RGB2HSV()
		{
			int rgb_max, rgb_min;
			int delta;

			rgb_max = Max(RGB);
			rgb_min = Min(RGB);
			delta = rgb_max - rgb_min;

			if (rgb_max == RGB[0])
			{
				HSV[0] = 60 * ((RGB[1] - RGB[2]) / delta);
			}
			else if (rgb_max == RGB[1])
			{
				HSV[0] = 60 * ((RGB[2] - RGB[0]) / delta) + 120;
			}
			else if (rgb_max == RGB[2])
			{
				HSV[0] = 60 * ((RGB[0] - RGB[1]) / delta) + 240;
			}
			if (HSV[0] < 0)
			{
				HSV[0] = HSV[0] + 360;
			}

			HSV[1] = (delta / rgb_max) * 255;
			HSV[2] = rgb_max;

		}

		public void setHSV(int H, int S, int V)
		{
			HSV[0] = H * 2;
			HSV[1] = S;
			HSV[2] = V;
			HSV2RGB();
		}

		public Color getColor()
		{
			SampleColor = Color.FromArgb(RGB[0], RGB[1], RGB[2]);
			return SampleColor;
		}

		public int getR()
		{
			return RGB[0];
		}
		public int getG()
		{
			return RGB[1];
		}
		public int getB()
		{
			return RGB[2];
		}

		public int Max(params int[] nums)
		{
			// 引数が渡されない場合
			if (nums.Length == 0) return 0;
			int max = nums[0];
			for (int i = 1; i < nums.Length; i++)
			{
				max = max > nums[i] ? max : nums[i];
				// Minの場合は不等号を逆にすればOK
			}
			return max;
		}
		public int Min(params int[] nums)
		{
			// 引数が渡されない場合
			if (nums.Length == 0) return 0;
			int min = nums[0];
			for (int i = 1; i < nums.Length; i++)
			{
				min = min < nums[i] ? min : nums[i];
				// Minの場合は不等号を逆にすればOK
			}
			return min;
		}
	}
}
