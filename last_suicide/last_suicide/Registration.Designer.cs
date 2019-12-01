namespace last_suicide
{
    partial class Registration
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
            this.buttOK = new System.Windows.Forms.Button();
            this.textB1 = new System.Windows.Forms.TextBox();
            this.textB2 = new System.Windows.Forms.TextBox();
            this.textB3 = new System.Windows.Forms.TextBox();
            this.textB4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPassWarn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttOK
            // 
            this.buttOK.Location = new System.Drawing.Point(219, 307);
            this.buttOK.Name = "buttOK";
            this.buttOK.Size = new System.Drawing.Size(112, 41);
            this.buttOK.TabIndex = 0;
            this.buttOK.Text = "OK";
            this.buttOK.UseVisualStyleBackColor = true;
            this.buttOK.Click += new System.EventHandler(this.buttOK_Click);
            // 
            // textB1
            // 
            this.textB1.Location = new System.Drawing.Point(50, 58);
            this.textB1.Name = "textB1";
            this.textB1.Size = new System.Drawing.Size(100, 20);
            this.textB1.TabIndex = 1;
            // 
            // textB2
            // 
            this.textB2.Location = new System.Drawing.Point(50, 113);
            this.textB2.Name = "textB2";
            this.textB2.Size = new System.Drawing.Size(100, 20);
            this.textB2.TabIndex = 2;
            // 
            // textB3
            // 
            this.textB3.Location = new System.Drawing.Point(50, 170);
            this.textB3.Name = "textB3";
            this.textB3.Size = new System.Drawing.Size(100, 20);
            this.textB3.TabIndex = 3;
            // 
            // textB4
            // 
            this.textB4.Location = new System.Drawing.Point(50, 231);
            this.textB4.Name = "textB4";
            this.textB4.Size = new System.Drawing.Size(100, 20);
            this.textB4.TabIndex = 4;
            this.textB4.TextChanged += new System.EventHandler(this.textB4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // lblPassWarn
            // 
            this.lblPassWarn.AutoSize = true;
            this.lblPassWarn.ForeColor = System.Drawing.Color.Red;
            this.lblPassWarn.Location = new System.Drawing.Point(47, 254);
            this.lblPassWarn.Name = "lblPassWarn";
            this.lblPassWarn.Size = new System.Drawing.Size(132, 13);
            this.lblPassWarn.TabIndex = 9;
            this.lblPassWarn.Text = "Введите до 15 символов";
            this.lblPassWarn.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 30);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Registration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPassWarn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB4);
            this.Controls.Add(this.textB3);
            this.Controls.Add(this.textB2);
            this.Controls.Add(this.textB1);
            this.Controls.Add(this.buttOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttOK;
        private System.Windows.Forms.TextBox textB1;
        private System.Windows.Forms.TextBox textB2;
        private System.Windows.Forms.TextBox textB3;
        private System.Windows.Forms.TextBox textB4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPassWarn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}