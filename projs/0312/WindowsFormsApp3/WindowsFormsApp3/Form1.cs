using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string plus1 = add_input_1.Text;        
            string plus2 = add_input_2.Text;
            float plus_1_num = 0;
            float plus_2_num = 0;

            try
            {
                plus_1_num = float.Parse(plus1);
            }
            catch
            {
                MessageBox.Show("더하기 좌측 입력에 숫자를 입력하세요");
            }
            
            try
            {  
                plus_2_num = float.Parse(plus2);
            }
            catch
            {
                MessageBox.Show("더하기 우측 입력에 숫자를 입력하세요");
            }

            Calculator calc = new Calculator();
            float result = calc.plus(plus_1_num, plus_2_num);

            add_result.Text = result + "";
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            string minus1 = minus_input_1.Text;
            string minus2 = minus_input_2.Text;
            float minus_1_num = 0;
            float minus_2_num = 0;

            try
            {  
                minus_1_num = float.Parse(minus1);
            }
            catch
            {
                MessageBox.Show("빼기 좌측 입력에 숫자를 입력하세요");
            }

            try
            {
                minus_2_num = float.Parse(minus2);
            }
            catch
            {
                MessageBox.Show("빼기 우측 입력에 숫자를 입력하세요");
            }

            Calculator calc = new Calculator();
            float result = calc.minus(minus_1_num, minus_2_num);

            minus_result.Text = result + "";
        }

        private void mul_button_Click(object sender, EventArgs e)
        {
            string mul1 = mul_input_1.Text;
            string mul2 = mul_input_2.Text;
            float mul_1_num = 0;
            float mul_2_num = 0;

            try
            {
                mul_1_num = float.Parse(mul1);
            }
            catch
            {
                MessageBox.Show("곱하기 좌측 입력에 숫자를 입력하세요");
            }

            try
            {
                mul_2_num = float.Parse(mul2);
            }
            catch
            {
                MessageBox.Show("곱하기 우측 입력에 숫자를 입력하세요");
            }

            Calculator calc = new Calculator();
            float result = calc.multiple(mul_1_num, mul_2_num);

            mul_result.Text = result + "";
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            string div1 = div_input_1.Text;
            string div2 = div_input_2.Text;
            float div_1_num = 0;
            float div_2_num = 1;

            if(div2 == "0")
            {
                MessageBox.Show("0으로 나눌 수 없습니다.");
                return;
            }

            try
            {
                div_1_num = float.Parse(div1);
            }
            catch
            {
                MessageBox.Show("나누기 좌측 입력에 숫자를 입력하세요");
            }

            try
            {
                div_2_num = float.Parse(div2);
            }
            catch
            {
                MessageBox.Show("나누기 우측 입력에 숫자를 입력하세요");
            }

            Calculator calc = new Calculator();
            float result = calc.divide(div_1_num, div_2_num);

            div_result.Text = result + "";
        }
    }
}
