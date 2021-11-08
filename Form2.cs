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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }       

        private void btn2_Click(object sender, EventArgs e)
        {
            FileScanMenu VILAS = new FileScanMenu();
            VILAS.Show(); //The button will send the user to File Scan Menu             
            
            // Hides the main menu
            this.Hide();            
        }

        private void Feedbtn_Click(object sender, EventArgs e)
        {
            Feedback VILAS = new Feedback();
            VILAS.Show();
            VILAS.Questions();
            this.Hide();
        }
        
        private void tutbtn_Click(object sender, EventArgs e)
        {
            Tutorial VILAS = new Tutorial();
            VILAS.Show();
            VILAS.tutstart();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Exit Button
        {
            Close();
            Application.Exit(); //Exits the program. Stops everything relating to the program from running
        }
    }
}
