namespace ICA19_SanjayK
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
            this.UI_NewPost_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_AddPost_Btn = new System.Windows.Forms.Button();
            this.UI_IdInput_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DeleteLastPost_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_DeleteById_Btn = new System.Windows.Forms.Button();
            this.UI_PostedMessage_Lbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_NewPost_Tbx
            // 
            this.UI_NewPost_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_NewPost_Tbx.Location = new System.Drawing.Point(12, 53);
            this.UI_NewPost_Tbx.Multiline = true;
            this.UI_NewPost_Tbx.Name = "UI_NewPost_Tbx";
            this.UI_NewPost_Tbx.Size = new System.Drawing.Size(537, 53);
            this.UI_NewPost_Tbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Post";
            // 
            // UI_AddPost_Btn
            // 
            this.UI_AddPost_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_AddPost_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AddPost_Btn.Location = new System.Drawing.Point(574, 65);
            this.UI_AddPost_Btn.Name = "UI_AddPost_Btn";
            this.UI_AddPost_Btn.Size = new System.Drawing.Size(141, 32);
            this.UI_AddPost_Btn.TabIndex = 2;
            this.UI_AddPost_Btn.Text = "Add Post";
            this.UI_AddPost_Btn.UseVisualStyleBackColor = true;
            this.UI_AddPost_Btn.Click += new System.EventHandler(this.UI_AddPost_Btn_Click);
            // 
            // UI_IdInput_Tbx
            // 
            this.UI_IdInput_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_IdInput_Tbx.Location = new System.Drawing.Point(628, 263);
            this.UI_IdInput_Tbx.Name = "UI_IdInput_Tbx";
            this.UI_IdInput_Tbx.Size = new System.Drawing.Size(129, 20);
            this.UI_IdInput_Tbx.TabIndex = 3;
            this.UI_IdInput_Tbx.TextChanged += new System.EventHandler(this.UI_IdInput_Tbx_TextChanged);
            // 
            // UI_DeleteLastPost_Btn
            // 
            this.UI_DeleteLastPost_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DeleteLastPost_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DeleteLastPost_Btn.Location = new System.Drawing.Point(628, 161);
            this.UI_DeleteLastPost_Btn.Name = "UI_DeleteLastPost_Btn";
            this.UI_DeleteLastPost_Btn.Size = new System.Drawing.Size(129, 42);
            this.UI_DeleteLastPost_Btn.TabIndex = 4;
            this.UI_DeleteLastPost_Btn.Text = "Delete Last Post";
            this.UI_DeleteLastPost_Btn.UseVisualStyleBackColor = true;
            this.UI_DeleteLastPost_Btn.Click += new System.EventHandler(this.UI_DeleteLastPost_Btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID to Delegate";
            // 
            // UI_DeleteById_Btn
            // 
            this.UI_DeleteById_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DeleteById_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DeleteById_Btn.Location = new System.Drawing.Point(628, 289);
            this.UI_DeleteById_Btn.Name = "UI_DeleteById_Btn";
            this.UI_DeleteById_Btn.Size = new System.Drawing.Size(129, 42);
            this.UI_DeleteById_Btn.TabIndex = 6;
            this.UI_DeleteById_Btn.Text = "Delete Post By Id";
            this.UI_DeleteById_Btn.UseVisualStyleBackColor = true;
            this.UI_DeleteById_Btn.Click += new System.EventHandler(this.UI_DeleteById_Btn_Click);
            // 
            // UI_PostedMessage_Lbx
            // 
            this.UI_PostedMessage_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_PostedMessage_Lbx.FormattingEnabled = true;
            this.UI_PostedMessage_Lbx.Location = new System.Drawing.Point(12, 161);
            this.UI_PostedMessage_Lbx.Name = "UI_PostedMessage_Lbx";
            this.UI_PostedMessage_Lbx.Size = new System.Drawing.Size(537, 264);
            this.UI_PostedMessage_Lbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Posted Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_PostedMessage_Lbx);
            this.Controls.Add(this.UI_DeleteById_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_DeleteLastPost_Btn);
            this.Controls.Add(this.UI_IdInput_Tbx);
            this.Controls.Add(this.UI_AddPost_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_NewPost_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_NewPost_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_AddPost_Btn;
        private System.Windows.Forms.TextBox UI_IdInput_Tbx;
        private System.Windows.Forms.Button UI_DeleteLastPost_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_DeleteById_Btn;
        private System.Windows.Forms.ListBox UI_PostedMessage_Lbx;
        private System.Windows.Forms.Label label3;
    }
}

