namespace filehandlingForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 25);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "File Handling Application";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(268, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter your directory path and file name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 162);
            label3.Name = "label3";
            label3.Size = new Size(159, 40);
            label3.TabIndex = 3;
            label3.Text = "Enter Your File Content\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(242, 162);
            label4.Name = "label4";
            label4.Size = new Size(206, 40);
            label4.TabIndex = 4;
            label4.Text = "Read the existing File Content\r\n\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(520, 162);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 5;
            label5.Text = "Find the words in the File\r\n";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(42, 205);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(159, 96);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Location = new Point(275, 205);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(159, 96);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.BorderStyle = BorderStyle.FixedSingle;
            richTextBox3.Location = new Point(535, 205);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(159, 96);
            richTextBox3.TabIndex = 8;
            richTextBox3.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(73, 352);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 9;
            button1.Text = "Write";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(316, 352);
            button2.Name = "button2";
            button2.Size = new Size(89, 29);
            button2.TabIndex = 10;
            button2.Text = "Read";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(583, 352);
            button3.Name = "button3";
            button3.Size = new Size(89, 29);
            button3.TabIndex = 11;
            button3.Text = "Find";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}