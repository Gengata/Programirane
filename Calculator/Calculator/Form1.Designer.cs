namespace Calculator
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
            txtnumber1 = new TextBox();
            txtnumber2 = new TextBox();
            lblResult = new Label();
            btnplus = new Button();
            btnminus = new Button();
            btndel = new Button();
            btnpo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtname = new TextBox();
            lblgreatings = new Label();
            btngreating = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtnumber1
            // 
            txtnumber1.Location = new Point(84, 167);
            txtnumber1.Name = "txtnumber1";
            txtnumber1.Size = new Size(116, 23);
            txtnumber1.TabIndex = 0;
            // 
            // txtnumber2
            // 
            txtnumber2.Location = new Point(268, 167);
            txtnumber2.Name = "txtnumber2";
            txtnumber2.Size = new Size(111, 23);
            txtnumber2.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(452, 169);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(87, 213);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(113, 52);
            btnplus.TabIndex = 3;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(251, 213);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(109, 48);
            btnminus.TabIndex = 4;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnminus_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(251, 297);
            btndel.Name = "btndel";
            btndel.Size = new Size(104, 53);
            btndel.TabIndex = 5;
            btndel.Text = "/";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnpo
            // 
            btnpo.Location = new Point(101, 297);
            btnpo.Name = "btnpo";
            btnpo.Size = new Size(99, 50);
            btnpo.TabIndex = 6;
            btnpo.Text = "*";
            btnpo.UseVisualStyleBackColor = true;
            btnpo.Click += btnpo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 136);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 137);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Num2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 172);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 9;
            label3.Text = "=";
            // 
            // txtname
            // 
            txtname.Location = new Point(178, 35);
            txtname.Name = "txtname";
            txtname.Size = new Size(91, 23);
            txtname.TabIndex = 10;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // lblgreatings
            // 
            lblgreatings.AutoSize = true;
            lblgreatings.Location = new Point(150, 70);
            lblgreatings.Name = "lblgreatings";
            lblgreatings.Size = new Size(0, 15);
            lblgreatings.TabIndex = 11;
            // 
            // btngreating
            // 
            btngreating.Location = new Point(178, 368);
            btngreating.Name = "btngreating";
            btngreating.Size = new Size(91, 51);
            btngreating.TabIndex = 12;
            btngreating.Text = "Greating?";
            btngreating.UseVisualStyleBackColor = true;
            btngreating.Click += btngreating_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 8);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 13;
            label4.Text = "Enter name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btngreating);
            Controls.Add(lblgreatings);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnpo);
            Controls.Add(btndel);
            Controls.Add(btnminus);
            Controls.Add(btnplus);
            Controls.Add(lblResult);
            Controls.Add(txtnumber2);
            Controls.Add(txtnumber1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnumber1;
        private TextBox txtnumber2;
        private Label lblResult;
        private Button btnplus;
        private Button btnminus;
        private Button btndel;
        private Button btnpo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtname;
        private Label lblgreatings;
        private Button btngreating;
        private Label label4;
    }
}
