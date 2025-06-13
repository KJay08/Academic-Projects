namespace Lab03_SanjayK
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
            this.UI_Play_Btn = new System.Windows.Forms.Button();
            this.UI_ShowScore_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_AnimationSpeed_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_Play_Btn
            // 
            this.UI_Play_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Play_Btn.Location = new System.Drawing.Point(322, 226);
            this.UI_Play_Btn.Name = "UI_Play_Btn";
            this.UI_Play_Btn.Size = new System.Drawing.Size(119, 40);
            this.UI_Play_Btn.TabIndex = 0;
            this.UI_Play_Btn.Text = "Play";
            this.UI_Play_Btn.UseVisualStyleBackColor = true;
            this.UI_Play_Btn.Click += new System.EventHandler(this.UI_Play_Btn_Click);
            // 
            // UI_ShowScore_Cbx
            // 
            this.UI_ShowScore_Cbx.AutoSize = true;
            this.UI_ShowScore_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ShowScore_Cbx.Location = new System.Drawing.Point(73, 86);
            this.UI_ShowScore_Cbx.Name = "UI_ShowScore_Cbx";
            this.UI_ShowScore_Cbx.Size = new System.Drawing.Size(141, 29);
            this.UI_ShowScore_Cbx.TabIndex = 1;
            this.UI_ShowScore_Cbx.Text = "Show Score";
            this.UI_ShowScore_Cbx.UseVisualStyleBackColor = true;
            this.UI_ShowScore_Cbx.CheckedChanged += new System.EventHandler(this.UI_ShowScore_Cbx_CheckedChanged);
            // 
            // UI_AnimationSpeed_Cbx
            // 
            this.UI_AnimationSpeed_Cbx.AutoSize = true;
            this.UI_AnimationSpeed_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AnimationSpeed_Cbx.Location = new System.Drawing.Point(73, 161);
            this.UI_AnimationSpeed_Cbx.Name = "UI_AnimationSpeed_Cbx";
            this.UI_AnimationSpeed_Cbx.Size = new System.Drawing.Size(239, 29);
            this.UI_AnimationSpeed_Cbx.TabIndex = 2;
            this.UI_AnimationSpeed_Cbx.Text = "Show Animation Speed";
            this.UI_AnimationSpeed_Cbx.UseVisualStyleBackColor = true;
            this.UI_AnimationSpeed_Cbx.CheckedChanged += new System.EventHandler(this.UI_AnimationSpeed_Cbx_CheckedChanged);
            // 
            // UI_Timer
            // 
            this.UI_Timer.Enabled = true;
            this.UI_Timer.Tick += new System.EventHandler(this.UI_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 319);
            this.Controls.Add(this.UI_AnimationSpeed_Cbx);
            this.Controls.Add(this.UI_ShowScore_Cbx);
            this.Controls.Add(this.UI_Play_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Play_Btn;
        private System.Windows.Forms.CheckBox UI_ShowScore_Cbx;
        private System.Windows.Forms.CheckBox UI_AnimationSpeed_Cbx;
        private System.Windows.Forms.Timer UI_Timer;
    }
}

