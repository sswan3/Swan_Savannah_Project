namespace Swan_Project
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            add = new Button();
            subtract = new Button();
            divide = new Button();
            multiply = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // add
            // 
            add.Location = new Point(539, 89);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 2;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // subtract
            // 
            subtract.Location = new Point(549, 134);
            subtract.Name = "subtract";
            subtract.Size = new Size(94, 29);
            subtract.TabIndex = 3;
            subtract.Text = "subtract";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += subtract_Click;
            // 
            // divide
            // 
            divide.Location = new Point(559, 199);
            divide.Name = "divide";
            divide.Size = new Size(94, 29);
            divide.TabIndex = 4;
            divide.Text = "divide";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(559, 251);
            multiply.Name = "multiply";
            multiply.Size = new Size(94, 29);
            multiply.TabIndex = 5;
            multiply.Text = "multiply";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(subtract);
            Controls.Add(add);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button add;
        private Button subtract;
        private Button divide;
        private Button multiply;
    }
}
