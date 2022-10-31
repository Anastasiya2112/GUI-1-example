namespace _123
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_first_number = new System.Windows.Forms.TextBox();
            this.textBox3_therd_number = new System.Windows.Forms.TextBox();
            this.textBox2_second_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_first_number
            // 
            this.textBox1_first_number.Location = new System.Drawing.Point(281, 60);
            this.textBox1_first_number.Name = "textBox1_first_number";
            this.textBox1_first_number.Size = new System.Drawing.Size(76, 23);
            this.textBox1_first_number.TabIndex = 1;
            this.textBox1_first_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3_therd_number
            // 
            this.textBox3_therd_number.Location = new System.Drawing.Point(501, 60);
            this.textBox3_therd_number.Name = "textBox3_therd_number";
            this.textBox3_therd_number.Size = new System.Drawing.Size(85, 23);
            this.textBox3_therd_number.TabIndex = 2;
            this.textBox3_therd_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2_second_number
            // 
            this.textBox2_second_number.Location = new System.Drawing.Point(375, 60);
            this.textBox2_second_number.Name = "textBox2_second_number";
            this.textBox2_second_number.Size = new System.Drawing.Size(99, 23);
            this.textBox2_second_number.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2_second_number);
            this.Controls.Add(this.textBox3_therd_number);
            this.Controls.Add(this.textBox1_first_number);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1_first_number;
        private TextBox textBox3_therd_number;
        private TextBox textBox2_second_number;
    }
}