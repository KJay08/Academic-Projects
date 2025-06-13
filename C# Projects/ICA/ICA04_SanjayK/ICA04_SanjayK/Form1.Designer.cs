namespace ICA04_SanjayK
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
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_40PerDay_Radio = new System.Windows.Forms.RadioButton();
            this.UI_50PerDay_Radio = new System.Windows.Forms.RadioButton();
            this.UI_60PerDay_Radio = new System.Windows.Forms.RadioButton();
            this.UI_GroupBox = new System.Windows.Forms.GroupBox();
            this.UI_Insurance_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Discount_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_NumDays_UpDown = new System.Windows.Forms.NumericUpDown();
            this.UI_NumDays_Lbl = new System.Windows.Forms.Label();
            this.UI_Total_Lbl = new System.Windows.Forms.Label();
            this.UI_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumDays_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Name_Tbx.Location = new System.Drawing.Point(219, 47);
            this.UI_Name_Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(435, 30);
            this.UI_Name_Tbx.TabIndex = 1;
            this.UI_Name_Tbx.TextChanged += new System.EventHandler(this.UI_Name_Tbx_TextChanged);
            // 
            // UI_40PerDay_Radio
            // 
            this.UI_40PerDay_Radio.AutoCheck = false;
            this.UI_40PerDay_Radio.AutoSize = true;
            this.UI_40PerDay_Radio.Checked = true;
            this.UI_40PerDay_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_40PerDay_Radio.Location = new System.Drawing.Point(11, 42);
            this.UI_40PerDay_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_40PerDay_Radio.Name = "UI_40PerDay_Radio";
            this.UI_40PerDay_Radio.Size = new System.Drawing.Size(157, 24);
            this.UI_40PerDay_Radio.TabIndex = 2;
            this.UI_40PerDay_Radio.TabStop = true;
            this.UI_40PerDay_Radio.Text = "Small $40.00/day";
            this.UI_40PerDay_Radio.UseVisualStyleBackColor = true;
            this.UI_40PerDay_Radio.CheckedChanged += new System.EventHandler(this.UI_PerDay_Radio_CheckedChanged);
            // 
            // UI_50PerDay_Radio
            // 
            this.UI_50PerDay_Radio.AutoSize = true;
            this.UI_50PerDay_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_50PerDay_Radio.Location = new System.Drawing.Point(11, 97);
            this.UI_50PerDay_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_50PerDay_Radio.Name = "UI_50PerDay_Radio";
            this.UI_50PerDay_Radio.Size = new System.Drawing.Size(175, 24);
            this.UI_50PerDay_Radio.TabIndex = 3;
            this.UI_50PerDay_Radio.Text = "MIdSize $50.00/day";
            this.UI_50PerDay_Radio.UseVisualStyleBackColor = true;
            this.UI_50PerDay_Radio.CheckedChanged += new System.EventHandler(this.UI_PerDay_Radio_CheckedChanged);
            // 
            // UI_60PerDay_Radio
            // 
            this.UI_60PerDay_Radio.AutoSize = true;
            this.UI_60PerDay_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_60PerDay_Radio.Location = new System.Drawing.Point(11, 153);
            this.UI_60PerDay_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_60PerDay_Radio.Name = "UI_60PerDay_Radio";
            this.UI_60PerDay_Radio.Size = new System.Drawing.Size(164, 24);
            this.UI_60PerDay_Radio.TabIndex = 4;
            this.UI_60PerDay_Radio.Text = "Sports $60.00/day";
            this.UI_60PerDay_Radio.UseVisualStyleBackColor = true;
            this.UI_60PerDay_Radio.CheckedChanged += new System.EventHandler(this.UI_PerDay_Radio_CheckedChanged);
            // 
            // UI_GroupBox
            // 
            this.UI_GroupBox.Controls.Add(this.UI_40PerDay_Radio);
            this.UI_GroupBox.Controls.Add(this.UI_60PerDay_Radio);
            this.UI_GroupBox.Controls.Add(this.UI_50PerDay_Radio);
            this.UI_GroupBox.Enabled = false;
            this.UI_GroupBox.Location = new System.Drawing.Point(39, 129);
            this.UI_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_GroupBox.Name = "UI_GroupBox";
            this.UI_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_GroupBox.Size = new System.Drawing.Size(315, 194);
            this.UI_GroupBox.TabIndex = 5;
            this.UI_GroupBox.TabStop = false;
            this.UI_GroupBox.Text = "Car Type";
            // 
            // UI_Insurance_Cbx
            // 
            this.UI_Insurance_Cbx.AutoSize = true;
            this.UI_Insurance_Cbx.Enabled = false;
            this.UI_Insurance_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Insurance_Cbx.Location = new System.Drawing.Point(477, 171);
            this.UI_Insurance_Cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Insurance_Cbx.Name = "UI_Insurance_Cbx";
            this.UI_Insurance_Cbx.Size = new System.Drawing.Size(204, 26);
            this.UI_Insurance_Cbx.TabIndex = 6;
            this.UI_Insurance_Cbx.Text = "Insurance $15.00/day";
            this.UI_Insurance_Cbx.UseVisualStyleBackColor = true;
            this.UI_Insurance_Cbx.CheckedChanged += new System.EventHandler(this.UI_PerDay_Radio_CheckedChanged);
            // 
            // UI_Discount_Cbx
            // 
            this.UI_Discount_Cbx.AutoSize = true;
            this.UI_Discount_Cbx.Enabled = false;
            this.UI_Discount_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Discount_Cbx.Location = new System.Drawing.Point(477, 217);
            this.UI_Discount_Cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Discount_Cbx.Name = "UI_Discount_Cbx";
            this.UI_Discount_Cbx.Size = new System.Drawing.Size(197, 26);
            this.UI_Discount_Cbx.TabIndex = 7;
            this.UI_Discount_Cbx.Text = "AMA Discount - 10%";
            this.UI_Discount_Cbx.UseVisualStyleBackColor = true;
            this.UI_Discount_Cbx.CheckedChanged += new System.EventHandler(this.UI_PerDay_Radio_CheckedChanged);
            // 
            // UI_NumDays_UpDown
            // 
            this.UI_NumDays_UpDown.Enabled = false;
            this.UI_NumDays_UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_NumDays_UpDown.Location = new System.Drawing.Point(625, 263);
            this.UI_NumDays_UpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_NumDays_UpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.UI_NumDays_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_NumDays_UpDown.Name = "UI_NumDays_UpDown";
            this.UI_NumDays_UpDown.Size = new System.Drawing.Size(85, 27);
            this.UI_NumDays_UpDown.TabIndex = 8;
            this.UI_NumDays_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_NumDays_UpDown.ValueChanged += new System.EventHandler(this.UI_PerDay_Radio_CheckedChanged);
            // 
            // UI_NumDays_Lbl
            // 
            this.UI_NumDays_Lbl.AutoSize = true;
            this.UI_NumDays_Lbl.Enabled = false;
            this.UI_NumDays_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_NumDays_Lbl.Location = new System.Drawing.Point(475, 265);
            this.UI_NumDays_Lbl.Name = "UI_NumDays_Lbl";
            this.UI_NumDays_Lbl.Size = new System.Drawing.Size(131, 20);
            this.UI_NumDays_Lbl.TabIndex = 9;
            this.UI_NumDays_Lbl.Text = "Number of Days";
            // 
            // UI_Total_Lbl
            // 
            this.UI_Total_Lbl.AutoSize = true;
            this.UI_Total_Lbl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UI_Total_Lbl.Enabled = false;
            this.UI_Total_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Total_Lbl.Location = new System.Drawing.Point(295, 391);
            this.UI_Total_Lbl.Name = "UI_Total_Lbl";
            this.UI_Total_Lbl.Size = new System.Drawing.Size(233, 32);
            this.UI_Total_Lbl.TabIndex = 10;
            this.UI_Total_Lbl.Text = "Total    :    $0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Total_Lbl);
            this.Controls.Add(this.UI_NumDays_Lbl);
            this.Controls.Add(this.UI_NumDays_UpDown);
            this.Controls.Add(this.UI_Discount_Cbx);
            this.Controls.Add(this.UI_Insurance_Cbx);
            this.Controls.Add(this.UI_GroupBox);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Car Rental";
            this.UI_GroupBox.ResumeLayout(false);
            this.UI_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumDays_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.RadioButton UI_40PerDay_Radio;
        private System.Windows.Forms.RadioButton UI_50PerDay_Radio;
        private System.Windows.Forms.RadioButton UI_60PerDay_Radio;
        private System.Windows.Forms.GroupBox UI_GroupBox;
        private System.Windows.Forms.CheckBox UI_Insurance_Cbx;
        private System.Windows.Forms.CheckBox UI_Discount_Cbx;
        private System.Windows.Forms.NumericUpDown UI_NumDays_UpDown;
        private System.Windows.Forms.Label UI_NumDays_Lbl;
        private System.Windows.Forms.Label UI_Total_Lbl;
    }
}

