
namespace LopPTUD2022_Sang
{
    partial class frmDMHH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDMHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new LopPTUD2022_Sang.QLBHDataSet();
            this.tblDMHHTableAdapter = new LopPTUD2022_Sang.QLBHDataSetTableAdapters.tblDMHHTableAdapter();
            this.txtManhom = new System.Windows.Forms.TextBox();
            this.txtMahh = new System.Windows.Forms.TextBox();
            this.txtTenhh = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtDGvnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý danh mục hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.Dvt,
            this.DGvnd,
            this.SanXuat});
            this.dataGridView1.DataSource = this.tblDMHHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 506);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhom.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 90;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHH.DataPropertyName = "MaHH";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaHH.HeaderText = "Mã hàng ";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 89;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenHH.DataPropertyName = "TenHH";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHH.HeaderText = "Tên Hàng ";
            this.TenHH.MinimumWidth = 6;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 96;
            // 
            // Dvt
            // 
            this.Dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dvt.DataPropertyName = "Dvt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Dvt.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dvt.HeaderText = "Đơn vị tính ";
            this.Dvt.MinimumWidth = 6;
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 75;
            // 
            // DGvnd
            // 
            this.DGvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DGvnd.DataPropertyName = "DGvnd";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGvnd.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGvnd.HeaderText = "Đơn giá VND ";
            this.DGvnd.MinimumWidth = 6;
            this.DGvnd.Name = "DGvnd";
            this.DGvnd.Width = 113;
            // 
            // SanXuat
            // 
            this.SanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SanXuat.DataPropertyName = "SanXuat";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanXuat.DefaultCellStyle = dataGridViewCellStyle6;
            this.SanXuat.HeaderText = "Nước Sản xuất ";
            this.SanXuat.MinimumWidth = 6;
            this.SanXuat.Name = "SanXuat";
            this.SanXuat.Width = 95;
            // 
            // tblDMHHBindingSource
            // 
            this.tblDMHHBindingSource.DataMember = "tblDMHH";
            this.tblDMHHBindingSource.DataSource = this.qLBHDataSetBindingSource;
            // 
            // qLBHDataSetBindingSource
            // 
            this.qLBHDataSetBindingSource.DataSource = this.qLBHDataSet;
            this.qLBHDataSetBindingSource.Position = 0;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDMHHTableAdapter
            // 
            this.tblDMHHTableAdapter.ClearBeforeFill = true;
            // 
            // txtManhom
            // 
            this.txtManhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManhom.Location = new System.Drawing.Point(854, 120);
            this.txtManhom.Multiline = true;
            this.txtManhom.Name = "txtManhom";
            this.txtManhom.Size = new System.Drawing.Size(228, 34);
            this.txtManhom.TabIndex = 2;
            // 
            // txtMahh
            // 
            this.txtMahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahh.Location = new System.Drawing.Point(854, 194);
            this.txtMahh.Multiline = true;
            this.txtMahh.Name = "txtMahh";
            this.txtMahh.Size = new System.Drawing.Size(228, 34);
            this.txtMahh.TabIndex = 3;
            // 
            // txtTenhh
            // 
            this.txtTenhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhh.Location = new System.Drawing.Point(854, 268);
            this.txtTenhh.Multiline = true;
            this.txtTenhh.Name = "txtTenhh";
            this.txtTenhh.Size = new System.Drawing.Size(228, 34);
            this.txtTenhh.TabIndex = 4;
            // 
            // txtdvt
            // 
            this.txtdvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdvt.Location = new System.Drawing.Point(854, 342);
            this.txtdvt.Multiline = true;
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(228, 34);
            this.txtdvt.TabIndex = 5;
            // 
            // txtDGvnd
            // 
            this.txtDGvnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGvnd.Location = new System.Drawing.Point(854, 416);
            this.txtDGvnd.Multiline = true;
            this.txtDGvnd.Name = "txtDGvnd";
            this.txtDGvnd.Size = new System.Drawing.Size(228, 34);
            this.txtDGvnd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã hàng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên hàng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "DVT ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(773, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đơn giá ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(773, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nước SX ";
            // 
            // txtsx
            // 
            this.txtsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsx.Location = new System.Drawing.Point(854, 482);
            this.txtsx.Multiline = true;
            this.txtsx.Name = "txtsx";
            this.txtsx.Size = new System.Drawing.Size(228, 34);
            this.txtsx.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đầu ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Trước ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Sau ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(471, 645);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cuối ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 680);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDGvnd);
            this.Controls.Add(this.txtdvt);
            this.Controls.Add(this.txtTenhh);
            this.Controls.Add(this.txtMahh);
            this.Controls.Add(this.txtManhom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmDMHH";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLBHDataSetBindingSource;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource tblDMHHBindingSource;
        private QLBHDataSetTableAdapters.tblDMHHTableAdapter tblDMHHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanXuat;
        private System.Windows.Forms.TextBox txtManhom;
        private System.Windows.Forms.TextBox txtMahh;
        private System.Windows.Forms.TextBox txtTenhh;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtDGvnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}