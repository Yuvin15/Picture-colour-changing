using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Windows.Forms;

namespace Drawings
{
    public partial class Form1 : Form
    {
        Bitmap image1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the image.
                image1 = new Bitmap(@"C:\Users\Yuvin\Downloads\10x-featured-social-media-image-size.png", true);

                int x, y;

                // Loop through the images pixels to reset color.
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.R, 100, 250 );
                        image1.SetPixel(x, y, newColor);
                    }
                }

                // Set the PictureBox to display the image.
                PictureBox1.Image = image1;

                // Display the pixel format in Label1.
                Label1.Text = "Pixel format: " + image1.PixelFormat.ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }
    }
}