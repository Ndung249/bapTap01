namespace FormSinhVien
{
    partial class FrmListSV
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
            this.dgvListSV = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFromDTB = new System.Windows.Forms.TextBox();
            this.txtToDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListSV
            // 
            this.dgvListSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSV.Location = new System.Drawing.Point(4, 91);
            this.dgvListSV.Name = "dgvListSV";
            this.dgvListSV.RowHeadersWidth = 51;
            this.dgvListSV.RowTemplate.Height = 24;
            this.dgvListSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSV.Size = new System.Drawing.Size(909, 426);
            this.dgvListSV.TabIndex = 0;
            this.dgvListSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSV_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(783, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(783, 48);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(65, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(691, 24);
            this.txtID.TabIndex = 3;
            // 
            // txtFromDTB
            // 
            this.txtFromDTB.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromDTB.Location = new System.Drawing.Point(65, 48);
            this.txtFromDTB.Name = "txtFromDTB";
            this.txtFromDTB.Size = new System.Drawing.Size(346, 24);
            this.txtFromDTB.TabIndex = 4;
            // 
            // txtToDTB
            // 
            this.txtToDTB.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDTB.Location = new System.Drawing.Point(458, 49);
            this.txtToDTB.Name = "txtToDTB";
            this.txtToDTB.Size = new System.Drawing.Size(298, 24);
            this.txtToDTB.TabIndex = 5;
            // 
            // FrmListSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 519);
            this.Controls.Add(this.txtToDTB);
            this.Controls.Add(this.txtFromDTB);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvListSV);
            this.Name = "FrmListSV";
            this.Text = "FrmListSV";
            this.Load += new System.EventHandler(this.FrmListSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListSV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFromDTB;
        private System.Windows.Forms.TextBox txtToDTB;
    }
}