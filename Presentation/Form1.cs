using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //button
            this.button1.BringToFront();
            //this.button4.BringToFront();
            //this.button3.BringToFront();
            //this.button4.BringToFront();
            this.button3.BackColor = Color.FromArgb(5, 5, 100, 25);
            //this.BackColor = Color.FromArgb(30, 75, 30, 100);
            //this.Shown += InitializeCustomButton;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CustomClick(object sender, EventArgs e)
        {

        }

        private int getGod = 4;
        
        public void TestWrite()
        {
            Debug.WriteLine(this.fortnite.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
