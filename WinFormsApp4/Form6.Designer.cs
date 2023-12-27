namespace WinFormsApp4
{
    partial class Num
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
            Timer = new System.Windows.Forms.Timer(components);
            buttonRun = new Button();
            buttonCheck = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(301, 211);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(94, 29);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "Начать";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click_1;
            // 
            // buttonCheck
            // 
            buttonCheck.Enabled = false;
            buttonCheck.Location = new Point(301, 246);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(94, 29);
            buttonCheck.TabIndex = 1;
            buttonCheck.Text = "Проверить";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Visible = false;
            buttonCheck.Click += buttonCheck_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(461, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(461, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(161, 101);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(161, 147);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 7;
            // 
            // Num
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonCheck);
            Controls.Add(buttonRun);
            Name = "Num";
            Text = "Form6";
            FormClosing += Form6_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Button buttonRun;
        private Button buttonCheck;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}