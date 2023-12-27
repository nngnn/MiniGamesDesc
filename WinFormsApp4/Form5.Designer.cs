namespace WinFormsApp4
{
    partial class Cup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cup1 = new PictureBox();
            cup2 = new PictureBox();
            cup3 = new PictureBox();
            startButton = new Button();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)cup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cup3).BeginInit();
            SuspendLayout();
            // 
            // cup1
            // 
            cup1.Location = new Point(537, 73);
            cup1.Name = "cup1";
            cup1.Size = new Size(191, 192);
            cup1.SizeMode = PictureBoxSizeMode.StretchImage;
            cup1.TabIndex = 0;
            cup1.TabStop = false;
            cup1.Click += cup1_Click;
            // 
            // cup2
            // 
            cup2.Location = new Point(312, 73);
            cup2.Name = "cup2";
            cup2.Size = new Size(172, 192);
            cup2.SizeMode = PictureBoxSizeMode.StretchImage;
            cup2.TabIndex = 1;
            cup2.TabStop = false;
            cup2.Click += cup2_Click;
            // 
            // cup3
            // 
            cup3.Location = new Point(74, 73);
            cup3.Name = "cup3";
            cup3.Size = new Size(189, 192);
            cup3.SizeMode = PictureBoxSizeMode.StretchImage;
            cup3.TabIndex = 2;
            cup3.TabStop = false;
            cup3.Click += cup3_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(278, 326);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 3;
            startButton.Text = "button1";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(299, 387);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "label1";
            // 
            // Cup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelStatus);
            Controls.Add(startButton);
            Controls.Add(cup3);
            Controls.Add(cup2);
            Controls.Add(cup1);
            Name = "Cup";
            Text = "Form5";
            FormClosing += Form5_FormClosing;
            ((System.ComponentModel.ISupportInitialize)cup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cup3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cup1;
        private PictureBox cup2;
        private PictureBox cup3;
        private Button startButton;
        private Label labelStatus;
    }
}