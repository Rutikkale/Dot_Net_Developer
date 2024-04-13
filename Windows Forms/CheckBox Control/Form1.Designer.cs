namespace CheckBox_Control
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
            this.label1 = new System.Windows.Forms.Label();
            this.SamsungCheck = new System.Windows.Forms.CheckBox();
            this.NokiaCheck = new System.Windows.Forms.CheckBox();
            this.OnePlusCheck = new System.Windows.Forms.CheckBox();
            this.IPhoneCkeck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT YOUR MOBILE COMPANIES";
            // 
            // SamsungCheck
            // 
            this.SamsungCheck.AutoSize = true;
            this.SamsungCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamsungCheck.Location = new System.Drawing.Point(169, 121);
            this.SamsungCheck.Name = "SamsungCheck";
            this.SamsungCheck.Size = new System.Drawing.Size(143, 29);
            this.SamsungCheck.TabIndex = 1;
            this.SamsungCheck.Text = "SAMSUNG";
            this.SamsungCheck.UseVisualStyleBackColor = true;
            this.SamsungCheck.CheckedChanged += new System.EventHandler(this.SamsungCheck_CheckedChanged);
            // 
            // NokiaCheck
            // 
            this.NokiaCheck.AutoSize = true;
            this.NokiaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NokiaCheck.Location = new System.Drawing.Point(169, 156);
            this.NokiaCheck.Name = "NokiaCheck";
            this.NokiaCheck.Size = new System.Drawing.Size(89, 29);
            this.NokiaCheck.TabIndex = 1;
            this.NokiaCheck.Text = "Nokia";
            this.NokiaCheck.UseVisualStyleBackColor = true;
            this.NokiaCheck.CheckedChanged += new System.EventHandler(this.NokiaCheck_CheckedChanged);
            // 
            // OnePlusCheck
            // 
            this.OnePlusCheck.AutoSize = true;
            this.OnePlusCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePlusCheck.Location = new System.Drawing.Point(169, 191);
            this.OnePlusCheck.Name = "OnePlusCheck";
            this.OnePlusCheck.Size = new System.Drawing.Size(117, 29);
            this.OnePlusCheck.TabIndex = 1;
            this.OnePlusCheck.Text = "OnePlus";
            this.OnePlusCheck.UseVisualStyleBackColor = true;
            this.OnePlusCheck.CheckedChanged += new System.EventHandler(this.OnePlusCheck_CheckedChanged);
            // 
            // IPhoneCkeck
            // 
            this.IPhoneCkeck.AutoSize = true;
            this.IPhoneCkeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPhoneCkeck.Location = new System.Drawing.Point(169, 226);
            this.IPhoneCkeck.Name = "IPhoneCkeck";
            this.IPhoneCkeck.Size = new System.Drawing.Size(102, 29);
            this.IPhoneCkeck.TabIndex = 1;
            this.IPhoneCkeck.Text = "IPhone";
            this.IPhoneCkeck.UseVisualStyleBackColor = true;
            this.IPhoneCkeck.CheckedChanged += new System.EventHandler(this.IPhoneCkeck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(169, 366);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "ENABLED";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(349, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "ENABLED";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IPhoneCkeck);
            this.Controls.Add(this.OnePlusCheck);
            this.Controls.Add(this.NokiaCheck);
            this.Controls.Add(this.SamsungCheck);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SamsungCheck;
        private System.Windows.Forms.CheckBox NokiaCheck;
        private System.Windows.Forms.CheckBox OnePlusCheck;
        private System.Windows.Forms.CheckBox IPhoneCkeck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}

