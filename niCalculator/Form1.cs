using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace niCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
        }
        public void Brackets()
        {
         
        }
        public void AutoCalculator(string autoOperator)
        {
            string blocker = TxtDisplay1.Text;
            if (TxtDisplay1.Text.Contains("%"))
            {
                blocker = blocker.Remove(blocker.Length - 1);
                TxtDisplay1.Text =blocker + "%";
            }
            else if (TxtDisplay1.Text.Contains("√"))
            {
                blocker = blocker.Replace("+","");
                blocker = blocker.Replace("-", "");
                blocker = blocker.Replace("x", "");
                blocker = blocker.Replace("÷", "");
                TxtDisplay1.Text = blocker;
            }
            else
            {
                Calculator(autoOperator);
            }
        }
        public void Calculator(string operators)
        {
            if (TxtDisplay2.Text != string.Empty && TxtDisplay1.Text == string.Empty)
            {
                string d2 = TxtDisplay2.Text;
                if (d2.Contains("+"))
                {
                    string strOperand = TxtDisplay2.Text;
                    strOperand= strOperand.Remove(strOperand.Length - 1);   
                    Double operand = Double.Parse(strOperand);
                    Double result = operand + operand;
                    TxtDisplay1.Text = result.ToString();
                }
                if (d2.Contains("-"))
                {
                    string strOperand = TxtDisplay2.Text;
                    strOperand = strOperand.Remove(strOperand.Length - 1);
                    Double operand = Double.Parse(strOperand);
                    Double result = operand - operand;
                    TxtDisplay1.Text = result.ToString();
                }
                if (d2.Contains("x"))
                {
                    string strOperand = TxtDisplay2.Text;
                    strOperand = strOperand.Remove(strOperand.Length - 1);
                    Double operand = Double.Parse(strOperand);
                    Double result = operand * operand;
                    TxtDisplay1.Text = result.ToString();
                }
                if (d2.Contains("÷"))
                {
                    string strOperand = TxtDisplay2.Text;
                    strOperand = strOperand.Remove(strOperand.Length - 1);
                    Double operand = Double.Parse(strOperand);
                    Double result = operand / operand;
                    TxtDisplay1.Text = result.ToString();
                }



            }
            if (TxtDisplay2.Text == string.Empty && TxtDisplay1.Text != string.Empty)
            {
                TxtDisplay2.Text = TxtDisplay1.Text + $"{operators}";
                TxtDisplay1.Text = string.Empty;
            }
           
            if (TxtDisplay2.Text != string.Empty && TxtDisplay1.Text != string.Empty)
            {
                TxtDisplay2.Text = TxtDisplay1.Text + $"{operators}";
                TxtDisplay1.Text = string.Empty;
            }
     
        }
        public void BtnNum(string btnNum)
        {
            string percent = TxtDisplay1.Text;
            if (TxtDisplay1.Text.Contains("%"))
            {
                percent = percent.Remove(percent.Length - 1);
                TxtDisplay1.Text = percent + "%";
            }
            else
            {
                if (TxtDisplay1.Text == string.Empty)
                {
                    TxtDisplay1.Text = $"{btnNum}";
                }
                else
                {
                    TxtDisplay1.Text += $"{btnNum}";
                }
            }
        }
        public void Btn0_Click(object sender, EventArgs e)
        {
            BtnNum(Btn0.Text);

        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            BtnNum(Btn1.Text);

        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            BtnNum(Btn2.Text);
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            BtnNum(Btn3.Text);
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            BtnNum(Btn4.Text);
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            BtnNum(Btn5.Text);
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            BtnNum(Btn6.Text);
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            BtnNum(Btn7.Text);
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            BtnNum(Btn8.Text);
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            BtnNum(Btn9.Text);
        }
        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == string.Empty)
                BtnNum($"0{BtnDecimal.Text}");
            if (!TxtDisplay1.Text.Contains(".")&& !TxtDisplay1.Text.Contains("√"))
            {
                BtnNum(BtnDecimal.Text);
               
            }

           
        }
        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text != String.Empty)
            {
                TxtDisplay1.Text =
                    TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1);
            }
            else TxtDisplay1.Text = String.Empty;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = TxtDisplay2.Text = string.Empty;
        }
        private void BtnDivision_Click(object sender, EventArgs e)
        {
           
                AutoCalculator(BtnDivision.Text);
            
        }
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            AutoCalculator(BtnMultiply.Text);
        }
        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            if(TxtDisplay1.Text==string.Empty)
                TxtDisplay1.Text = BtnSubtraction.Text;
           else
                AutoCalculator(BtnSubtraction.Text);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            AutoCalculator(BtnAdd.Text);
            

        }
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (TxtDisplay2.Text != string.Empty && TxtDisplay1.Text != string.Empty)
            {
                string d2 = TxtDisplay2.Text;
                if (d2.Contains("+"))
                {
                    string strOperand2 = TxtDisplay2.Text;
                    string strOperand1 = TxtDisplay1.Text;
                    TxtDisplay2.Text += TxtDisplay1.Text + "=";
                    if (strOperand2.Contains("="))
                    {
                      
                        int index = strOperand2.IndexOf("+");
                        strOperand2 = strOperand2.Substring(index +1);
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        TxtDisplay2.Text = TxtDisplay1.Text+"+"+strOperand2 + "=";
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand1 + operand2;
                        TxtDisplay1.Text = result.ToString();
                    }
                    else {
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand2 + operand1;
                        TxtDisplay1.Text = result.ToString();
                    }
                }
                if (d2.Contains("-"))
                {
                    string strOperand2 = TxtDisplay2.Text;
                    string strOperand1 = TxtDisplay1.Text;
                    TxtDisplay2.Text += TxtDisplay1.Text + "=";
                    if (strOperand2.Contains("="))
                    {
                        strOperand2 = strOperand2.Remove(0, 1);
                        int index = strOperand2.IndexOf("-");
                        strOperand2 = strOperand2.Substring(index + 1);
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        TxtDisplay2.Text = TxtDisplay1.Text + "-" + strOperand2 + "=";                     
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand1 - operand2;
                        TxtDisplay1.Text = result.ToString();
                       
                        
                        
                    }
                    else
                    {
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand2 - operand1;
                        TxtDisplay1.Text = result.ToString();
                    }
                }
                if (d2.Contains("x"))
                {
                    string strOperand2 = TxtDisplay2.Text;
                    string strOperand1 = TxtDisplay1.Text;
                    TxtDisplay2.Text += TxtDisplay1.Text + "=";
                    if (strOperand2.Contains("="))
                    {
                       
                        int index = strOperand2.IndexOf("x");
                        strOperand2 = strOperand2.Substring(index + 1);
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        TxtDisplay2.Text = TxtDisplay1.Text + "x" + strOperand2 + "=";
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand1 * operand2;
                        TxtDisplay1.Text = result.ToString();
                    }
                    else
                    {
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand2 * operand1;
                        TxtDisplay1.Text = result.ToString();
                    }
                }
                if (d2.Contains("÷"))
                {
                    string strOperand2 = TxtDisplay2.Text;
                    string strOperand1 = TxtDisplay1.Text;
                    TxtDisplay2.Text += TxtDisplay1.Text + "=";
                    if (strOperand2.Contains("="))
                    {
                        int index = strOperand2.IndexOf("÷");
                        strOperand2 = strOperand2.Substring(index + 1);
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        TxtDisplay2.Text = TxtDisplay1.Text + "÷" + strOperand2 + "=";
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand1 / operand2;
                        TxtDisplay1.Text = result.ToString();
                    }
                    else
                    {
                        strOperand2 = strOperand2.Remove(strOperand2.Length - 1);
                        Double operand2 = Double.Parse(strOperand2);
                        Double operand1 = Double.Parse(strOperand1);
                        Double result = operand2 / operand1;
                        TxtDisplay1.Text = result.ToString();
                    }
                }

            }
            if (TxtDisplay1.Text.Contains("%"))
            {

                string d1 = TxtDisplay1.Text;
                TxtDisplay2.Text = TxtDisplay1.Text + "=";
                d1 = d1.Remove(d1.Length - 1);
                Double percent = Double.Parse(d1);
                percent = percent/100;
                TxtDisplay1.Text = percent.ToString();
            }
            if (TxtDisplay1.Text.Contains("√")&& !TxtDisplay1.Text.Contains("-"))
            {

                string d1 = TxtDisplay1.Text;
                TxtDisplay2.Text = TxtDisplay1.Text + "=";
                d1 = d1.Replace("√", "");
                Double Sqr = Double.Parse(d1);
                Sqr = Math.Sqrt(Sqr);
                TxtDisplay1.Text =Sqr.ToString();
            }
        }
        private void BtnPercent_Click(object sender, EventArgs e)
        {
            
            if (TxtDisplay1.Text!=string.Empty)
            {
              
                string percent = TxtDisplay1.Text;
                if (TxtDisplay1.Text.Contains("%"))
                {
                    percent = percent.Remove(percent.Length - 1);
                    TxtDisplay1.Text = percent + "%";
                }
                else
                {

                    TxtDisplay1.Text += BtnPercent.Text;
                    string blocker = TxtDisplay1.Text;
                    if (TxtDisplay1.Text.Contains("√"))
                    {
                        blocker = blocker.Replace("%", "");
                        TxtDisplay1.Text = blocker;
                    }
                }
               
               
            }

            
        }
        private void BtnSqrRoot_Click(object sender, EventArgs e)
        {
            TxtDisplay2.Text = string.Empty;
            if (TxtDisplay1.Text==string.Empty)
                TxtDisplay1.Text += BtnSqrRoot.Text;
            if(!TxtDisplay1.Text.Contains("√"))

            {
                string SqrSymbol=BtnSqrRoot.Text;
                SqrSymbol += TxtDisplay1.Text;
                TxtDisplay1.Text = SqrSymbol;
            }
        }
        private void TxtDisplay1_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void Form1_Load(object sender, EventArgs e)
        {
           TxtDisplay1.Text = TxtDisplay2.Text = string.Empty;
        }
    }
}
