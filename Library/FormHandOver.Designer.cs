namespace Library
{
    partial class FormHandOver
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblOverDueText = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.ChConfirmPayment = new System.Windows.Forms.CheckBox();
            this.lblODFee = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRID = new System.Windows.Forms.Label();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.lblUserAvailability = new System.Windows.Forms.Label();
            this.lblEData = new System.Windows.Forms.Label();
            this.lblEBID = new System.Windows.Forms.Label();
            this.lblEReservation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(156, 107);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(187, 24);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Index or Phone No";
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(156, 140);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(82, 24);
            this.lblBID.TabIndex = 0;
            this.lblBID.Text = "Book ID";
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(379, 106);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(158, 24);
            this.txtData.TabIndex = 1;
            // 
            // txtBID
            // 
            this.txtBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.Location = new System.Drawing.Point(379, 140);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(238, 24);
            this.txtBID.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(543, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Teal;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(640, 106);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 46);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(155, 276);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(639, 268);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.TabStop = false;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // lblOverDueText
            // 
            this.lblOverDueText.AutoSize = true;
            this.lblOverDueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverDueText.Location = new System.Drawing.Point(156, 206);
            this.lblOverDueText.Name = "lblOverDueText";
            this.lblOverDueText.Size = new System.Drawing.Size(142, 24);
            this.lblOverDueText.TabIndex = 0;
            this.lblOverDueText.Text = "Over Due Fee";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(156, 235);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(168, 24);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "Confirm Payment";
            // 
            // ChConfirmPayment
            // 
            this.ChConfirmPayment.AutoSize = true;
            this.ChConfirmPayment.Location = new System.Drawing.Point(331, 241);
            this.ChConfirmPayment.Name = "ChConfirmPayment";
            this.ChConfirmPayment.Size = new System.Drawing.Size(15, 14);
            this.ChConfirmPayment.TabIndex = 4;
            this.ChConfirmPayment.UseVisualStyleBackColor = true;
            // 
            // lblODFee
            // 
            this.lblODFee.AutoSize = true;
            this.lblODFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblODFee.Location = new System.Drawing.Point(313, 206);
            this.lblODFee.Name = "lblODFee";
            this.lblODFee.Size = new System.Drawing.Size(142, 24);
            this.lblODFee.TabIndex = 0;
            this.lblODFee.Text = "Over Due Fee";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(640, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 46);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRID.Location = new System.Drawing.Point(156, 173);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(113, 24);
            this.lblRID.TabIndex = 0;
            this.lblRID.Text = "Resevation";
            // 
            // txtRID
            // 
            this.txtRID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRID.Location = new System.Drawing.Point(379, 173);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(238, 24);
            this.txtRID.TabIndex = 3;
            // 
            // lblUserAvailability
            // 
            this.lblUserAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserAvailability.AutoSize = true;
            this.lblUserAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAvailability.Location = new System.Drawing.Point(151, 567);
            this.lblUserAvailability.Name = "lblUserAvailability";
            this.lblUserAvailability.Size = new System.Drawing.Size(157, 24);
            this.lblUserAvailability.TabIndex = 0;
            this.lblUserAvailability.Text = "User Availability";
            // 
            // lblEData
            // 
            this.lblEData.AutoSize = true;
            this.lblEData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEData.ForeColor = System.Drawing.Color.Red;
            this.lblEData.Location = new System.Drawing.Point(351, 106);
            this.lblEData.Name = "lblEData";
            this.lblEData.Size = new System.Drawing.Size(26, 24);
            this.lblEData.TabIndex = 0;
            this.lblEData.Text = "**";
            // 
            // lblEBID
            // 
            this.lblEBID.AutoSize = true;
            this.lblEBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBID.ForeColor = System.Drawing.Color.Red;
            this.lblEBID.Location = new System.Drawing.Point(351, 139);
            this.lblEBID.Name = "lblEBID";
            this.lblEBID.Size = new System.Drawing.Size(26, 24);
            this.lblEBID.TabIndex = 0;
            this.lblEBID.Text = "**";
            // 
            // lblEReservation
            // 
            this.lblEReservation.AutoSize = true;
            this.lblEReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEReservation.ForeColor = System.Drawing.Color.Red;
            this.lblEReservation.Location = new System.Drawing.Point(351, 173);
            this.lblEReservation.Name = "lblEReservation";
            this.lblEReservation.Size = new System.Drawing.Size(26, 24);
            this.lblEReservation.TabIndex = 0;
            this.lblEReservation.Text = "**";
            // 
            // FormHandOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 642);
            this.Controls.Add(this.ChConfirmPayment);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblUserAvailability);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblODFee);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.lblOverDueText);
            this.Controls.Add(this.lblEReservation);
            this.Controls.Add(this.lblEBID);
            this.Controls.Add(this.lblEData);
            this.Controls.Add(this.lblBID);
            this.Controls.Add(this.lblData);
            this.Name = "FormHandOver";
            this.Text = "Hand Over";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblOverDueText;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.CheckBox ChConfirmPayment;
        private System.Windows.Forms.Label lblODFee;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Label lblUserAvailability;
        private System.Windows.Forms.Label lblEData;
        private System.Windows.Forms.Label lblEBID;
        private System.Windows.Forms.Label lblEReservation;
    }
}