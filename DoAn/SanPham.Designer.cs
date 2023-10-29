namespace DoAn
{
    partial class SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSanPham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtGiaSp = new System.Windows.Forms.TextBox();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbGiaSp = new System.Windows.Forms.Label();
            this.lbTenSp = new System.Windows.Forms.Label();
            this.lbMaSp = new System.Windows.Forms.Label();
            this.lbThongTinSp = new System.Windows.Forms.Label();
            this.bttCancel_Add = new System.Windows.Forms.Button();
            this.bttSave_Add = new System.Windows.Forms.Button();
            this.bttUpdate_Add = new System.Windows.Forms.Button();
            this.bttDelete_Add = new System.Windows.Forms.Button();
            this.bttCancel_Update = new System.Windows.Forms.Button();
            this.bttAdd_Update = new System.Windows.Forms.Button();
            this.bttSave_Update = new System.Windows.Forms.Button();
            this.bttDelete_Update = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.BackColor = System.Drawing.SystemColors.Info;
            this.lbSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSanPham.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbSanPham.Location = new System.Drawing.Point(15, 17);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(170, 34);
            this.lbSanPham.TabIndex = 0;
            this.lbSanPham.Text = "SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameCl,
            this.Cost,
            this.Quantity});
            this.dataGridView1.Location = new System.Drawing.Point(23, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 225);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttDelete.FlatAppearance.BorderSize = 0;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Location = new System.Drawing.Point(651, 253);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(72, 30);
            this.bttDelete.TabIndex = 37;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.bttUpdate.FlatAppearance.BorderSize = 0;
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Location = new System.Drawing.Point(548, 253);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(72, 30);
            this.bttUpdate.TabIndex = 36;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.bttAdd.FlatAppearance.BorderSize = 0;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Location = new System.Drawing.Point(439, 253);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(72, 30);
            this.bttAdd.TabIndex = 35;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttCancel.FlatAppearance.BorderSize = 0;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttCancel.Location = new System.Drawing.Point(330, 253);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(72, 30);
            this.bttCancel.TabIndex = 34;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQuantity.Location = new System.Drawing.Point(580, 151);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(57, 22);
            this.txtQuantity.TabIndex = 48;
            // 
            // txtGiaSp
            // 
            this.txtGiaSp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGiaSp.Location = new System.Drawing.Point(580, 102);
            this.txtGiaSp.Name = "txtGiaSp";
            this.txtGiaSp.ReadOnly = true;
            this.txtGiaSp.Size = new System.Drawing.Size(144, 22);
            this.txtGiaSp.TabIndex = 46;
            // 
            // txtTenSp
            // 
            this.txtTenSp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenSp.Location = new System.Drawing.Point(194, 151);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.ReadOnly = true;
            this.txtTenSp.Size = new System.Drawing.Size(144, 22);
            this.txtTenSp.TabIndex = 45;
            // 
            // txtMaSp
            // 
            this.txtMaSp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaSp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSp.Location = new System.Drawing.Point(194, 102);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.ReadOnly = true;
            this.txtMaSp.Size = new System.Drawing.Size(144, 22);
            this.txtMaSp.TabIndex = 44;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(451, 156);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(88, 17);
            this.lbQuantity.TabIndex = 43;
            this.lbQuantity.Text = "QUANTITY:";
            // 
            // lbGiaSp
            // 
            this.lbGiaSp.AutoSize = true;
            this.lbGiaSp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaSp.Location = new System.Drawing.Point(451, 107);
            this.lbGiaSp.Name = "lbGiaSp";
            this.lbGiaSp.Size = new System.Drawing.Size(119, 17);
            this.lbGiaSp.TabIndex = 41;
            this.lbGiaSp.Text = "GIÁ SẢN PHẨM:";
            // 
            // lbTenSp
            // 
            this.lbTenSp.AutoSize = true;
            this.lbTenSp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSp.Location = new System.Drawing.Point(50, 156);
            this.lbTenSp.Name = "lbTenSp";
            this.lbTenSp.Size = new System.Drawing.Size(122, 17);
            this.lbTenSp.TabIndex = 40;
            this.lbTenSp.Text = "TÊN SẢN PHẨM:";
            // 
            // lbMaSp
            // 
            this.lbMaSp.AutoSize = true;
            this.lbMaSp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSp.Location = new System.Drawing.Point(50, 107);
            this.lbMaSp.Name = "lbMaSp";
            this.lbMaSp.Size = new System.Drawing.Size(117, 17);
            this.lbMaSp.TabIndex = 39;
            this.lbMaSp.Text = "MÃ SẢN PHẨM:";
            // 
            // lbThongTinSp
            // 
            this.lbThongTinSp.AutoSize = true;
            this.lbThongTinSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinSp.Location = new System.Drawing.Point(17, 61);
            this.lbThongTinSp.Name = "lbThongTinSp";
            this.lbThongTinSp.Size = new System.Drawing.Size(194, 20);
            this.lbThongTinSp.TabIndex = 38;
            this.lbThongTinSp.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // bttCancel_Add
            // 
            this.bttCancel_Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttCancel_Add.FlatAppearance.BorderSize = 0;
            this.bttCancel_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttCancel_Add.Location = new System.Drawing.Point(330, 253);
            this.bttCancel_Add.Name = "bttCancel_Add";
            this.bttCancel_Add.Size = new System.Drawing.Size(72, 30);
            this.bttCancel_Add.TabIndex = 49;
            this.bttCancel_Add.Text = "Cancel";
            this.bttCancel_Add.UseVisualStyleBackColor = false;
            this.bttCancel_Add.Click += new System.EventHandler(this.bttCancel_Add_Click);
            // 
            // bttSave_Add
            // 
            this.bttSave_Add.BackColor = System.Drawing.SystemColors.Desktop;
            this.bttSave_Add.FlatAppearance.BorderSize = 0;
            this.bttSave_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave_Add.Location = new System.Drawing.Point(440, 253);
            this.bttSave_Add.Name = "bttSave_Add";
            this.bttSave_Add.Size = new System.Drawing.Size(72, 30);
            this.bttSave_Add.TabIndex = 50;
            this.bttSave_Add.Text = "Save";
            this.bttSave_Add.UseVisualStyleBackColor = false;
            this.bttSave_Add.Click += new System.EventHandler(this.bttSave_Add_Click);
            // 
            // bttUpdate_Add
            // 
            this.bttUpdate_Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttUpdate_Add.FlatAppearance.BorderSize = 0;
            this.bttUpdate_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate_Add.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bttUpdate_Add.Location = new System.Drawing.Point(549, 253);
            this.bttUpdate_Add.Name = "bttUpdate_Add";
            this.bttUpdate_Add.Size = new System.Drawing.Size(72, 30);
            this.bttUpdate_Add.TabIndex = 51;
            this.bttUpdate_Add.Text = "Update";
            this.bttUpdate_Add.UseVisualStyleBackColor = false;
            // 
            // bttDelete_Add
            // 
            this.bttDelete_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttDelete_Add.FlatAppearance.BorderSize = 0;
            this.bttDelete_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete_Add.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttDelete_Add.Location = new System.Drawing.Point(652, 253);
            this.bttDelete_Add.Name = "bttDelete_Add";
            this.bttDelete_Add.Size = new System.Drawing.Size(72, 30);
            this.bttDelete_Add.TabIndex = 52;
            this.bttDelete_Add.Text = "Delete";
            this.bttDelete_Add.UseVisualStyleBackColor = false;
            // 
            // bttCancel_Update
            // 
            this.bttCancel_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttCancel_Update.FlatAppearance.BorderSize = 0;
            this.bttCancel_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel_Update.Location = new System.Drawing.Point(330, 253);
            this.bttCancel_Update.Name = "bttCancel_Update";
            this.bttCancel_Update.Size = new System.Drawing.Size(72, 30);
            this.bttCancel_Update.TabIndex = 53;
            this.bttCancel_Update.Text = "Cancel";
            this.bttCancel_Update.UseVisualStyleBackColor = false;
            this.bttCancel_Update.Click += new System.EventHandler(this.bttCancel_Update_Click);
            // 
            // bttAdd_Update
            // 
            this.bttAdd_Update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttAdd_Update.FlatAppearance.BorderSize = 0;
            this.bttAdd_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd_Update.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttAdd_Update.Location = new System.Drawing.Point(439, 253);
            this.bttAdd_Update.Name = "bttAdd_Update";
            this.bttAdd_Update.Size = new System.Drawing.Size(72, 30);
            this.bttAdd_Update.TabIndex = 54;
            this.bttAdd_Update.Text = "Add";
            this.bttAdd_Update.UseVisualStyleBackColor = false;
            // 
            // bttSave_Update
            // 
            this.bttSave_Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttSave_Update.FlatAppearance.BorderSize = 0;
            this.bttSave_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave_Update.Location = new System.Drawing.Point(549, 253);
            this.bttSave_Update.Name = "bttSave_Update";
            this.bttSave_Update.Size = new System.Drawing.Size(72, 30);
            this.bttSave_Update.TabIndex = 55;
            this.bttSave_Update.Text = "Save";
            this.bttSave_Update.UseVisualStyleBackColor = false;
            this.bttSave_Update.Click += new System.EventHandler(this.bttSave_Update_Click);
            // 
            // bttDelete_Update
            // 
            this.bttDelete_Update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttDelete_Update.FlatAppearance.BorderSize = 0;
            this.bttDelete_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete_Update.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttDelete_Update.Location = new System.Drawing.Point(651, 253);
            this.bttDelete_Update.Name = "bttDelete_Update";
            this.bttDelete_Update.Size = new System.Drawing.Size(72, 30);
            this.bttDelete_Update.TabIndex = 56;
            this.bttDelete_Update.Text = "Delete";
            this.bttDelete_Update.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 70F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameCl
            // 
            this.NameCl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCl.FillWeight = 170F;
            this.NameCl.HeaderText = "Name";
            this.NameCl.MinimumWidth = 6;
            this.NameCl.Name = "NameCl";
            this.NameCl.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.FillWeight = 120F;
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.FillWeight = 80F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // SanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttAdd_Update);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtGiaSp);
            this.Controls.Add(this.txtTenSp);
            this.Controls.Add(this.txtMaSp);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbGiaSp);
            this.Controls.Add(this.lbTenSp);
            this.Controls.Add(this.lbMaSp);
            this.Controls.Add(this.lbThongTinSp);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.bttCancel_Add);
            this.Controls.Add(this.bttUpdate_Add);
            this.Controls.Add(this.bttDelete_Add);
            this.Controls.Add(this.bttDelete_Update);
            this.Controls.Add(this.bttCancel_Update);
            this.Controls.Add(this.bttSave_Add);
            this.Controls.Add(this.bttSave_Update);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(760, 587);
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtGiaSp;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbGiaSp;
        private System.Windows.Forms.Label lbTenSp;
        private System.Windows.Forms.Label lbMaSp;
        private System.Windows.Forms.Label lbThongTinSp;
        private System.Windows.Forms.Button bttCancel_Add;
        private System.Windows.Forms.Button bttSave_Add;
        private System.Windows.Forms.Button bttUpdate_Add;
        private System.Windows.Forms.Button bttDelete_Add;
        private System.Windows.Forms.Button bttCancel_Update;
        private System.Windows.Forms.Button bttAdd_Update;
        private System.Windows.Forms.Button bttSave_Update;
        private System.Windows.Forms.Button bttDelete_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
