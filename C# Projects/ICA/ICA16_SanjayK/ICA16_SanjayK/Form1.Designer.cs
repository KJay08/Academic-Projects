namespace ICA16_SanjayK
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
            this.UI_LoadFile_Btn = new System.Windows.Forms.Button();
            this.UI_Test_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Find_Btn = new System.Windows.Forms.Button();
            this.UI_SimpleTest_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayFile_Tbx = new System.Windows.Forms.TextBox();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_LoadFile_Btn
            // 
            this.UI_LoadFile_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoadFile_Btn.Location = new System.Drawing.Point(12, 39);
            this.UI_LoadFile_Btn.Name = "UI_LoadFile_Btn";
            this.UI_LoadFile_Btn.Size = new System.Drawing.Size(122, 35);
            this.UI_LoadFile_Btn.TabIndex = 0;
            this.UI_LoadFile_Btn.Text = "Load File";
            this.UI_LoadFile_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadFile_Btn.Click += new System.EventHandler(this.UI_LoadFile_Btn_Click);
            // 
            // UI_Test_Tbx
            // 
            this.UI_Test_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Test_Tbx.Location = new System.Drawing.Point(384, 43);
            this.UI_Test_Tbx.Name = "UI_Test_Tbx";
            this.UI_Test_Tbx.Size = new System.Drawing.Size(276, 27);
            this.UI_Test_Tbx.TabIndex = 1;
            // 
            // UI_Find_Btn
            // 
            this.UI_Find_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Find_Btn.Location = new System.Drawing.Point(140, 39);
            this.UI_Find_Btn.Name = "UI_Find_Btn";
            this.UI_Find_Btn.Size = new System.Drawing.Size(122, 35);
            this.UI_Find_Btn.TabIndex = 2;
            this.UI_Find_Btn.Text = "Find";
            this.UI_Find_Btn.UseVisualStyleBackColor = true;
            this.UI_Find_Btn.Click += new System.EventHandler(this.UI_Find_Btn_Click);
            // 
            // UI_SimpleTest_Btn
            // 
            this.UI_SimpleTest_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SimpleTest_Btn.Location = new System.Drawing.Point(666, 39);
            this.UI_SimpleTest_Btn.Name = "UI_SimpleTest_Btn";
            this.UI_SimpleTest_Btn.Size = new System.Drawing.Size(122, 35);
            this.UI_SimpleTest_Btn.TabIndex = 3;
            this.UI_SimpleTest_Btn.Text = "Simple Test";
            this.UI_SimpleTest_Btn.UseVisualStyleBackColor = true;
            this.UI_SimpleTest_Btn.Click += new System.EventHandler(this.UI_SimpleTest_Btn_Click);
            // 
            // UI_DisplayFile_Tbx
            // 
            this.UI_DisplayFile_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayFile_Tbx.Location = new System.Drawing.Point(12, 92);
            this.UI_DisplayFile_Tbx.Multiline = true;
            this.UI_DisplayFile_Tbx.Name = "UI_DisplayFile_Tbx";
            this.UI_DisplayFile_Tbx.Size = new System.Drawing.Size(776, 320);
            this.UI_DisplayFile_Tbx.TabIndex = 4;
            // 
            // UI_OFD
            // 
            this.UI_OFD.FileName = "openFileDialog1";
            // 
            // UI_Timer
            // 
            this.UI_Timer.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_DisplayFile_Tbx);
            this.Controls.Add(this.UI_SimpleTest_Btn);
            this.Controls.Add(this.UI_Find_Btn);
            this.Controls.Add(this.UI_Test_Tbx);
            this.Controls.Add(this.UI_LoadFile_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_LoadFile_Btn;
        private System.Windows.Forms.TextBox UI_Test_Tbx;
        private System.Windows.Forms.Button UI_Find_Btn;
        private System.Windows.Forms.Button UI_SimpleTest_Btn;
        private System.Windows.Forms.TextBox UI_DisplayFile_Tbx;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
        private System.Windows.Forms.Timer UI_Timer;
    }
}

