namespace Lab03_SanjayK
{
    partial class ModelessDialongScore
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
            this.UI_Score_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Score_Lbl
            // 
            this.UI_Score_Lbl.AutoSize = true;
            this.UI_Score_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Score_Lbl.Location = new System.Drawing.Point(44, 41);
            this.UI_Score_Lbl.Name = "UI_Score_Lbl";
            this.UI_Score_Lbl.Size = new System.Drawing.Size(153, 29);
            this.UI_Score_Lbl.TabIndex = 0;
            this.UI_Score_Lbl.Text = "Score :  0000";
            // 
            // ModelessDialongScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 109);
            this.Controls.Add(this.UI_Score_Lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelessDialongScore";
            this.Text = "ModelessDialongScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessDialongScore_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Score_Lbl;
    }
}