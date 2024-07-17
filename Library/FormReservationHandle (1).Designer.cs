namespace Library
{
    partial class FormReservationHandle
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblBID = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.lblMPName = new System.Windows.Forms.Label();
            this.lblBAname = new System.Windows.Forms.Label();
            this.lblODName = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblBA = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblEdata = new System.Windows.Forms.Label();
            this.lblEID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(150, 95);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(187, 24);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Index or Phone No";
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(150, 133);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(82, 24);
            this.lblBID.TabIndex = 0;
            this.lblBID.Text = "Book ID";
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(370, 95);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(210, 24);
            this.txtData.TabIndex = 1;
            // 
            // txtBID
            // 
            this.txtBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.Location = new System.Drawing.Point(370, 133);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(285, 24);
            this.txtBID.TabIndex = 2;
            // 
            // lblMPName
            // 
            this.lblMPName.AutoSize = true;
            this.lblMPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPName.Location = new System.Drawing.Point(150, 213);
            this.lblMPName.Name = "lblMPName";
            this.lblMPName.Size = new System.Drawing.Size(169, 24);
            this.lblMPName.TabIndex = 0;
            this.lblMPName.Text = "Monthly Payment";
            // 
            // lblBAname
            // 
            this.lblBAname.AutoSize = true;
            this.lblBAname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAname.Location = new System.Drawing.Point(150, 239);
            this.lblBAname.Name = "lblBAname";
            this.lblBAname.Size = new System.Drawing.Size(161, 24);
            this.lblBAname.TabIndex = 0;
            this.lblBAname.Text = "Book Availability";
            // 
            // lblODName
            // 
            this.lblODName.AutoSize = true;
            this.lblODName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblODName.Location = new System.Drawing.Point(150, 265);
            this.lblODName.Name = "lblODName";
            this.lblODName.Size = new System.Drawing.Size(99, 24);
            this.lblODName.TabIndex = 0;
            this.lblODName.Text = "Over Due";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(419, 213);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(66, 24);
            this.lblMP.TabIndex = 0;
            this.lblMP.Text = "Status";
            // 
            // lblBA
            // 
            this.lblBA.AutoSize = true;
            this.lblBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBA.Location = new System.Drawing.Point(419, 239);
            this.lblBA.Name = "lblBA";
            this.lblBA.Size = new System.Drawing.Size(66, 24);
            this.lblBA.TabIndex = 0;
            this.lblBA.Text = "Status";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOD.Location = new System.Drawing.Point(419, 265);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(66, 24);
            this.lblOD.TabIndex = 0;
            this.lblOD.Text = "Status";
            // 
            // btnCheck
            // 
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(694, 95);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(125, 42);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(694, 143);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 42);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(154, 307);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(665, 237);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(150, 577);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(157, 24);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Availability";
            // 
            // lblEdata
            // 
            this.lblEdata.AutoSize = true;
            this.lblEdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdata.ForeColor = System.Drawing.Color.Red;
            this.lblEdata.Location = new System.Drawing.Point(341, 98);
            this.lblEdata.Name = "lblEdata";
            this.lblEdata.Size = new System.Drawing.Size(26, 24);
            this.lblEdata.TabIndex = 0;
            this.lblEdata.Text = "**";
            // 
            // lblEID
            // 
            this.lblEID.AutoSize = true;
            this.lblEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEID.ForeColor = System.Drawing.Color.Red;
            this.lblEID.Location = new System.Drawing.Point(341, 133);
            this.lblEID.Name = "lblEID";
            this.lblEID.Size = new System.Drawing.Size(26, 24);
            this.lblEID.TabIndex = 0;
            this.lblEID.Text = "**";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(694, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 46);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(586, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(744, 580);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "HISTORY";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // FormReservationHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 642);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblOD);
            this.Controls.Add(this.lblODName);
            this.Controls.Add(this.lblBA);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblBAname);
            this.Controls.Add(this.lblMPName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblBID);
            this.Controls.Add(this.lblEID);
            this.Controls.Add(this.lblEdata);
            this.Controls.Add(this.lblData);
            this.Name = "FormReservationHandle";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label lblMPName;
        private System.Windows.Forms.Label lblBAname;
        private System.Windows.Forms.Label lblODName;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblBA;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblEdata;
        private System.Windows.Forms.Label lblEID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHistory;
    }
}