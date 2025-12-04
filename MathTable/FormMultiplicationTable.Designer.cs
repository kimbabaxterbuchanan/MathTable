namespace MathTable
{
    partial class FormMultiplicationTable
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
            this.dgvMultiplicationTable = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiplicationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMultiplicationTable
            // 
            this.dgvMultiplicationTable.AllowUserToAddRows = false;
            this.dgvMultiplicationTable.AllowUserToDeleteRows = false;
            this.dgvMultiplicationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultiplicationTable.Location = new System.Drawing.Point(0, 0);
            this.dgvMultiplicationTable.Name = "dgvMultiplicationTable";
            this.dgvMultiplicationTable.ReadOnly = true;
            this.dgvMultiplicationTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMultiplicationTable.RowTemplate.Height = 35;
            this.dgvMultiplicationTable.Size = new System.Drawing.Size(1375, 514);
            this.dgvMultiplicationTable.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1272, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMultiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 559);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMultiplicationTable);
            this.Name = "FormMultiplicationTable";
            this.Text = "FormMultiplicationTable";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiplicationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMultiplicationTable;
        private System.Windows.Forms.Button btnClose;
    }
}