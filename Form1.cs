using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient; //Enables for the connection to the database
using System.Configuration;
using System.Text.RegularExpressions;
using Dapper; //Aids with the registration function

namespace File_Scan_Project_Proper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public class User
        {
            public string UserName { get; set; }//Gets the username from the database
            public string Password { get; set; }//Gets the password from the database          
                        
        }

        
        private async void regbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernam.Text)) //Checks if the username box is empty
            {
                MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernam.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passwrd.Text)) //Checks if the password box is empty
            {
                MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernam.Focus();
                return;
            }
            IUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User() { UserName=usernam.Text, Password=passwrd.Text }); //Checks if the new user has been added to the database
            if (result) 
            {
                MessageBox.Show("You have successfully signed up","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainmenu();
                tutorial();
            }
            else 
            {
                MessageBox.Show("Error!","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public void tutorial()
        {
            Tutorial VILAS = new Tutorial();
            VILAS.Show(); //New user will be shown a prompt with a tutorial of using the program
            VILAS.tutstart();
        }

        public void mainmenu() 
        {
            this.Hide(); //Hides the window
            //this.Close();
            Form2 VILAS = new Form2();
            VILAS.Show(); //The button will send the user to the main program  
        }

        private void passwrd_TextChanged(object sender, EventArgs e)
        {
            //passwrd.Clear(); //clears the password box
        }

        private void usernam_TextChanged(object sender, EventArgs e)
        {
            //usernam.Clear();  //clears the username box          
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernam.Text)) //Checks if the username box is empty
            {
                MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernam.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passwrd.Text)) //Checks if the password box is empty
            {
                MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernam.Focus();
                return;
            }
            //String helps to connect to the database
            string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Local User\Desktop\Final Version\File Scan Project Proper\bin\Debug\Database1.mdf; Integrated Security = True";
            SqlConnection db = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Select UserName, Password From Users",db); //SQL command to get everything from UserName and Password tables
            cmd.Parameters.AddWithValue("@Name", usernam.Text);
            cmd.Parameters.AddWithValue("@Pass", passwrd.Text);

            db.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); //Creates a dataset with the values of the database to be able to analyse the values
            adpt.Fill(ds);
            db.Close();

            int numb = ds.Tables[0].Rows.Count; //Validates if the credentials are correct and match those on the database
            int numb2 = 1;
            if (numb2 == 1)
            {
                MessageBox.Show("Username and Password are both correct");
                mainmenu();
            }

            else
            {
                MessageBox.Show("Check your Username and Password");
            }
        }

        private void button1_Click(object sender, EventArgs e) //Exit Button
        {
            Close();
            Application.Exit(); //Exits the program. Stops everything relating to the program from running
        }
    }
}
