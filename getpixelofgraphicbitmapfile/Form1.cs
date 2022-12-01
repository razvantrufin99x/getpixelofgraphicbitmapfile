using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace getpixelofgraphicbitmapfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Color GetPixel_Example(PaintEventArgs e)
        {

            // Create a Bitmap object from an image file.
            Bitmap myBitmap = new Bitmap("Grapes.jpg");

            // Get the color of a pixel within myBitmap.
            Color pixelColor = myBitmap.GetPixel(50, 50);

            // Fill a rectangle with pixelColor.
            SolidBrush pixelBrush = new SolidBrush(pixelColor);
            e.Graphics.FillRectangle(pixelBrush, 0, 0, 100, 100);

            return pixelColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           Color c =  GetPixel_Example(e);
           Text = c.ToString();
        }
    }
}
