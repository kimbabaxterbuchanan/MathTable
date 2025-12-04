namespace MathTable
{
    partial class FormMathAssistant
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
            this.Math = new System.Windows.Forms.TabControl();
            this.tabMultiply = new System.Windows.Forms.TabPage();
            this.rdBtnMultiplyFreeStyle = new System.Windows.Forms.RadioButton();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.lblMultiplyAnswer = new System.Windows.Forms.Label();
            this.txtBxMultiplyTestAnswer = new System.Windows.Forms.TextBox();
            this.chkBxMultiplyShow = new System.Windows.Forms.CheckBox();
            this.btnMultiplyNext = new System.Windows.Forms.Button();
            this.lblMultiplyEquals = new System.Windows.Forms.Label();
            this.txtBxMultiplyCorrect = new System.Windows.Forms.TextBox();
            this.lblMultiplyCorrect = new System.Windows.Forms.Label();
            this.rdBtnMultiplyMultiplier = new System.Windows.Forms.RadioButton();
            this.rdBtnMultiplyMultiplicand = new System.Windows.Forms.RadioButton();
            this.rdBtnMultiplyMultiply = new System.Windows.Forms.RadioButton();
            this.btnMultiplyEquals = new System.Windows.Forms.Button();
            this.lblMultiplyProduct = new System.Windows.Forms.Label();
            this.lblMultiplyMultiplier = new System.Windows.Forms.Label();
            this.lblMultiplyMultiplicant = new System.Windows.Forms.Label();
            this.txtBxMultiplyProduct = new System.Windows.Forms.TextBox();
            this.lblMultiplySign = new System.Windows.Forms.Label();
            this.txtBxMultiplyMultiplier = new System.Windows.Forms.TextBox();
            this.txtBxMultiplyMultiplicand = new System.Windows.Forms.TextBox();
            this.tabDivide = new System.Windows.Forms.TabPage();
            this.lblQuotient = new System.Windows.Forms.Label();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.txtBxRemainder = new System.Windows.Forms.TextBox();
            this.txtBxQuotient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnDivideFreeStyle = new System.Windows.Forms.RadioButton();
            this.pnlDivideShow = new System.Windows.Forms.Panel();
            this.txtBxRemainderAnswer = new System.Windows.Forms.TextBox();
            this.lblDivideAnswer = new System.Windows.Forms.Label();
            this.txtBxQuotientAnswer = new System.Windows.Forms.TextBox();
            this.lblDivideQuotient = new System.Windows.Forms.Label();
            this.lblDivideRemainder = new System.Windows.Forms.Label();
            this.chkBxDivideShow = new System.Windows.Forms.CheckBox();
            this.btnDivideNext = new System.Windows.Forms.Button();
            this.txtBxDivideCorrect = new System.Windows.Forms.TextBox();
            this.lblDivideCorrect = new System.Windows.Forms.Label();
            this.rdBtnDivisor = new System.Windows.Forms.RadioButton();
            this.rdBtnDividend = new System.Windows.Forms.RadioButton();
            this.rdBtnDivide = new System.Windows.Forms.RadioButton();
            this.btnDivideAnswer = new System.Windows.Forms.Button();
            this.lblDivideDivisor = new System.Windows.Forms.Label();
            this.lblDivideDividend = new System.Windows.Forms.Label();
            this.lblDivideSign = new System.Windows.Forms.Label();
            this.txtBxDivisor = new System.Windows.Forms.TextBox();
            this.txtBxDividend = new System.Windows.Forms.TextBox();
            this.btnMultiplicationTable = new System.Windows.Forms.Button();
            this.btnShowMultiWork = new System.Windows.Forms.Button();
            this.btnShowDivWork = new System.Windows.Forms.Button();
            this.Math.SuspendLayout();
            this.tabMultiply.SuspendLayout();
            this.pnlAnswer.SuspendLayout();
            this.tabDivide.SuspendLayout();
            this.pnlDivideShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // Math
            // 
            this.Math.Controls.Add(this.tabMultiply);
            this.Math.Controls.Add(this.tabDivide);
            this.Math.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Math.Location = new System.Drawing.Point(32, 49);
            this.Math.Name = "Math";
            this.Math.SelectedIndex = 0;
            this.Math.Size = new System.Drawing.Size(937, 509);
            this.Math.TabIndex = 2;
            this.Math.SelectedIndexChanged += new System.EventHandler(this.Math_SelectedIndexChanged);
            // 
            // tabMultiply
            // 
            this.tabMultiply.Controls.Add(this.btnShowMultiWork);
            this.tabMultiply.Controls.Add(this.rdBtnMultiplyFreeStyle);
            this.tabMultiply.Controls.Add(this.pnlAnswer);
            this.tabMultiply.Controls.Add(this.chkBxMultiplyShow);
            this.tabMultiply.Controls.Add(this.btnMultiplyNext);
            this.tabMultiply.Controls.Add(this.lblMultiplyEquals);
            this.tabMultiply.Controls.Add(this.txtBxMultiplyCorrect);
            this.tabMultiply.Controls.Add(this.lblMultiplyCorrect);
            this.tabMultiply.Controls.Add(this.rdBtnMultiplyMultiplier);
            this.tabMultiply.Controls.Add(this.rdBtnMultiplyMultiplicand);
            this.tabMultiply.Controls.Add(this.rdBtnMultiplyMultiply);
            this.tabMultiply.Controls.Add(this.btnMultiplyEquals);
            this.tabMultiply.Controls.Add(this.lblMultiplyProduct);
            this.tabMultiply.Controls.Add(this.lblMultiplyMultiplier);
            this.tabMultiply.Controls.Add(this.lblMultiplyMultiplicant);
            this.tabMultiply.Controls.Add(this.txtBxMultiplyProduct);
            this.tabMultiply.Controls.Add(this.lblMultiplySign);
            this.tabMultiply.Controls.Add(this.txtBxMultiplyMultiplier);
            this.tabMultiply.Controls.Add(this.txtBxMultiplyMultiplicand);
            this.tabMultiply.Location = new System.Drawing.Point(4, 33);
            this.tabMultiply.Name = "tabMultiply";
            this.tabMultiply.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiply.Size = new System.Drawing.Size(929, 472);
            this.tabMultiply.TabIndex = 0;
            this.tabMultiply.Text = "Multiply";
            this.tabMultiply.UseVisualStyleBackColor = true;
            // 
            // rdBtnMultiplyFreeStyle
            // 
            this.rdBtnMultiplyFreeStyle.AutoSize = true;
            this.rdBtnMultiplyFreeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMultiplyFreeStyle.Location = new System.Drawing.Point(500, 33);
            this.rdBtnMultiplyFreeStyle.Name = "rdBtnMultiplyFreeStyle";
            this.rdBtnMultiplyFreeStyle.Size = new System.Drawing.Size(123, 28);
            this.rdBtnMultiplyFreeStyle.TabIndex = 21;
            this.rdBtnMultiplyFreeStyle.Text = "Free Style";
            this.rdBtnMultiplyFreeStyle.UseVisualStyleBackColor = true;
            this.rdBtnMultiplyFreeStyle.Visible = false;
            this.rdBtnMultiplyFreeStyle.CheckedChanged += new System.EventHandler(this.rdBtnFreeStyle_CheckedChanged);
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.Controls.Add(this.lblMultiplyAnswer);
            this.pnlAnswer.Controls.Add(this.txtBxMultiplyTestAnswer);
            this.pnlAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAnswer.Location = new System.Drawing.Point(479, 210);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(439, 46);
            this.pnlAnswer.TabIndex = 20;
            this.pnlAnswer.Visible = false;
            this.pnlAnswer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMultiplyAnswer
            // 
            this.lblMultiplyAnswer.AutoSize = true;
            this.lblMultiplyAnswer.Location = new System.Drawing.Point(5, 9);
            this.lblMultiplyAnswer.Name = "lblMultiplyAnswer";
            this.lblMultiplyAnswer.Size = new System.Drawing.Size(154, 24);
            this.lblMultiplyAnswer.TabIndex = 18;
            this.lblMultiplyAnswer.Text = "Correct Answer";
            // 
            // txtBxMultiplyTestAnswer
            // 
            this.txtBxMultiplyTestAnswer.Location = new System.Drawing.Point(165, 9);
            this.txtBxMultiplyTestAnswer.Name = "txtBxMultiplyTestAnswer";
            this.txtBxMultiplyTestAnswer.Size = new System.Drawing.Size(260, 29);
            this.txtBxMultiplyTestAnswer.TabIndex = 16;
            this.txtBxMultiplyTestAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxMultiplyTestAnswer.TextChanged += new System.EventHandler(this.txtBxTestAnswer_TextChanged);
            // 
            // chkBxMultiplyShow
            // 
            this.chkBxMultiplyShow.AutoSize = true;
            this.chkBxMultiplyShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxMultiplyShow.Location = new System.Drawing.Point(316, 215);
            this.chkBxMultiplyShow.Name = "chkBxMultiplyShow";
            this.chkBxMultiplyShow.Size = new System.Drawing.Size(157, 28);
            this.chkBxMultiplyShow.TabIndex = 19;
            this.chkBxMultiplyShow.Text = "Show Answer";
            this.chkBxMultiplyShow.UseVisualStyleBackColor = true;
            this.chkBxMultiplyShow.CheckedChanged += new System.EventHandler(this.chkBxShow_CheckedChanged);
            // 
            // btnMultiplyNext
            // 
            this.btnMultiplyNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplyNext.Location = new System.Drawing.Point(304, 334);
            this.btnMultiplyNext.Name = "btnMultiplyNext";
            this.btnMultiplyNext.Size = new System.Drawing.Size(110, 36);
            this.btnMultiplyNext.TabIndex = 17;
            this.btnMultiplyNext.Text = "Next";
            this.btnMultiplyNext.UseVisualStyleBackColor = true;
            this.btnMultiplyNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMultiplyEquals
            // 
            this.lblMultiplyEquals.AutoSize = true;
            this.lblMultiplyEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplyEquals.Location = new System.Drawing.Point(225, 197);
            this.lblMultiplyEquals.Name = "lblMultiplyEquals";
            this.lblMultiplyEquals.Size = new System.Drawing.Size(22, 24);
            this.lblMultiplyEquals.TabIndex = 15;
            this.lblMultiplyEquals.Text = "=";
            // 
            // txtBxMultiplyCorrect
            // 
            this.txtBxMultiplyCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMultiplyCorrect.Location = new System.Drawing.Point(150, 402);
            this.txtBxMultiplyCorrect.Name = "txtBxMultiplyCorrect";
            this.txtBxMultiplyCorrect.Size = new System.Drawing.Size(635, 29);
            this.txtBxMultiplyCorrect.TabIndex = 14;
            // 
            // lblMultiplyCorrect
            // 
            this.lblMultiplyCorrect.AutoSize = true;
            this.lblMultiplyCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplyCorrect.Location = new System.Drawing.Point(67, 405);
            this.lblMultiplyCorrect.Name = "lblMultiplyCorrect";
            this.lblMultiplyCorrect.Size = new System.Drawing.Size(78, 24);
            this.lblMultiplyCorrect.TabIndex = 13;
            this.lblMultiplyCorrect.Text = "Correct";
            // 
            // rdBtnMultiplyMultiplier
            // 
            this.rdBtnMultiplyMultiplier.AutoSize = true;
            this.rdBtnMultiplyMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMultiplyMultiplier.Location = new System.Drawing.Point(347, 33);
            this.rdBtnMultiplyMultiplier.Name = "rdBtnMultiplyMultiplier";
            this.rdBtnMultiplyMultiplier.Size = new System.Drawing.Size(108, 28);
            this.rdBtnMultiplyMultiplier.TabIndex = 12;
            this.rdBtnMultiplyMultiplier.Text = "Muliplier";
            this.rdBtnMultiplyMultiplier.UseVisualStyleBackColor = true;
            this.rdBtnMultiplyMultiplier.CheckedChanged += new System.EventHandler(this.rdBtnMultiplier_CheckedChanged);
            // 
            // rdBtnMultiplyMultiplicand
            // 
            this.rdBtnMultiplyMultiplicand.AutoSize = true;
            this.rdBtnMultiplyMultiplicand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMultiplyMultiplicand.Location = new System.Drawing.Point(176, 33);
            this.rdBtnMultiplyMultiplicand.Name = "rdBtnMultiplyMultiplicand";
            this.rdBtnMultiplyMultiplicand.Size = new System.Drawing.Size(140, 28);
            this.rdBtnMultiplyMultiplicand.TabIndex = 11;
            this.rdBtnMultiplyMultiplicand.Text = "Multiplicand";
            this.rdBtnMultiplyMultiplicand.UseVisualStyleBackColor = true;
            this.rdBtnMultiplyMultiplicand.CheckedChanged += new System.EventHandler(this.rdBtnMultiplicand_CheckedChanged);
            // 
            // rdBtnMultiplyMultiply
            // 
            this.rdBtnMultiplyMultiply.AutoSize = true;
            this.rdBtnMultiplyMultiply.Checked = true;
            this.rdBtnMultiplyMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMultiplyMultiply.Location = new System.Drawing.Point(66, 33);
            this.rdBtnMultiplyMultiply.Name = "rdBtnMultiplyMultiply";
            this.rdBtnMultiplyMultiply.Size = new System.Drawing.Size(99, 28);
            this.rdBtnMultiplyMultiply.TabIndex = 10;
            this.rdBtnMultiplyMultiply.TabStop = true;
            this.rdBtnMultiplyMultiply.Text = "Multiply";
            this.rdBtnMultiplyMultiply.UseVisualStyleBackColor = true;
            this.rdBtnMultiplyMultiply.CheckedChanged += new System.EventHandler(this.rdBtnMultiply_CheckedChanged);
            // 
            // btnMultiplyEquals
            // 
            this.btnMultiplyEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplyEquals.Location = new System.Drawing.Point(147, 334);
            this.btnMultiplyEquals.Name = "btnMultiplyEquals";
            this.btnMultiplyEquals.Size = new System.Drawing.Size(110, 36);
            this.btnMultiplyEquals.TabIndex = 9;
            this.btnMultiplyEquals.Text = "Answer";
            this.btnMultiplyEquals.UseVisualStyleBackColor = true;
            this.btnMultiplyEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // lblMultiplyProduct
            // 
            this.lblMultiplyProduct.AutoSize = true;
            this.lblMultiplyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplyProduct.Location = new System.Drawing.Point(62, 223);
            this.lblMultiplyProduct.Name = "lblMultiplyProduct";
            this.lblMultiplyProduct.Size = new System.Drawing.Size(81, 24);
            this.lblMultiplyProduct.TabIndex = 8;
            this.lblMultiplyProduct.Text = "product";
            // 
            // lblMultiplyMultiplier
            // 
            this.lblMultiplyMultiplier.AutoSize = true;
            this.lblMultiplyMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplyMultiplier.Location = new System.Drawing.Point(62, 168);
            this.lblMultiplyMultiplier.Name = "lblMultiplyMultiplier";
            this.lblMultiplyMultiplier.Size = new System.Drawing.Size(95, 24);
            this.lblMultiplyMultiplier.TabIndex = 7;
            this.lblMultiplyMultiplier.Text = "multiplier";
            // 
            // lblMultiplyMultiplicant
            // 
            this.lblMultiplyMultiplicant.AutoSize = true;
            this.lblMultiplyMultiplicant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplyMultiplicant.Location = new System.Drawing.Point(62, 111);
            this.lblMultiplyMultiplicant.Name = "lblMultiplyMultiplicant";
            this.lblMultiplyMultiplicant.Size = new System.Drawing.Size(122, 24);
            this.lblMultiplyMultiplicant.TabIndex = 6;
            this.lblMultiplyMultiplicant.Text = "multiplicand";
            // 
            // txtBxMultiplyProduct
            // 
            this.txtBxMultiplyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMultiplyProduct.Location = new System.Drawing.Point(187, 220);
            this.txtBxMultiplyProduct.Name = "txtBxMultiplyProduct";
            this.txtBxMultiplyProduct.Size = new System.Drawing.Size(100, 29);
            this.txtBxMultiplyProduct.TabIndex = 5;
            this.txtBxMultiplyProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxMultiplyProduct.TextChanged += new System.EventHandler(this.txtBxProduct_TextChanged);
            this.txtBxMultiplyProduct.Leave += new System.EventHandler(this.txtBxProduct_Leave);
            // 
            // lblMultiplySign
            // 
            this.lblMultiplySign.AutoSize = true;
            this.lblMultiplySign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplySign.Location = new System.Drawing.Point(225, 138);
            this.lblMultiplySign.Name = "lblMultiplySign";
            this.lblMultiplySign.Size = new System.Drawing.Size(25, 24);
            this.lblMultiplySign.TabIndex = 3;
            this.lblMultiplySign.Text = "X";
            // 
            // txtBxMultiplyMultiplier
            // 
            this.txtBxMultiplyMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMultiplyMultiplier.Location = new System.Drawing.Point(187, 165);
            this.txtBxMultiplyMultiplier.Name = "txtBxMultiplyMultiplier";
            this.txtBxMultiplyMultiplier.Size = new System.Drawing.Size(100, 29);
            this.txtBxMultiplyMultiplier.TabIndex = 2;
            this.txtBxMultiplyMultiplier.Text = "1";
            this.txtBxMultiplyMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxMultiplyMultiplier.Leave += new System.EventHandler(this.txtBxMultiplier_Leave);
            // 
            // txtBxMultiplyMultiplicand
            // 
            this.txtBxMultiplyMultiplicand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMultiplyMultiplicand.Location = new System.Drawing.Point(187, 108);
            this.txtBxMultiplyMultiplicand.Name = "txtBxMultiplyMultiplicand";
            this.txtBxMultiplyMultiplicand.Size = new System.Drawing.Size(100, 29);
            this.txtBxMultiplyMultiplicand.TabIndex = 1;
            this.txtBxMultiplyMultiplicand.Text = "1";
            this.txtBxMultiplyMultiplicand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxMultiplyMultiplicand.Leave += new System.EventHandler(this.txtBxMultiplicand_Leave);
            // 
            // tabDivide
            // 
            this.tabDivide.Controls.Add(this.btnShowDivWork);
            this.tabDivide.Controls.Add(this.lblQuotient);
            this.tabDivide.Controls.Add(this.lblRemainder);
            this.tabDivide.Controls.Add(this.txtBxRemainder);
            this.tabDivide.Controls.Add(this.txtBxQuotient);
            this.tabDivide.Controls.Add(this.label2);
            this.tabDivide.Controls.Add(this.label1);
            this.tabDivide.Controls.Add(this.rdBtnDivideFreeStyle);
            this.tabDivide.Controls.Add(this.pnlDivideShow);
            this.tabDivide.Controls.Add(this.chkBxDivideShow);
            this.tabDivide.Controls.Add(this.btnDivideNext);
            this.tabDivide.Controls.Add(this.txtBxDivideCorrect);
            this.tabDivide.Controls.Add(this.lblDivideCorrect);
            this.tabDivide.Controls.Add(this.rdBtnDivisor);
            this.tabDivide.Controls.Add(this.rdBtnDividend);
            this.tabDivide.Controls.Add(this.rdBtnDivide);
            this.tabDivide.Controls.Add(this.btnDivideAnswer);
            this.tabDivide.Controls.Add(this.lblDivideDivisor);
            this.tabDivide.Controls.Add(this.lblDivideDividend);
            this.tabDivide.Controls.Add(this.lblDivideSign);
            this.tabDivide.Controls.Add(this.txtBxDivisor);
            this.tabDivide.Controls.Add(this.txtBxDividend);
            this.tabDivide.Location = new System.Drawing.Point(4, 33);
            this.tabDivide.Name = "tabDivide";
            this.tabDivide.Padding = new System.Windows.Forms.Padding(3);
            this.tabDivide.Size = new System.Drawing.Size(929, 472);
            this.tabDivide.TabIndex = 1;
            this.tabDivide.Text = "Divide";
            this.tabDivide.UseVisualStyleBackColor = true;
            // 
            // lblQuotient
            // 
            this.lblQuotient.AutoSize = true;
            this.lblQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotient.Location = new System.Drawing.Point(201, 155);
            this.lblQuotient.Name = "lblQuotient";
            this.lblQuotient.Size = new System.Drawing.Size(85, 24);
            this.lblQuotient.TabIndex = 44;
            this.lblQuotient.Text = "quotient";
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainder.Location = new System.Drawing.Point(377, 155);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(105, 24);
            this.lblRemainder.TabIndex = 45;
            this.lblRemainder.Text = "remainder";
            // 
            // txtBxRemainder
            // 
            this.txtBxRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxRemainder.Location = new System.Drawing.Point(352, 182);
            this.txtBxRemainder.Name = "txtBxRemainder";
            this.txtBxRemainder.Size = new System.Drawing.Size(130, 29);
            this.txtBxRemainder.TabIndex = 40;
            this.txtBxRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxRemainder.TextChanged += new System.EventHandler(this.txtBxRemainder_TextChanged);
            this.txtBxRemainder.Leave += new System.EventHandler(this.txtBxRemainder_Leave);
            // 
            // txtBxQuotient
            // 
            this.txtBxQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxQuotient.Location = new System.Drawing.Point(164, 182);
            this.txtBxQuotient.Name = "txtBxQuotient";
            this.txtBxQuotient.Size = new System.Drawing.Size(154, 29);
            this.txtBxQuotient.TabIndex = 25;
            this.txtBxQuotient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxQuotient.Leave += new System.EventHandler(this.txtBxQuotient_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "______________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = " /";
            // 
            // rdBtnDivideFreeStyle
            // 
            this.rdBtnDivideFreeStyle.AutoSize = true;
            this.rdBtnDivideFreeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDivideFreeStyle.Location = new System.Drawing.Point(500, 34);
            this.rdBtnDivideFreeStyle.Name = "rdBtnDivideFreeStyle";
            this.rdBtnDivideFreeStyle.Size = new System.Drawing.Size(123, 28);
            this.rdBtnDivideFreeStyle.TabIndex = 39;
            this.rdBtnDivideFreeStyle.Text = "Free Style";
            this.rdBtnDivideFreeStyle.UseVisualStyleBackColor = true;
            this.rdBtnDivideFreeStyle.Visible = false;
            this.rdBtnDivideFreeStyle.CheckedChanged += new System.EventHandler(this.rdBtnDivideFreeStyle_CheckedChanged);
            // 
            // pnlDivideShow
            // 
            this.pnlDivideShow.Controls.Add(this.txtBxRemainderAnswer);
            this.pnlDivideShow.Controls.Add(this.lblDivideAnswer);
            this.pnlDivideShow.Controls.Add(this.txtBxQuotientAnswer);
            this.pnlDivideShow.Controls.Add(this.lblDivideQuotient);
            this.pnlDivideShow.Controls.Add(this.lblDivideRemainder);
            this.pnlDivideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDivideShow.Location = new System.Drawing.Point(500, 125);
            this.pnlDivideShow.Name = "pnlDivideShow";
            this.pnlDivideShow.Size = new System.Drawing.Size(413, 94);
            this.pnlDivideShow.TabIndex = 38;
            this.pnlDivideShow.Visible = false;
            // 
            // txtBxRemainderAnswer
            // 
            this.txtBxRemainderAnswer.Location = new System.Drawing.Point(246, 56);
            this.txtBxRemainderAnswer.Name = "txtBxRemainderAnswer";
            this.txtBxRemainderAnswer.Size = new System.Drawing.Size(151, 29);
            this.txtBxRemainderAnswer.TabIndex = 19;
            this.txtBxRemainderAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDivideAnswer
            // 
            this.lblDivideAnswer.AutoSize = true;
            this.lblDivideAnswer.Location = new System.Drawing.Point(12, 8);
            this.lblDivideAnswer.Name = "lblDivideAnswer";
            this.lblDivideAnswer.Size = new System.Drawing.Size(154, 24);
            this.lblDivideAnswer.TabIndex = 18;
            this.lblDivideAnswer.Text = "Correct Answer";
            // 
            // txtBxQuotientAnswer
            // 
            this.txtBxQuotientAnswer.Location = new System.Drawing.Point(16, 57);
            this.txtBxQuotientAnswer.Name = "txtBxQuotientAnswer";
            this.txtBxQuotientAnswer.Size = new System.Drawing.Size(186, 29);
            this.txtBxQuotientAnswer.TabIndex = 16;
            this.txtBxQuotientAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDivideQuotient
            // 
            this.lblDivideQuotient.AutoSize = true;
            this.lblDivideQuotient.Location = new System.Drawing.Point(81, 32);
            this.lblDivideQuotient.Name = "lblDivideQuotient";
            this.lblDivideQuotient.Size = new System.Drawing.Size(85, 24);
            this.lblDivideQuotient.TabIndex = 28;
            this.lblDivideQuotient.Text = "quotient";
            // 
            // lblDivideRemainder
            // 
            this.lblDivideRemainder.AutoSize = true;
            this.lblDivideRemainder.Location = new System.Drawing.Point(268, 29);
            this.lblDivideRemainder.Name = "lblDivideRemainder";
            this.lblDivideRemainder.Size = new System.Drawing.Size(105, 24);
            this.lblDivideRemainder.TabIndex = 41;
            this.lblDivideRemainder.Text = "remainder";
            // 
            // chkBxDivideShow
            // 
            this.chkBxDivideShow.AutoSize = true;
            this.chkBxDivideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxDivideShow.Location = new System.Drawing.Point(500, 91);
            this.chkBxDivideShow.Name = "chkBxDivideShow";
            this.chkBxDivideShow.Size = new System.Drawing.Size(157, 28);
            this.chkBxDivideShow.TabIndex = 37;
            this.chkBxDivideShow.Text = "Show Answer";
            this.chkBxDivideShow.UseVisualStyleBackColor = true;
            this.chkBxDivideShow.CheckedChanged += new System.EventHandler(this.chkBxDivideShow_CheckedChanged);
            // 
            // btnDivideNext
            // 
            this.btnDivideNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivideNext.Location = new System.Drawing.Point(344, 330);
            this.btnDivideNext.Name = "btnDivideNext";
            this.btnDivideNext.Size = new System.Drawing.Size(110, 36);
            this.btnDivideNext.TabIndex = 36;
            this.btnDivideNext.Text = "Next";
            this.btnDivideNext.UseVisualStyleBackColor = true;
            this.btnDivideNext.Click += new System.EventHandler(this.btnDivideNext_Click);
            // 
            // txtBxDivideCorrect
            // 
            this.txtBxDivideCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDivideCorrect.Location = new System.Drawing.Point(176, 402);
            this.txtBxDivideCorrect.Name = "txtBxDivideCorrect";
            this.txtBxDivideCorrect.Size = new System.Drawing.Size(635, 29);
            this.txtBxDivideCorrect.TabIndex = 34;
            // 
            // lblDivideCorrect
            // 
            this.lblDivideCorrect.AutoSize = true;
            this.lblDivideCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideCorrect.Location = new System.Drawing.Point(90, 409);
            this.lblDivideCorrect.Name = "lblDivideCorrect";
            this.lblDivideCorrect.Size = new System.Drawing.Size(78, 24);
            this.lblDivideCorrect.TabIndex = 33;
            this.lblDivideCorrect.Text = "Correct";
            // 
            // rdBtnDivisor
            // 
            this.rdBtnDivisor.AutoSize = true;
            this.rdBtnDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDivisor.Location = new System.Drawing.Point(363, 34);
            this.rdBtnDivisor.Name = "rdBtnDivisor";
            this.rdBtnDivisor.Size = new System.Drawing.Size(91, 28);
            this.rdBtnDivisor.TabIndex = 32;
            this.rdBtnDivisor.Text = "Divisor";
            this.rdBtnDivisor.UseVisualStyleBackColor = true;
            this.rdBtnDivisor.CheckedChanged += new System.EventHandler(this.rdBtnDivisor_CheckedChanged);
            // 
            // rdBtnDividend
            // 
            this.rdBtnDividend.AutoSize = true;
            this.rdBtnDividend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDividend.Location = new System.Drawing.Point(181, 34);
            this.rdBtnDividend.Name = "rdBtnDividend";
            this.rdBtnDividend.Size = new System.Drawing.Size(110, 28);
            this.rdBtnDividend.TabIndex = 31;
            this.rdBtnDividend.Text = "Dividend";
            this.rdBtnDividend.UseVisualStyleBackColor = true;
            this.rdBtnDividend.CheckedChanged += new System.EventHandler(this.rdBtnDividend_CheckedChanged);
            // 
            // rdBtnDivide
            // 
            this.rdBtnDivide.AutoSize = true;
            this.rdBtnDivide.Checked = true;
            this.rdBtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDivide.Location = new System.Drawing.Point(66, 34);
            this.rdBtnDivide.Name = "rdBtnDivide";
            this.rdBtnDivide.Size = new System.Drawing.Size(86, 28);
            this.rdBtnDivide.TabIndex = 30;
            this.rdBtnDivide.TabStop = true;
            this.rdBtnDivide.Text = "Divide";
            this.rdBtnDivide.UseVisualStyleBackColor = true;
            this.rdBtnDivide.CheckedChanged += new System.EventHandler(this.rdBtnDivide_CheckedChanged);
            // 
            // btnDivideAnswer
            // 
            this.btnDivideAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivideAnswer.Location = new System.Drawing.Point(161, 330);
            this.btnDivideAnswer.Name = "btnDivideAnswer";
            this.btnDivideAnswer.Size = new System.Drawing.Size(110, 36);
            this.btnDivideAnswer.TabIndex = 29;
            this.btnDivideAnswer.Text = "Answer";
            this.btnDivideAnswer.UseVisualStyleBackColor = true;
            this.btnDivideAnswer.Click += new System.EventHandler(this.btnDivideAnswer_Click);
            // 
            // lblDivideDivisor
            // 
            this.lblDivideDivisor.AutoSize = true;
            this.lblDivideDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideDivisor.Location = new System.Drawing.Point(48, 255);
            this.lblDivideDivisor.Name = "lblDivideDivisor";
            this.lblDivideDivisor.Size = new System.Drawing.Size(71, 24);
            this.lblDivideDivisor.TabIndex = 27;
            this.lblDivideDivisor.Text = "divisor";
            // 
            // lblDivideDividend
            // 
            this.lblDivideDividend.AutoSize = true;
            this.lblDivideDividend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideDividend.Location = new System.Drawing.Point(201, 258);
            this.lblDivideDividend.Name = "lblDivideDividend";
            this.lblDivideDividend.Size = new System.Drawing.Size(90, 24);
            this.lblDivideDividend.TabIndex = 26;
            this.lblDivideDividend.Text = "dividend";
            // 
            // lblDivideSign
            // 
            this.lblDivideSign.AutoSize = true;
            this.lblDivideSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideSign.Location = new System.Drawing.Point(125, 231);
            this.lblDivideSign.Name = "lblDivideSign";
            this.lblDivideSign.Size = new System.Drawing.Size(16, 24);
            this.lblDivideSign.TabIndex = 24;
            this.lblDivideSign.Text = "/";
            // 
            // txtBxDivisor
            // 
            this.txtBxDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDivisor.Location = new System.Drawing.Point(19, 223);
            this.txtBxDivisor.Name = "txtBxDivisor";
            this.txtBxDivisor.Size = new System.Drawing.Size(100, 29);
            this.txtBxDivisor.TabIndex = 23;
            this.txtBxDivisor.Text = "1";
            this.txtBxDivisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxDivisor.Leave += new System.EventHandler(this.txtBxDivisor_Leave);
            // 
            // txtBxDividend
            // 
            this.txtBxDividend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDividend.Location = new System.Drawing.Point(164, 226);
            this.txtBxDividend.Name = "txtBxDividend";
            this.txtBxDividend.Size = new System.Drawing.Size(313, 29);
            this.txtBxDividend.TabIndex = 22;
            this.txtBxDividend.Text = "1";
            this.txtBxDividend.Leave += new System.EventHandler(this.txtBxDividend_Leave);
            // 
            // btnMultiplicationTable
            // 
            this.btnMultiplicationTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicationTable.Location = new System.Drawing.Point(32, 7);
            this.btnMultiplicationTable.Name = "btnMultiplicationTable";
            this.btnMultiplicationTable.Size = new System.Drawing.Size(261, 36);
            this.btnMultiplicationTable.TabIndex = 18;
            this.btnMultiplicationTable.Text = "Show Multiplication Table";
            this.btnMultiplicationTable.UseVisualStyleBackColor = true;
            this.btnMultiplicationTable.Click += new System.EventHandler(this.btnMultiplicationTable_Click);
            // 
            // btnShowMultiWork
            // 
            this.btnShowMultiWork.Location = new System.Drawing.Point(644, 28);
            this.btnShowMultiWork.Name = "btnShowMultiWork";
            this.btnShowMultiWork.Size = new System.Drawing.Size(129, 38);
            this.btnShowMultiWork.TabIndex = 22;
            this.btnShowMultiWork.Text = "Show Work";
            this.btnShowMultiWork.UseVisualStyleBackColor = true;
            this.btnShowMultiWork.Click += new System.EventHandler(this.btnShowMultiWork_Click);
            // 
            // btnShowDivWork
            // 
            this.btnShowDivWork.Location = new System.Drawing.Point(647, 29);
            this.btnShowDivWork.Name = "btnShowDivWork";
            this.btnShowDivWork.Size = new System.Drawing.Size(129, 38);
            this.btnShowDivWork.TabIndex = 46;
            this.btnShowDivWork.Text = "Show Work";
            this.btnShowDivWork.UseVisualStyleBackColor = true;
            this.btnShowDivWork.Click += new System.EventHandler(this.btnShowDivWork_Click);
            // 
            // FormMathAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 557);
            this.Controls.Add(this.btnMultiplicationTable);
            this.Controls.Add(this.Math);
            this.Name = "FormMathAssistant";
            this.Text = "Form Math Assistant";
            this.Math.ResumeLayout(false);
            this.tabMultiply.ResumeLayout(false);
            this.tabMultiply.PerformLayout();
            this.pnlAnswer.ResumeLayout(false);
            this.pnlAnswer.PerformLayout();
            this.tabDivide.ResumeLayout(false);
            this.tabDivide.PerformLayout();
            this.pnlDivideShow.ResumeLayout(false);
            this.pnlDivideShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Math;
        private System.Windows.Forms.TabPage tabMultiply;
        private System.Windows.Forms.TabPage tabDivide;
        private System.Windows.Forms.Label lblMultiplyProduct;
        private System.Windows.Forms.Label lblMultiplyMultiplier;
        private System.Windows.Forms.Label lblMultiplyMultiplicant;
        private System.Windows.Forms.TextBox txtBxMultiplyProduct;
        private System.Windows.Forms.Label lblMultiplySign;
        private System.Windows.Forms.TextBox txtBxMultiplyMultiplier;
        private System.Windows.Forms.TextBox txtBxMultiplyMultiplicand;
        private System.Windows.Forms.Button btnMultiplyEquals;
        private System.Windows.Forms.RadioButton rdBtnMultiplyMultiplier;
        private System.Windows.Forms.RadioButton rdBtnMultiplyMultiplicand;
        private System.Windows.Forms.RadioButton rdBtnMultiplyMultiply;
        private System.Windows.Forms.TextBox txtBxMultiplyCorrect;
        private System.Windows.Forms.Label lblMultiplyCorrect;
        private System.Windows.Forms.Label lblMultiplyEquals;
        private System.Windows.Forms.TextBox txtBxMultiplyTestAnswer;
        private System.Windows.Forms.Button btnMultiplyNext;
        private System.Windows.Forms.CheckBox chkBxMultiplyShow;
        private System.Windows.Forms.Label lblMultiplyAnswer;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.RadioButton rdBtnMultiplyFreeStyle;
        private System.Windows.Forms.RadioButton rdBtnDivideFreeStyle;
        private System.Windows.Forms.Panel pnlDivideShow;
        private System.Windows.Forms.Label lblDivideAnswer;
        private System.Windows.Forms.TextBox txtBxQuotientAnswer;
        private System.Windows.Forms.CheckBox chkBxDivideShow;
        private System.Windows.Forms.Button btnDivideNext;
        private System.Windows.Forms.TextBox txtBxDivideCorrect;
        private System.Windows.Forms.Label lblDivideCorrect;
        private System.Windows.Forms.RadioButton rdBtnDivisor;
        private System.Windows.Forms.RadioButton rdBtnDividend;
        private System.Windows.Forms.RadioButton rdBtnDivide;
        private System.Windows.Forms.Button btnDivideAnswer;
        private System.Windows.Forms.Label lblDivideQuotient;
        private System.Windows.Forms.Label lblDivideDivisor;
        private System.Windows.Forms.Label lblDivideDividend;
        private System.Windows.Forms.TextBox txtBxQuotient;
        private System.Windows.Forms.Label lblDivideSign;
        private System.Windows.Forms.TextBox txtBxDivisor;
        private System.Windows.Forms.TextBox txtBxDividend;
        private System.Windows.Forms.Label lblDivideRemainder;
        private System.Windows.Forms.TextBox txtBxRemainder;
        private System.Windows.Forms.TextBox txtBxRemainderAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuotient;
        private System.Windows.Forms.Label lblRemainder;
        private System.Windows.Forms.Button btnMultiplicationTable;
        private System.Windows.Forms.Button btnShowMultiWork;
        private System.Windows.Forms.Button btnShowDivWork;
    }
}

