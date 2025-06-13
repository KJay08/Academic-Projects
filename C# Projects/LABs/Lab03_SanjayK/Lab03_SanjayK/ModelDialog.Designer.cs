namespace Lab03_SanjayK
{
    partial class ModelDialog
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
            this.UI_Easy_Radio = new System.Windows.Forms.RadioButton();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Medium_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Hard_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Hard_Radio);
            this.groupBox1.Controls.Add(this.UI_Medium_Radio);
            this.groupBox1.Controls.Add(this.UI_Easy_Radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // UI_Easy_Radio
            // 
            this.UI_Easy_Radio.AutoSize = true;
            this.UI_Easy_Radio.Checked = true;
            this.UI_Easy_Radio.Location = new System.Drawing.Point(20, 35);
            this.UI_Easy_Radio.Name = "UI_Easy_Radio";
            this.UI_Easy_Radio.Size = new System.Drawing.Size(67, 24);
            this.UI_Easy_Radio.TabIndex = 0;
            this.UI_Easy_Radio.TabStop = true;
            this.UI_Easy_Radio.Text = "Easy";
            this.UI_Easy_Radio.UseVisualStyleBackColor = true;
            this.UI_Easy_Radio.CheckedChanged += new System.EventHandler(this.UI_DifficultyLevel_Radio_CheckedChanged);
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_OK_Btn.Location = new System.Drawing.Point(20, 248);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(96, 31);
            this.UI_OK_Btn.TabIndex = 1;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Medium_Radio
            // 
            this.UI_Medium_Radio.AutoSize = true;
            this.UI_Medium_Radio.Location = new System.Drawing.Point(20, 73);
            this.UI_Medium_Radio.Name = "UI_Medium_Radio";
            this.UI_Medium_Radio.Size = new System.Drawing.Size(89, 24);
            this.UI_Medium_Radio.TabIndex = 1;
            this.UI_Medium_Radio.TabStop = true;
            this.UI_Medium_Radio.Text = "Medium";
            this.UI_Medium_Radio.UseVisualStyleBackColor = true;
            this.UI_Medium_Radio.CheckedChanged += new System.EventHandler(this.UI_DifficultyLevel_Radio_CheckedChanged);
            // 
            // UI_Hard_Radio
            // 
            this.UI_Hard_Radio.AutoSize = true;
            this.UI_Hard_Radio.Location = new System.Drawing.Point(20, 114);
            this.UI_Hard_Radio.Name = "UI_Hard_Radio";
            this.UI_Hard_Radio.Size = new System.Drawing.Size(67, 24);
            this.UI_Hard_Radio.TabIndex = 2;
            this.UI_Hard_Radio.TabStop = true;
            this.UI_Hard_Radio.Text = "Hard";
            this.UI_Hard_Radio.UseVisualStyleBackColor = true;
            this.UI_Hard_Radio.CheckedChanged += new System.EventHandler(this.UI_DifficultyLevel_Radio_CheckedChanged);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(246, 248);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(96, 31);
            this.UI_Cancel_Btn.TabIndex = 2;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // ModelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 328);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelDialog";
            this.Text = "ModelDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Hard_Radio;
        private System.Windows.Forms.RadioButton UI_Medium_Radio;
        private System.Windows.Forms.RadioButton UI_Easy_Radio;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
    }
}