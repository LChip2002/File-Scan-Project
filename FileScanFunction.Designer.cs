
using System;

namespace File_Scan_Project_Proper
{
    partial class FileScanFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileScanFunction));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.finbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.redobtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.listBox2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(12, 71);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(642, 326);
            this.listBox2.TabIndex = 0;
            // 
            // finbutton
            // 
            this.finbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.finbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finbutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finbutton.ForeColor = System.Drawing.Color.Aqua;
            this.finbutton.Image = ((System.Drawing.Image)(resources.GetObject("finbutton.Image")));
            this.finbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finbutton.Location = new System.Drawing.Point(490, 426);
            this.finbutton.Name = "finbutton";
            this.finbutton.Size = new System.Drawing.Size(144, 83);
            this.finbutton.TabIndex = 1;
            this.finbutton.Text = "Finish";
            this.finbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.finbutton.UseVisualStyleBackColor = false;
            this.finbutton.Click += new System.EventHandler(this.finbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.delbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbutton.ForeColor = System.Drawing.Color.Aqua;
            this.delbutton.Image = ((System.Drawing.Image)(resources.GetObject("delbutton.Image")));
            this.delbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delbutton.Location = new System.Drawing.Point(263, 426);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(144, 83);
            this.delbutton.TabIndex = 2;
            this.delbutton.Text = "Delete";
            this.delbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delbutton.UseVisualStyleBackColor = false;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // redobtn
            // 
            this.redobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.redobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redobtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redobtn.ForeColor = System.Drawing.Color.Aqua;
            this.redobtn.Image = ((System.Drawing.Image)(resources.GetObject("redobtn.Image")));
            this.redobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redobtn.Location = new System.Drawing.Point(33, 426);
            this.redobtn.Name = "redobtn";
            this.redobtn.Size = new System.Drawing.Size(144, 83);
            this.redobtn.TabIndex = 3;
            this.redobtn.Text = "Redo";
            this.redobtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redobtn.UseVisualStyleBackColor = false;
            this.redobtn.Click += new System.EventHandler(this.redobtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.Location = new System.Drawing.Point(610, 12);
            this.exitbtn.MinimumSize = new System.Drawing.Size(43, 43);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(46, 43);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // FileScanFunction
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(667, 521);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.redobtn);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.finbutton);
            this.Controls.Add(this.listBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileScanFunction";
            this.Load += new System.EventHandler(this.FileScanFunction_Load_1);
            this.ResumeLayout(false);

        }

        private void FileScanFunction_Load_1(object sender, EventArgs e)
        {
            return;
        }

        #endregion
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button finbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button redobtn;
    }
}