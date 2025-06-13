namespace ICA09_SanjayK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_OutputString_Tbx = new System.Windows.Forms.TextBox();
            this.UI_RecReverse_Btn = new System.Windows.Forms.Button();
            this.UI_RecShow_Btn = new System.Windows.Forms.Button();
            this.UI_InputString_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UI_OutputFactor_Tbx = new System.Windows.Forms.TextBox();
            this.UI_FindFactors_Btn = new System.Windows.Forms.Button();
            this.UI_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UI_OutputUpper_Tbx = new System.Windows.Forms.TextBox();
            this.UI_FindUpperCase_Btn = new System.Windows.Forms.Button();
            this.UI_InputUpper_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_OutputString_Tbx);
            this.groupBox1.Controls.Add(this.UI_RecReverse_Btn);
            this.groupBox1.Controls.Add(this.UI_RecShow_Btn);
            this.groupBox1.Controls.Add(this.UI_InputString_Tbx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String Recursion";
            // 
            // UI_OutputString_Tbx
            // 
            this.UI_OutputString_Tbx.Location = new System.Drawing.Point(52, 76);
            this.UI_OutputString_Tbx.Name = "UI_OutputString_Tbx";
            this.UI_OutputString_Tbx.ReadOnly = true;
            this.UI_OutputString_Tbx.Size = new System.Drawing.Size(703, 20);
            this.UI_OutputString_Tbx.TabIndex = 3;
            // 
            // UI_RecReverse_Btn
            // 
            this.UI_RecReverse_Btn.Location = new System.Drawing.Point(297, 47);
            this.UI_RecReverse_Btn.Name = "UI_RecReverse_Btn";
            this.UI_RecReverse_Btn.Size = new System.Drawing.Size(182, 23);
            this.UI_RecReverse_Btn.TabIndex = 2;
            this.UI_RecReverse_Btn.Text = "Rec Reverse";
            this.UI_RecReverse_Btn.UseVisualStyleBackColor = true;
            this.UI_RecReverse_Btn.Click += new System.EventHandler(this.UI_RecReverse_Btn_Click);
            // 
            // UI_RecShow_Btn
            // 
            this.UI_RecShow_Btn.Location = new System.Drawing.Point(78, 47);
            this.UI_RecShow_Btn.Name = "UI_RecShow_Btn";
            this.UI_RecShow_Btn.Size = new System.Drawing.Size(182, 23);
            this.UI_RecShow_Btn.TabIndex = 1;
            this.UI_RecShow_Btn.Text = "Rec Show";
            this.UI_RecShow_Btn.UseVisualStyleBackColor = true;
            this.UI_RecShow_Btn.Click += new System.EventHandler(this.UI_RecShow_Btn_Click);
            // 
            // UI_InputString_Tbx
            // 
            this.UI_InputString_Tbx.Location = new System.Drawing.Point(52, 20);
            this.UI_InputString_Tbx.Name = "UI_InputString_Tbx";
            this.UI_InputString_Tbx.Size = new System.Drawing.Size(703, 20);
            this.UI_InputString_Tbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UI_OutputFactor_Tbx);
            this.groupBox2.Controls.Add(this.UI_FindFactors_Btn);
            this.groupBox2.Controls.Add(this.UI_NumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factor Finder";
            // 
            // UI_OutputFactor_Tbx
            // 
            this.UI_OutputFactor_Tbx.Location = new System.Drawing.Point(52, 74);
            this.UI_OutputFactor_Tbx.Name = "UI_OutputFactor_Tbx";
            this.UI_OutputFactor_Tbx.ReadOnly = true;
            this.UI_OutputFactor_Tbx.Size = new System.Drawing.Size(703, 20);
            this.UI_OutputFactor_Tbx.TabIndex = 2;
            // 
            // UI_FindFactors_Btn
            // 
            this.UI_FindFactors_Btn.Location = new System.Drawing.Point(52, 45);
            this.UI_FindFactors_Btn.Name = "UI_FindFactors_Btn";
            this.UI_FindFactors_Btn.Size = new System.Drawing.Size(120, 23);
            this.UI_FindFactors_Btn.TabIndex = 1;
            this.UI_FindFactors_Btn.Text = "Find Factors";
            this.UI_FindFactors_Btn.UseVisualStyleBackColor = true;
            this.UI_FindFactors_Btn.Click += new System.EventHandler(this.UI_FindFactors_Btn_Click);
            // 
            // UI_NumericUpDown
            // 
            this.UI_NumericUpDown.Location = new System.Drawing.Point(52, 19);
            this.UI_NumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.UI_NumericUpDown.Name = "UI_NumericUpDown";
            this.UI_NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.UI_NumericUpDown.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UI_OutputUpper_Tbx);
            this.groupBox3.Controls.Add(this.UI_FindUpperCase_Btn);
            this.groupBox3.Controls.Add(this.UI_InputUpper_Tbx);
            this.groupBox3.Location = new System.Drawing.Point(12, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 117);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Binary Hunter";
            // 
            // UI_OutputUpper_Tbx
            // 
            this.UI_OutputUpper_Tbx.Location = new System.Drawing.Point(52, 76);
            this.UI_OutputUpper_Tbx.Name = "UI_OutputUpper_Tbx";
            this.UI_OutputUpper_Tbx.ReadOnly = true;
            this.UI_OutputUpper_Tbx.Size = new System.Drawing.Size(703, 20);
            this.UI_OutputUpper_Tbx.TabIndex = 3;
            // 
            // UI_FindUpperCase_Btn
            // 
            this.UI_FindUpperCase_Btn.Location = new System.Drawing.Point(78, 47);
            this.UI_FindUpperCase_Btn.Name = "UI_FindUpperCase_Btn";
            this.UI_FindUpperCase_Btn.Size = new System.Drawing.Size(182, 23);
            this.UI_FindUpperCase_Btn.TabIndex = 1;
            this.UI_FindUpperCase_Btn.Text = "Find Uppercase";
            this.UI_FindUpperCase_Btn.UseVisualStyleBackColor = true;
            this.UI_FindUpperCase_Btn.Click += new System.EventHandler(this.UI_FindUpperCase_Btn_Click);
            // 
            // UI_InputUpper_Tbx
            // 
            this.UI_InputUpper_Tbx.Location = new System.Drawing.Point(52, 20);
            this.UI_InputUpper_Tbx.Name = "UI_InputUpper_Tbx";
            this.UI_InputUpper_Tbx.Size = new System.Drawing.Size(703, 20);
            this.UI_InputUpper_Tbx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UI_OutputString_Tbx;
        private System.Windows.Forms.Button UI_RecReverse_Btn;
        private System.Windows.Forms.Button UI_RecShow_Btn;
        private System.Windows.Forms.TextBox UI_InputString_Tbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox UI_OutputFactor_Tbx;
        private System.Windows.Forms.Button UI_FindFactors_Btn;
        private System.Windows.Forms.NumericUpDown UI_NumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox UI_OutputUpper_Tbx;
        private System.Windows.Forms.Button UI_FindUpperCase_Btn;
        private System.Windows.Forms.TextBox UI_InputUpper_Tbx;
    }
}

