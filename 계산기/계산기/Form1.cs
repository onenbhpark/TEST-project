using System;
using System.Windows.Forms;

namespace 계산기
{
    public partial class Form1 : Form
    {
        /* 변수선언
        lvalue에 피연산자(기존숫자저장)
        사칙연산 op에저장
        사칙연산 이후 숫자가새로시작 flag사용 */
        private double lValue;
        private char op = '\0';
        //op를 처음엔 null문자로하고 숫자버튼에서 나머지처리
        private bool opFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 계산기 크기조절x 고정
            BorderStyle 변경 */
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        // 스트링타입
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "1";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "1";
        }

        // 저장값,op,lbresult.text 전부초기화
        private void btnC_Click(object sender, EventArgs e)
        {
            lbResult.Text = "0";
            lbExp.Text = "";
            lValue = 0;
            op = '\0';
            opFlag = false;
        }

        // remove 로 뒤에한자리만 지워지도록
        // 구글ms string종류 참조
        private void btnBC_Click(object sender, EventArgs e)
        {
            lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 1);
            // 더이상 지울숫자가없을때 에러발생
            if (lbResult.Text.Length == 0)
                lbResult.Text = "0";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "7";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "8";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "9";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "4";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "5";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "6";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "6";
        }

        // " - "
        private void button12_Click(object sender, EventArgs e)
        {
            lValue = Double.Parse(lbResult.Text);
            lbExp.Text = lbResult.Text + " - ";
            op = '-';
            opFlag = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "2";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "3";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "3";
        }

        /* " + "
         버튼이눌릴때 텍스트에있는값을 저장할곳이 필요 > lvalue
         저장소가 이퀄누른뒤 나중에 처리되어야해서 함수밖에 만들어야해서 밖에생성 */
        private void button16_Click(object sender, EventArgs e)
        {
            lValue = Double.Parse(lbResult.Text);
            lbExp.Text = lbResult.Text + " + ";
            op = '+';
            opFlag = true;
        }

        // " +/- "
        private void button17_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(lbResult.Text);
            //텍스트에 있는값을 숫자로 변환
            lbResult.Text = (-v).ToString();
            //다시 문자변환
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "0" || opFlag == true)
            {
                lbResult.Text = "0";
                opFlag = false;
            }
            else
                lbResult.Text = lbResult.Text + "0";
        }

        // 결과( = )
        private void button19_Click(object sender, EventArgs e)
        {
            Double rVlaue = Double.Parse(lbResult.Text);
            switch (op)
            {
                case '+':
                    lbResult.Text = (lValue + rVlaue).ToString();
                    break;
                /* 이퀄에서 +연산 이후 -연산 확인시 -가아닌 +만 되는문제발생
                case 입력시 l,r벨류기호를 "- 가아닌 + 로 복붙하여 입력해놔 계산값이 +로만 계산됬었지만 수정" */
                case '-':
                    lbResult.Text = (lValue - rVlaue).ToString();
                    break;
            }
            lbExp.Text = "";
       }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
