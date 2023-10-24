using System;
using System.Windows.Forms;

namespace 계산기
{
    public partial class Form1 : Form
    {
        /* 변수선언
        Value1에 피연산자(기존숫자저장)
        사칙연산 op에저장
        사칙연산 이후 숫자가 새로시작 flag사용 */
        decimal Value1 = 0;
        string op = string.Empty;
        bool opFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 계산기 크기조절안되게 고정
            BorderStyle 변경 */
        }

        ///////////////////// C /////////////////////
        private void btnC_Click(object sender, EventArgs e)
        {
            lbResult.Text = "0";
            lbExp.Text = "";
            Value1 = 0;
            op = string.Empty;
            opFlag = false;
        }

        ///////////////////// BC /////////////////////
        private void btnBC_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 1);
            if
                (lbResult.Text.Length == 0 || (lbResult.Text.Length == 1 && lbResult.Text.Contains("-")))
                lbResult.Text = "0";
            decimal v = decimal.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        ///////////////////// " - " /////////////////////
        private void button12_Click(object sender, EventArgs e)
        {
            opFlag = true;
            Value1 = decimal.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = Value1 + " " + op;
        }

        ///////////////////// " + " /////////////////////
        private void button16_Click(object sender, EventArgs e)
        {
            opFlag = true;
            Value1 = decimal.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = Value1 + " " + op;
        }

        ///////////////////// (+/-) /////////////////////
        private void button17_Click(object sender, EventArgs e)
        {
            decimal c = decimal.Parse(lbResult.Text);
            lbResult.Text = (-c).ToString();
            decimal v = decimal.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        ///////////////////// " = " /////////////////////
        private void button19_Click(object sender, EventArgs e)
        {
            decimal Value2 = decimal.Parse(lbResult.Text);
            switch (op)
            {
                case "+":
                    lbResult.Text = (Value1 + Value2).ToString();
                    break;
                case "-":
                    lbResult.Text = (Value1 - Value2).ToString();
                    break;
                case "×":
                    lbResult.Text = (Value1 * Value2).ToString();
                    break;
                case "÷":
                    lbResult.Text = (Value1 / Value2).ToString();
                    break;
            }
            decimal v = decimal.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
            //string sMsg;
            //sMsg = string.Format("Value1{0}:Value2{1}:result{2},", Value1, Value2, lbResult.Text);
            //Console.WriteLine(sMsg);
            lbExp.Text = Value1 + " " + op + " " + Value2 + " =";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ///////////////////// " / " /////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            opFlag = true;
            Value1 = decimal.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = Value1 + " " + op;
        }
        ///////////////////// " * " /////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            opFlag = true;
            Value1 = decimal.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = Value1 + " " + op;
        }
        ///////////////////// " . " /////////////////////
        private void button3_Click(object sender, EventArgs e)
        {
            if (lbResult.Text.Contains("."))
                return;
            else
                lbResult.Text += ".";
        }
        ///////////////////// " , " /////////////////////
        private static string Comma(decimal v, string s)
        {
            int pos = 0;
            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                if (pos == 1)
                    return s;
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);

            return s;
            // contains 문자열찾기
            // IndexOf 문자열위치찾기
            // format 다양한형태로 문자열변환
            // N0=소수점없이 천단위마다 콤마
            // N1=소수점한자리 천단위마다 콤마
            // N2=소수점두자리 천단위마다 콤마
        }

        ///////////////////// " Number " /////////////////////
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Name.Remove(0, 3);
            //string sMsg;
            string sCompare = lbResult.Text.Replace(",", "");
            sCompare = sCompare.Replace("-", "");
            sCompare = sCompare.Replace(".", "");

            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = s;
                opFlag = false;
            }
            else
            {
                //sMsg = string.Format("Text : {0} | Length : {1}", lbResult.Text, lbResult.Text.Length);
                //Console.WriteLine(sMsg);
                //sMsg = string.Format("sCompare : {0} | Length : {1}", sCompare, sCompare.Length);
                //Console.WriteLine(sMsg);
                if (sCompare.Length == 16)
                {
                    return;
                }
                lbResult.Text += s;
            }

            decimal v = decimal.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }
    }
}
