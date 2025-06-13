namespace Lab02_SanjayK
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
            this.UI_UnsortedData_DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UI_SortedData_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_DisplayUnsorted_Btn = new System.Windows.Forms.Button();
            this.UI_ClearUnsorted_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_FileData_Radio = new System.Windows.Forms.RadioButton();
            this.UI_ProvidedList_Radio = new System.Windows.Forms.RadioButton();
            this.UI_SortByEmployeeID_Btn = new System.Windows.Forms.Button();
            this.UI_SortByLastNames_Btn = new System.Windows.Forms.Button();
            this.UI_ClearSorted_Btn = new System.Windows.Forms.Button();
            this.UI_OFD_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_Timer_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.UI_MainFile_OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_UnsortedData_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_SortedData_DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_UnsortedData_DGV
            // 
            this.UI_UnsortedData_DGV.AllowUserToAddRows = false;
            this.UI_UnsortedData_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_UnsortedData_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.UI_UnsortedData_DGV.Location = new System.Drawing.Point(22, 45);
            this.UI_UnsortedData_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.UI_UnsortedData_DGV.Name = "UI_UnsortedData_DGV";
            this.UI_UnsortedData_DGV.RowHeadersVisible = false;
            this.UI_UnsortedData_DGV.RowHeadersWidth = 51;
            this.UI_UnsortedData_DGV.RowTemplate.Height = 24;
            this.UI_UnsortedData_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UI_UnsortedData_DGV.Size = new System.Drawing.Size(341, 349);
            this.UI_UnsortedData_DGV.TabIndex = 0;
            this.UI_UnsortedData_DGV.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_UnsortedData_DGV_DragDrop);
            this.UI_UnsortedData_DGV.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_UnsortedData_DGV_DragEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 150;
            // 
            // UI_SortedData_DGV
            // 
            this.UI_SortedData_DGV.AllowUserToAddRows = false;
            this.UI_SortedData_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_SortedData_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.UI_SortedData_DGV.Location = new System.Drawing.Point(568, 45);
            this.UI_SortedData_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.UI_SortedData_DGV.Name = "UI_SortedData_DGV";
            this.UI_SortedData_DGV.RowHeadersVisible = false;
            this.UI_SortedData_DGV.RowHeadersWidth = 51;
            this.UI_SortedData_DGV.RowTemplate.Height = 24;
            this.UI_SortedData_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UI_SortedData_DGV.Size = new System.Drawing.Size(341, 349);
            this.UI_SortedData_DGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unsorted Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorted Data";
            // 
            // UI_DisplayUnsorted_Btn
            // 
            this.UI_DisplayUnsorted_Btn.Location = new System.Drawing.Point(412, 41);
            this.UI_DisplayUnsorted_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_DisplayUnsorted_Btn.Name = "UI_DisplayUnsorted_Btn";
            this.UI_DisplayUnsorted_Btn.Size = new System.Drawing.Size(114, 41);
            this.UI_DisplayUnsorted_Btn.TabIndex = 4;
            this.UI_DisplayUnsorted_Btn.Text = "Display Unsorted List";
            this.UI_DisplayUnsorted_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayUnsorted_Btn.Click += new System.EventHandler(this.UI_DisplayUnsorted_Btn_Click);
            // 
            // UI_ClearUnsorted_Btn
            // 
            this.UI_ClearUnsorted_Btn.Location = new System.Drawing.Point(412, 87);
            this.UI_ClearUnsorted_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_ClearUnsorted_Btn.Name = "UI_ClearUnsorted_Btn";
            this.UI_ClearUnsorted_Btn.Size = new System.Drawing.Size(114, 41);
            this.UI_ClearUnsorted_Btn.TabIndex = 5;
            this.UI_ClearUnsorted_Btn.Text = "Clear Unsorted Data Grid";
            this.UI_ClearUnsorted_Btn.UseVisualStyleBackColor = true;
            this.UI_ClearUnsorted_Btn.Click += new System.EventHandler(this.UI_ClearUnsorted_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_FileData_Radio);
            this.groupBox1.Controls.Add(this.UI_ProvidedList_Radio);
            this.groupBox1.Location = new System.Drawing.Point(405, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(128, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // UI_FileData_Radio
            // 
            this.UI_FileData_Radio.AutoSize = true;
            this.UI_FileData_Radio.Location = new System.Drawing.Point(14, 48);
            this.UI_FileData_Radio.Margin = new System.Windows.Forms.Padding(2);
            this.UI_FileData_Radio.Name = "UI_FileData_Radio";
            this.UI_FileData_Radio.Size = new System.Drawing.Size(67, 17);
            this.UI_FileData_Radio.TabIndex = 1;
            this.UI_FileData_Radio.TabStop = true;
            this.UI_FileData_Radio.Text = "File Data";
            this.UI_FileData_Radio.UseVisualStyleBackColor = true;
            this.UI_FileData_Radio.CheckedChanged += new System.EventHandler(this.UI_FileData_Radio_CheckedChanged);
            // 
            // UI_ProvidedList_Radio
            // 
            this.UI_ProvidedList_Radio.AutoSize = true;
            this.UI_ProvidedList_Radio.Location = new System.Drawing.Point(14, 24);
            this.UI_ProvidedList_Radio.Margin = new System.Windows.Forms.Padding(2);
            this.UI_ProvidedList_Radio.Name = "UI_ProvidedList_Radio";
            this.UI_ProvidedList_Radio.Size = new System.Drawing.Size(86, 17);
            this.UI_ProvidedList_Radio.TabIndex = 0;
            this.UI_ProvidedList_Radio.TabStop = true;
            this.UI_ProvidedList_Radio.Text = "Provided List";
            this.UI_ProvidedList_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_SortByEmployeeID_Btn
            // 
            this.UI_SortByEmployeeID_Btn.Location = new System.Drawing.Point(412, 240);
            this.UI_SortByEmployeeID_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_SortByEmployeeID_Btn.Name = "UI_SortByEmployeeID_Btn";
            this.UI_SortByEmployeeID_Btn.Size = new System.Drawing.Size(114, 32);
            this.UI_SortByEmployeeID_Btn.TabIndex = 7;
            this.UI_SortByEmployeeID_Btn.Text = "Sort By EmployeeID";
            this.UI_SortByEmployeeID_Btn.UseVisualStyleBackColor = true;
            this.UI_SortByEmployeeID_Btn.Click += new System.EventHandler(this.UI_SortByEmployeeID_Btn_Click);
            // 
            // UI_SortByLastNames_Btn
            // 
            this.UI_SortByLastNames_Btn.Location = new System.Drawing.Point(412, 277);
            this.UI_SortByLastNames_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_SortByLastNames_Btn.Name = "UI_SortByLastNames_Btn";
            this.UI_SortByLastNames_Btn.Size = new System.Drawing.Size(114, 32);
            this.UI_SortByLastNames_Btn.TabIndex = 8;
            this.UI_SortByLastNames_Btn.Text = "Sort By Last Names";
            this.UI_SortByLastNames_Btn.UseVisualStyleBackColor = true;
            this.UI_SortByLastNames_Btn.Click += new System.EventHandler(this.UI_SortByLastNames_Btn_Click);
            // 
            // UI_ClearSorted_Btn
            // 
            this.UI_ClearSorted_Btn.Location = new System.Drawing.Point(412, 314);
            this.UI_ClearSorted_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_ClearSorted_Btn.Name = "UI_ClearSorted_Btn";
            this.UI_ClearSorted_Btn.Size = new System.Drawing.Size(114, 41);
            this.UI_ClearSorted_Btn.TabIndex = 9;
            this.UI_ClearSorted_Btn.Text = "Clear Sorted Data Grid";
            this.UI_ClearSorted_Btn.UseVisualStyleBackColor = true;
            this.UI_ClearSorted_Btn.Click += new System.EventHandler(this.UI_ClearSorted_Btn_Click);
            // 
            // UI_OFD_Btn
            // 
            this.UI_OFD_Btn.Enabled = false;
            this.UI_OFD_Btn.Location = new System.Drawing.Point(412, 363);
            this.UI_OFD_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_OFD_Btn.Name = "UI_OFD_Btn";
            this.UI_OFD_Btn.Size = new System.Drawing.Size(114, 41);
            this.UI_OFD_Btn.TabIndex = 10;
            this.UI_OFD_Btn.Text = "Open File Through OFD";
            this.UI_OFD_Btn.UseVisualStyleBackColor = true;
            this.UI_OFD_Btn.Click += new System.EventHandler(this.UI_OFD_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time Taken (Elapsed Ticks) : ";
            // 
            // UI_Timer_Tbx
            // 
            this.UI_Timer_Tbx.Location = new System.Drawing.Point(788, 421);
            this.UI_Timer_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.UI_Timer_Tbx.Name = "UI_Timer_Tbx";
            this.UI_Timer_Tbx.ReadOnly = true;
            this.UI_Timer_Tbx.Size = new System.Drawing.Size(112, 20);
            this.UI_Timer_Tbx.TabIndex = 12;
            // 
            // UI_MainFile_OFD
            // 
            this.UI_MainFile_OFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 454);
            this.Controls.Add(this.UI_Timer_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_OFD_Btn);
            this.Controls.Add(this.UI_ClearSorted_Btn);
            this.Controls.Add(this.UI_SortByLastNames_Btn);
            this.Controls.Add(this.UI_SortByEmployeeID_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_ClearUnsorted_Btn);
            this.Controls.Add(this.UI_DisplayUnsorted_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_SortedData_DGV);
            this.Controls.Add(this.UI_UnsortedData_DGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_UnsortedData_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_SortedData_DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView UI_UnsortedData_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView UI_SortedData_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_DisplayUnsorted_Btn;
        private System.Windows.Forms.Button UI_ClearUnsorted_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_FileData_Radio;
        private System.Windows.Forms.RadioButton UI_ProvidedList_Radio;
        private System.Windows.Forms.Button UI_SortByEmployeeID_Btn;
        private System.Windows.Forms.Button UI_SortByLastNames_Btn;
        private System.Windows.Forms.Button UI_ClearSorted_Btn;
        private System.Windows.Forms.Button UI_OFD_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_Timer_Tbx;
        private System.Windows.Forms.Timer UI_Timer;
        private System.Windows.Forms.OpenFileDialog UI_MainFile_OFD;
    }
}

