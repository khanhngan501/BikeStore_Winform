
namespace _19110038_HoangNhutKhanhNgan
{
    partial class DistrictListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistrictListForm));
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCommune = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPID
            // 
            this.txtPID.BackColor = System.Drawing.Color.MintCream;
            this.txtPID.Location = new System.Drawing.Point(633, 192);
            this.txtPID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(276, 22);
            this.txtPID.TabIndex = 95;
            // 
            // txtDName
            // 
            this.txtDName.BackColor = System.Drawing.Color.MintCream;
            this.txtDName.Location = new System.Drawing.Point(635, 149);
            this.txtDName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(276, 22);
            this.txtDName.TabIndex = 94;
            // 
            // txtDID
            // 
            this.txtDID.BackColor = System.Drawing.Color.MintCream;
            this.txtDID.Location = new System.Drawing.Point(635, 95);
            this.txtDID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(276, 22);
            this.txtDID.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(504, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "District ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(489, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 91;
            this.label4.Text = "District name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(504, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 90;
            this.label3.Text = "Province ID:";
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(16, 117);
            this.dtGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.Size = new System.Drawing.Size(455, 363);
            this.dtGridView.TabIndex = 89;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            // 
            // cbProv
            // 
            this.cbProv.BackColor = System.Drawing.Color.MintCream;
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(119, 84);
            this.cbProv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(351, 24);
            this.cbProv.TabIndex = 88;
            this.cbProv.SelectedIndexChanged += new System.EventHandler(this.cbProv_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 87;
            this.label2.Text = "Province:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(223, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 43);
            this.label1.TabIndex = 86;
            this.label1.Text = "UPDATE DISTRICT LIST";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(161, 95);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(105, 37);
            this.btExit.TabIndex = 90;
            this.btExit.Text = "Exit";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
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
            this.btReload.Location = new System.Drawing.Point(28, 95);
            this.btReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(119, 37);
            this.btReload.TabIndex = 91;
            this.btReload.Text = "Reload";
            this.btReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
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
            this.btDelete.Location = new System.Drawing.Point(287, 30);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(116, 37);
            this.btDelete.TabIndex = 92;
            this.btDelete.Text = "Delete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
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
            this.btSave.Location = new System.Drawing.Point(161, 30);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 37);
            this.btSave.TabIndex = 93;
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
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(28, 30);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(119, 37);
            this.btAdd.TabIndex = 89;
            this.btAdd.Text = "Add";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCommune
            // 
            this.btCommune.BackColor = System.Drawing.Color.Snow;
            this.btCommune.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCommune.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btCommune.Location = new System.Drawing.Point(287, 91);
            this.btCommune.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCommune.Name = "btCommune";
            this.btCommune.Size = new System.Drawing.Size(135, 41);
            this.btCommune.TabIndex = 87;
            this.btCommune.Text = "Commune >>";
            this.btCommune.UseVisualStyleBackColor = false;
            this.btCommune.Click += new System.EventHandler(this.btCommune_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExit);
            this.groupBox1.Controls.Add(this.btReload);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btCommune);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(483, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(429, 155);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // DistrictListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(927, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.cbProv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DistrictListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistrictListForm";
            this.Load += new System.EventHandler(this.DistrictListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.ComboBox cbProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCommune;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}