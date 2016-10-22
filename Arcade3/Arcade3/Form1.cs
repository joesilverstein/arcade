/****************************************
 * Form1.cs
 * Arcade suite.
 * Joe Silverstein, Katherine Bunson, Brian Belleville, 5/23/11
 * *************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BouncingRectangle;
using WindowsFormsApplication1;
using FaerieBubbles;

namespace Arcade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form myForm = new invadersForm();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new snakegame();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form myForm = new FaerieBubbles.FaerieBubbles();
            myForm.Show();
        }
    }
}