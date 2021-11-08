using System;
using System.Windows.Forms;
using System.IO; //Allows for File Directories to be reached
using System.Text.RegularExpressions; //Regex Class allowing me to check if the file directory matches the specified filetypes.


namespace File_Scan_Project_Proper
{
    public partial class FileScanFunction : Form
    {
        public FileScanFunction()
        {
            InitializeComponent();
        }        

        private void FileScanFunction_Load(object sender, EventArgs e)
        {

        }

        public void AutoScan()
        {
            listBox2.HorizontalScrollbar = true; //Shows a horizontal bar for the user to be able to scroll and see the full directory
            Filestuff.AutScTot += 1;
            listBox2.Items.Clear(); //Clears the listbox
                       
            foreach (var file in Filestuff.files)
            {
                for (int i = 0; i < Filestuff.filetypes.Length; i++)
                {
                    bool isFile = Regex.IsMatch(file, Filestuff.filetypes[i]); //Does the file directory match the file types in variable filetypes
                    if (isFile)
                    {
                        listBox2.Items.Add(file); //Every file that matches the file types is added to the listbox shown to the user                       
                    }
                }
            }
            foreach (var file2 in Filestuff.files2)
            {
                for (int i = 0; i < Filestuff.filetypes.Length; i++)
                {
                    bool isFile = Regex.IsMatch(file2, Filestuff.filetypes[i]); //Does the file directory match the file types in variable filetypes
                    if (isFile)
                    {
                        listBox2.Items.Add(file2); //Every file that matches the file types is added to the listbox shown to the user                       
                    }
                }
            }
            foreach (var file3 in Filestuff.files3)
            {
                listBox2.Items.Add(file3); //Adds everything from the temp directory                
            }
        }
        
        public void ManualScan()
        {
            listBox2.HorizontalScrollbar = true; //Shows a horizontal bar for the user to be able to scroll and see the full directory
            Filestuff.ManScTot += 1;
            listBox2.Items.Clear();
            
            //Checks if folder diologue is correct
            if (Filestuff.FDB.ShowDialog() == DialogResult.OK)
            {
                listBox2.Items.Clear(); //Clears ListBox                
                //Manual File Directory
                string[] filemans = Directory.GetFiles(Filestuff.FDB.SelectedPath);// Array contains all the files that are inside the selected directory
                foreach (var fileman in filemans)
                {
                    for (int i = 0; i < Filestuff.filetypes.Length; i++)
                    {
                        bool isFile = Regex.IsMatch(fileman, Filestuff.filetypes[i]); //Does the file directory match the file types in variable filetypes
                        if (isFile)
                        {
                            listBox2.Items.Add(fileman); //Every file that matches the file types is added to the listbox shown to the user
                        }
                    }
                }
            }
        }
        
        private void finbutton_Click(object sender, EventArgs e)
        {
            Form2 VILAS = new Form2();
            VILAS.Show();
            this.Hide();
        }

        private void delbutton_Click(object sender, EventArgs e)
        {            
            if (Filestuff.AutScTot == 1) 
            {                
                foreach (var file in Filestuff.files)
                {
                    for (int i = 0; i < Filestuff.filetypes.Length; i++)
                    {
                        bool isFile = Regex.IsMatch(file, Filestuff.filetypes[i]); //Does the file directory match the file types in variable filetypes
                        if (isFile)
                        {                            
                            File.Delete(file); //Deletes the files that have these filetypes within the Directory                            
                        }
                    }
                }
                foreach (var file2 in Filestuff.files2)
                {
                    for (int i = 0; i < Filestuff.filetypes.Length; i++)
                    {
                        bool isFile = Regex.IsMatch(file2, Filestuff.filetypes[i]); //Does the file directory match the file types in variable filetypes
                        if (isFile)
                        {
                            File.Delete(file2); //Deletes the files that have these filetypes within the Directory
                        }
                    }
                }
                foreach (var file3 in Filestuff.files3)
                {
                    File.Delete(file3); //Deletes every file in the temp directory and clears the folders inside the directory.
                }
                listBox2.Items.Clear();
                listBox2.Items.Add("The files have been deleted");
            }
            if (Filestuff.ManScTot == 1) 
            {
                string[] filemans = Directory.GetFiles(Filestuff.FDB.SelectedPath);// Array contains all the files that are inside the selected directory
                foreach (var fileman in filemans)
                {
                    for (int i = 0; i < Filestuff.filetypes.Length; i++)
                    {
                        bool isFile = Regex.IsMatch(fileman, Filestuff.filetypes[i]); //Does the file directory match the file types in variable filetypes
                        if (isFile)
                        {
                            File.Delete(fileman); //Deletes the files that have these filetypes within the Directory
                        }
                    }
                }
                listBox2.Items.Clear();
                listBox2.Items.Add("The files have been deleted");
            }
            
        }

        private void redobtn_Click(object sender, EventArgs e)
        {
            //After one of the scans has already been runned it, ScTot should equal 1. This will allow the scan to be repeated
            if (Filestuff.AutScTot == 1) 
            {
                Filestuff.AutScTot = Filestuff.AutScTot - 1; //Sets value back to 0
                listBox2.Refresh();
                AutoScan(); //Called to run again
            }

            if(Filestuff.ManScTot == 1) 
            {
                Filestuff.ManScTot = Filestuff.ManScTot - 1; //Sets value back to 0
                ManualScan();//Called to run again
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit(); //Exits the program. Stops everything relating to the program from running
        }
    }
}
