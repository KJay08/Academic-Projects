namespace ICA06_SanjayK
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
            this.UI_DisplayData_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_DisplayCount_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayMaximum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DisplayMinimum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DisplayCount_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DisplayMinimum_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayMaximum_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DisplayData_Tbx
            // 
            this.UI_DisplayData_Tbx.AllowDrop = true;
            this.UI_DisplayData_Tbx.Location = new System.Drawing.Point(37, 102);
            this.UI_DisplayData_Tbx.Multiline = true;
            this.UI_DisplayData_Tbx.Name = "UI_DisplayData_Tbx";
            this.UI_DisplayData_Tbx.ReadOnly = true;
            this.UI_DisplayData_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_DisplayData_Tbx.Size = new System.Drawing.Size(245, 324);
            this.UI_DisplayData_Tbx.TabIndex = 0;
            this.UI_DisplayData_Tbx.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DisplayData_Tbx_DragDrop);
            this.UI_DisplayData_Tbx.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DisplayData_Tbx_DragEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag Drop Your File On The List Box";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_DisplayCount_Btn
            // 
            this.UI_DisplayCount_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayCount_Btn.Location = new System.Drawing.Point(312, 143);
            this.UI_DisplayCount_Btn.Name = "UI_DisplayCount_Btn";
            this.UI_DisplayCount_Btn.Size = new System.Drawing.Size(170, 32);
            this.UI_DisplayCount_Btn.TabIndex = 2;
            this.UI_DisplayCount_Btn.Text = "Display Count";
            this.UI_DisplayCount_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayCount_Btn.Click += new System.EventHandler(this.UI_DisplayCount_Btn_Click);
            // 
            // UI_DisplayMaximum_Tbx
            // 
            this.UI_DisplayMaximum_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayMaximum_Tbx.Location = new System.Drawing.Point(677, 228);
            this.UI_DisplayMaximum_Tbx.Name = "UI_DisplayMaximum_Tbx";
            this.UI_DisplayMaximum_Tbx.Size = new System.Drawing.Size(111, 30);
            this.UI_DisplayMaximum_Tbx.TabIndex = 3;
            // 
            // UI_DisplayMinimum_Tbx
            // 
            this.UI_DisplayMinimum_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayMinimum_Tbx.Location = new System.Drawing.Point(677, 181);
            this.UI_DisplayMinimum_Tbx.Name = "UI_DisplayMinimum_Tbx";
            this.UI_DisplayMinimum_Tbx.Size = new System.Drawing.Size(111, 30);
            this.UI_DisplayMinimum_Tbx.TabIndex = 4;
            // 
            // UI_DisplayCount_Tbx
            // 
            this.UI_DisplayCount_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayCount_Tbx.Location = new System.Drawing.Point(677, 142);
            this.UI_DisplayCount_Tbx.Name = "UI_DisplayCount_Tbx";
            this.UI_DisplayCount_Tbx.Size = new System.Drawing.Size(111, 30);
            this.UI_DisplayCount_Tbx.TabIndex = 5;
            // 
            // UI_DisplayMinimum_Btn
            // 
            this.UI_DisplayMinimum_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayMinimum_Btn.Location = new System.Drawing.Point(312, 183);
            this.UI_DisplayMinimum_Btn.Name = "UI_DisplayMinimum_Btn";
            this.UI_DisplayMinimum_Btn.Size = new System.Drawing.Size(170, 32);
            this.UI_DisplayMinimum_Btn.TabIndex = 6;
            this.UI_DisplayMinimum_Btn.Text = "Display Minimum";
            this.UI_DisplayMinimum_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayMinimum_Btn.Click += new System.EventHandler(this.UI_DisplayMinimum_Btn_Click);
            // 
            // UI_DisplayMaximum_Btn
            // 
            this.UI_DisplayMaximum_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayMaximum_Btn.Location = new System.Drawing.Point(312, 230);
            this.UI_DisplayMaximum_Btn.Name = "UI_DisplayMaximum_Btn";
            this.UI_DisplayMaximum_Btn.Size = new System.Drawing.Size(170, 32);
            this.UI_DisplayMaximum_Btn.TabIndex = 7;
            this.UI_DisplayMaximum_Btn.Text = "Display Maximum";
            this.UI_DisplayMaximum_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayMaximum_Btn.Click += new System.EventHandler(this.UI_DisplayMaximum_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Values :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Minimum Value :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maximum Value :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_DisplayMaximum_Btn);
            this.Controls.Add(this.UI_DisplayMinimum_Btn);
            this.Controls.Add(this.UI_DisplayCount_Tbx);
            this.Controls.Add(this.UI_DisplayMinimum_Tbx);
            this.Controls.Add(this.UI_DisplayMaximum_Tbx);
            this.Controls.Add(this.UI_DisplayCount_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_DisplayData_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_DisplayData_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_DisplayCount_Btn;
        private System.Windows.Forms.TextBox UI_DisplayMaximum_Tbx;
        private System.Windows.Forms.TextBox UI_DisplayMinimum_Tbx;
        private System.Windows.Forms.TextBox UI_DisplayCount_Tbx;
        private System.Windows.Forms.Button UI_DisplayMinimum_Btn;
        private System.Windows.Forms.Button UI_DisplayMaximum_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

