namespace lab_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAllToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pastToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            deletToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            backColorToolStripMenuItem = new ToolStripMenuItem();
            appToolStripMenuItem = new ToolStripMenuItem();
            exercise1ToolStripMenuItem = new ToolStripMenuItem();
            exercise2ToolStripMenuItem = new ToolStripMenuItem();
            exercise3ToolStripMenuItem = new ToolStripMenuItem();
            exercise4ToolStripMenuItem = new ToolStripMenuItem();
            exercise5ToolStripMenuItem = new ToolStripMenuItem();
            exercise6ToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, formatToolStripMenuItem, appToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAllToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = Properties.Resources._new;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New         Ctrl+N";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = Properties.Resources.open;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open        Ctrl+O";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.save_file;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save          Ctrl +S";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAllToolStripMenuItem
            // 
            saveAllToolStripMenuItem.Image = Properties.Resources.saveAll;
            saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            saveAllToolStripMenuItem.Size = new Size(180, 22);
            saveAllToolStripMenuItem.Text = "Save all";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.close;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, copyToolStripMenuItem, pastToolStripMenuItem, cutToolStripMenuItem, deletToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pastToolStripMenuItem
            // 
            pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            pastToolStripMenuItem.Size = new Size(180, 22);
            pastToolStripMenuItem.Text = "Past";
            pastToolStripMenuItem.Click += pastToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // deletToolStripMenuItem
            // 
            deletToolStripMenuItem.Name = "deletToolStripMenuItem";
            deletToolStripMenuItem.Size = new Size(180, 22);
            deletToolStripMenuItem.Text = "Delet";
            deletToolStripMenuItem.Click += deletToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(180, 22);
            selectAllToolStripMenuItem.Text = "selectAll";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, backColorToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // backColorToolStripMenuItem
            // 
            backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            backColorToolStripMenuItem.Size = new Size(180, 22);
            backColorToolStripMenuItem.Text = "backColor";
            backColorToolStripMenuItem.Click += backColorToolStripMenuItem_Click;
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exercise1ToolStripMenuItem, exercise2ToolStripMenuItem, exercise3ToolStripMenuItem, exercise4ToolStripMenuItem, exercise5ToolStripMenuItem, exercise6ToolStripMenuItem });
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(41, 20);
            appToolStripMenuItem.Text = "App";
            // 
            // exercise1ToolStripMenuItem
            // 
            exercise1ToolStripMenuItem.Image = Properties.Resources.app;
            exercise1ToolStripMenuItem.Name = "exercise1ToolStripMenuItem";
            exercise1ToolStripMenuItem.Size = new Size(180, 22);
            exercise1ToolStripMenuItem.Text = "Exercise 4";
            exercise1ToolStripMenuItem.Click += exercise1ToolStripMenuItem_Click;
            // 
            // exercise2ToolStripMenuItem
            // 
            exercise2ToolStripMenuItem.Image = Properties.Resources.app;
            exercise2ToolStripMenuItem.Name = "exercise2ToolStripMenuItem";
            exercise2ToolStripMenuItem.Size = new Size(180, 22);
            exercise2ToolStripMenuItem.Text = "Exercise 2";
            exercise2ToolStripMenuItem.Click += exercise2ToolStripMenuItem_Click;
            // 
            // exercise3ToolStripMenuItem
            // 
            exercise3ToolStripMenuItem.Image = Properties.Resources.app;
            exercise3ToolStripMenuItem.Name = "exercise3ToolStripMenuItem";
            exercise3ToolStripMenuItem.Size = new Size(180, 22);
            exercise3ToolStripMenuItem.Text = "Exercise 3";
            exercise3ToolStripMenuItem.Click += exercise3ToolStripMenuItem_Click;
            // 
            // exercise4ToolStripMenuItem
            // 
            exercise4ToolStripMenuItem.Image = Properties.Resources.app;
            exercise4ToolStripMenuItem.Name = "exercise4ToolStripMenuItem";
            exercise4ToolStripMenuItem.Size = new Size(180, 22);
            exercise4ToolStripMenuItem.Text = "Exercise 4";
            exercise4ToolStripMenuItem.Click += exercise4ToolStripMenuItem_Click;
            // 
            // exercise5ToolStripMenuItem
            // 
            exercise5ToolStripMenuItem.Image = Properties.Resources.app;
            exercise5ToolStripMenuItem.Name = "exercise5ToolStripMenuItem";
            exercise5ToolStripMenuItem.Size = new Size(180, 22);
            exercise5ToolStripMenuItem.Text = "Exercise 5";
            exercise5ToolStripMenuItem.Click += exercise5ToolStripMenuItem_Click;
            // 
            // exercise6ToolStripMenuItem
            // 
            exercise6ToolStripMenuItem.Image = Properties.Resources.app;
            exercise6ToolStripMenuItem.Name = "exercise6ToolStripMenuItem";
            exercise6ToolStripMenuItem.Size = new Size(180, 22);
            exercise6ToolStripMenuItem.Text = "Exercise 6";
            exercise6ToolStripMenuItem.Click += exercise6ToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(755, 362);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem exercise1ToolStripMenuItem;
        private ToolStripMenuItem exercise2ToolStripMenuItem;
        private ToolStripMenuItem exercise3ToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAllToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem deletToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem backColorToolStripMenuItem;
        private ToolStripMenuItem exercise4ToolStripMenuItem;
        private ToolStripMenuItem exercise5ToolStripMenuItem;
        private ToolStripMenuItem exercise6ToolStripMenuItem;
    }
}