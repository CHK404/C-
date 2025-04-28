using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_02_variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //변수의 선언
            int numOfCrew;

            //변수의 사용(값 복사)
            numOfCrew = 19;

            //변수의 초기화
            string className = "말하기";

            //변수의 값 덮어쓰기
            className = "수학";

            //선언보다 밑 줄에서 사용 가능
            //LineCount = 10; (x)
            int lineCount;

            //선언시 같은 이름 사용 불가 (ex. float buffer)
            byte buffer;

            //데이터 타입이 완전히 다르면 복사 불가
            int number = 10;
            string word = "안녕";

            //number = word; (x)

            //같은 형식에서 데이터 타입의 크기에 따라 복사 가능 or 불가능
            short word2 = 20;

            //int > short 더 큰 범위의 데이터 타입
            number = word2; //자료형이 다르지만 복사 가능

            //변수끼리 값 복사
            int var_x = 10;
            int var_y = var_x; //x -> y로 복사

            //사칙 연산 및 괄호 활용
            int var_z = var_x * var_y;
            int result = var_z + (var_x + 5);


            //scope가 다르면 사용 불가
            {
                int inside = 100;
            }

            //int outside = inside + 50;
            //inside와 scope가 달라서 사용 불가

            //실습. 변수 및 캐스팅
            byte classNum = 15;
            short temp = 15;
            int aprilDays = 30;
            float piF = 3.14159f;
            double piDou = 3.141592653589793;
            decimal piDec = 3.1415926535897932384626433832m;

            textBox_print.Text += classNum.GetType() + "System.Byte classNum: " + classNum.ToString() + "\r\n";
            textBox_print.Text += temp.GetType() + "System.Short temp: " + temp.ToString() + "\r\n";
            textBox_print.Text += aprilDays.GetType() + "System.Int aprilDays: " + aprilDays.ToString() + "\r\n";
            textBox_print.Text += piF.GetType() + "System.Float piF: " + piF.ToString() + "\r\n";
            textBox_print.Text += piDou.GetType() + "System.Double piDou: " + piDou.ToString() + "\r\n";
            textBox_print.Text += piDec.GetType() + "System.Decimal piDec: " + piDec.ToString() + "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
