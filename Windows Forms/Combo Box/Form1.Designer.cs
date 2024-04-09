namespace Combo_Box
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
            this.HobbiesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_button1 = new System.Windows.Forms.Button();
            this.Count_button1 = new System.Windows.Forms.Button();
            this.RemoveSpecificItemsbutton2 = new System.Windows.Forms.Button();
            this.ClearItemsbutton3 = new System.Windows.Forms.Button();
            this.Sortbutton4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hobbies :";
            // 
            // HobbiesComboBox
            // 
            this.HobbiesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.HobbiesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HobbiesComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.HobbiesComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.HobbiesComboBox.FormattingEnabled = true;
            this.HobbiesComboBox.Items.AddRange(new object[] {
            "Writing",
            "Reading",
            "Swimming",
            "Listening",
            "Dancing",
            "singing"});
            this.HobbiesComboBox.Location = new System.Drawing.Point(159, 122);
            this.HobbiesComboBox.Name = "HobbiesComboBox";
            this.HobbiesComboBox.Size = new System.Drawing.Size(416, 24);
            this.HobbiesComboBox.TabIndex = 1;
            this.HobbiesComboBox.SelectedIndexChanged += new System.EventHandler(this.HobbiesComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Items :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Add_button1
            // 
            this.Add_button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_button1.Location = new System.Drawing.Point(569, 46);
            this.Add_button1.Name = "Add_button1";
            this.Add_button1.Size = new System.Drawing.Size(150, 34);
            this.Add_button1.TabIndex = 4;
            this.Add_button1.Text = "ADD";
            this.Add_button1.UseVisualStyleBackColor = false;
            this.Add_button1.Click += new System.EventHandler(this.Add_button1_Click);
            // 
            // Count_button1
            // 
            this.Count_button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Count_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_button1.Location = new System.Drawing.Point(159, 178);
            this.Count_button1.Name = "Count_button1";
            this.Count_button1.Size = new System.Drawing.Size(416, 30);
            this.Count_button1.TabIndex = 5;
            this.Count_button1.Text = "Count Combo Box Items";
            this.Count_button1.UseVisualStyleBackColor = false;
            this.Count_button1.Click += new System.EventHandler(this.Count_button1_Click);
            // 
            // RemoveSpecificItemsbutton2
            // 
            this.RemoveSpecificItemsbutton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveSpecificItemsbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSpecificItemsbutton2.Location = new System.Drawing.Point(159, 238);
            this.RemoveSpecificItemsbutton2.Name = "RemoveSpecificItemsbutton2";
            this.RemoveSpecificItemsbutton2.Size = new System.Drawing.Size(416, 30);
            this.RemoveSpecificItemsbutton2.TabIndex = 6;
            this.RemoveSpecificItemsbutton2.Text = "Remove Specific Items";
            this.RemoveSpecificItemsbutton2.UseVisualStyleBackColor = false;
            this.RemoveSpecificItemsbutton2.Click += new System.EventHandler(this.RemoveSpecificItemsbutton2_Click);
            // 
            // ClearItemsbutton3
            // 
            this.ClearItemsbutton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearItemsbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearItemsbutton3.Location = new System.Drawing.Point(159, 290);
            this.ClearItemsbutton3.Name = "ClearItemsbutton3";
            this.ClearItemsbutton3.Size = new System.Drawing.Size(416, 30);
            this.ClearItemsbutton3.TabIndex = 7;
            this.ClearItemsbutton3.Text = "Clear All Items";
            this.ClearItemsbutton3.UseVisualStyleBackColor = false;
            this.ClearItemsbutton3.Click += new System.EventHandler(this.ClearItemsbutton3_Click);
            // 
            // Sortbutton4
            // 
            this.Sortbutton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sortbutton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortbutton4.Location = new System.Drawing.Point(159, 346);
            this.Sortbutton4.Name = "Sortbutton4";
            this.Sortbutton4.Size = new System.Drawing.Size(416, 30);
            this.Sortbutton4.TabIndex = 8;
            this.Sortbutton4.Text = "Sort Items";
            this.Sortbutton4.UseVisualStyleBackColor = false;
            this.Sortbutton4.Click += new System.EventHandler(this.Sortbutton4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sortbutton4);
            this.Controls.Add(this.ClearItemsbutton3);
            this.Controls.Add(this.RemoveSpecificItemsbutton2);
            this.Controls.Add(this.Count_button1);
            this.Controls.Add(this.Add_button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HobbiesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HobbiesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add_button1;
        private System.Windows.Forms.Button Count_button1;
        private System.Windows.Forms.Button RemoveSpecificItemsbutton2;
        private System.Windows.Forms.Button ClearItemsbutton3;
        private System.Windows.Forms.Button Sortbutton4;
        private System.Windows.Forms.Label label3;
    }
}

