namespace Library
{
    partial class FormPayment
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
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblRValue = new System.Windows.Forms.Label();
            this.lblMValue = new System.Windows.Forms.Label();
            this.lblOValue = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(174, 70);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(74, 21);
            this.comboYear.TabIndex = 0;
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "Select",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboMonth.Location = new System.Drawing.Point(339, 70);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(85, 21);
            this.comboMonth.TabIndex = 0;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Select",
            "Register",
            "Monthly",
            "OverDue"});
            this.comboType.Location = new System.Drawing.Point(502, 70);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(85, 21);
            this.comboType.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(122, 68);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(49, 24);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(271, 70);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(63, 24);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(446, 70);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 24);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(119, 132);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(226, 24);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "Total Registation Payment";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(119, 168);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(200, 24);
            this.lblM.TabIndex = 1;
            this.lblM.Text = "Total Monthly Payment";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(119, 204);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(215, 24);
            this.lblO.TabIndex = 1;
            this.lblO.Text = "Total Over Due Payment";
            // 
            // lblRValue
            // 
            this.lblRValue.AutoSize = true;
            this.lblRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRValue.Location = new System.Drawing.Point(373, 132);
            this.lblRValue.Name = "lblRValue";
            this.lblRValue.Size = new System.Drawing.Size(226, 24);
            this.lblRValue.TabIndex = 1;
            this.lblRValue.Text = "Total Registation Payment";
            // 
            // lblMValue
            // 
            this.lblMValue.AutoSize = true;
            this.lblMValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMValue.Location = new System.Drawing.Point(373, 168);
            this.lblMValue.Name = "lblMValue";
            this.lblMValue.Size = new System.Drawing.Size(200, 24);
            this.lblMValue.TabIndex = 1;
            this.lblMValue.Text = "Total Monthly Payment";
            // 
            // lblOValue
            // 
            this.lblOValue.AutoSize = true;
            this.lblOValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOValue.Location = new System.Drawing.Point(373, 204);
            this.lblOValue.Name = "lblOValue";
            this.lblOValue.Size = new System.Drawing.Size(215, 24);
            this.lblOValue.TabIndex = 1;
            this.lblOValue.Text = "Total Over Due Payment";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(91, 311);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(760, 258);
            this.dataGrid.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Teal;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(727, 70);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(124, 46);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(727, 122);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 642);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblOValue);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblMValue);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblRValue);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboYear);
            this.Name = "FormPayment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblRValue;
        private System.Windows.Forms.Label lblMValue;
        private System.Windows.Forms.Label lblOValue;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClear;
    }
}