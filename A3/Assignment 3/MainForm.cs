using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class MainForm : Form
    {

        //Instance of BMI calc. 
        private BMICalculator BMIcalc = new BMICalculator();
        private SavingCalculator SavCalc = new SavingCalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }


        private void InitializeGUI()
        {
            this.Text = "The Body Mass Calculator & Saving Calculator by Paul Moustakas";

            //Input Controls 
            //BMI Calc
            radioButtonImperial.Checked = true;
            labelHeight.Text = "Height (feet)";
            labelWeight.Text = "Weight (lbs)";

            //Saving Calc
            lblAmountPaidRes.Text = String.Empty;
            lblFinalBalanceRes.Text = String.Empty; 

            //Output
            //BMI Calc
            textBoxHeight.Text = String.Empty;
            textBoxWeight.Text = String.Empty;

            //Saving Calc
            textBoxMonthlyDepo.Text = String.Empty;
            textBoxPeriodYear.Text = String.Empty;  


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void buttonCalculateBMIOnClick(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResults();
            }

        }

        private bool ReadInputBMI()
        {
            BMIcalc.SetName(textBoxName.Text);
            if (ReadHeight() && ReadWeight())
                return true;
         
            return false;
        }


        private void DisplayResults()
        {
            labelBMIResult.Text = BMIcalc.CalculateBMI().ToString("f2");
            labelBMICategory.Text = BMIcalc.BMIWeightCategory().ToString();
        }


     
        private void label2_Click_1(object sender, EventArgs e){ }


        private void textBox2_TextChanged(object sender, EventArgs e){}

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void radioButtonMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMetric.Checked)
            {
                labelHeight.Text = "Height (cm)";
                labelWeight.Text = "Weight (kg)";
                BMIcalc.SetUnit(UnitType.Metric);
            }
        }

        private void radioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonImperial.Checked)
            {
                labelHeight.Text = "Height (foot)";
                labelWeight.Text = "Weight (lbs)";
                BMIcalc.SetUnit(UnitType.Imperial);
            }
        }


        private bool ReadHeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(textBoxHeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (BMIcalc.getUnit() == UnitType.Imperial)
                    {
                        BMIcalc.SetHeight(outValue * 12.00);
                    }
                    else
                    {
                        BMIcalc.SetHeight(outValue / 100.0);
                    }
                }
                else { ok = false; }
            }
            if (!ok)
                MessageBox.Show("Invalid height value!", "error");
            return ok;
        }


        private bool ReadWeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(textBoxWeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (BMIcalc.getUnit() == UnitType.Imperial) { BMIcalc.SetWeight(outValue);}
                    else { BMIcalc.SetWeight(outValue); }
                }
                else { ok = false; }
            }
            if (!ok)
                MessageBox.Show("Invalid height value!", "error");
            return ok;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblFinalBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblFinalBalanceRes_Click(object sender, EventArgs e)
        {

        }


        private void DisplaySavingResults()
        {
            lblAmountPaidRes.Text = SavCalc.GetAmountPaid().ToString("f2");
            lblFinalBalanceRes.Text = SavCalc.CalculateSaving().ToString();
        }

        private void btnCalcSaving_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputSaving();

            if (ok)
            {
                DisplaySavingResults();
            }
        }


        private bool ReadInputSaving ()
        {
            if (MonthlyDeposit() && Period())
                return true;

            return false;
        }


        private bool MonthlyDeposit()
        {
            double outValue = 0;
            bool ok = double.TryParse(textBoxMonthlyDepo.Text, out outValue);
            if (ok)
            {
                if (outValue > 0) { SavCalc.SetMonthlyDeposit(outValue); }
                else { ok = false; }
            }
            if (!ok)
                MessageBox.Show("Invalid input value!", "error");
            return ok;
        }


        private bool Period()
        {
            double outValue = 0;
            bool ok = double.TryParse(textBoxPeriodYear.Text, out outValue);
            if (ok)
            {
                if (outValue > 0) { SavCalc.SetPeriod(outValue); }
                else { ok = false; }
            }
            if (!ok)
                MessageBox.Show("Invalid input period!", "error");
            return ok;
        }
    }

}


