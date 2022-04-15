using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEqual
{
    public partial class QuadCalc : Form
    {
        public QuadCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Очистить все поля        
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_a.Text = "";
            textBox_b.Text = "";
            textBox_c.Text = "";
            textBox_x1.Text = "";
            textBox_x2.Text = "";
            label_comment.Text = "";
        }

        // Закрыть программу
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Найти корни уравнения
        private void button_solve_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, dis;
            if ((textBox_a.Text != "") && (textBox_b.Text != "") && (textBox_c.Text != ""))
            {
                a = Convert.ToDouble(textBox_a.Text);
                b = Convert.ToDouble(textBox_b.Text);
                c = Convert.ToDouble(textBox_c.Text);
                // a=0, b=0, c=0
                if (a == 0 && b == 0 && c == 0)
                {
                    textBox_x1.Text = "";
                    textBox_x2.Text = "";
                    label_comment.Text = "Верное равенство";
                    return;
                }
                // a=0, b=0
                if (a == 0 && b == 0)
                {
                    textBox_x1.Text = "";
                    textBox_x2.Text = "";
                    label_comment.Text = "Неверное равенство";
                    return;
                }
                // b=0, c=0
                if (b == 0 && c == 0)
                {
                    textBox_x1.Text = "0";
                    textBox_x2.Text = "";
                    label_comment.Text = "Неполное квадратное уравнение. Имеет один корень";
                    return;
                }
                
                // a=0
                if (a == 0)
                {
                    x1 = -c / b;
                    textBox_x1.Text = Convert.ToString(x1);
                    textBox_x2.Text = "";
                    label_comment.Text = "Линейное уравнение – имеет один корень.";
                    return;
                }
                // b=0
                if (b == 0)
                {
                    x1 = -c / a;
                    if (x1 > 0)
                    {
                        x1 = Math.Sqrt(x1);
                        x2 = -x1;
                        textBox_x1.Text = Convert.ToString(x1);
                        textBox_x2.Text = Convert.ToString(x2);
                        label_comment.Text = "Неполное квадратное уравнение. Имеет два корня";
                        return;
                    }
                    else
                    {
                        textBox_x1.Text = "";
                        textBox_x2.Text = "";
                        label_comment.Text = "Неполное квадратное уравнение. Не имеет действительных корней.";
                        return;
                    }
                }

                // Вычисление и проверка дискриминанта, поиск корней
                dis = (Math.Pow(b, 2) - 4 * a * c);
                if (dis < 0)
                {
                    textBox_x1.Text = "";
                    textBox_x2.Text = "";
                    label_comment.Text = "Дискриминант < 0. Уравнение не имеет действительных корней.";
                }
                else if (dis == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                    textBox_x1.Text = Convert.ToString(x1);
                    textBox_x2.Text = Convert.ToString(x2);
                    label_comment.Text = "Дискриминант = 0. Уравнение имеет два одинаковых корня.";
                }
                else if (dis > 0)
                {
                    x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                    x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                    textBox_x1.Text = Convert.ToString(x1);
                    textBox_x2.Text = Convert.ToString(x2);
                    label_comment.Text = "Дискриминант > 0. Уравнение имеет два корня.";
                }
            }
            // Не все поля заполнены
            else
            {
                textBox_x1.Text = "";
                textBox_x2.Text = "";
                label_comment.Text = "Пожалуйста, задайте значения всех переменных";
            }
        }

        // Фильтрация вводимых данных в поле "a"
        private void textBox_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_a.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox_a.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button_solve.Focus();
                return;
            } e.Handled = true;
        }

        // Фильтрация вводимых данных в поле "b"
        private void textBox_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_b.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox_b.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button_solve.Focus();
                return;
            } 
            e.Handled = true;
        }

        // Фильтрация вводимых данных в поле "c"
        private void textBox_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_c.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox_c.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button_solve.Focus();
                return;
            } e.Handled = true;
        }
    }
}
