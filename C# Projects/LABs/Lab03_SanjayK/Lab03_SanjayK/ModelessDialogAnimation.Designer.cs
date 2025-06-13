namespace Lab03_SanjayK
{
    partial class ModelessDialogAnimation
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
            this.UI_AnimationSpeed_Bar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSpeed_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_AnimationSpeed_Bar
            // 
            this.UI_AnimationSpeed_Bar.Location = new System.Drawing.Point(21, 38);
            this.UI_AnimationSpeed_Bar.Maximum = 200;
            this.UI_AnimationSpeed_Bar.Minimum = 10;
            this.UI_AnimationSpeed_Bar.Name = "UI_AnimationSpeed_Bar";
            this.UI_AnimationSpeed_Bar.Size = new System.Drawing.Size(588, 56);
            this.UI_AnimationSpeed_Bar.TabIndex = 0;
            this.UI_AnimationSpeed_Bar.TickFrequency = 20;
            this.UI_AnimationSpeed_Bar.Value = 10;
            this.UI_AnimationSpeed_Bar.Scroll += new System.EventHandler(this.UI_AnimationSpeed_Bar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "10ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "200ms";
            // 
            // ModelessDialogAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_AnimationSpeed_Bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelessDialogAnimation";
            this.Text = "ModelessDialogAnimation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessDialogAnimation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSpeed_Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_AnimationSpeed_Bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}