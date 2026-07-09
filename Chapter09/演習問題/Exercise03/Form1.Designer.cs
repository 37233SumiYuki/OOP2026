namespace Exercise03 {
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
            components = new System.ComponentModel.Container();
            btStart = new Button();
            btStop = new Button();
            lbTimeDisp = new Label();
            btReset = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.Location = new Point(37, 84);
            btStart.Name = "btStart";
            btStart.Size = new Size(163, 50);
            btStart.TabIndex = 0;
            btStart.Text = "スタート";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(217, 84);
            btStop.Name = "btStop";
            btStop.Size = new Size(163, 50);
            btStop.TabIndex = 0;
            btStop.Text = "ストップ";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // lbTimeDisp
            // 
            lbTimeDisp.BackColor = Color.FromArgb(192, 255, 192);
            lbTimeDisp.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTimeDisp.Location = new Point(37, 22);
            lbTimeDisp.Name = "lbTimeDisp";
            lbTimeDisp.Size = new Size(343, 40);
            lbTimeDisp.TabIndex = 1;
            // 
            // btReset
            // 
            btReset.Location = new Point(37, 169);
            btReset.Name = "btReset";
            btReset.Size = new Size(163, 52);
            btReset.TabIndex = 2;
            btReset.Text = "リセット";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // button3
            // 
            button3.Location = new Point(217, 169);
            button3.Name = "button3";
            button3.Size = new Size(163, 52);
            button3.TabIndex = 5;
            button3.Text = "ラップタイム";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(418, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 199);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(673, 233);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(btReset);
            Controls.Add(lbTimeDisp);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btStart;
        private Button btStop;
        private Label lbTimeDisp;
        private Button btReset;
        private Button button3;
        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
