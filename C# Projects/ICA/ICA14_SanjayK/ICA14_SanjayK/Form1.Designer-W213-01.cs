namespace ICA14_SanjayK
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
            this.UI_InputString_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Uppercase_Radio = new System.Windows.Forms.RadioButton();
            this.UI_LowerCase_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Flipcase_Radio = new System.Windows.Forms.RadioButton();
            this.UI_OutputString_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input String :";
            // 
            // UI_InputString_Tbx
            // 
            this.UI_InputString_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_InputString_Tbx.Location = new System.Drawing.Point(12, 80);
            this.UI_InputString_Tbx.Name = "UI_InputString_Tbx";
            this.UI_InputString_Tbx.Size = new System.Drawing.Size(776, 26);
            this.UI_InputString_Tbx.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Flipcase_Radio);
            this.groupBox1.Controls.Add(this.UI_LowerCase_Radio);
            this.groupBox1.Controls.Add(this.UI_Uppercase_Radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type :";
            // 
            // UI_Uppercase_Radio
            // 
            this.UI_Uppercase_Radio.AutoSize = true;
            this.UI_Uppercase_Radio.Location = new System.Drawing.Point(24, 42);
            this.UI_Uppercase_Radio.Name = "UI_Uppercase_Radio";
            this.UI_Uppercase_Radio.Size = new System.Drawing.Size(96, 20);
            this.UI_Uppercase_Radio.TabIndex = 0;
            this.UI_Uppercase_Radio.Text = "Uppercase ";
            this.UI_Uppercase_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_LowerCase_Radio
            // 
            this.UI_LowerCase_Radio.AutoSize = true;
            this.UI_LowerCase_Radio.Location = new System.Drawing.Point(345, 42);
            this.UI_LowerCase_Radio.Name = "UI_LowerCase_Radio";
            this.UI_LowerCase_Radio.Size = new System.Drawing.Size(91, 20);
            this.UI_LowerCase_Radio.TabIndex = 1;
            this.UI_LowerCase_Radio.Text = "Lowercase";
            this.UI_LowerCase_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_Flipcase_Radio
            // 
            this.UI_Flipcase_Radio.AutoSize = true;
            this.UI_Flipcase_Radio.Checked = true;
            this.UI_Flipcase_Radio.Location = new System.Drawing.Point(680, 42);
            this.UI_Flipcase_Radio.Name = "UI_Flipcase_Radio";
            this.UI_Flipcase_Radio.Size = new System.Drawing.Size(77, 20);
            this.UI_Flipcase_Radio.TabIndex = 2;
            this.UI_Flipcase_Radio.TabStop = true;
            this.UI_Flipcase_Radio.Text = "Flipcase";
            this.UI_Flipcase_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_OutputString_Tbx
            // 
            this.UI_OutputString_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_OutputString_Tbx.Location = new System.Drawing.Point(12, 361);
            this.UI_OutputString_Tbx.Name = "UI_OutputString_Tbx";
            this.UI_OutputString_Tbx.ReadOnly = true;
            this.UI_OutputString_Tbx.Size = new System.Drawing.Size(776, 26);
            this.UI_OutputString_Tbx.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output String :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_OutputString_Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_InputString_Tbx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "22";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_InputString_Tbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Flipcase_Radio;
        private System.Windows.Forms.RadioButton UI_LowerCase_Radio;
        private System.Windows.Forms.RadioButton UI_Uppercase_Radio;
        private System.Windows.Forms.TextBox UI_OutputString_Tbx;
        private System.Windows.Forms.Label label2;
    }
}

