namespace Arrays
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
            problem1Btn = new Button();
            problem2Btn = new Button();
            problem3Btn = new Button();
            SuspendLayout();
            // 
            // problem1Btn
            // 
            problem1Btn.Location = new Point(161, 40);
            problem1Btn.Name = "problem1Btn";
            problem1Btn.Size = new Size(94, 29);
            problem1Btn.TabIndex = 0;
            problem1Btn.Text = "Problem #1";
            problem1Btn.UseVisualStyleBackColor = true;
            problem1Btn.Click += problem1Btn_Click;
            // 
            // problem2Btn
            // 
            problem2Btn.Location = new Point(335, 40);
            problem2Btn.Name = "problem2Btn";
            problem2Btn.Size = new Size(94, 29);
            problem2Btn.TabIndex = 1;
            problem2Btn.Text = "Problem #2";
            problem2Btn.UseVisualStyleBackColor = true;
            problem2Btn.Click += problem2Btn_Click;
            // 
            // problem3Btn
            // 
            problem3Btn.Location = new Point(517, 40);
            problem3Btn.Name = "problem3Btn";
            problem3Btn.Size = new Size(94, 29);
            problem3Btn.TabIndex = 2;
            problem3Btn.Text = "Problem #3";
            problem3Btn.UseVisualStyleBackColor = true;
            problem3Btn.Click += problem3Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(problem3Btn);
            Controls.Add(problem2Btn);
            Controls.Add(problem1Btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button problem1Btn;
        private Button problem2Btn;
        private Button problem3Btn;
    }
}
