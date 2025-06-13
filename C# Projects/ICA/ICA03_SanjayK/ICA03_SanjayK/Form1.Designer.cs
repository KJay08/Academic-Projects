namespace ICA03_SanjayK
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
            this.UI_StartWatch_Btn = new System.Windows.Forms.Button();
            this.UI_StopWatch_Btn = new System.Windows.Forms.Button();
            this.UI_Time_Lbl = new System.Windows.Forms.Label();
            this.UI_Time_Lbx = new System.Windows.Forms.ListBox();
            this.UI_ResetWatch_Btn = new System.Windows.Forms.Button();
            this.UI_SplitWatch_Btn = new System.Windows.Forms.Button();
            this.UI_Change_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_StartWatch_Btn
            // 
            this.UI_StartWatch_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_StartWatch_Btn.Location = new System.Drawing.Point(202, 78);
            this.UI_StartWatch_Btn.Name = "UI_StartWatch_Btn";
            this.UI_StartWatch_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_StartWatch_Btn.TabIndex = 0;
            this.UI_StartWatch_Btn.Text = "Start";
            this.UI_StartWatch_Btn.UseVisualStyleBackColor = true;
            this.UI_StartWatch_Btn.Click += new System.EventHandler(this.UI_StartWatch_Btn_Click);
            // 
            // UI_StopWatch_Btn
            // 
            this.UI_StopWatch_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_StopWatch_Btn.Location = new System.Drawing.Point(202, 124);
            this.UI_StopWatch_Btn.Name = "UI_StopWatch_Btn";
            this.UI_StopWatch_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_StopWatch_Btn.TabIndex = 2;
            this.UI_StopWatch_Btn.Text = "Stop";
            this.UI_StopWatch_Btn.UseVisualStyleBackColor = true;
            this.UI_StopWatch_Btn.Click += new System.EventHandler(this.UI_StopWatch_Btn_Click);
            // 
            // UI_Time_Lbl
            // 
            this.UI_Time_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Time_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Time_Lbl.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Time_Lbl.Location = new System.Drawing.Point(6, 7);
            this.UI_Time_Lbl.Name = "UI_Time_Lbl";
            this.UI_Time_Lbl.Padding = new System.Windows.Forms.Padding(8);
            this.UI_Time_Lbl.Size = new System.Drawing.Size(289, 51);
            this.UI_Time_Lbl.TabIndex = 5;
            this.UI_Time_Lbl.Text = "(0)  00:00:00.00";
            this.UI_Time_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Time_Lbx
            // 
            this.UI_Time_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Time_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Time_Lbx.FormattingEnabled = true;
            this.UI_Time_Lbx.IntegralHeight = false;
            this.UI_Time_Lbx.ItemHeight = 20;
            this.UI_Time_Lbx.Location = new System.Drawing.Point(5, 78);
            this.UI_Time_Lbx.Name = "UI_Time_Lbx";
            this.UI_Time_Lbx.Size = new System.Drawing.Size(168, 342);
            this.UI_Time_Lbx.TabIndex = 4;
            // 
            // UI_ResetWatch_Btn
            // 
            this.UI_ResetWatch_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ResetWatch_Btn.Location = new System.Drawing.Point(202, 169);
            this.UI_ResetWatch_Btn.Name = "UI_ResetWatch_Btn";
            this.UI_ResetWatch_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_ResetWatch_Btn.TabIndex = 3;
            this.UI_ResetWatch_Btn.Text = "Reset";
            this.UI_ResetWatch_Btn.UseVisualStyleBackColor = true;
            this.UI_ResetWatch_Btn.Click += new System.EventHandler(this.UI_ResetWatch_Btn_Click);
            // 
            // UI_SplitWatch_Btn
            // 
            this.UI_SplitWatch_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_SplitWatch_Btn.Location = new System.Drawing.Point(202, 397);
            this.UI_SplitWatch_Btn.Name = "UI_SplitWatch_Btn";
            this.UI_SplitWatch_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_SplitWatch_Btn.TabIndex = 1;
            this.UI_SplitWatch_Btn.Text = "Split";
            this.UI_SplitWatch_Btn.UseVisualStyleBackColor = true;
            this.UI_SplitWatch_Btn.Click += new System.EventHandler(this.UI_SplitWatch_Btn_Click);
            // 
            // UI_Change_Timer
            // 
            this.UI_Change_Timer.Enabled = true;
            this.UI_Change_Timer.Interval = 20;
            this.UI_Change_Timer.Tick += new System.EventHandler(this.UI_Change_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.UI_SplitWatch_Btn);
            this.Controls.Add(this.UI_ResetWatch_Btn);
            this.Controls.Add(this.UI_Time_Lbx);
            this.Controls.Add(this.UI_Time_Lbl);
            this.Controls.Add(this.UI_StopWatch_Btn);
            this.Controls.Add(this.UI_StartWatch_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_StartWatch_Btn;
        private System.Windows.Forms.Button UI_StopWatch_Btn;
        private System.Windows.Forms.Label UI_Time_Lbl;
        private System.Windows.Forms.ListBox UI_Time_Lbx;
        private System.Windows.Forms.Button UI_ResetWatch_Btn;
        private System.Windows.Forms.Button UI_SplitWatch_Btn;
        private System.Windows.Forms.Timer UI_Change_Timer;
    }
}

