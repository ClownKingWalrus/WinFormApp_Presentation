using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    partial class Form1
    {
        public int fortnite = 5;

        public void TestWriteAgain()
        {
            Debug.WriteLine(this.getGod.ToString());
        }

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new Presentation.TransparentButton();
            this.button4 = new Presentation.TransparentButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 364);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CustomClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(440, 364);
            this.button2.TabIndex = 1;
            this.button2.Text = "BUTTON CUSTOM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(36, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(500, 400);
            this.button3.TabIndex = 2;
            this.button3.Text = "TransparentCustomClassButton";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(593, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(500, 400);
            this.button4.TabIndex = 2;
            this.button4.Text = "AAAAAAAAAAAAAAAAAAAAA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1349, 986);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Good_Job_if_you_Got_Here";
            this.ResumeLayout(false);

        }

        #endregion
        //private void InitializeCustomButton(object sender, EventArgs e)
        //{
        //    this.button2 = new System.Windows.Forms.Button();
        //    //CUSTOM BUTTON
        //    this.button2.Location = new System.Drawing.Point(465, 270);
        //    this.button2.Name = "button2";
        //    this.button2.Size = new System.Drawing.Size(440, 364);
        //    this.button2.TabIndex = 0;
        //    this.button2.Text = "BUTTON CUSTOM";
        //    this.button2.UseVisualStyleBackColor = true;
        //    this.button1.Click += new System.EventHandler(this.CustomClick);
        //    this.Controls.Add(button2);
        //}

        //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        private System.Windows.Forms.Button button1;

        //my custom made button
        private System.Windows.Forms.Button button2;
        private TransparentButton button3;
        private TransparentButton button4;
    }
}

