
namespace _19110038_HoangNhutKhanhNgan
{
    partial class StockListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockListForm));
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.grPanel = new System.Windows.Forms.GroupBox();
            this.cbProName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStoreName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSID = new System.Windows.Forms.ComboBox();
            this.cbPID = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.grPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Tomato;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(38, 586);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(113, 39);
            this.btExit.TabIndex = 71;
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
            this.btEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.Location = new System.Drawing.Point(197, 34);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(113, 41);
            this.btEdit.TabIndex = 70;
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
            this.dtGridView.Location = new System.Drawing.Point(549, 107);
            this.dtGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.Size = new System.Drawing.Size(449, 518);
            this.dtGridView.TabIndex = 68;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            // 
            // grPanel
            // 
            this.grPanel.Controls.Add(this.cbProName);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.cbStoreName);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Controls.Add(this.cbSID);
            this.grPanel.Controls.Add(this.cbPID);
            this.grPanel.Controls.Add(this.txtQuantity);
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label7);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Location = new System.Drawing.Point(13, 107);
            this.grPanel.Margin = new System.Windows.Forms.Padding(4);
            this.grPanel.Name = "grPanel";
            this.grPanel.Padding = new System.Windows.Forms.Padding(4);
            this.grPanel.Size = new System.Drawing.Size(515, 274);
            this.grPanel.TabIndex = 76;
            this.grPanel.TabStop = false;
            // 
            // cbProName
            // 
            this.cbProName.BackColor = System.Drawing.Color.MintCream;
            this.cbProName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProName.FormattingEnabled = true;
            this.cbProName.Location = new System.Drawing.Point(169, 176);
            this.cbProName.Margin = new System.Windows.Forms.Padding(4);
            this.cbProName.Name = "cbProName";
            this.cbProName.Size = new System.Drawing.Size(315, 24);
            this.cbProName.TabIndex = 56;
            this.cbProName.SelectedIndexChanged += new System.EventHandler(this.cbProName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(4, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Product Name:";
            // 
            // cbStoreName
            // 
            this.cbStoreName.BackColor = System.Drawing.Color.MintCream;
            this.cbStoreName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStoreName.FormattingEnabled = true;
            this.cbStoreName.Location = new System.Drawing.Point(169, 86);
            this.cbStoreName.Margin = new System.Windows.Forms.Padding(4);
            this.cbStoreName.Name = "cbStoreName";
            this.cbStoreName.Size = new System.Drawing.Size(315, 24);
            this.cbStoreName.TabIndex = 54;
            this.cbStoreName.SelectedIndexChanged += new System.EventHandler(this.cbStoreName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Store Name:";
            // 
            // cbSID
            // 
            this.cbSID.BackColor = System.Drawing.Color.MintCream;
            this.cbSID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSID.FormattingEnabled = true;
            this.cbSID.Location = new System.Drawing.Point(169, 40);
            this.cbSID.Margin = new System.Windows.Forms.Padding(4);
            this.cbSID.Name = "cbSID";
            this.cbSID.Size = new System.Drawing.Size(315, 24);
            this.cbSID.TabIndex = 52;
            this.cbSID.SelectedIndexChanged += new System.EventHandler(this.cbSID_SelectedIndexChanged);
            // 
            // cbPID
            // 
            this.cbPID.BackColor = System.Drawing.Color.MintCream;
            this.cbPID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPID.FormattingEnabled = true;
            this.cbPID.Location = new System.Drawing.Point(169, 133);
            this.cbPID.Margin = new System.Windows.Forms.Padding(4);
            this.cbPID.Name = "cbPID";
            this.cbPID.Size = new System.Drawing.Size(315, 24);
            this.cbPID.TabIndex = 49;
            this.cbPID.SelectedIndexChanged += new System.EventHandler(this.cbPID_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.MintCream;
            this.txtQuantity.Location = new System.Drawing.Point(169, 219);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(315, 22);
            this.txtQuantity.TabIndex = 10;
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
            this.label6.Location = new System.Drawing.Point(58, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Store ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(54, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(37, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product ID:";
            // 
            // btReload
            // 
            this.btReload.BackColor = System.Drawing.Color.SaddleBrown;
            this.btReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReload.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReload.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReload.ForeColor = System.Drawing.Color.White;
            this.btReload.Image = ((System.Drawing.Image)(resources.GetObject("btReload.Image")));
            this.btReload.Location = new System.Drawing.Point(337, 92);
            this.btReload.Margin = new System.Windows.Forms.Padding(4);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(117, 41);
            this.btReload.TabIndex = 72;
            this.btReload.Text = "Reload";
            this.btReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(291, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 39);
            this.label1.TabIndex = 67;
            this.label1.Text = "UPDATE  STOCK LIST";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.SaddleBrown;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.Location = new System.Drawing.Point(197, 92);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(113, 41);
            this.btDelete.TabIndex = 73;
            this.btDelete.Text = "Delete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.SaddleBrown;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(337, 34);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(117, 41);
            this.btCancel.TabIndex = 74;
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
            this.btSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(57, 92);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 41);
            this.btSave.TabIndex = 75;
            this.btSave.Text = "Save";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SaddleBrown;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(57, 34);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(119, 41);
            this.btAdd.TabIndex = 69;
            this.btAdd.Text = "Add";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btReload);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 416);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(516, 153);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // StockListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1035, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StockListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockList";
            this.Load += new System.EventHandler(this.StockListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.GroupBox grPanel;
        private System.Windows.Forms.ComboBox cbSID;
        private System.Windows.Forms.ComboBox cbPID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStoreName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProName;
        private System.Windows.Forms.Label label3;
    }
}