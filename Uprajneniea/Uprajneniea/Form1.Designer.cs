namespace Uprajneniea
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
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            входToolStripMenuItem = new ToolStripMenuItem();
            галерияToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            control11 = new Control1();
            menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            menuStrip3.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, входToolStripMenuItem, галерияToolStripMenuItem });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(800, 24);
            menuStrip3.TabIndex = 2;
            menuStrip3.Text = "menuStrip3";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(61, 20);
            aToolStripMenuItem.Text = "Начало";
            aToolStripMenuItem.Click += aToolStripMenuItem_Click;
            // 
            // входToolStripMenuItem
            // 
            входToolStripMenuItem.Name = "входToolStripMenuItem";
            входToolStripMenuItem.Size = new Size(45, 20);
            входToolStripMenuItem.Text = "Вход";
            входToolStripMenuItem.Click += входToolStripMenuItem_Click;
            // 
            // галерияToolStripMenuItem
            // 
            галерияToolStripMenuItem.Name = "галерияToolStripMenuItem";
            галерияToolStripMenuItem.Size = new Size(64, 20);
            галерияToolStripMenuItem.Text = "Галерия";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.изтеглен_файл;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 48);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // control11
            // 
            control11.BackColor = Color.Transparent;
            control11.Location = new Point(0, 24);
            control11.Name = "control11";
            control11.Size = new Size(800, 470);
            control11.TabIndex = 4;
            control11.Load += control11_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            Controls.Add(control11);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem входToolStripMenuItem;
        private ToolStripMenuItem галерияToolStripMenuItem;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private Control1 control11;
    }
}
