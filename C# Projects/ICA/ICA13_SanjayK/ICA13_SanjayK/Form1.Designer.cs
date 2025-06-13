namespace ICA13_SanjayK
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
            this.UI_FontColour_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_FontColour_Label
            // 
            this.UI_FontColour_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_FontColour_Label.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_FontColour_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UI_FontColour_Label.Location = new System.Drawing.Point(266, 113);
            this.UI_FontColour_Label.Name = "UI_FontColour_Label";
            this.UI_FontColour_Label.Size = new System.Drawing.Size(248, 177);
            this.UI_FontColour_Label.TabIndex = 0;
            this.UI_FontColour_Label.Text = "This is Initial font!";
            this.UI_FontColour_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_FontColour_Label.Click += new System.EventHandler(this.UI_FontColour_Label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_FontColour_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI_FontColour_Label;
    }
}

