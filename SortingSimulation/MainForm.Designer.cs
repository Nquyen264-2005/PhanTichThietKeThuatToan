namespace SortingSimulation
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.numElements = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlgorithm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numElements)).BeginInit();
            this.SuspendLayout();
            // 
            // numElements
            // 
            this.numElements.Location = new System.Drawing.Point(193, 77);
            this.numElements.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numElements.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numElements.Name = "numElements";
            this.numElements.Size = new System.Drawing.Size(97, 26);
            this.numElements.TabIndex = 0;
            this.numElements.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phần tử:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô phỏng thuật toán";
            // 
            // cboAlgorithm
            // 
            this.cboAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlgorithm.FormattingEnabled = true;
            this.cboAlgorithm.Items.AddRange(new object[] {
            "QuickSort",
            "HeapSort",
            "MergeSort"});
            this.cboAlgorithm.Location = new System.Drawing.Point(191, 130);
            this.cboAlgorithm.Name = "cboAlgorithm";
            this.cboAlgorithm.Size = new System.Drawing.Size(121, 28);
            this.cboAlgorithm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giải thuật  :";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(107, 239);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(135, 49);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Sắp xếp";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTime.Location = new System.Drawing.Point(226, 192);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(19, 25);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(35, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thời gian thực thi:";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 20;
            this.lstResult.Location = new System.Drawing.Point(59, 294);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(253, 144);
            this.lstResult.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAlgorithm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numElements);
            this.Name = "MainForm";
            this.Text = "Sorting Simulation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAlgorithm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstResult;
    }
}
