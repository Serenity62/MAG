namespace MAG
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.loadThemeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(9, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 205);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Location = new System.Drawing.Point(145, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 98);
            this.panel5.TabIndex = 1;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(3, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 98);
            this.panel4.TabIndex = 1;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(9, 8);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(50, 28);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(63, 8);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(50, 28);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(118, 8);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(50, 28);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(173, 8);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(50, 28);
            this.copyBtn.TabIndex = 4;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(9, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 98);
            this.panel2.TabIndex = 0;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(154, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 98);
            this.panel3.TabIndex = 1;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // themeTextBox
            // 
            this.themeTextBox.Location = new System.Drawing.Point(228, 12);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(100, 20);
            this.themeTextBox.TabIndex = 5;
            // 
            // loadThemeButton
            // 
            this.loadThemeButton.Location = new System.Drawing.Point(334, 10);
            this.loadThemeButton.Name = "loadThemeButton";
            this.loadThemeButton.Size = new System.Drawing.Size(75, 23);
            this.loadThemeButton.TabIndex = 6;
            this.loadThemeButton.Text = "Load";
            this.loadThemeButton.UseVisualStyleBackColor = true;
            this.loadThemeButton.Click += new System.EventHandler(this.loadThemeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.loadThemeButton);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.Button loadThemeButton;
    }
}

