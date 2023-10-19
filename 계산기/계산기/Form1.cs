using System;
using System.Windows.Forms;

namespace 계산기
{
    public partial class Form1 : Form
    {
        /* 변수선언
        lvalue에 피연산자(기존숫자저장)
        사칙연산 op에저장
        사칙연산 이후 숫자가 새로시작 flag사용 */
        double lValue = 0;
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

        private void btn1_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "1";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "1";
            }
            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        ///////////////////// C /////////////////////
        private void btnC_Click(object sender, EventArgs e)
        {
            lbResult.Text = "0";
            lbExp.Text = "";
            lValue = 0;
            op = string.Empty;
            opFlag = false;
        }

        ///////////////////// BC /////////////////////
        private void btnBC_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 1);
            // 더이상 지울숫자가없을때 에러발생
            if
                (lbResult.Text.Length == 0)
                lbResult.Text = "0";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "7";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "7";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "8";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "8";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "9";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "9";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "4";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "4";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "5";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "5";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "6";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "6";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        ///////////////////// 빼기 /////////////////////
        private void button12_Click(object sender, EventArgs e)
        {
            opFlag = true;
            lValue = double.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = lValue + " " + op;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "2";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "2";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "3";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "3";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        ///////////////////// 더하기 /////////////////////
        private void button16_Click(object sender, EventArgs e)
        {
            opFlag = true;
            lValue = double.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = lValue + " " + op;
        }

        ///////////////////// (+/-) /////////////////////
        private void button17_Click(object sender, EventArgs e)
        {
            double c = double.Parse(lbResult.Text);
            lbResult.Text = (-c).ToString();
            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Replace(",", "");
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "0";
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 16)
                {
                    return;
                }
                lbResult.Text += "0";
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }

        ///////////////////// (결과 =) /////////////////////
        private void button19_Click(object sender, EventArgs e)
        {
            double rValue = double.Parse(lbResult.Text);
            switch (op)
            {
                case "+":
                    lbResult.Text = (lValue + rValue).ToString();
                    break;
                case "-":
                    lbResult.Text = (lValue - rValue).ToString();
                    break;
                case "×":
                    lbResult.Text = (lValue * rValue).ToString();
                    break;
                case "÷":
                    lbResult.Text = (lValue / rValue).ToString();
                    break;
            }
            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
            lbExp.Text = lValue + " " + op + " " + rValue + " =";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ///////////////////// (나누기) /////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            opFlag = true;
            lValue = double.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = lValue + " " + op;
        }
        ///////////////////// (곱하기) /////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            opFlag = true;
            lValue = double.Parse(lbResult.Text);
            Button btn = sender as Button;
            op = btn.Text.ToString();
            lbExp.Text = lValue + " " + op;
        }
        ///////////////////// (소수점) /////////////////////
        private void button3_Click(object sender, EventArgs e)
        {
            if (lbResult.Text.Contains("."))
                return;
            else
                lbResult.Text += ".";
        }
        ///////////////////// (콤마) /////////////////////
        private static string Comma(double v, string s)
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

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Name.Remove(0, 3);
            
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = s;
                opFlag = false;
            }
            else
            {
                if (lbResult.Text.Length == 21)
                {
                    return;
                }
                lbResult.Text += s;
            }

            double v = double.Parse(lbResult.Text);
            lbResult.Text = Comma(v, lbResult.Text);
        }
    }
}
