namespace ICA13_SanjayK
{
    partial class ModalDialogForm
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
            this.UI_SelectFont_Btn = new System.Windows.Forms.Button();
            this.UI_SelectColour_Btn = new System.Windows.Forms.Button();
            this.UI_Font_Lbl = new System.Windows.Forms.Label();
            this.UI_Colour_Lbl = new System.Windows.Forms.Label();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_ColorDialog = new System.Windows.Forms.ColorDialog();
            this.UI_FontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // UI_SelectFont_Btn
            // 
            this.UI_SelectFont_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SelectFont_Btn.Location = new System.Drawing.Point(35, 113);
            this.UI_SelectFont_Btn.Name = "UI_SelectFont_Btn";
            this.UI_SelectFont_Btn.Size = new System.Drawing.Size(111, 33);
            this.UI_SelectFont_Btn.TabIndex = 0;
            this.UI_SelectFont_Btn.Text = "Select Font";
            this.UI_SelectFont_Btn.UseVisualStyleBackColor = true;
            this.UI_SelectFont_Btn.Click += new System.EventHandler(this.UI_SelectFont_Btn_Click);
            // 
            // UI_SelectColour_Btn
            // 
            this.UI_SelectColour_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SelectColour_Btn.Location = new System.Drawing.Point(35, 172);
            this.UI_SelectColour_Btn.Name = "UI_SelectColour_Btn";
            this.UI_SelectColour_Btn.Size = new System.Drawing.Size(111, 33);
            this.UI_SelectColour_Btn.TabIndex = 1;
            this.UI_SelectColour_Btn.Text = "Select Colour";
            this.UI_SelectColour_Btn.UseVisualStyleBackColor = true;
            this.UI_SelectColour_Btn.Click += new System.EventHandler(this.UI_SelectColour_Btn_Click);
            // 
            // UI_Font_Lbl
            // 
            this.UI_Font_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Font_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Font_Lbl.Location = new System.Drawing.Point(165, 113);
            this.UI_Font_Lbl.Name = "UI_Font_Lbl";
            this.UI_Font_Lbl.Size = new System.Drawing.Size(599, 33);
            this.UI_Font_Lbl.TabIndex = 2;
            this.UI_Font_Lbl.Text = "label1";
            this.UI_Font_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Colour_Lbl
            // 
            this.UI_Colour_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Colour_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Colour_Lbl.Location = new System.Drawing.Point(165, 172);
            this.UI_Colour_Lbl.Name = "UI_Colour_Lbl";
            this.UI_Colour_Lbl.Size = new System.Drawing.Size(599, 33);
            this.UI_Colour_Lbl.TabIndex = 3;
            this.UI_Colour_Lbl.Text = "label1";
            this.UI_Colour_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_OK_Btn.Location = new System.Drawing.Point(323, 342);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(117, 31);
            this.UI_OK_Btn.TabIndex = 4;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // ModalDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_Colour_Lbl);
            this.Controls.Add(this.UI_Font_Lbl);
            this.Controls.Add(this.UI_SelectColour_Btn);
            this.Controls.Add(this.UI_SelectFont_Btn);
            this.Name = "ModalDialogForm";
            this.Text = "ModalDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_SelectFont_Btn;
        private System.Windows.Forms.Button UI_SelectColour_Btn;
        private System.Windows.Forms.Label UI_Font_Lbl;
        private System.Windows.Forms.Label UI_Colour_Lbl;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.ColorDialog UI_ColorDialog;
        private System.Windows.Forms.FontDialog UI_FontDialog;
    }
}