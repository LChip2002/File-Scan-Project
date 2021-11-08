
namespace File_Scan_Project_Proper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regbtn = new System.Windows.Forms.Button();
            this.usernam = new System.Windows.Forms.TextBox();
            this.passwrd = new System.Windows.Forms.TextBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regbtn
            // 
            this.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.ForeColor = System.Drawing.Color.Aqua;
            this.regbtn.Location = new System.Drawing.Point(67, 275);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(121, 53);
            this.regbtn.TabIndex = 0;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // usernam
            // 
            this.usernam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.usernam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernam.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernam.ForeColor = System.Drawing.Color.Aqua;
            this.usernam.Location = new System.Drawing.Point(67, 116);
            this.usernam.Name = "usernam";
            this.usernam.Size = new System.Drawing.Size(237, 25);
            this.usernam.TabIndex = 1;
            this.usernam.Text = "Username";
            this.usernam.TextChanged += new System.EventHandler(this.usernam_TextChanged);
            // 
            // passwrd
            // 
            this.passwrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passwrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwrd.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrd.ForeColor = System.Drawing.Color.Aqua;
            this.passwrd.Location = new System.Drawing.Point(67, 173);
            this.passwrd.Name = "passwrd";
            this.passwrd.Size = new System.Drawing.Size(237, 25);
            this.passwrd.TabIndex = 2;
            this.passwrd.Text = "Password";
            this.passwrd.TextChanged += new System.EventHandler(this.passwrd_TextChanged);
            // 
            // logbtn
            // 
            this.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbtn.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.ForeColor = System.Drawing.Color.Aqua;
            this.logbtn.Location = new System.Drawing.Point(213, 275);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(113, 53);
            this.logbtn.TabIndex = 3;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 85);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login/Sign Up";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(328, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 43);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(386, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.passwrd);
            this.Controls.Add(this.usernam);
            this.Controls.Add(this.regbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.TextBox usernam;
        private System.Windows.Forms.TextBox passwrd;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

