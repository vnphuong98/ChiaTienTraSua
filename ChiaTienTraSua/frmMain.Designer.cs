
namespace ChiaTienTraSua
{
    partial class frmMain
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
            this.btnCaculator = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoneyDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAfterDiscount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCaculator
            // 
            this.btnCaculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaculator.Location = new System.Drawing.Point(527, 352);
            this.btnCaculator.Name = "btnCaculator";
            this.btnCaculator.Size = new System.Drawing.Size(202, 46);
            this.btnCaculator.TabIndex = 1;
            this.btnCaculator.Text = "Caculator";
            this.btnCaculator.UseVisualStyleBackColor = true;
            this.btnCaculator.Click += new System.EventHandler(this.btnCaculator_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(615, 326);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(114, 20);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.Text = "0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(535, 327);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(76, 20);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount:";
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colMoney,
            this.colMoneyDis});
            this.dgvMain.Location = new System.Drawing.Point(13, 13);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(508, 385);
            this.dgvMain.TabIndex = 6;
            this.dgvMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellEndEdit);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colMoney
            // 
            this.colMoney.HeaderText = "Money";
            this.colMoney.Name = "colMoney";
            // 
            // colMoneyDis
            // 
            this.colMoneyDis.HeaderText = "Money After Discount";
            this.colMoneyDis.Name = "colMoneyDis";
            this.colMoneyDis.ReadOnly = true;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.Location = new System.Drawing.Point(535, 14);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(48, 20);
            this.lblTotalMoney.TabIndex = 8;
            this.lblTotalMoney.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(615, 13);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(114, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total AD:";
            // 
            // txtTotalAfterDiscount
            // 
            this.txtTotalAfterDiscount.Location = new System.Drawing.Point(615, 57);
            this.txtTotalAfterDiscount.Name = "txtTotalAfterDiscount";
            this.txtTotalAfterDiscount.ReadOnly = true;
            this.txtTotalAfterDiscount.Size = new System.Drawing.Size(114, 20);
            this.txtTotalAfterDiscount.TabIndex = 9;
            this.txtTotalAfterDiscount.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalAfterDiscount);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.btnCaculator);
            this.Name = "frmMain";
            this.Text = "Cute";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCaculator;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoneyDis;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAfterDiscount;
    }
}

