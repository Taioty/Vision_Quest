namespace hub
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
            this.myBar = new System.Windows.Forms.ProgressBar();
            this.enemyBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myBar
            // 
            this.myBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.myBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.myBar.Location = new System.Drawing.Point(56, 120);
            this.myBar.Margin = new System.Windows.Forms.Padding(4);
            this.myBar.Name = "myBar";
            this.myBar.Size = new System.Drawing.Size(176, 32);
            this.myBar.Step = 1;
            this.myBar.TabIndex = 0;
            this.myBar.Value = 100;
            // 
            // enemyBar
            // 
            this.enemyBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemyBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enemyBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.enemyBar.Location = new System.Drawing.Point(385, 120);
            this.enemyBar.Margin = new System.Windows.Forms.Padding(4);
            this.enemyBar.Name = "enemyBar";
            this.enemyBar.Size = new System.Drawing.Size(176, 32);
            this.enemyBar.Step = 1;
            this.enemyBar.TabIndex = 1;
            this.enemyBar.Value = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Engage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(629, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enemyBar);
            this.Controls.Add(this.myBar);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "First Fight";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar myBar;
        private System.Windows.Forms.ProgressBar enemyBar;
        private System.Windows.Forms.Button button1;
    }
}

