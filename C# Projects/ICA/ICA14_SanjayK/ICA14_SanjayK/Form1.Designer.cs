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
            this.UI_Flipcase_Radio = new System.Windows.Forms.RadioButton();
            this.UI_LowerCase_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Uppercase_Radio = new System.Windows.Forms.RadioButton();
            this.UI_OutputString_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input String :";
            // 
            // UI_InputString_Tbx
            // 
            this.UI_InputString_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_InputString_Tbx.Location = new System.Drawing.Point(16, 98);
            this.UI_InputString_Tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_InputString_Tbx.Name = "UI_InputString_Tbx";
            this.UI_InputString_Tbx.Size = new System.Drawing.Size(1033, 30);
            this.UI_InputString_Tbx.TabIndex = 1;
            this.UI_InputString_Tbx.TextChanged += new System.EventHandler(this.UI_InputString_Tbx_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Flipcase_Radio);
            this.groupBox1.Controls.Add(this.UI_LowerCase_Radio);
            this.groupBox1.Controls.Add(this.UI_Uppercase_Radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 191);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type :";
            // 
            // UI_Flipcase_Radio
            // 
            this.UI_Flipcase_Radio.AutoSize = true;
            this.UI_Flipcase_Radio.Checked = true;
            this.UI_Flipcase_Radio.Location = new System.Drawing.Point(907, 52);
            this.UI_Flipcase_Radio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_Flipcase_Radio.Name = "UI_Flipcase_Radio";
            this.UI_Flipcase_Radio.Size = new System.Drawing.Size(93, 24);
            this.UI_Flipcase_Radio.TabIndex = 0;
            this.UI_Flipcase_Radio.TabStop = true;
            this.UI_Flipcase_Radio.Text = "Flipcase";
            this.UI_Flipcase_Radio.UseVisualStyleBackColor = true;
            this.UI_Flipcase_Radio.CheckedChanged += new System.EventHandler(this.UI_ControlChanged);
            // 
            // UI_LowerCase_Radio
            // 
            this.UI_LowerCase_Radio.AutoSize = true;
            this.UI_LowerCase_Radio.Location = new System.Drawing.Point(460, 52);
            this.UI_LowerCase_Radio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_LowerCase_Radio.Name = "UI_LowerCase_Radio";
            this.UI_LowerCase_Radio.Size = new System.Drawing.Size(112, 24);
            this.UI_LowerCase_Radio.TabIndex = 2;
            this.UI_LowerCase_Radio.Text = "Lowercase";
            this.UI_LowerCase_Radio.UseVisualStyleBackColor = true;
            this.UI_LowerCase_Radio.CheckedChanged += new System.EventHandler(this.UI_ControlChanged);
            // 
            // UI_Uppercase_Radio
            // 
            this.UI_Uppercase_Radio.AutoSize = true;
            this.UI_Uppercase_Radio.Location = new System.Drawing.Point(32, 52);
            this.UI_Uppercase_Radio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_Uppercase_Radio.Name = "UI_Uppercase_Radio";
            this.UI_Uppercase_Radio.Size = new System.Drawing.Size(116, 24);
            this.UI_Uppercase_Radio.TabIndex = 1;
            this.UI_Uppercase_Radio.Text = "Uppercase ";
            this.UI_Uppercase_Radio.UseVisualStyleBackColor = true;
            this.UI_Uppercase_Radio.CheckedChanged += new System.EventHandler(this.UI_ControlChanged);
            // 
            // UI_OutputString_Tbx
            // 
            this.UI_OutputString_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_OutputString_Tbx.Location = new System.Drawing.Point(16, 444);
            this.UI_OutputString_Tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_OutputString_Tbx.Name = "UI_OutputString_Tbx";
            this.UI_OutputString_Tbx.ReadOnly = true;
            this.UI_OutputString_Tbx.Size = new System.Drawing.Size(1033, 30);
            this.UI_OutputString_Tbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output String :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.UI_OutputString_Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_InputString_Tbx);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "StringBender";
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

