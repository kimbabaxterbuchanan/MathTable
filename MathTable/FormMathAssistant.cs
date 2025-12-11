using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Web;

namespace MathTable
{
    public partial class FormMathAssistant : Form
    {
        Random random;
        int multiplicantResults = 0;
        int multiplierResults = 0;
        int productResults = 0;
        bool bCorrectAnswer = false;
        String answerstr = string.Empty;

        int dividendResults = 0;
        int divisorResults = 0;
        int quotientResults = 0;
        int remainderResults = 0;
        bool freestyle = false;

        public FormMathAssistant()
        {
            InitializeComponent();
            object sender = new object();
            EventArgs e = new EventArgs();
            setRandomValues(sender, e);
            txtBxMultiplyMultiplicand.Text = multiplicantResults.ToString();
            txtBxMultiplyMultiplier.Text = multiplierResults.ToString();
            txtBxMultiplyProduct.Text = string.Empty;
            productResults = multiplicantResults * multiplierResults;
            txtBxMultiplyTestAnswer.Text = productResults.ToString();
            txtBxMultiplyTestAnswer.Enabled = false;
            bCorrectAnswer = false;
            btnMultiplyNext.Enabled = false;
            txtBxMultiplyMultiplicand.Enabled = false;
            txtBxMultiplyMultiplier.Enabled = false;
            lblDivideRemainder.Enabled = false;
            txtBxRemainderAnswer.Enabled = false;
            lblDivideQuotient.Enabled = false;
            txtBxQuotientAnswer.Enabled = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            var multiplicantAnswer = Convert.ToInt32(string.IsNullOrEmpty(txtBxMultiplyMultiplicand.Text) ? "0" : txtBxMultiplyMultiplicand.Text);
            var multiplierAnswer = Convert.ToInt32(string.IsNullOrEmpty(txtBxMultiplyMultiplier.Text) ? "0" : txtBxMultiplyMultiplier.Text);
            int product = Convert.ToInt32(string.IsNullOrEmpty(txtBxMultiplyProduct.Text) ? "0" : txtBxMultiplyProduct.Text);
            txtBxMultiplyTestAnswer.Text = productResults.ToString();

            if (!rdBtnMultiplyMultiply.Checked && ! freestyle)
            {
                product = multiplicantAnswer * multiplierAnswer;
            }

            if (product == productResults)
            {
                txtBxMultiplyCorrect.Text = "Congratulations, You are correct";
                bCorrectAnswer = true;
                btnMultiplyNext.Enabled = !rdBtnMultiplyFreeStyle.Checked;
            }
            else
            {
                txtBxMultiplyCorrect.Text = "Wrong " + answerstr + " try again....";
                bCorrectAnswer = false;
                if (rdBtnMultiplyMultiply.Checked)
                {
                    txtBxMultiplyProduct.Text = string.Empty;
                    txtBxMultiplyProduct.Focus();
                }
                else
                {
                    if (rdBtnMultiplyMultiplier.Checked)
                    {
                        txtBxMultiplyMultiplier.Text = string.Empty;
                        txtBxMultiplyMultiplier.Focus();

                    }
                    if (rdBtnMultiplyMultiplicand.Checked)
                    {
                        txtBxMultiplyMultiplicand.Text = string.Empty;
                        txtBxMultiplyMultiplicand.Focus();
                    }


                }
            }
        }

        private void setRandomValues(object sender, EventArgs e)
        {
            rdBtnMultiply_CheckedChanged(sender, e);
            rdBtnMultiplicand_CheckedChanged(sender, e);
            rdBtnMultiplier_CheckedChanged(sender, e);
            rdBtnDivide_CheckedChanged(sender, e);
            rdBtnDividend_CheckedChanged(sender, e);
            rdBtnDivisor_CheckedChanged(sender, e);
        }

