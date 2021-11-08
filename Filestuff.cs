using System;
using System.Windows.Forms;
using System.IO; //Allows for File Directories to be reached



namespace File_Scan_Project_Proper
{
    public partial class FileScanFunction
    {
        class Filestuff
        {
            //These Totals allows for the program to be able to determine which scan can be ran when redo is pressed.
            public static int ManScTot = 0;
            public static int AutScTot = 0;

            //Open File Browser
            public static FolderBrowserDialog FDB = new FolderBrowserDialog();
            
            //Gets file directories from folders
            public static string[] files = Directory.GetFiles($@"C:\Users\{Environment.UserName}\Desktop\Testing_FileSc", "*.*", SearchOption.AllDirectories);
            public static string[] files2 = Directory.GetFiles($@"C:\Users\{Environment.UserName}\Downloads\", "*.*", SearchOption.AllDirectories);          
            public static string[] files3 = Directory.GetFiles($@"C:\Users\{Environment.UserName}\AppData\Local\Temp\", "*.*", SearchOption.AllDirectories);

            //Finds the directories that match the file types that need to be identified
            public static string[] filetypes = { ".doc", ".exe", ".tmp", ".txt", ".html", ".py", ".js", ".jar", ".vb", ".vbs", ".sfx", ".bat", ".dll", ".log" };
            
        }
        
    }
}
