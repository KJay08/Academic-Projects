namespace ICA10_SanjayK
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Trackbar_Bar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_ColorDialog_Lbl = new System.Windows.Forms.Label();
            this.UI_Generate_Btn = new System.Windows.Forms.Button();
            this.UI_FillColor_Btn = new System.Windows.Forms.Button();
            this.UI_Fill_Btn = new System.Windows.Forms.Button();
            this.UI_ColorDialog = new System.Windows.Forms.ColorDialog();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Trackbar_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Block";
            // 
            // UI_Trackbar_Bar
            // 
            this.UI_Trackbar_Bar.Location = new System.Drawing.Point(38, 65);
            this.UI_Trackbar_Bar.Maximum = 3000;
            this.UI_Trackbar_Bar.Minimum = 100;
            this.UI_Trackbar_Bar.Name = "UI_Trackbar_Bar";
            this.UI_Trackbar_Bar.Size = new System.Drawing.Size(720, 45);
            this.UI_Trackbar_Bar.TabIndex = 1;
            this.UI_Trackbar_Bar.TickFrequency = 100;
            this.UI_Trackbar_Bar.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "3000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fill Colors : ";
            // 
            // UI_ColorDialog_Lbl
            // 
            this.UI_ColorDialog_Lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UI_ColorDialog_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ColorDialog_Lbl.Location = new System.Drawing.Point(378, 180);
            this.UI_ColorDialog_Lbl.Name = "UI_ColorDialog_Lbl";
            this.UI_ColorDialog_Lbl.Size = new System.Drawing.Size(70, 34);
            this.UI_ColorDialog_Lbl.TabIndex = 5;
            // 
            // UI_Generate_Btn
            // 
            this.UI_Generate_Btn.Location = new System.Drawing.Point(68, 314);
            this.UI_Generate_Btn.Name = "UI_Generate_Btn";
            this.UI_Generate_Btn.Size = new System.Drawing.Size(95, 23);
            this.UI_Generate_Btn.TabIndex = 6;
            this.UI_Generate_Btn.Text = "Generate";
            this.UI_Generate_Btn.UseVisualStyleBackColor = true;
            this.UI_Generate_Btn.Click += new System.EventHandler(this.UI_Generate_Btn_Click);
            // 
            // UI_FillColor_Btn
            // 
            this.UI_FillColor_Btn.Location = new System.Drawing.Point(315, 314);
            this.UI_FillColor_Btn.Name = "UI_FillColor_Btn";
            this.UI_FillColor_Btn.Size = new System.Drawing.Size(95, 23);
            this.UI_FillColor_Btn.TabIndex = 7;
            this.UI_FillColor_Btn.Text = "Fill Color";
            this.UI_FillColor_Btn.UseVisualStyleBackColor = true;
            this.UI_FillColor_Btn.Click += new System.EventHandler(this.UI_FillColor_Btn_Click);
            // 
            // UI_Fill_Btn
            // 
            this.UI_Fill_Btn.Location = new System.Drawing.Point(580, 314);
            this.UI_Fill_Btn.Name = "UI_Fill_Btn";
            this.UI_Fill_Btn.Size = new System.Drawing.Size(95, 23);
            this.UI_Fill_Btn.TabIndex = 8;
            this.UI_Fill_Btn.Text = "Fill";
            this.UI_Fill_Btn.UseVisualStyleBackColor = true;
            this.UI_Fill_Btn.Click += new System.EventHandler(this.UI_Fill_Btn_Click);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Fill_Btn);
            this.Controls.Add(this.UI_FillColor_Btn);
            this.Controls.Add(this.UI_Generate_Btn);
            this.Controls.Add(this.UI_ColorDialog_Lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_Trackbar_Bar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_Trackbar_Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar UI_Trackbar_Bar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UI_ColorDialog_Lbl;
        private System.Windows.Forms.Button UI_Generate_Btn;
        private System.Windows.Forms.Button UI_FillColor_Btn;
        private System.Windows.Forms.Button UI_Fill_Btn;
        private System.Windows.Forms.ColorDialog UI_ColorDialog;
        private System.Windows.Forms.Timer UI_Timer;
    }
}

