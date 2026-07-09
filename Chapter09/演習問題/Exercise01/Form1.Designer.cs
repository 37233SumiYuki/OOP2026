namespace Exercise01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("MS UI Gothic", 26.25F);
            button1.Location = new Point(57, 42);
            button1.Name = "button1";
            button1.Size = new Size(173, 55);
            button1.TabIndex = 0;
            button1.Text = "①";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox1.Location = new Point(236, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(517, 44);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox2.Location = new Point(236, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(517, 44);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox3.Location = new Point(236, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(517, 44);
            textBox3.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button2.Location = new Point(57, 138);
            button2.Name = "button2";
            button2.Size = new Size(173, 54);
            button2.TabIndex = 2;
            button2.Text = "②";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button3.Location = new Point(57, 245);
            button3.Name = "button3";
            button3.Size = new Size(165, 57);
            button3.TabIndex = 3;
            button3.Text = "③";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 372);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}
