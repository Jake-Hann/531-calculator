using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _531_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetLables();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxSquat1RM.Text != null && textBoxSquat1RM.Text != "")
            {
                int squatOneRepMax = int.Parse(textBoxSquat1RM.Text);
                SetSquatWeights(squatOneRepMax);
            }

            if (textBoxBench1RM.Text != null && textBoxBench1RM.Text != "")
            {
                int benchOneRepMax = int.Parse(textBoxBench1RM.Text);
                SetBenchWeights(benchOneRepMax);
            }

            if (textBoxDeadlift1RM.Text != null && textBoxDeadlift1RM.Text != "")
            {
                int deadliftOneRepMax = int.Parse(textBoxDeadlift1RM.Text);
                SetDeadliftWeights(deadliftOneRepMax);
            }

            if (textBoxOHP1RM.Text != null && textBoxOHP1RM.Text != "")
            {
                int ohpOneRepMax = int.Parse(textBoxOHP1RM.Text);
                SetOHPWeights(ohpOneRepMax);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetLables();
        }

        private void SetSquatWeights(int repMax)
        {
            labelSqautW1FirstSet.Text = "5 x " + WeekOneFirstSet(repMax) + " kg";
            labelSqautW1SecondSet.Text = "5 x " + WeekOneSecondSet(repMax) + " kg";
            labelSqautW1LastSet.Text = "5+ x " + WeekOneLastSet(repMax) + " kg";

            labelSqautW2FirstSet.Text = "3 x " + WeekTwoFirstSet(repMax) + " kg";
            labelSqautW2SecondSet.Text = "3 x " + WeekTwoSecondSet(repMax) + " kg";
            labelSqautW2LastSet.Text = "3+ x " + WeekTwoLastSet(repMax) + " kg";

            labelSqautW3FirstSet.Text = "5 x " + WeekThreeFirstSet(repMax) + " kg";
            labelSqautW3SecondSet.Text = "3 x " + WeekThreeSecondSet(repMax) + " kg";
            labelSqautW3LastSet.Text = "1+ x " + WeekThreeLastSet(repMax) + " kg";
        }

        private void SetBenchWeights(int repMax)
        {   
            labelBPW1FirstSet.Text = "5 x " + WeekOneFirstSet(repMax) + " kg";
            labelBPW1SecondSet.Text = "5 x " + WeekOneSecondSet(repMax) + " kg";
            labelBPW1LastSet.Text = "5+ x " + WeekOneLastSet(repMax) + " kg";

            labelBPW2FirstSet.Text = "3 x " + WeekTwoFirstSet(repMax) + " kg";
            labelBPW2SecondSet.Text = "3 x " + WeekTwoSecondSet(repMax) + " kg";
            labelBPW2LastSet.Text = "3+ x " + WeekTwoLastSet(repMax) + " kg";

            labelBPW3FirstSet.Text = "5 x " + WeekThreeFirstSet(repMax) + " kg";
            labelBPW3SecondSet.Text = "3 x " + WeekThreeSecondSet(repMax) + " kg";
            labelBPW3LastSet.Text = "1+ x " + WeekThreeLastSet(repMax) + " kg";
        }

        private void SetDeadliftWeights(int repMax)
        {
            labelDeadW1FirstSet.Text = "5 x " + WeekOneFirstSet(repMax) + " kg";
            labelDeadW1SecondSet.Text = "5 x " + WeekOneSecondSet(repMax) + " kg";
            labelDeadW1LastSet.Text = "5+ x " + WeekOneLastSet(repMax) + " kg";

            labelDeadW2FirstSet.Text = "3 x " + WeekTwoFirstSet(repMax) + " kg";
            labelDeadW2SecondSet.Text = "3 x " + WeekTwoSecondSet(repMax) + " kg";
            labelDeadW2LastSet.Text = "3+ x " + WeekTwoLastSet(repMax) + " kg";

            labelDeadW3FirstSet.Text = "5 x " + WeekThreeFirstSet(repMax) + " kg";
            labelDeadW3SecondSet.Text = "3 x " + WeekThreeSecondSet(repMax) + " kg";
            labelDeadW3LastSet.Text = "1+ x " + WeekThreeLastSet(repMax) + " kg";
        }

        private void SetOHPWeights(int repMax)
        {
            labelOHPW1FirstSet.Text = "5 x " + WeekOneFirstSet(repMax) + " kg";
            labelOHPW1SecondSet.Text = "5 x " + WeekOneSecondSet(repMax) + " kg";
            labelOHPW1LastSet.Text = "5+ x " + WeekOneLastSet(repMax) + " kg";

            labelOHPW2FirstSet.Text = "3 x " + WeekTwoFirstSet(repMax) + " kg";
            labelOHPW2SecondSet.Text = "3 x " + WeekTwoSecondSet(repMax) + " kg";
            labelOHPW2LastSet.Text = "3+ x " + WeekTwoLastSet(repMax) + " kg";

            labelOHPW3FirstSet.Text = "5 x " + WeekThreeFirstSet(repMax) + " kg";
            labelOHPW3SecondSet.Text = "3 x " + WeekThreeSecondSet(repMax) + " kg";
            labelOHPW3LastSet.Text = "1+ x " + WeekThreeLastSet(repMax) + " kg";
        }

        private void ResetLables()
        {
            // Textboxes
            textBoxSquat1RM.Text = "";
            textBoxBench1RM.Text = "";
            textBoxDeadlift1RM.Text = "";
            textBoxOHP1RM.Text = "";

            // Squat
            labelSqautW1FirstSet.Text = "5 x 65%";
            labelSqautW1SecondSet.Text = "5 x 75%";
            labelSqautW1LastSet.Text = "5+ x 85%";

            labelSqautW2FirstSet.Text = "3 x 70%";
            labelSqautW2SecondSet.Text = "3 x 80%";
            labelSqautW2LastSet.Text = "3+ x 90%";

            labelSqautW3FirstSet.Text = "5 x 75%";
            labelSqautW3SecondSet.Text = "3 x 85%";
            labelSqautW3LastSet.Text = "1+ x 95%";

            // Bench
            labelBPW1FirstSet.Text = "5 x 65%";
            labelBPW1SecondSet.Text = "5 x 75%";
            labelBPW1LastSet.Text = "5+ x 85%";

            labelBPW2FirstSet.Text = "3 x 70%";
            labelBPW2SecondSet.Text = "3 x 80%";
            labelBPW2LastSet.Text = "3+ x 90%";

            labelBPW3FirstSet.Text = "5 x 75%";
            labelBPW3SecondSet.Text = "3 x 85%";
            labelBPW3LastSet.Text = "1+ x 95%";

            // Deadlift 
            labelDeadW1FirstSet.Text = "5 x 65%";
            labelDeadW1SecondSet.Text = "5 x 75%";
            labelDeadW1LastSet.Text = "5+ x 85%";

            labelDeadW2FirstSet.Text = "3 x 70%";
            labelDeadW2SecondSet.Text = "3 x 80%";
            labelDeadW2LastSet.Text = "3+ x 90%";

            labelDeadW3FirstSet.Text = "5 x 75%";
            labelDeadW3SecondSet.Text = "3 x 85%";
            labelDeadW3LastSet.Text = "1+ x 95%";

            // OHP
            labelOHPW1FirstSet.Text = "5 x 65%";
            labelOHPW1SecondSet.Text = "5 x 75%";
            labelOHPW1LastSet.Text = "5+ x 85%";

            labelOHPW2FirstSet.Text = "3 x 70%";
            labelOHPW2SecondSet.Text = "3 x 80%";
            labelOHPW2LastSet.Text = "3+ x 90%";

            labelOHPW3FirstSet.Text = "5 x 75%";
            labelOHPW3SecondSet.Text = "3 x 85%";
            labelOHPW3LastSet.Text = "1+ x 95%";
        }

        private double TrainingMax (int repMax)
        {
            // Training max = 90% of 1rm
            return (repMax / 100) * 90;
        }

        private double WeekOneFirstSet (int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 65;
        }

        private double WeekOneSecondSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 75;
        }

        private double WeekOneLastSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 85;
        }

        private double WeekTwoFirstSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 70;
        }

        private double WeekTwoSecondSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 80;
        }

        private double WeekTwoLastSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 90;
        }

        private double WeekThreeFirstSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 75;
        }

        private double WeekThreeSecondSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 85;
        }

        private double WeekThreeLastSet(int repMax)
        {
            double tm = TrainingMax(repMax);
            return (tm / 100) * 95;
        }

        private void textBoxSquat1RM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow integers in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxBench1RM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow integers in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxDeadlift1RM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow integers in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxOHP1RM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow integers in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
