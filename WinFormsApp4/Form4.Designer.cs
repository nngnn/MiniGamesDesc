namespace WinFormsApp4
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            gamePanel = new Panel();
            statusLabel = new Label();
            ballsLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            wrongTimer = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            SuspendLayout();
            // 
            // gamePanel
            // 
            gamePanel.Location = new Point(0, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(527, 453);
            gamePanel.TabIndex = 0;
            gamePanel.Paint += gamePanel_Paint;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(740, 21);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(50, 20);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "label1";
            // 
            // ballsLabel
            // 
            ballsLabel.AutoSize = true;
            ballsLabel.Location = new Point(621, 60);
            ballsLabel.Name = "ballsLabel";
            ballsLabel.Size = new Size(50, 20);
            ballsLabel.TabIndex = 1;
            ballsLabel.Text = "label1";
            ballsLabel.Visible = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // wrongTimer
            // 
            wrongTimer.Interval = 750;
            wrongTimer.Tick += wrongTimer_Tick_1;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(621, 107);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(50, 20);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "label1";
            timeLabel.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 635);
            Controls.Add(timeLabel);
            Controls.Add(ballsLabel);
            Controls.Add(statusLabel);
            Controls.Add(gamePanel);
            Name = "Form4";
            Text = "Form4";
            FormClosing += Form4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel gamePanel;
        private Label statusLabel;
        private Label ballsLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer wrongTimer;
        private Label timeLabel;
    }
}