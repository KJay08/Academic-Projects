namespace ICA07_SanjayK
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
            this.UI_InitialValues_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_ClearSortedTbx_Btn = new System.Windows.Forms.Button();
            this.UI_SelectionSort_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_InsertionSort_Radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_SortedValues_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SetValues_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_SortingTime_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DragAndDrop_Lbl = new System.Windows.Forms.Label();
            this.UI_SortingTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_InitialValues_Tbx
            // 
            this.UI_InitialValues_Tbx.Location = new System.Drawing.Point(20, 83);
            this.UI_InitialValues_Tbx.Multiline = true;
            this.UI_InitialValues_Tbx.Name = "UI_InitialValues_Tbx";
            this.UI_InitialValues_Tbx.ReadOnly = true;
            this.UI_InitialValues_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_InitialValues_Tbx.Size = new System.Drawing.Size(298, 323);
            this.UI_InitialValues_Tbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Values";
            // 
            // UI_ClearSortedTbx_Btn
            // 
            this.UI_ClearSortedTbx_Btn.Location = new System.Drawing.Point(728, 431);
            this.UI_ClearSortedTbx_Btn.Name = "UI_ClearSortedTbx_Btn";
            this.UI_ClearSortedTbx_Btn.Size = new System.Drawing.Size(109, 28);
            this.UI_ClearSortedTbx_Btn.TabIndex = 2;
            this.UI_ClearSortedTbx_Btn.Text = "Clear Sorted";
            this.UI_ClearSortedTbx_Btn.UseVisualStyleBackColor = true;
            this.UI_ClearSortedTbx_Btn.Click += new System.EventHandler(this.UI_ClearSortedTbx_Btn_Click_1);
            // 
            // UI_SelectionSort_Radio
            // 
            this.UI_SelectionSort_Radio.AutoSize = true;
            this.UI_SelectionSort_Radio.Location = new System.Drawing.Point(29, 32);
            this.UI_SelectionSort_Radio.Name = "UI_SelectionSort_Radio";
            this.UI_SelectionSort_Radio.Size = new System.Drawing.Size(101, 19);
            this.UI_SelectionSort_Radio.TabIndex = 3;
            this.UI_SelectionSort_Radio.TabStop = true;
            this.UI_SelectionSort_Radio.Text = "Selection Sort";
            this.UI_SelectionSort_Radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_InsertionSort_Radio);
            this.groupBox1.Controls.Add(this.UI_SelectionSort_Radio);
            this.groupBox1.Location = new System.Drawing.Point(379, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting Method";
            // 
            // UI_InsertionSort_Radio
            // 
            this.UI_InsertionSort_Radio.AutoSize = true;
            this.UI_InsertionSort_Radio.Location = new System.Drawing.Point(29, 72);
            this.UI_InsertionSort_Radio.Name = "UI_InsertionSort_Radio";
            this.UI_InsertionSort_Radio.Size = new System.Drawing.Size(97, 19);
            this.UI_InsertionSort_Radio.TabIndex = 4;
            this.UI_InsertionSort_Radio.TabStop = true;
            this.UI_InsertionSort_Radio.Text = "Insertion Sort";
            this.UI_InsertionSort_Radio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sorted Values";
            // 
            // UI_SortedValues_Tbx
            // 
            this.UI_SortedValues_Tbx.AllowDrop = true;
            this.UI_SortedValues_Tbx.Location = new System.Drawing.Point(650, 83);
            this.UI_SortedValues_Tbx.Multiline = true;
            this.UI_SortedValues_Tbx.Name = "UI_SortedValues_Tbx";
            this.UI_SortedValues_Tbx.ReadOnly = true;
            this.UI_SortedValues_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_SortedValues_Tbx.Size = new System.Drawing.Size(298, 323);
            this.UI_SortedValues_Tbx.TabIndex = 5;
            // 
            // UI_SetValues_Btn
            // 
            this.UI_SetValues_Btn.Location = new System.Drawing.Point(436, 260);
            this.UI_SetValues_Btn.Name = "UI_SetValues_Btn";
            this.UI_SetValues_Btn.Size = new System.Drawing.Size(94, 27);
            this.UI_SetValues_Btn.TabIndex = 7;
            this.UI_SetValues_Btn.Text = "Set Values";
            this.UI_SetValues_Btn.UseVisualStyleBackColor = true;
            this.UI_SetValues_Btn.Click += new System.EventHandler(this.UI_SetValues_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sorting Time (ticks) :";
            // 
            // UI_SortingTime_Tbx
            // 
            this.UI_SortingTime_Tbx.Location = new System.Drawing.Point(430, 353);
            this.UI_SortingTime_Tbx.Name = "UI_SortingTime_Tbx";
            this.UI_SortingTime_Tbx.Size = new System.Drawing.Size(100, 21);
            this.UI_SortingTime_Tbx.TabIndex = 9;
            // 
            // UI_DragAndDrop_Lbl
            // 
            this.UI_DragAndDrop_Lbl.AllowDrop = true;
            this.UI_DragAndDrop_Lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UI_DragAndDrop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DragAndDrop_Lbl.Location = new System.Drawing.Point(66, 431);
            this.UI_DragAndDrop_Lbl.Name = "UI_DragAndDrop_Lbl";
            this.UI_DragAndDrop_Lbl.Size = new System.Drawing.Size(163, 53);
            this.UI_DragAndDrop_Lbl.TabIndex = 10;
            this.UI_DragAndDrop_Lbl.Text = "Drag And Drop Your File Here";
            this.UI_DragAndDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragAndDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragDrop);
            this.UI_DragAndDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragEnter);
            // 
            // UI_SortingTimer
            // 
            this.UI_SortingTimer.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 506);
            this.Controls.Add(this.UI_DragAndDrop_Lbl);
            this.Controls.Add(this.UI_SortingTime_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_SetValues_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_SortedValues_Tbx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_ClearSortedTbx_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_InitialValues_Tbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_InitialValues_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_ClearSortedTbx_Btn;
        private System.Windows.Forms.RadioButton UI_SelectionSort_Radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_InsertionSort_Radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UI_SortedValues_Tbx;
        private System.Windows.Forms.Button UI_SetValues_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_SortingTime_Tbx;
        private System.Windows.Forms.Label UI_DragAndDrop_Lbl;
        private System.Windows.Forms.Timer UI_SortingTimer;
    }
}

