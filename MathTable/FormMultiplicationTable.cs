using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTable
{
    public partial class FormMultiplicationTable : Form
    {
        int[] multiplicand = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] multiplier = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public FormMultiplicationTable()
        {
            InitializeComponent();
            loadMultiplicationTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void loadMultiplicationTable()
        {
            LoadHeaders();
 
            for (int i = 0; i < multiplier.Length; i++)
            {
                object[] row = new object[multiplier.Length+1];
                for (int j = 0; j < multiplicand.Length; j++)
                {
                    var multiplicationValue = multiplicand[i] * multiplier[j];
                    row[j] = multiplicationValue.ToString();
                }
                dgvMultiplicationTable.Rows[i].SetValues(row);
            }
        }

        private void LoadHeaders()
        {
            var colheader = "Multiplier";
            var rowheader = "Multiplicand";
            dgvMultiplicationTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            for (int i = 0; i < multiplier.Length; i++)
            {

                dgvMultiplicationTable.Columns.Add(string.Empty, string.Empty);
            }
            for (int j = 0; j < multiplicand.Length; j++)
            {
                dgvMultiplicationTable.Rows.Add();
            }
            var columnHeaderLoc = multiplier.Length / 2 ;
            var RowHeaderLoc = multiplicand.Length / 2;

            dgvMultiplicationTable.Columns[columnHeaderLoc].HeaderText = colheader;
            dgvMultiplicationTable.Rows[RowHeaderLoc].HeaderCell.Value = rowheader;
            dgvMultiplicationTable.RowHeadersWidth = rowheader.Length;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var tableValues = Convert.ToInt32(txtBxTableValues.Text);
            var tableColumnAndRows = multiplicand.Length;

            var adjColumnAndRows = tableValues - tableColumnAndRows;

            multiplicand = new int[tableValues];
            multiplier = new int[tableValues];

            for (int i = 0; i < tableValues; i++)
            {
                multiplicand[i] = i + 1;
                multiplier[i] = i + 1;
            }

            dgvMultiplicationTable.Rows.Clear();
            dgvMultiplicationTable.Columns.Clear();

            loadMultiplicationTable();

            var cntrlSize = dgvMultiplicationTable.Size;
            var cntrlColumnWidth = dgvMultiplicationTable.Columns[0].Width;
            var cntrlRowHeight = dgvMultiplicationTable.Rows [0].Height;

            var formSize = this.ClientSize;

            if (adjColumnAndRows > 0)
            {
                formSize.Width = formSize.Width + (cntrlColumnWidth * adjColumnAndRows);
                formSize.Height = formSize.Height + (cntrlRowHeight * adjColumnAndRows);

                cntrlSize.Width = cntrlSize.Width + (cntrlColumnWidth * adjColumnAndRows);
                cntrlSize.Height = cntrlSize.Height + (cntrlRowHeight * adjColumnAndRows);
            }
            else if (adjColumnAndRows < 0)
            {
                formSize.Width = formSize.Width + (cntrlColumnWidth * adjColumnAndRows);
                formSize.Height = formSize.Height + (cntrlRowHeight * adjColumnAndRows);

                cntrlSize.Width = cntrlSize.Width + (cntrlColumnWidth * adjColumnAndRows);
                cntrlSize.Height = cntrlSize.Height + (cntrlRowHeight * adjColumnAndRows);
            }

            this.ClientSize = formSize;
            dgvMultiplicationTable.Size = cntrlSize;

            Application.DoEvents ();
        }
    }
}