        private void rdBtnMultiply_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMultiplyMultiply.Checked)
            {
                bCorrectAnswer = false;
                random = new Random();
                multiplicantResults = random.Next(1, 12);
                multiplierResults = random.Next(1, 12);
                txtBxMultiplyMultiplicand.Text = multiplicantResults.ToString();
                txtBxMultiplyMultiplier.Text = multiplierResults.ToString();
                productResults = multiplicantResults * multiplierResults;
                txtBxMultiplyProduct.Text = string.Empty;
                txtBxMultiplyTestAnswer.Text = productResults.ToString();
                lblMultiplyAnswer.Text = "Correct Answer";
                txtBxMultiplyProduct.Enabled = true;
                txtBxMultiplyMultiplicand.Enabled = false;
                txtBxMultiplyMultiplier.Enabled = false;
                showAddition(multiplicantResults, multiplierResults);
            }
        }

        private void rdBtnMultiplicand_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMultiplyMultiplicand.Checked)
            {
                bCorrectAnswer = false;
                random = new Random();
                multiplicantResults = random.Next(1, 12);
                multiplierResults = random.Next(1, 12);

                txtBxMultiplyMultiplicand.Text = string.Empty;
                txtBxMultiplyMultiplier.Text = multiplierResults.ToString();
                productResults = multiplicantResults * multiplierResults;
                txtBxMultiplyProduct.Text = productResults.ToString();
                txtBxMultiplyTestAnswer.Text = multiplicantResults.ToString();
 //               lblMultiplyAnswer.Text = "Your Answer";
                txtBxMultiplyProduct.Enabled = false;
                txtBxMultiplyMultiplicand.Enabled = true;
                txtBxMultiplyMultiplier.Enabled = false;
                showAddition(multiplicantResults, multiplierResults);
            }
        }

        private void rdBtnMultiplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMultiplyMultiplier.Checked)
            {
                bCorrectAnswer = false;
                random = new Random();
                multiplicantResults = random.Next(1, 12);
                multiplierResults = random.Next(1, 12);

                txtBxMultiplyMultiplicand.Text = multiplicantResults.ToString();
                txtBxMultiplyMultiplier.Text = string.Empty;
                productResults = multiplicantResults * multiplierResults;
                txtBxMultiplyTestAnswer.Text = multiplierResults.ToString();
                txtBxMultiplyProduct.Text = productResults.ToString();
//                lblMultiplyAnswer.Text = "Your Answer";
                txtBxMultiplyProduct.Enabled = false;
                txtBxMultiplyMultiplicand.Enabled = false;
                txtBxMultiplyMultiplier.Enabled = true;
                showAddition(multiplicantResults, multiplierResults);
            }
        }

        private void txtBxMultiplicand_Leave(object sender, EventArgs e)
        {
            getFreeStyle();
            productResults = multiplicantResults * multiplierResults;
            txtBxMultiplyTestAnswer.Text = productResults.ToString();
        }

        private void txtBxMultiplier_Leave(object sender, EventArgs e)
        {
            getFreeStyle();
            productResults = multiplicantResults * multiplierResults;
            txtBxMultiplyTestAnswer.Text = productResults.ToString();
        }

        private void txtBxProduct_Leave(object sender, EventArgs e)
        {
            txtBxMultiplyTestAnswer.Text = productResults.ToString();
        }

        private int valuecheck(int valueToCheck)
        {
            try
            {

                    if (valueToCheck == 1 && !string.IsNullOrWhiteSpace(txtBxMultiplyMultiplicand.Text))
                    {
                        return Convert.ToInt32(txtBxMultiplyMultiplicand.Text);
                    }
                    if (valueToCheck == 2 && !string.IsNullOrWhiteSpace(txtBxMultiplyMultiplier.Text))
                    {
                        return Convert.ToInt32(txtBxMultiplyMultiplier.Text);
                    }
                    if (valueToCheck == 3 && !string.IsNullOrWhiteSpace(txtBxMultiplyProduct.Text))
                    {
                        return Convert.ToInt32(txtBxMultiplyProduct.Text);
                    }
                    if (valueToCheck == 4 && !string.IsNullOrWhiteSpace(txtBxDivisor.Text))
                    {
                        return Convert.ToInt32(txtBxDivisor.Text);
                    }
                    if (valueToCheck == 5 && !string.IsNullOrWhiteSpace(txtBxDividend.Text))
                    {
                        return Convert.ToInt32(txtBxDividend.Text);
                    }
                    if (valueToCheck == 6 && !string.IsNullOrWhiteSpace(txtBxQuotient.Text))
                    {
                        return Convert.ToInt32(txtBxQuotient.Text);
                    }
                    if (valueToCheck == 7 && !string.IsNullOrWhiteSpace(txtBxRemainder.Text))
                    {
                        return Convert.ToInt32(txtBxRemainder.Text);
                    }

            }
            catch
            {
                txtBxMultiplyCorrect.Text = "Not a valid Number";
            }
            return -1;
        }

        private void txtBxProduct_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!rdBtnMultiplyFreeStyle.Checked)
            {
                clearTextBoxes();
                if (bCorrectAnswer)
                {
                    setRandomValues(sender, e);
                }
            }
            btnMultiplyNext.Enabled = false;
        }

        private void clearTextBoxes()
        {
            txtBxMultiplyTestAnswer.Text = string.Empty;
            txtBxMultiplyCorrect.Text = string.Empty;
            txtBxMultiplyMultiplicand.Text = string.Empty;
            txtBxMultiplyProduct.Text = string.Empty;
            txtBxMultiplyMultiplier.Text = string.Empty;
            btnMultiplyNext.Enabled = false;

            txtBxRemainder.Text = string.Empty;
            txtBxQuotient.Text = string.Empty;
            txtBxDividend.Text = string.Empty;
            txtBxDivisor.Text = string.Empty;
            txtBxQuotientAnswer.Text = string.Empty;
            txtBxRemainderAnswer.Text = string.Empty;  
            txtBxDivideCorrect .Text = string.Empty;
            btnDivideNext.Enabled = false;
            lblAddition.Text = string.Empty;
        }

        private void txtBxTestAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBxShow_CheckedChanged(object sender, EventArgs e)
        {
            pnlAnswer.Visible = chkBxMultiplyShow.Checked;
        }

        private void showAddition(int multiplicand, int multiplier)
        {
            int product = 0;
            string plusSign = "   ";
            lblAddition.Text = string.Empty;
            for (int i = 0; i < multiplier; i++)
            {
                lblAddition.Text += plusSign + multiplicand.ToString() + Environment.NewLine;
                product += multiplicand;
                lblAddition.Refresh();
                plusSign = "+ ";
            }
            lblAddition.Text += "--------------" + Environment.NewLine;
            lblAddition.Text += " " + product.ToString();
        }

        private void rdBtnFreeStyle_CheckedChanged(object sender, EventArgs e)
        {
            FormShowMultiplicationWork formShowMultiplicationWork = new FormShowMultiplicationWork();
            formShowMultiplicationWork.ShowDialog();
            
            freestyle = rdBtnMultiplyFreeStyle.Checked;
            if (rdBtnMultiplyFreeStyle.Checked)
            {
                txtBxMultiplyProduct.Enabled = true;
                txtBxMultiplyMultiplicand.Enabled = true;
                txtBxMultiplyMultiplier.Enabled = true;
                btnMultiplyNext.Enabled = false;
                lblMultiplyAnswer.Text = "Correct Answer";
            }
            
        }

        private void rdBtnDivide_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnDivide.Checked)
            {
                bCorrectAnswer = false;
                random = new Random();
                divisorResults = random.Next(1, 12);
                dividendResults = random.Next(1, 12)+divisorResults;
                txtBxDivisor.Text = divisorResults.ToString();
                txtBxDividend.Text = dividendResults.ToString();
                quotientResults = dividendResults / divisorResults;
                remainderResults = Convert.ToInt32(dividendResults - Convert.ToDecimal((divisorResults * quotientResults)));
                txtBxQuotient.Text = string.Empty;
                txtBxQuotientAnswer.Text = quotientResults.ToString();
                txtBxRemainder.Text = string.Empty;
                txtBxRemainderAnswer.Text = remainderResults.ToString();
                lblDivideAnswer.Text = "Correct Answer";
                lblDivideQuotient.Text = "quotient";
                txtBxQuotient.Enabled = true;
                txtBxRemainder.Enabled = true;
                txtBxDividend.Enabled = false;
                txtBxDivisor.Enabled = false;
                showSubtraction(dividendResults, divisorResults, quotientResults);
            }
        }

        private void rdBtnDividend_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnDividend.Checked)
            {
                bCorrectAnswer = false;
                random = new Random();
                divisorResults = random.Next(1, 12);
                dividendResults = random.Next(1, 12) + divisorResults;
                txtBxDivisor.Text = divisorResults.ToString();
                txtBxDividend.Text = string.Empty;
                quotientResults = dividendResults / divisorResults;
                remainderResults = Convert.ToInt32(dividendResults - Convert.ToDecimal((divisorResults * quotientResults)));

                txtBxQuotient.Text = quotientResults.ToString();
                txtBxQuotientAnswer.Text = dividendResults.ToString();
                txtBxRemainder.Text = remainderResults == 0 ? string.Empty : remainderResults.ToString();
                txtBxRemainderAnswer.Text = string.Empty;
                lblDivideAnswer.Text = "Your Answer";
                lblDivideQuotient.Text = "dividend";
                txtBxQuotient.Enabled = false;
                txtBxRemainder.Enabled = false;
                txtBxDividend.Enabled = true;
                txtBxDivisor.Enabled = false;
                showSubtraction(dividendResults, divisorResults, quotientResults);
            }
        }

        private void rdBtnDivisor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnDivisor.Checked)
            {
                bCorrectAnswer = false;
                random = new Random();
                divisorResults = random.Next(1, 12);
                dividendResults = random.Next(1, 12) + divisorResults;
                txtBxDivisor.Text = string.Empty;
                txtBxDividend.Text = dividendResults.ToString();
                quotientResults = dividendResults / divisorResults;
                remainderResults = Convert.ToInt32(dividendResults - Convert.ToDecimal((divisorResults * quotientResults)));

                txtBxQuotient.Text = quotientResults.ToString();
                txtBxQuotientAnswer.Text = divisorResults.ToString();
                txtBxRemainder.Text = remainderResults == 0 ? string.Empty : remainderResults.ToString();
                txtBxRemainderAnswer.Text = string.Empty;
                lblDivideAnswer.Text = "Your Answer";
                lblDivideQuotient.Text = "divisor";
                txtBxQuotient.Enabled = false;
                txtBxRemainder.Enabled = false;
                txtBxDividend.Enabled = false;
                txtBxDivisor.Enabled = true;
                showSubtraction(dividendResults, divisorResults, quotientResults);
            }
        }

        private void rdBtnDivideFreeStyle_CheckedChanged(object sender, EventArgs e)
        {
            FormShowDivisionWork formShowDivisionWork = new FormShowDivisionWork();
            formShowDivisionWork.ShowDialog();

            freestyle = rdBtnDivideFreeStyle.Checked;
            if (rdBtnDivideFreeStyle.Checked)
            {
                lblDivideAnswer.Text = "Correct Answer";
                lblDivideQuotient.Text = "quotient";
                txtBxQuotient.Enabled = true;
                txtBxRemainder.Enabled = true;
                txtBxDividend.Enabled = true;
                txtBxDivisor.Enabled = true;
                btnDivideNext.Enabled = false;
            }

        }

        private void btnDivideAnswer_Click(object sender, EventArgs e)
        {
            int dividend = Convert.ToInt32(String.IsNullOrWhiteSpace(txtBxDividend.Text) ? "1" : txtBxDividend.Text);
            int divisor = Convert.ToInt32(String.IsNullOrWhiteSpace(txtBxDivisor.Text) ? "1" : txtBxDivisor.Text);
            int quotient = Convert.ToInt32(String.IsNullOrWhiteSpace(txtBxQuotient.Text) ? "0" : txtBxQuotient.Text);
            int remainder = Convert.ToInt32(string.IsNullOrWhiteSpace(txtBxRemainder.Text) == true ? 0 : Convert.ToInt32(txtBxRemainder.Text));

            if (!rdBtnDivide.Checked && !freestyle)
            {
                 quotient = dividend / divisor;
                 remainder = dividend - (divisor * quotient);
            }
            else if (freestyle)
            {
                quotientResults = dividendResults / divisorResults;
                remainderResults = Convert.ToInt32(dividendResults - Convert.ToDecimal((divisorResults * quotientResults)));
                txtBxQuotientAnswer.Text = quotientResults.ToString();
                txtBxRemainderAnswer.Text = remainderResults.ToString();
            }

            if (quotient == quotientResults &&  remainder == remainderResults)
            {
                txtBxDivideCorrect.Text = "Congratulations, You are correct";
                bCorrectAnswer = true;
                btnDivideNext.Enabled = !rdBtnDivideFreeStyle.Checked;
            }
            else
            {
                txtBxDivideCorrect.Text = "Wrong " + answerstr + " try again....";
                bCorrectAnswer = false;
                if (rdBtnDivide.Checked)
                {
                    txtBxQuotient.Text = string.Empty;
                    txtBxRemainder.Text = string.Empty;
                    txtBxQuotient.Focus();
                }
                if (rdBtnDividend.Checked)
                {
                    txtBxDividend.Text = string.Empty;
                    txtBxDividend.Focus();
                }
                if (rdBtnDivisor.Checked)
                {
                    txtBxDivisor.Text = string.Empty;
                    txtBxDivisor.Focus();
                }
                btnDivideNext.Enabled = false;
            }
        }

        private void btnDivideNext_Click(object sender, EventArgs e)
        {
            if (!rdBtnDivideFreeStyle.Checked)
            {
                clearTextBoxes();
                if (bCorrectAnswer)
                {
                    setRandomValues(sender, e);
                }
            }
            btnDivideNext.Enabled = false;
        }



        private void chkBxDivideShow_CheckedChanged(object sender, EventArgs e)
        {
            pnlDivideShow.Visible = chkBxDivideShow.Checked;
         }

        private void showSubtraction(int dividend, int divisor, int quotientResults)
        {
            string minusSign = "   ";
            lblSubtract.Text = string.Empty;
            int quotient = 0;
            int remainder = 0;

            for (int i = 0; i < quotientResults; i++)
            {
                lblSubtract.Text += minusSign + divisor.ToString() + Environment.NewLine;
                lblSubtract.Refresh();
                quotient = quotient + divisor;
                minusSign = "+ ";
            }
            remainder = dividend - quotient;
            lblSubtract.Text += "--------------" + Environment.NewLine;
            lblSubtract.Text += "   " + quotientResults.ToString() + " needing " + remainder.ToString();
        }

        private void txtBxDivisor_Leave(object sender, EventArgs e)
        {

            getFreeStyle();
        }

        private void txtBxDividend_Leave(object sender, EventArgs e)
        {
            getFreeStyle();
        }

        private void txtBxQuotient_Leave(object sender, EventArgs e)
        {
            getFreeStyle();
        }

        private void txtBxRemainder_Leave(object sender, EventArgs e)
        {
            getFreeStyle();
        }

        private void getFreeStyle()
        {
            if (freestyle)
            {
                var multiplicantResult = valuecheck(1);
                if (multiplicantResult > -1)
                {
                    multiplicantResults = multiplicantResult;
                }
                var multiplierResult = valuecheck(2);
                if (multiplierResult > -1)
                {
                    multiplierResults = multiplierResult;
                }
                var productResult = valuecheck(3);
                if (productResult > -1)
                {
                    productResults = productResult;
                }

                var divisorResult = valuecheck(4);
                if (divisorResult > -1)
                {
                    divisorResults = divisorResult;
                }
                var dividendResult = valuecheck(5);
                if (dividendResult > -1)
                {
                    dividendResults = dividendResult;
                }
                var quotientResult = valuecheck(6);
                if (quotientResult > -1)
                {
                    quotientResults = quotientResult;
                }
                var remainderResult = valuecheck(7);
                if (remainderResult > -1)
                {
                    remainderResults = remainderResult;
                }
            }
        }

        private void Math_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectIdx = Math.SelectedIndex;
            if (selectIdx == 0)
            {
                freestyle = false;
                rdBtnMultiplyMultiply.Checked = true;
            }
            if (selectIdx == 1)
            {
                freestyle = false;
                rdBtnDivide.Checked = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBxRemainder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultiplicationTable_Click(object sender, EventArgs e)
        {
            var formMultiplicationTable = new FormMultiplicationTable();
            formMultiplicationTable.Show();
        }

        private void btnShowMultiWork_Click(object sender, EventArgs e)
        {
            FormShowMultiplicationWork formShowMultiplicationWork = new FormShowMultiplicationWork();
            formShowMultiplicationWork.ShowDialog();
        }

        private void btnShowDivWork_Click(object sender, EventArgs e)
        {
            FormShowDivisionWork formShowDivisionWork = new FormShowDivisionWork();
            formShowDivisionWork.ShowDialog();
        }

        private void txtBxQuotientAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
