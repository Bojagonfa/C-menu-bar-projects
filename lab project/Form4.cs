using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int ImageNumber = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // retrieve image from resources and load into PictureBox
            pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"image{ImageNumber}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image Files|*.jpg;*.gif;*.png";
            img.ShowDialog();
            //SizeMode options – StretchImage, AutoSize, Zoom, etc
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = img.FileName;
            //byte myimg = (byte)pictureBox1.Image.PixelFormat; you will use this in your project 

        }
    }
}
