namespace Assignment_3
{
    partial class MainForm
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
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.GroupBoxBMI = new System.Windows.Forms.GroupBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelBMICategory = new System.Windows.Forms.Label();
            this.labelBMIResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BMIResult = new System.Windows.Forms.Label();
            this.groupBoxSavingPlan = new System.Windows.Forms.GroupBox();
            this.textBoxPeriodYear = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyDepo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.btnCalcSaving = new System.Windows.Forms.Button();
            this.groupBoxFutureValue = new System.Windows.Forms.GroupBox();
            this.lblAmountPaidRes = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblFinalBalanceRes = new System.Windows.Forms.Label();
            this.GroupBoxBMI.SuspendLayout();
            this.groupBoxUnit.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.groupBoxSavingPlan.SuspendLayout();
            this.groupBoxFutureValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Location = new System.Drawing.Point(97, 186);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(210, 34);
            this.btnCalculateBMI.TabIndex = 0;
            this.btnCalculateBMI.Text = "Calculate BMI";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.buttonCalculateBMIOnClick);
            // 
            // GroupBoxBMI
            // 
            this.GroupBoxBMI.Controls.Add(this.textBoxWeight);
            this.GroupBoxBMI.Controls.Add(this.textBoxHeight);
            this.GroupBoxBMI.Controls.Add(this.textBoxName);
            this.GroupBoxBMI.Controls.Add(this.labelWeight);
            this.GroupBoxBMI.Controls.Add(this.labelHeight);
            this.GroupBoxBMI.Controls.Add(this.label1);
            this.GroupBoxBMI.Location = new System.Drawing.Point(37, 44);
            this.GroupBoxBMI.Name = "GroupBoxBMI";
            this.GroupBoxBMI.Size = new System.Drawing.Size(285, 124);
            this.GroupBoxBMI.TabIndex = 1;
            this.GroupBoxBMI.TabStop = false;
            this.GroupBoxBMI.Text = "BMI Calculator";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(104, 84);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(58, 20);
            this.textBoxWeight.TabIndex = 6;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(104, 61);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(58, 20);
            this.textBoxHeight.TabIndex = 4;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(166, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(6, 84);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(62, 13);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight (kg)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 61);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 13);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height (cm)";
            this.labelHeight.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBoxUnit
            // 
            this.groupBoxUnit.Controls.Add(this.radioButtonImperial);
            this.groupBoxUnit.Controls.Add(this.radioButtonMetric);
            this.groupBoxUnit.Location = new System.Drawing.Point(349, 44);
            this.groupBoxUnit.Name = "groupBoxUnit";
            this.groupBoxUnit.Size = new System.Drawing.Size(219, 124);
            this.groupBoxUnit.TabIndex = 2;
            this.groupBoxUnit.TabStop = false;
            this.groupBoxUnit.Text = "Unit";
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Location = new System.Drawing.Point(23, 65);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(95, 17);
            this.radioButtonImperial.TabIndex = 1;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial (ft, lbs)";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            this.radioButtonImperial.CheckedChanged += new System.EventHandler(this.radioButtonImperial_CheckedChanged);
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Location = new System.Drawing.Point(23, 37);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(95, 17);
            this.radioButtonMetric.TabIndex = 0;
            this.radioButtonMetric.TabStop = true;
            this.radioButtonMetric.Text = "Metric (cm, kg)";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            this.radioButtonMetric.CheckedChanged += new System.EventHandler(this.radioButtonMetric_CheckedChanged);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelBMICategory);
            this.groupBoxResults.Controls.Add(this.labelBMIResult);
            this.groupBoxResults.Controls.Add(this.label5);
            this.groupBoxResults.Controls.Add(this.BMIResult);
            this.groupBoxResults.Location = new System.Drawing.Point(46, 241);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(531, 107);
            this.groupBoxResults.TabIndex = 3;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results for";
            // 
            // labelBMICategory
            // 
            this.labelBMICategory.AutoSize = true;
            this.labelBMICategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBMICategory.Location = new System.Drawing.Point(167, 67);
            this.labelBMICategory.Name = "labelBMICategory";
            this.labelBMICategory.Size = new System.Drawing.Size(69, 15);
            this.labelBMICategory.TabIndex = 3;
            this.labelBMICategory.Text = "BMIcategory";
            this.labelBMICategory.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelBMIResult
            // 
            this.labelBMIResult.AutoSize = true;
            this.labelBMIResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBMIResult.Location = new System.Drawing.Point(167, 40);
            this.labelBMIResult.Name = "labelBMIResult";
            this.labelBMIResult.Size = new System.Drawing.Size(58, 15);
            this.labelBMIResult.TabIndex = 2;
            this.labelBMIResult.Text = "BMIResult";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Weight category";
            // 
            // BMIResult
            // 
            this.BMIResult.AutoSize = true;
            this.BMIResult.Location = new System.Drawing.Point(9, 40);
            this.BMIResult.Name = "BMIResult";
            this.BMIResult.Size = new System.Drawing.Size(26, 13);
            this.BMIResult.TabIndex = 0;
            this.BMIResult.Text = "BMI";
            // 
            // groupBoxSavingPlan
            // 
            this.groupBoxSavingPlan.Controls.Add(this.textBoxPeriodYear);
            this.groupBoxSavingPlan.Controls.Add(this.textBoxMonthlyDepo);
            this.groupBoxSavingPlan.Controls.Add(this.label2);
            this.groupBoxSavingPlan.Controls.Add(this.labelDeposit);
            this.groupBoxSavingPlan.Location = new System.Drawing.Point(596, 44);
            this.groupBoxSavingPlan.Name = "groupBoxSavingPlan";
            this.groupBoxSavingPlan.Size = new System.Drawing.Size(310, 124);
            this.groupBoxSavingPlan.TabIndex = 3;
            this.groupBoxSavingPlan.TabStop = false;
            this.groupBoxSavingPlan.Text = "Saving plan";
            // 
            // textBoxPeriodYear
            // 
            this.textBoxPeriodYear.Location = new System.Drawing.Point(186, 87);
            this.textBoxPeriodYear.Name = "textBoxPeriodYear";
            this.textBoxPeriodYear.Size = new System.Drawing.Size(113, 20);
            this.textBoxPeriodYear.TabIndex = 8;
            // 
            // textBoxMonthlyDepo
            // 
            this.textBoxMonthlyDepo.Location = new System.Drawing.Point(186, 61);
            this.textBoxMonthlyDepo.Name = "textBoxMonthlyDepo";
            this.textBoxMonthlyDepo.Size = new System.Drawing.Size(113, 20);
            this.textBoxMonthlyDepo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Period ( years )";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(15, 61);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(75, 13);
            this.labelDeposit.TabIndex = 2;
            this.labelDeposit.Text = "Montly deposit";
            this.labelDeposit.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcSaving
            // 
            this.btnCalcSaving.Location = new System.Drawing.Point(653, 186);
            this.btnCalcSaving.Name = "btnCalcSaving";
            this.btnCalcSaving.Size = new System.Drawing.Size(210, 34);
            this.btnCalcSaving.TabIndex = 4;
            this.btnCalcSaving.Text = "Calculate saving";
            this.btnCalcSaving.UseVisualStyleBackColor = true;
            this.btnCalcSaving.Click += new System.EventHandler(this.btnCalcSaving_Click);
            // 
            // groupBoxFutureValue
            // 
            this.groupBoxFutureValue.Controls.Add(this.lblFinalBalanceRes);
            this.groupBoxFutureValue.Controls.Add(this.lblAmountPaidRes);
            this.groupBoxFutureValue.Controls.Add(this.lblFinalBalance);
            this.groupBoxFutureValue.Controls.Add(this.lblAmountPaid);
            this.groupBoxFutureValue.Location = new System.Drawing.Point(596, 241);
            this.groupBoxFutureValue.Name = "groupBoxFutureValue";
            this.groupBoxFutureValue.Size = new System.Drawing.Size(310, 107);
            this.groupBoxFutureValue.TabIndex = 3;
            this.groupBoxFutureValue.TabStop = false;
            this.groupBoxFutureValue.Text = "Future value";
            // 
            // lblAmountPaidRes
            // 
            this.lblAmountPaidRes.AutoSize = true;
            this.lblAmountPaidRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountPaidRes.Location = new System.Drawing.Point(147, 35);
            this.lblAmountPaidRes.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblAmountPaidRes.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblAmountPaidRes.Name = "lblAmountPaidRes";
            this.lblAmountPaidRes.Size = new System.Drawing.Size(150, 15);
            this.lblAmountPaidRes.TabIndex = 4;
            this.lblAmountPaidRes.Text = "AP";
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.Location = new System.Drawing.Point(15, 69);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(70, 13);
            this.lblFinalBalance.TabIndex = 15;
            this.lblFinalBalance.Text = "Final balance";
            this.lblFinalBalance.Click += new System.EventHandler(this.lblFinalBalance_Click);
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(15, 40);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(66, 13);
            this.lblAmountPaid.TabIndex = 12;
            this.lblAmountPaid.Text = "Amount paid";
            // 
            // lblFinalBalanceRes
            // 
            this.lblFinalBalanceRes.AutoSize = true;
            this.lblFinalBalanceRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinalBalanceRes.Location = new System.Drawing.Point(147, 62);
            this.lblFinalBalanceRes.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblFinalBalanceRes.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblFinalBalanceRes.Name = "lblFinalBalanceRes";
            this.lblFinalBalanceRes.Size = new System.Drawing.Size(150, 15);
            this.lblFinalBalanceRes.TabIndex = 17;
            this.lblFinalBalanceRes.Text = "FB";
            this.lblFinalBalanceRes.Click += new System.EventHandler(this.lblFinalBalanceRes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 383);
            this.Controls.Add(this.groupBoxFutureValue);
            this.Controls.Add(this.btnCalcSaving);
            this.Controls.Add(this.groupBoxSavingPlan);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxUnit);
            this.Controls.Add(this.GroupBoxBMI);
            this.Controls.Add(this.btnCalculateBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator by Paul Moustakas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxBMI.ResumeLayout(false);
            this.GroupBoxBMI.PerformLayout();
            this.groupBoxUnit.ResumeLayout(false);
            this.groupBoxUnit.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.groupBoxSavingPlan.ResumeLayout(false);
            this.groupBoxSavingPlan.PerformLayout();
            this.groupBoxFutureValue.ResumeLayout(false);
            this.groupBoxFutureValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.GroupBox GroupBoxBMI;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxUnit;
        private System.Windows.Forms.RadioButton radioButtonImperial;
        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelBMICategory;
        private System.Windows.Forms.Label labelBMIResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BMIResult;
        private System.Windows.Forms.GroupBox groupBoxSavingPlan;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPeriodYear;
        private System.Windows.Forms.TextBox textBoxMonthlyDepo;
        private System.Windows.Forms.Button btnCalcSaving;
        private System.Windows.Forms.GroupBox groupBoxFutureValue;
        private System.Windows.Forms.Label lblAmountPaidRes;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblFinalBalanceRes;
    }
}

