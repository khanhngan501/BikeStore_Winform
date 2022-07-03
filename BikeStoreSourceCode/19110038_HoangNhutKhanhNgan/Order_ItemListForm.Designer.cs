
namespace _19110038_HoangNhutKhanhNgan
{
    partial class Order_ItemListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_ItemListForm));
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbPID = new System.Windows.Forms.ComboBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.grPanel = new System.Windows.Forms.GroupBox();
            this.cbPName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.cbOID = new System.Windows.Forms.ComboBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.grPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SaddleBrown;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(23, 588);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(105, 38);
            this.btAdd.TabIndex = 59;
            this.btAdd.Text = "Add";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.SaddleBrown;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(363, 588);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(113, 38);
            this.btCancel.TabIndex = 64;
            this.btCancel.Text = "Cancel";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.SaddleBrown;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(248, 588);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(107, 38);
            this.btSave.TabIndex = 65;
            this.btSave.Text = "Save";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbPID
            // 
            this.cbPID.BackColor = System.Drawing.Color.MintCream;
            this.cbPID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPID.FormattingEnabled = true;
            this.cbPID.Location = new System.Drawing.Point(140, 87);
            this.cbPID.Margin = new System.Windows.Forms.Padding(4);
            this.cbPID.Name = "cbPID";
            this.cbPID.Size = new System.Drawing.Size(287, 24);
            this.cbPID.TabIndex = 49;
            this.cbPID.SelectedValueChanged += new System.EventHandler(this.cbPID_SelectedIndexChanged);
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.Color.MintCream;
            this.txtItemID.Location = new System.Drawing.Point(605, 140);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(292, 22);
            this.txtItemID.TabIndex = 48;
            this.txtItemID.Leave += new System.EventHandler(this.txtItemID_Leave);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.SaddleBrown;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.Location = new System.Drawing.Point(484, 588);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 38);
            this.btDelete.TabIndex = 63;
            this.btDelete.Text = "Delete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtListPrice
            // 
            this.txtListPrice.BackColor = System.Drawing.Color.MintCream;
            this.txtListPrice.Location = new System.Drawing.Point(139, 142);
            this.txtListPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(316, 22);
            this.txtListPrice.TabIndex = 51;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.DarkRed;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(861, 588);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(105, 38);
            this.btExit.TabIndex = 61;
            this.btExit.Text = "Exit";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.Location = new System.Drawing.Point(136, 588);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(104, 38);
            this.btEdit.TabIndex = 60;
            this.btEdit.Text = "Edit";
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(16, 325);
            this.dtGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.Size = new System.Drawing.Size(947, 245);
            this.dtGridView.TabIndex = 58;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            // 
            // grPanel
            // 
            this.grPanel.Controls.Add(this.cbPName);
            this.grPanel.Controls.Add(this.label5);
            this.grPanel.Controls.Add(this.txtQuan);
            this.grPanel.Controls.Add(this.cbOID);
            this.grPanel.Controls.Add(this.txtListPrice);
            this.grPanel.Controls.Add(this.cbPID);
            this.grPanel.Controls.Add(this.txtItemID);
            this.grPanel.Controls.Add(this.txtDiscount);
            this.grPanel.Controls.Add(this.label9);
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label7);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(16, 71);
            this.grPanel.Margin = new System.Windows.Forms.Padding(4);
            this.grPanel.Name = "grPanel";
            this.grPanel.Padding = new System.Windows.Forms.Padding(4);
            this.grPanel.Size = new System.Drawing.Size(947, 236);
            this.grPanel.TabIndex = 66;
            this.grPanel.TabStop = false;
            // 
            // cbPName
            // 
            this.cbPName.BackColor = System.Drawing.Color.MintCream;
            this.cbPName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPName.FormattingEnabled = true;
            this.cbPName.Location = new System.Drawing.Point(605, 89);
            this.cbPName.Margin = new System.Windows.Forms.Padding(4);
            this.cbPName.Name = "cbPName";
            this.cbPName.Size = new System.Drawing.Size(292, 24);
            this.cbPName.TabIndex = 55;
            this.cbPName.SelectedValueChanged += new System.EventHandler(this.cbPName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(436, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Product Name:";
            // 
            // txtQuan
            // 
            this.txtQuan.BackColor = System.Drawing.Color.MintCream;
            this.txtQuan.Location = new System.Drawing.Point(605, 190);
            this.txtQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(292, 22);
            this.txtQuan.TabIndex = 53;
            // 
            // cbOID
            // 
            this.cbOID.BackColor = System.Drawing.Color.MintCream;
            this.cbOID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOID.FormattingEnabled = true;
            this.cbOID.Location = new System.Drawing.Point(140, 37);
            this.cbOID.Margin = new System.Windows.Forms.Padding(4);
            this.cbOID.Name = "cbOID";
            this.cbOID.Size = new System.Drawing.Size(287, 24);
            this.cbOID.TabIndex = 52;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.MintCream;
            this.txtDiscount.Location = new System.Drawing.Point(139, 192);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(315, 22);
            this.txtDiscount.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(29, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "List price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(484, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(33, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Order ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(29, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Discount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(16, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(492, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(500, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item ID:";
            // 
            // btReload
            // 
            this.btReload.BackColor = System.Drawing.Color.SaddleBrown;
            this.btReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReload.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReload.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReload.ForeColor = System.Drawing.Color.White;
            this.btReload.Image = ((System.Drawing.Image)(resources.GetObject("btReload.Image")));
            this.btReload.Location = new System.Drawing.Point(603, 588);
            this.btReload.Margin = new System.Windows.Forms.Padding(4);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(113, 38);
            this.btReload.TabIndex = 62;
            this.btReload.Text = "Reload";
            this.btReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 39);
            this.label1.TabIndex = 57;
            this.label1.Text = "UPDATE ORDER ITEM LIST";
            // 
            // Order_ItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(987, 641);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Order_ItemListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_ItemLis";
            this.Load += new System.EventHandler(this.Order_ItemListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbPID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.GroupBox grPanel;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOID;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.ComboBox cbPName;
        private System.Windows.Forms.Label label5;
    }
}