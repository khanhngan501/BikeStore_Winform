
namespace _19110038_HoangNhutKhanhNgan
{
    partial class OrderListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListForm));
            this.btDelete = new System.Windows.Forms.Button();
            this.cbStaffID = new System.Windows.Forms.ComboBox();
            this.cbStoreID = new System.Windows.Forms.ComboBox();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btReload = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grPanel = new System.Windows.Forms.GroupBox();
            this.cbStaffName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStoreName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateShipped = new System.Windows.Forms.DateTimePicker();
            this.dateRequire = new System.Windows.Forms.DateTimePicker();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.cbCID = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.grPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.btDelete.Location = new System.Drawing.Point(517, 645);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(116, 36);
            this.btDelete.TabIndex = 43;
            this.btDelete.Text = "Delete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cbStaffID
            // 
            this.cbStaffID.BackColor = System.Drawing.Color.MintCream;
            this.cbStaffID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStaffID.FormattingEnabled = true;
            this.cbStaffID.Location = new System.Drawing.Point(150, 246);
            this.cbStaffID.Margin = new System.Windows.Forms.Padding(4);
            this.cbStaffID.Name = "cbStaffID";
            this.cbStaffID.Size = new System.Drawing.Size(265, 24);
            this.cbStaffID.TabIndex = 15;
            this.cbStaffID.SelectedIndexChanged += new System.EventHandler(this.cbStaffID_SelectedIndexChanged);
            // 
            // cbStoreID
            // 
            this.cbStoreID.BackColor = System.Drawing.Color.MintCream;
            this.cbStoreID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStoreID.FormattingEnabled = true;
            this.cbStoreID.Location = new System.Drawing.Point(150, 204);
            this.cbStoreID.Margin = new System.Windows.Forms.Padding(4);
            this.cbStoreID.Name = "cbStoreID";
            this.cbStoreID.Size = new System.Drawing.Size(265, 24);
            this.cbStoreID.TabIndex = 14;
            this.cbStoreID.SelectedIndexChanged += new System.EventHandler(this.cbStoreID_SelectedIndexChanged);
            // 
            // txtOID
            // 
            this.txtOID.BackColor = System.Drawing.Color.MintCream;
            this.txtOID.Location = new System.Drawing.Point(159, 39);
            this.txtOID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(313, 22);
            this.txtOID.TabIndex = 11;
            this.txtOID.Leave += new System.EventHandler(this.txtOID_Leave);
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
            this.btExit.Location = new System.Drawing.Point(855, 645);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(108, 36);
            this.btExit.TabIndex = 41;
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
            this.btEdit.Location = new System.Drawing.Point(141, 645);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(103, 36);
            this.btEdit.TabIndex = 40;
            this.btEdit.Text = "Edit";
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
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
            this.btAdd.Location = new System.Drawing.Point(28, 645);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(103, 36);
            this.btAdd.TabIndex = 39;
            this.btAdd.Text = "Add";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(25, 380);
            this.dtGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.Size = new System.Drawing.Size(937, 245);
            this.dtGridView.TabIndex = 38;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.BackColor = System.Drawing.Color.MintCream;
            this.txtOrderStatus.Location = new System.Drawing.Point(150, 161);
            this.txtOrderStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.Size = new System.Drawing.Size(316, 22);
            this.txtOrderStatus.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(39, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Store ID:";
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
            this.btReload.Location = new System.Drawing.Point(648, 645);
            this.btReload.Margin = new System.Windows.Forms.Padding(4);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(124, 36);
            this.btReload.TabIndex = 42;
            this.btReload.Text = "Reload";
            this.btReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(46, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Staff ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "UPDATE ORDER LIST";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(7, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Order status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(40, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Order ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(322, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Require date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(618, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipped date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // grPanel
            // 
            this.grPanel.Controls.Add(this.cbStaffName);
            this.grPanel.Controls.Add(this.label12);
            this.grPanel.Controls.Add(this.cbStoreName);
            this.grPanel.Controls.Add(this.label11);
            this.grPanel.Controls.Add(this.cbCName);
            this.grPanel.Controls.Add(this.label10);
            this.grPanel.Controls.Add(this.dateShipped);
            this.grPanel.Controls.Add(this.dateRequire);
            this.grPanel.Controls.Add(this.dateOrder);
            this.grPanel.Controls.Add(this.cbCID);
            this.grPanel.Controls.Add(this.cbStaffID);
            this.grPanel.Controls.Add(this.cbStoreID);
            this.grPanel.Controls.Add(this.txtOID);
            this.grPanel.Controls.Add(this.txtOrderStatus);
            this.grPanel.Controls.Add(this.label9);
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label7);
            this.grPanel.Controls.Add(this.label5);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(25, 76);
            this.grPanel.Margin = new System.Windows.Forms.Padding(4);
            this.grPanel.Name = "grPanel";
            this.grPanel.Padding = new System.Windows.Forms.Padding(4);
            this.grPanel.Size = new System.Drawing.Size(937, 296);
            this.grPanel.TabIndex = 46;
            this.grPanel.TabStop = false;
            // 
            // cbStaffName
            // 
            this.cbStaffName.BackColor = System.Drawing.Color.MintCream;
            this.cbStaffName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStaffName.FormattingEnabled = true;
            this.cbStaffName.Location = new System.Drawing.Point(583, 250);
            this.cbStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.cbStaffName.Name = "cbStaffName";
            this.cbStaffName.Size = new System.Drawing.Size(337, 24);
            this.cbStaffName.TabIndex = 53;
            this.cbStaffName.SelectedIndexChanged += new System.EventHandler(this.cbStaffName_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(460, 250);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 25);
            this.label12.TabIndex = 52;
            this.label12.Text = "Staff Name:";
            // 
            // cbStoreName
            // 
            this.cbStoreName.BackColor = System.Drawing.Color.MintCream;
            this.cbStoreName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStoreName.FormattingEnabled = true;
            this.cbStoreName.Location = new System.Drawing.Point(583, 205);
            this.cbStoreName.Margin = new System.Windows.Forms.Padding(4);
            this.cbStoreName.Name = "cbStoreName";
            this.cbStoreName.Size = new System.Drawing.Size(337, 24);
            this.cbStoreName.TabIndex = 51;
            this.cbStoreName.SelectedIndexChanged += new System.EventHandler(this.cbStoreName_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(453, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 50;
            this.label11.Text = "Store Name:";
            // 
            // cbCName
            // 
            this.cbCName.BackColor = System.Drawing.Color.MintCream;
            this.cbCName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCName.FormattingEnabled = true;
            this.cbCName.Location = new System.Drawing.Point(583, 78);
            this.cbCName.Margin = new System.Windows.Forms.Padding(4);
            this.cbCName.Name = "cbCName";
            this.cbCName.Size = new System.Drawing.Size(337, 24);
            this.cbCName.TabIndex = 49;
            this.cbCName.SelectedIndexChanged += new System.EventHandler(this.cbCName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(415, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Customer Name:";
            // 
            // dateShipped
            // 
            this.dateShipped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateShipped.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateShipped.Location = new System.Drawing.Point(760, 116);
            this.dateShipped.Margin = new System.Windows.Forms.Padding(4);
            this.dateShipped.Name = "dateShipped";
            this.dateShipped.Size = new System.Drawing.Size(160, 22);
            this.dateShipped.TabIndex = 47;
            this.dateShipped.ValueChanged += new System.EventHandler(this.dateShipped_ValueChanged);
            // 
            // dateRequire
            // 
            this.dateRequire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateRequire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRequire.Location = new System.Drawing.Point(458, 118);
            this.dateRequire.Margin = new System.Windows.Forms.Padding(4);
            this.dateRequire.Name = "dateRequire";
            this.dateRequire.Size = new System.Drawing.Size(143, 22);
            this.dateRequire.TabIndex = 21;
            this.dateRequire.ValueChanged += new System.EventHandler(this.dateRequire_ValueChanged);
            // 
            // dateOrder
            // 
            this.dateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOrder.Location = new System.Drawing.Point(156, 118);
            this.dateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(143, 22);
            this.dateOrder.TabIndex = 20;
            // 
            // cbCID
            // 
            this.cbCID.BackColor = System.Drawing.Color.MintCream;
            this.cbCID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCID.FormattingEnabled = true;
            this.cbCID.Location = new System.Drawing.Point(159, 78);
            this.cbCID.Margin = new System.Windows.Forms.Padding(4);
            this.cbCID.Name = "cbCID";
            this.cbCID.Size = new System.Drawing.Size(256, 24);
            this.cbCID.TabIndex = 19;
            this.cbCID.SelectedIndexChanged += new System.EventHandler(this.cbCID_SelectedIndexChanged);
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
            this.btCancel.Location = new System.Drawing.Point(373, 645);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(128, 36);
            this.btCancel.TabIndex = 44;
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
            this.btSave.Location = new System.Drawing.Point(257, 645);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(103, 36);
            this.btSave.TabIndex = 45;
            this.btSave.Text = "Save";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(989, 724);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cbStaffID;
        private System.Windows.Forms.ComboBox cbStoreID;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grPanel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dateRequire;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.ComboBox cbCID;
        private System.Windows.Forms.DateTimePicker dateShipped;
        private System.Windows.Forms.ComboBox cbCName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbStaffName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbStoreName;
        private System.Windows.Forms.Label label11;
    }
}