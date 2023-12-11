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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Underline);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Italic);
        }
    }
}

