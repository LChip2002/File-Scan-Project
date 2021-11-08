using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Scan_Project_Proper
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }
        public void Questions() 
        {
            linkLabel1.Text = "How can I check if the files in the folder has been removed?";
            linkLabel2.Text = "Why can I not select the Recycling bin in the Manual Scan?";
            linkLabel3.Text = "How do I know which file is which?";
            linkLabel4.Text = "How come not every single file in the selected folder is being shown?";
            linkLabel5.Text = "Is there a way to leave the program without deleting or damaging any files?";
            linkLabel6.Text = "How would I be able to explain this program to my family and friends?";
            linkLabel7.Text = "What does these rows of long text in the file scan mean?";
            linkLabel8.Text = "What happens if I forget my login details?";
            linkLabel9.Text = "Is this program safe to use?";
            label1.Text = "Select a question";            
        }
        class line 
        {
            public static string newline = Environment.NewLine; //Creates a new line for the text in the description
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared.
            label1.Text = "When the delete button has been pressed," + line.newline + "a message telling the user that the files" + line.newline + 
                "have been deleted. But you can also check" +line.newline+"by redoing the scan or check the" + line.newline + "folders that were scanned.";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_5.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared            
            label1.Text = "Currently with either scan you are" + line.newline + "unable to select the recycling bin" + line.newline +
                "as it is not a feature of the program" + line.newline + "yet as there were difficulties during development";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_6.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared
            label1.Text = "Highlighted above, there's an example" + line.newline + "of a file directory. After the" + line.newline +
                "last backslash to the far right" + line.newline + "is the actual file that you can identify";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_7.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared
            label1.Text = "This is due to the Scan" + line.newline + "only looking for files that match" + line.newline + "certain types of files." +
                line.newline + "Therefore, not every single file will" + line.newline + "will be shown.";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_8.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared
            label1.Text = "You can easily leave the scan" + line.newline + "by either pressing finish or exiting" + line.newline + 
                "the program by pressing the red" +line.newline + "cross in the right corner";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_9.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared
            label1.Text = "If they are new to the program" + line.newline + "to help them, let them select" + line.newline +
                "the tutorial section that should" + line.newline + "go over the basics of the program";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_10.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared
            label1.Text = "The results of the file scan" + line.newline + "are the path to the file itself." + line.newline +
                "At the end of it, there is " + line.newline + "the text of your files";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_8.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared
            label1.Text = "Currently the only way to" + line.newline + "reset your details is by registering" + line.newline +
                "again and set up a new account.";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_11.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Text = ""; //The text description is initially cleared
            label1.Text = "Despite this program accessing" + line.newline + "your files, nothing bad can" + line.newline +
                "happen as it is in your control." + line.newline + "Make sure you don't share your details.";
            pictureBox1.ImageLocation = @"C:\Users\Local User\Desktop\Final Version\Screenshot_12.PNG"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Size of image stretches to match the size of the textbox                
            pictureBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Exit Button
        {
            Close();
            Application.Exit(); //Exits the program. Stops everything relating to the program from running
        }

        private void button2_Click(object sender, EventArgs e) //Back Button
        {
            Close();
            Form2 VILAS = new Form2();
            VILAS.Show();
        }
    }
}
