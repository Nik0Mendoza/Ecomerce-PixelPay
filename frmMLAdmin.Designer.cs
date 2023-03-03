﻿namespace EcomGr3
{
    partial class frmMLAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMLAdmin));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMLpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMLstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMLimageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblMLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pixelPlayDataSet = new EcomGr3.PixelPlayDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemStock = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblItemStock = new System.Windows.Forms.Label();
            this.itemDisplay = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tblMLTableAdapter = new EcomGr3.PixelPlayDataSetTableAdapters.tblMLTableAdapter();
            this.lblItemsearch = new System.Windows.Forms.Label();
            this.txtItemsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPlayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(74, 69);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.itemMLnameDataGridViewTextBoxColumn,
            this.itemMLpriceDataGridViewTextBoxColumn,
            this.itemMLstockDataGridViewTextBoxColumn,
            this.itemMLimageDataGridViewImageColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.tblMLBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(806, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 629);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemMLnameDataGridViewTextBoxColumn
            // 
            this.itemMLnameDataGridViewTextBoxColumn.DataPropertyName = "itemMLname";
            this.itemMLnameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemMLnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemMLnameDataGridViewTextBoxColumn.Name = "itemMLnameDataGridViewTextBoxColumn";
            this.itemMLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemMLpriceDataGridViewTextBoxColumn
            // 
            this.itemMLpriceDataGridViewTextBoxColumn.DataPropertyName = "itemMLprice";
            this.itemMLpriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.itemMLpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemMLpriceDataGridViewTextBoxColumn.Name = "itemMLpriceDataGridViewTextBoxColumn";
            this.itemMLpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemMLstockDataGridViewTextBoxColumn
            // 
            this.itemMLstockDataGridViewTextBoxColumn.DataPropertyName = "itemMLstock";
            this.itemMLstockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.itemMLstockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemMLstockDataGridViewTextBoxColumn.Name = "itemMLstockDataGridViewTextBoxColumn";
            this.itemMLstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemMLimageDataGridViewImageColumn
            // 
            this.itemMLimageDataGridViewImageColumn.DataPropertyName = "itemMLimage";
            this.itemMLimageDataGridViewImageColumn.HeaderText = "Item Image";
            this.itemMLimageDataGridViewImageColumn.MinimumWidth = 6;
            this.itemMLimageDataGridViewImageColumn.Name = "itemMLimageDataGridViewImageColumn";
            this.itemMLimageDataGridViewImageColumn.ReadOnly = true;
            // 
            // tblMLBindingSource
            // 
            this.tblMLBindingSource.DataMember = "tblML";
            this.tblMLBindingSource.DataSource = this.pixelPlayDataSet;
            // 
            // pixelPlayDataSet
            // 
            this.pixelPlayDataSet.DataSetName = "PixelPlayDataSet";
            this.pixelPlayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(113, 471);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(322, 49);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtItemName.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtItemName.Location = new System.Drawing.Point(443, 201);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(322, 34);
            this.txtItemName.TabIndex = 32;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtItemPrice.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtItemPrice.Location = new System.Drawing.Point(443, 302);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(322, 34);
            this.txtItemPrice.TabIndex = 33;
            // 
            // txtItemStock
            // 
            this.txtItemStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtItemStock.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtItemStock.Location = new System.Drawing.Point(443, 401);
            this.txtItemStock.Name = "txtItemStock";
            this.txtItemStock.Size = new System.Drawing.Size(322, 34);
            this.txtItemStock.TabIndex = 34;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(438, 170);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(122, 28);
            this.lblItemName.TabIndex = 36;
            this.lblItemName.Text = "Item Name:";
            this.lblItemName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemPrice.Location = new System.Drawing.Point(438, 271);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(113, 28);
            this.lblItemPrice.TabIndex = 37;
            this.lblItemPrice.Text = "Item Price:";
            // 
            // lblItemStock
            // 
            this.lblItemStock.AutoSize = true;
            this.lblItemStock.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemStock.Location = new System.Drawing.Point(438, 370);
            this.lblItemStock.Name = "lblItemStock";
            this.lblItemStock.Size = new System.Drawing.Size(118, 28);
            this.lblItemStock.TabIndex = 38;
            this.lblItemStock.Text = "Item Stock:";
            // 
            // itemDisplay
            // 
            this.itemDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.itemDisplay.Image = ((System.Drawing.Image)(resources.GetObject("itemDisplay.Image")));
            this.itemDisplay.Location = new System.Drawing.Point(113, 105);
            this.itemDisplay.Name = "itemDisplay";
            this.itemDisplay.Size = new System.Drawing.Size(251, 234);
            this.itemDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemDisplay.TabIndex = 40;
            this.itemDisplay.TabStop = false;
            this.itemDisplay.Click += new System.EventHandler(this.itemDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(443, 471);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(322, 49);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(113, 547);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(322, 49);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.btnUpload.Location = new System.Drawing.Point(127, 376);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(228, 49);
            this.btnUpload.TabIndex = 45;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tblMLTableAdapter
            // 
            this.tblMLTableAdapter.ClearBeforeFill = true;
            // 
            // lblItemsearch
            // 
            this.lblItemsearch.AutoSize = true;
            this.lblItemsearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemsearch.Location = new System.Drawing.Point(438, 74);
            this.lblItemsearch.Name = "lblItemsearch";
            this.lblItemsearch.Size = new System.Drawing.Size(156, 28);
            this.lblItemsearch.TabIndex = 47;
            this.lblItemsearch.Text = "Search Item ID:";
            this.lblItemsearch.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtItemsearch
            // 
            this.txtItemsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtItemsearch.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtItemsearch.Location = new System.Drawing.Point(443, 105);
            this.txtItemsearch.Name = "txtItemsearch";
            this.txtItemsearch.Size = new System.Drawing.Size(322, 34);
            this.txtItemsearch.TabIndex = 46;
            this.txtItemsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(443, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 49);
            this.button1.TabIndex = 48;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMLAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblItemsearch);
            this.Controls.Add(this.txtItemsearch);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.itemDisplay);
            this.Controls.Add(this.lblItemStock);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemStock);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMLAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMLAdmin";
            this.Load += new System.EventHandler(this.frmMLAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPlayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtItemStock;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemStock;
        private System.Windows.Forms.PictureBox itemDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpload;
        private PixelPlayDataSet pixelPlayDataSet;
        private System.Windows.Forms.BindingSource tblMLBindingSource;
        private PixelPlayDataSetTableAdapters.tblMLTableAdapter tblMLTableAdapter;
        private System.Windows.Forms.Label lblItemsearch;
        private System.Windows.Forms.TextBox txtItemsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemMLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemMLpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemMLstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn itemMLimageDataGridViewImageColumn;
    }
}