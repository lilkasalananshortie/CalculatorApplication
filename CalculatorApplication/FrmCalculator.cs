using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CalculatorApplication.CalculatorClass;
namespace CalculatorApplication
{

    public partial class FrmCalculator : Form
    {
        CalculatorClass cal = new CalculatorClass();
        public static double result = 0;
        double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();

            image1.Hide();


            double answer;
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

        }
        private void FrmCalculator_Load(object sender, EventArgs e)
        {
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            image1.Visible = !image1.Visible;

            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);
            string operation = cbOperator.SelectedItem.ToString();


            if (cbOperator.SelectedIndex == 0)
            {
                result = cal.GetSum(num1, num2);
            }
            else if (cbOperator.SelectedIndex == 1)
            {
                result = cal.GetDifference(num1, num2);
            }
            else if (cbOperator.SelectedIndex == 2)
            {
                result = cal.GetProduct(num1, num2);
            }
            else if (cbOperator.SelectedIndex == 3)
            {
                result = cal.GetQuotient(num1, num2);
            }
            else
            {
                this.Close();
            }
            lblDisplayTotal.Text = result.ToString();

        }


        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {
        }
    }
}