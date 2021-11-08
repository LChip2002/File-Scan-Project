using System;
using System.Windows.Forms;

namespace File_Scan_Project_Proper
{
    public partial class FileScanMenu : Form
    {
        public FileScanMenu()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }  

        private void AutoScbtn_Click(object sender, EventArgs e)
        {
            FileScanFunction VILAS = new FileScanFunction();
            VILAS.Show(); //The button will send the user to File Scan Menu
            // Hides the main menu
            this.Hide();
            VILAS.AutoScan();
        }

        private void ManScbtn_Click(object sender, EventArgs e)
        {
            FileScanFunction VILAS = new FileScanFunction();
            VILAS.Show(); //The button will send the user to File Scan Menu
            // Hides the main menu
            this.Hide();
            VILAS.ManualScan();
        }

        private void button1_Click(object sender, EventArgs e) //Exit Button
        {
            Close();
            Application.Exit(); //Exits the program. Stops everything relating to the program from running
        }
    }






}
