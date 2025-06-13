namespace ICA11_SanjayK
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_EntryNames_Lbx = new System.Windows.Forms.ListBox();
            this.UI_InputSearch_Tbx = new System.Windows.Forms.TextBox();
            this.UI_AddName_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_SearchName_Btn = new System.Windows.Forms.Button();
            this.UI_SortedNames_Lbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Names (Order of Entry)";
            // 
            // UI_EntryNames_Lbx
            // 
            this.UI_EntryNames_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_EntryNames_Lbx.FormattingEnabled = true;
            this.UI_EntryNames_Lbx.ItemHeight = 16;
            this.UI_EntryNames_Lbx.Location = new System.Drawing.Point(25, 64);
            this.UI_EntryNames_Lbx.Name = "UI_EntryNames_Lbx";
            this.UI_EntryNames_Lbx.Size = new System.Drawing.Size(207, 324);
            this.UI_EntryNames_Lbx.TabIndex = 1;
            // 
            // UI_InputSearch_Tbx
            // 
            this.UI_InputSearch_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_InputSearch_Tbx.Location = new System.Drawing.Point(325, 90);
            this.UI_InputSearch_Tbx.Name = "UI_InputSearch_Tbx";
            this.UI_InputSearch_Tbx.Size = new System.Drawing.Size(202, 22);
            this.UI_InputSearch_Tbx.TabIndex = 2;
            // 
            // UI_AddName_Btn
            // 
            this.UI_AddName_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AddName_Btn.Location = new System.Drawing.Point(325, 157);
            this.UI_AddName_Btn.Name = "UI_AddName_Btn";
            this.UI_AddName_Btn.Size = new System.Drawing.Size(156, 44);
            this.UI_AddName_Btn.TabIndex = 3;
            this.UI_AddName_Btn.Text = "Add Name";
            this.UI_AddName_Btn.UseVisualStyleBackColor = true;
            this.UI_AddName_Btn.Click += new System.EventHandler(this.UI_AddName_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name : ";
            // 
            // UI_SearchName_Btn
            // 
            this.UI_SearchName_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SearchName_Btn.Location = new System.Drawing.Point(325, 232);
            this.UI_SearchName_Btn.Name = "UI_SearchName_Btn";
            this.UI_SearchName_Btn.Size = new System.Drawing.Size(156, 44);
            this.UI_SearchName_Btn.TabIndex = 5;
            this.UI_SearchName_Btn.Text = "Search";
            this.UI_SearchName_Btn.UseVisualStyleBackColor = true;
            this.UI_SearchName_Btn.Click += new System.EventHandler(this.UI_SearchName_Btn_Click);
            // 
            // UI_SortedNames_Lbx
            // 
            this.UI_SortedNames_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SortedNames_Lbx.FormattingEnabled = true;
            this.UI_SortedNames_Lbx.ItemHeight = 16;
            this.UI_SortedNames_Lbx.Location = new System.Drawing.Point(557, 64);
            this.UI_SortedNames_Lbx.Name = "UI_SortedNames_Lbx";
            this.UI_SortedNames_Lbx.Size = new System.Drawing.Size(207, 324);
            this.UI_SortedNames_Lbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "List of Names (Sorted)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_SortedNames_Lbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_SearchName_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_AddName_Btn);
            this.Controls.Add(this.UI_InputSearch_Tbx);
            this.Controls.Add(this.UI_EntryNames_Lbx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox UI_EntryNames_Lbx;
        private System.Windows.Forms.TextBox UI_InputSearch_Tbx;
        private System.Windows.Forms.Button UI_AddName_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_SearchName_Btn;
        private System.Windows.Forms.ListBox UI_SortedNames_Lbx;
        private System.Windows.Forms.Label label3;
    }
}

