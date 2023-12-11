using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_project
{


    public partial class Form3 : Form
    {
        public MessageBoxButtons butType;
        public MessageBoxIcon icon;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this exersise result", "exersice", butType,icon);


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            butType = MessageBoxButtons.OK;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            butType = MessageBoxButtons.OKCancel;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            butType = MessageBoxButtons.AbortRetryIgnore;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            butType = MessageBoxButtons.YesNoCancel;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            butType = MessageBoxButtons.YesNo;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            butType = MessageBoxButtons.RetryCancel;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Error;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Exclamation;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Information;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Question;
        }
    }
}
