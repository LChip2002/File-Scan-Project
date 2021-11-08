
using System;
using System.ComponentModel;

namespace File_Scan_Project_Proper
{
    partial class FileScanMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileScanMenu));
            this.AutoScbtn = new System.Windows.Forms.Button();
            this.ManScbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoScbtn
            // 
            this.AutoScbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.AutoScbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoScbtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScbtn.ForeColor = System.Drawing.Color.Aqua;
            this.AutoScbtn.Image = ((System.Drawing.Image)(resources.GetObject("AutoScbtn.Image")));
            this.AutoScbtn.Location = new System.Drawing.Point(96, 170);
            this.AutoScbtn.Name = "AutoScbtn";
            this.AutoScbtn.Size = new System.Drawing.Size(160, 132);
            this.AutoScbtn.TabIndex = 1;
            this.AutoScbtn.Text = "Automatic Scan";
            this.AutoScbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AutoScbtn.UseVisualStyleBackColor = false;
            this.AutoScbtn.Click += new System.EventHandler(this.AutoScbtn_Click);
            // 
            // ManScbtn
            // 
            this.ManScbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ManScbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManScbtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManScbtn.ForeColor = System.Drawing.Color.Aqua;
            this.ManScbtn.Image = ((System.Drawing.Image)(resources.GetObject("ManScbtn.Image")));
            this.ManScbtn.Location = new System.Drawing.Point(378, 170);
            this.ManScbtn.Name = "ManScbtn";
            this.ManScbtn.Size = new System.Drawing.Size(160, 132);
            this.ManScbtn.TabIndex = 2;
            this.ManScbtn.Text = "Manual Scan";
            this.ManScbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ManScbtn.UseVisualStyleBackColor = false;
            this.ManScbtn.Click += new System.EventHandler(this.ManScbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 100);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(599, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 43);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label1.Font = new System.Drawing.Font("Nachlieli CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(252, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Scan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(93, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 95);
            this.label2.TabIndex = 4;
            this.label2.Text = "Certain folders commonly \r\nknown for holding files that\r\ncan impact storage, perf" +
    "ormance\r\nand security are searched \r\nautomatically.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(375, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 95);
            this.label3.TabIndex = 5;
            this.label3.Text = "You get to choose which folder \r\nyou want to be scanned and that \r\nwill be scanne" +
    "d to identify files \r\nthat can impact storage, performance \r\nand security.";
            // 
            // FileScanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(649, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManScbtn);
            this.Controls.Add(this.AutoScbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileScanMenu";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        private System.Windows.Forms.Button AutoScbtn;
        private System.Windows.Forms.Button ManScbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}