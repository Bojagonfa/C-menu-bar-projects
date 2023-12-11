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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }



        private void checkedListBox1_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            {
                string item = checkedListBox1.Items[e.Index].ToString();


                if (e.NewValue == CheckState.Checked)
                {

                    if (!listBox1.Items.Contains(item))
                    {
                        listBox1.Items.Add(item);
                    }
                }
                else
                {

                    listBox1.Items.Remove(item);
                }
            }
        }
    }
}

