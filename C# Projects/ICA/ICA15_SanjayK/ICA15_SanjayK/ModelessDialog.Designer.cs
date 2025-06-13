namespace ICA15_SanjayK
{
    partial class ModelessDialog
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
            this.UI_Red_Track = new System.Windows.Forms.TrackBar();
            this.UI_Green_Track = new System.Windows.Forms.TrackBar();
            this.UI_Blue_Track = new System.Windows.Forms.TrackBar();
            this.UI_OP_Track = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Red_Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Green_Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Blue_Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_OP_Track)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Red_Track
            // 
            this.UI_Red_Track.BackColor = System.Drawing.Color.LightCoral;
            this.UI_Red_Track.Location = new System.Drawing.Point(6, 19);
            this.UI_Red_Track.Maximum = 255;
            this.UI_Red_Track.Minimum = 1;
            this.UI_Red_Track.Name = "UI_Red_Track";
            this.UI_Red_Track.Size = new System.Drawing.Size(764, 45);
            this.UI_Red_Track.TabIndex = 0;
            this.UI_Red_Track.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Red_Track.Value = 1;
            this.UI_Red_Track.Scroll += new System.EventHandler(this.UI_RGB_Track_Scroll);
            // 
            // UI_Green_Track
            // 
            this.UI_Green_Track.BackColor = System.Drawing.Color.YellowGreen;
            this.UI_Green_Track.Location = new System.Drawing.Point(6, 70);
            this.UI_Green_Track.Maximum = 255;
            this.UI_Green_Track.Minimum = 1;
            this.UI_Green_Track.Name = "UI_Green_Track";
            this.UI_Green_Track.Size = new System.Drawing.Size(764, 45);
            this.UI_Green_Track.TabIndex = 1;
            this.UI_Green_Track.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Green_Track.Value = 1;
            this.UI_Green_Track.Scroll += new System.EventHandler(this.UI_RGB_Track_Scroll);
            // 
            // UI_Blue_Track
            // 
            this.UI_Blue_Track.BackColor = System.Drawing.Color.SlateBlue;
            this.UI_Blue_Track.Location = new System.Drawing.Point(6, 121);
            this.UI_Blue_Track.Maximum = 255;
            this.UI_Blue_Track.Minimum = 1;
            this.UI_Blue_Track.Name = "UI_Blue_Track";
            this.UI_Blue_Track.Size = new System.Drawing.Size(764, 45);
            this.UI_Blue_Track.TabIndex = 2;
            this.UI_Blue_Track.Value = 1;
            this.UI_Blue_Track.Scroll += new System.EventHandler(this.UI_RGB_Track_Scroll);
            // 
            // UI_OP_Track
            // 
            this.UI_OP_Track.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UI_OP_Track.Location = new System.Drawing.Point(6, 32);
            this.UI_OP_Track.Maximum = 100;
            this.UI_OP_Track.Name = "UI_OP_Track";
            this.UI_OP_Track.Size = new System.Drawing.Size(764, 45);
            this.UI_OP_Track.TabIndex = 3;
            this.UI_OP_Track.Value = 100;
            this.UI_OP_Track.Scroll += new System.EventHandler(this.UI_OP_Track_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Red_Track);
            this.groupBox1.Controls.Add(this.UI_Green_Track);
            this.groupBox1.Controls.Add(this.UI_Blue_Track);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UI_OP_Track);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opacity";
            // 
            // ModelessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModelessDialog";
            this.Text = "ModelessDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Red_Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Green_Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Blue_Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_OP_Track)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_Red_Track;
        private System.Windows.Forms.TrackBar UI_Green_Track;
        private System.Windows.Forms.TrackBar UI_Blue_Track;
        private System.Windows.Forms.TrackBar UI_OP_Track;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}