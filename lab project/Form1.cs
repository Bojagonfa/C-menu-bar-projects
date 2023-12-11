namespace lab_project
{
    public partial class Form1 : Form
    {
        public static Form1 instance;


        public Form1()
        {
            InitializeComponent();
            instance = this;
        }



        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exercise3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 demo3 = new Form3();
            demo3.Show();
        }

        private void exercise2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 demo = new Form2();
            demo.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files|*.txt;*.doc;*.docx";
            file.ShowDialog();
            richTextBox1.Text = File.ReadAllText(file.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.InitialDirectory = @"C:\";
            fsave.Title = "Save text Files";
            fsave.CheckFileExists = true;
            fsave.CheckPathExists = true;
            fsave.DefaultExt = "txt";
            fsave.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fsave.FilterIndex = 2;
            fsave.RestoreDirectory = true;
            if (fsave.ShowDialog() == DialogResult.OK)
            {
                this.Text = fsave.FileName;
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void deletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            richTextBox1.SelectionFont = font.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            richTextBox1.SelectionColor = col.Color;
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            richTextBox1.BackColor = col.Color;
        }

        private void exercise1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 demo4 = new Form4();
            demo4.Show();
        }

        private void exercise4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 demo5 = new Form5();
            demo5.Show();
        }

        private void exercise5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 demo6 = new Form6();
            demo6.Show();
        }

        private void exercise6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 demo7 = new Form7();
            demo7.Show();
        }
    }
}
