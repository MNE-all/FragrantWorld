using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FragrantWorld.Windows
{
    public partial class Captcha : UserControl
    {
        private int Value { get; set; }
        public Captcha()
        {
            InitializeComponent();
            RefreshValue();
        }

        public void RefreshValue()
        {
            var rnd = new Random();
            Value = rnd.Next(1000, 9999);

            int[] nums = new int[]
            {
                Value / 1000,
                Value / 100 % 10,
                Value / 10 % 10,
                Value % 10
            };

            var image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var g = Graphics.FromImage(image);


            var width = 0;
            foreach(var num in nums)
            {
                g.DrawString(num.ToString(), new Font("TimesNewRoman", 25), Brushes.Red, new Point(width, rnd.Next(-10, 20)));
                width += (this.Width / 4);
                g.DrawLine(new Pen(Color.IndianRed, 5), new Point(0, rnd.Next(-30, 100)),
                    new Point(this.Width, rnd.Next(-30, 100)));
            }
           

            pictureBox1.Image = image;
        }

        public bool ValidateValue(int answer) => Value == answer;

    }
}
