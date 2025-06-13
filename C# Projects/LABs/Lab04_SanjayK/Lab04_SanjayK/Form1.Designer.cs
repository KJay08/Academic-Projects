namespace Lab04_SanjayK
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
            this.components = new System.ComponentModel.Container();
            this.UI_SegInfoDisplay_Lbl = new System.Windows.Forms.Label();
            this.UI_UndoLine_Btn = new System.Windows.Forms.Button();
            this.UI_ThicknessTrackbar = new System.Windows.Forms.TrackBar();
            this.UI_UndoSegment_Btn = new System.Windows.Forms.Button();
            this.UI_ReduceComplexity_Btn = new System.Windows.Forms.Button();
            this.UI_Colour_Btn = new System.Windows.Forms.Button();
            this.UI_Thickness_Lbl = new System.Windows.Forms.Label();
            this.UI_Alpha_Lbl = new System.Windows.Forms.Label();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.UI_ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_ThicknessTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_SegInfoDisplay_Lbl
            // 
            this.UI_SegInfoDisplay_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_SegInfoDisplay_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SegInfoDisplay_Lbl.Location = new System.Drawing.Point(9, 28);
            this.UI_SegInfoDisplay_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_SegInfoDisplay_Lbl.Name = "UI_SegInfoDisplay_Lbl";
            this.UI_SegInfoDisplay_Lbl.Size = new System.Drawing.Size(582, 30);
            this.UI_SegInfoDisplay_Lbl.TabIndex = 0;
            this.UI_SegInfoDisplay_Lbl.Text = "0 lines, 0 total segments.";
            this.UI_SegInfoDisplay_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_UndoLine_Btn
            // 
            this.UI_UndoLine_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_UndoLine_Btn.Location = new System.Drawing.Point(9, 83);
            this.UI_UndoLine_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_UndoLine_Btn.Name = "UI_UndoLine_Btn";
            this.UI_UndoLine_Btn.Size = new System.Drawing.Size(582, 30);
            this.UI_UndoLine_Btn.TabIndex = 1;
            this.UI_UndoLine_Btn.Text = "Undo Line...";
            this.UI_UndoLine_Btn.UseVisualStyleBackColor = true;
            this.UI_UndoLine_Btn.Click += new System.EventHandler(this.UI_UndoLine_Btn_Click);
            // 
            // UI_ThicknessTrackbar
            // 
            this.UI_ThicknessTrackbar.Location = new System.Drawing.Point(9, 289);
            this.UI_ThicknessTrackbar.Margin = new System.Windows.Forms.Padding(2);
            this.UI_ThicknessTrackbar.Maximum = 255;
            this.UI_ThicknessTrackbar.Name = "UI_ThicknessTrackbar";
            this.UI_ThicknessTrackbar.Size = new System.Drawing.Size(582, 45);
            this.UI_ThicknessTrackbar.TabIndex = 2;
            this.UI_ThicknessTrackbar.TickFrequency = 4;
            this.UI_ThicknessTrackbar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_ThicknessTrackbar.Scroll += new System.EventHandler(this.UI_ThicknessTrackbar_Scroll);
            // 
            // UI_UndoSegment_Btn
            // 
            this.UI_UndoSegment_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_UndoSegment_Btn.Location = new System.Drawing.Point(9, 130);
            this.UI_UndoSegment_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_UndoSegment_Btn.Name = "UI_UndoSegment_Btn";
            this.UI_UndoSegment_Btn.Size = new System.Drawing.Size(582, 30);
            this.UI_UndoSegment_Btn.TabIndex = 3;
            this.UI_UndoSegment_Btn.Text = "Undo Segment...";
            this.UI_UndoSegment_Btn.UseVisualStyleBackColor = true;
            this.UI_UndoSegment_Btn.Click += new System.EventHandler(this.UI_UndoSegment_Btn_Click);
            // 
            // UI_ReduceComplexity_Btn
            // 
            this.UI_ReduceComplexity_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ReduceComplexity_Btn.Location = new System.Drawing.Point(9, 178);
            this.UI_ReduceComplexity_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_ReduceComplexity_Btn.Name = "UI_ReduceComplexity_Btn";
            this.UI_ReduceComplexity_Btn.Size = new System.Drawing.Size(582, 30);
            this.UI_ReduceComplexity_Btn.TabIndex = 4;
            this.UI_ReduceComplexity_Btn.Text = "Reduce Complexity...";
            this.UI_ReduceComplexity_Btn.UseVisualStyleBackColor = true;
            this.UI_ReduceComplexity_Btn.Click += new System.EventHandler(this.ReduceComplexityButton_Click);
            // 
            // UI_Colour_Btn
            // 
            this.UI_Colour_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Colour_Btn.Location = new System.Drawing.Point(9, 228);
            this.UI_Colour_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_Colour_Btn.Name = "UI_Colour_Btn";
            this.UI_Colour_Btn.Size = new System.Drawing.Size(582, 30);
            this.UI_Colour_Btn.TabIndex = 5;
            this.UI_Colour_Btn.Text = "Colour";
            this.UI_Colour_Btn.UseVisualStyleBackColor = true;
            this.UI_Colour_Btn.Click += new System.EventHandler(this.UI_Colour_Btn_Click);
            // 
            // UI_Thickness_Lbl
            // 
            this.UI_Thickness_Lbl.AutoSize = true;
            this.UI_Thickness_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Thickness_Lbl.Location = new System.Drawing.Point(10, 332);
            this.UI_Thickness_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_Thickness_Lbl.Name = "UI_Thickness_Lbl";
            this.UI_Thickness_Lbl.Size = new System.Drawing.Size(80, 17);
            this.UI_Thickness_Lbl.TabIndex = 6;
            this.UI_Thickness_Lbl.Text = "Thickness :";
            // 
            // UI_Alpha_Lbl
            // 
            this.UI_Alpha_Lbl.AutoSize = true;
            this.UI_Alpha_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Alpha_Lbl.Location = new System.Drawing.Point(501, 332);
            this.UI_Alpha_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_Alpha_Lbl.Name = "UI_Alpha_Lbl";
            this.UI_Alpha_Lbl.Size = new System.Drawing.Size(56, 17);
            this.UI_Alpha_Lbl.TabIndex = 7;
            this.UI_Alpha_Lbl.Text = "Alpha  :";
            // 
            // UI_Timer
            // 
            this.UI_Timer.Enabled = true;
            this.UI_Timer.Tick += new System.EventHandler(this.UI_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.UI_Alpha_Lbl);
            this.Controls.Add(this.UI_Thickness_Lbl);
            this.Controls.Add(this.UI_Colour_Btn);
            this.Controls.Add(this.UI_ReduceComplexity_Btn);
            this.Controls.Add(this.UI_UndoSegment_Btn);
            this.Controls.Add(this.UI_ThicknessTrackbar);
            this.Controls.Add(this.UI_UndoLine_Btn);
            this.Controls.Add(this.UI_SegInfoDisplay_Lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_ThicknessTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_SegInfoDisplay_Lbl;
        private System.Windows.Forms.Button UI_UndoLine_Btn;
        private System.Windows.Forms.TrackBar UI_ThicknessTrackbar;
        private System.Windows.Forms.Button UI_UndoSegment_Btn;
        private System.Windows.Forms.Button UI_ReduceComplexity_Btn;
        private System.Windows.Forms.Button UI_Colour_Btn;
        private System.Windows.Forms.Label UI_Thickness_Lbl;
        private System.Windows.Forms.Label UI_Alpha_Lbl;
        private System.Windows.Forms.Timer UI_Timer;
        private System.Windows.Forms.ColorDialog UI_ColorDialog;
    }
}

