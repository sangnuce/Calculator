using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class f_Main : Form
    {
        private double oldValue; //Lưu lại số hạng thứ nhất
        private string last_op = ""; //Lưu lại toán tử cuối cùng
        private bool op_Click = false; //Lưu lại xem có phải vừa click toán tử hay không

        public f_Main()
        {
            InitializeComponent();
        }
        //Hàm xử lý khi click các số và dấu '.'
        private void number_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button) sender;
            //Nếu vừa có toán tử được click thì reset ô kết quả để nhập số hạng thứ 2
            if (op_Click == true)
            {
                scr.Text = "0";
                op_Click = false;
            }
            //Nếu nhập dấu '.' thì cần kiểm tra đã có dấu chấm hay chưa rồi mới thêm
            if (btn.Name == "Dot")
            {
                if (scr.Text.IndexOf('.') < 0)
                {
                    scr.Text += '.';
                }
            }
            else
            {
                //Lấy giá trị của nút vừa click
                string num = btn.Name.Split('_')[1];
                //Kiểm tra xem nếu ô kết quả đang có Text = '0' thì làm rỗng
                //để khi chèn số vừa click thì không bị thừa số 0 ở đầu
                if (scr.Text == "0")
                {
                    scr.Text = "";
                }
                //Chèn số vừa click
                scr.Text += num;
            }
        }
        //Hàm xử lý khi click toán tử
        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;
            double new_operand = Convert.ToDouble(scr.Text); //Lấy toán hạng mới
            //Kiểm tra nếu chưa có toán tử nào được click thì gán toán hạng đầu cho toán hạng mới
            if (last_op == "")
            {
                oldValue = new_operand;
            }
            //Nếu không thì thực hiện phép tính của toán hạng thứ nhất đã lưu với toán hạng mới
            //và lưu kết quả vào toán hạng thứ nhất
            else
            {
                switch (last_op)
                {
                    case "+":
                        oldValue += new_operand;
                        break;
                    case "-":
                        oldValue -= new_operand;
                        break;
                    case "x":
                        oldValue *= new_operand;
                        break;
                    case "/":
                        if (new_operand == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!");
                            return;
                        }
                        else
                        {
                            oldValue /= new_operand;
                        }
                        break;
                    default:
                        break;
                }
            }
            //In giá trị là toán hạng thứ nhất ra màn hình
            scr.Text = (oldValue).ToString();
            op_Click = true; //Cài trạng thái vừa click toán tử
            //Lưu lại toán tử vừa click để thực hiện phép tính với toán hạng mới
            if (btn.Text == "=")
            {
                last_op = "";
            }
            else
            {
                last_op = btn.Text;
            }
        }
        //Hàm xử lý đảo dấu của toán hạng ở ô kết quả
        private void Neg_Click(object sender, EventArgs e)
        {
            scr.Text = (-1 * (Convert.ToDouble(scr.Text))).ToString();
        }
        //Hàm xử lý reset trạng thái cho máy tính bỏ túi
        private void Clear_Click(object sender, EventArgs e)
        {
            scr.Text = "0";
            oldValue = 0;
            op_Click = false;
        }
    }
}
