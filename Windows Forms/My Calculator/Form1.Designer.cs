namespace My_Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Addition_button = new System.Windows.Forms.Button();
            this.Subtraction_button = new System.Windows.Forms.Button();
            this.Multiply_button = new System.Windows.Forms.Button();
            this.Division_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Calculator Application ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Your Second Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(340, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(388, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Addition_button
            // 
            this.Addition_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Addition_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addition_button.Location = new System.Drawing.Point(48, 241);
            this.Addition_button.Name = "Addition_button";
            this.Addition_button.Size = new System.Drawing.Size(119, 33);
            this.Addition_button.TabIndex = 5;
            this.Addition_button.Text = "Addition";
            this.Addition_button.UseVisualStyleBackColor = false;
            this.Addition_button.Click += new System.EventHandler(this.Addition_button_Click);
            // 
            // Subtraction_button
            // 
            this.Subtraction_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Subtraction_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction_button.Location = new System.Drawing.Point(197, 241);
            this.Subtraction_button.Name = "Subtraction_button";
            this.Subtraction_button.Size = new System.Drawing.Size(155, 33);
            this.Subtraction_button.TabIndex = 6;
            this.Subtraction_button.Text = "Subtraction";
            this.Subtraction_button.UseVisualStyleBackColor = false;
            this.Subtraction_button.Click += new System.EventHandler(this.Subtraction_button_Click);
            // 
            // Multiply_button
            // 
            this.Multiply_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_button.Location = new System.Drawing.Point(394, 241);
            this.Multiply_button.Name = "Multiply_button";
            this.Multiply_button.Size = new System.Drawing.Size(167, 33);
            this.Multiply_button.TabIndex = 7;
            this.Multiply_button.Text = "Multiplication";
            this.Multiply_button.UseVisualStyleBackColor = false;
            this.Multiply_button.Click += new System.EventHandler(this.Multiply_button_Click);
            // 
            // Division_button
            // 
            this.Division_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Division_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division_button.Location = new System.Drawing.Point(623, 241);
            this.Division_button.Name = "Division_button";
            this.Division_button.Size = new System.Drawing.Size(92, 33);
            this.Division_button.TabIndex = 8;
            this.Division_button.Text = "Division";
            this.Division_button.UseVisualStyleBackColor = false;
            this.Division_button.Click += new System.EventHandler(this.Division_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Division_button);
            this.Controls.Add(this.Multiply_button);
            this.Controls.Add(this.Subtraction_button);
            this.Controls.Add(this.Addition_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calculator Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Addition_button;
        private System.Windows.Forms.Button Subtraction_button;
        private System.Windows.Forms.Button Multiply_button;
        private System.Windows.Forms.Button Division_button;
        private System.Windows.Forms.Label label4;
    }
}

