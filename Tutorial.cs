using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Scan_Project_Proper
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }
        class Tutstuff
        {
            public static int tutinc = 0; //Increment for the tutorial, allowing the user to navigate it
        }
        public void tutstart() 
        {
            if (Tutstuff.tutinc == 0) 
            {
                backbtn.Hide();
                pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_37.PNG"; //path to image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
                pictureBox1.Show();
            }
            if (Tutstuff.tutinc == 1)
            {
                backbtn.Show();
                pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_1.PNG"; //path to image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
                pictureBox1.Show();
            }
            if (Tutstuff.tutinc == 2)
            {
                pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_2.PNG"; //path to image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
                pictureBox1.Show();
            }
            if (Tutstuff.tutinc == 3)
            {
                pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_3.PNG"; //path to image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
                pictureBox1.Show();
            }
            if (Tutstuff.tutinc == 4)
            {
                nextbtn.Hide();
                pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_4.PNG"; //path to image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
                pictureBox1.Show();
            }
            
        }
        private void backbtn_Click(object sender, EventArgs e)
        {            
            if(Tutstuff.tutinc < 0) 
            {
                return;
            }
            else 
            {
                Tutstuff.tutinc = Tutstuff.tutinc - 1;
                tutstart();
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            
            if (Tutstuff.tutinc <= 5) 
            {
                Tutstuff.tutinc = Tutstuff.tutinc + 1;
                tutstart();
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Tutorial Exit
        {
            Close(); //Closes the tutorial
        }
    }
}
