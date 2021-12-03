using Quadrangle.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadrangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // làm mới
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            label15.Text = "";
            label16.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tính toán
            string x1 = textBox1.Text.ToString();
            string y1 = textBox2.Text.ToString();
            string x2 = textBox3.Text.ToString();
            string y2 = textBox4.Text.ToString();
            string x3 = textBox5.Text.ToString();
            string y3 = textBox6.Text.ToString();
            string x4 = textBox7.Text.ToString();
            string y4 = textBox8.Text.ToString();

            if (string.IsNullOrEmpty(x1) || string.IsNullOrEmpty(y1) ||
                string.IsNullOrEmpty(x2) || string.IsNullOrEmpty(y2) ||
                string.IsNullOrEmpty(x3) || string.IsNullOrEmpty(y3) ||
                string.IsNullOrEmpty(x4) || string.IsNullOrEmpty(y4)
                )
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin các đỉnh");
            }
            else if (!isNumber(x1) || !isNumber(y1) ||
                !isNumber(x2) || !isNumber(y2) ||
                !isNumber(x3) || !isNumber(y3) ||
                !isNumber(x4) || !isNumber(y4)
                )
            {
                MessageBox.Show("Các đỉnh phải là dạng số");
            }
            else
            {
                var dinhs = new List<ToaDo>()
                {
                     new ToaDo()
                    {
                        x = int.Parse(x1),
                        y = int.Parse(y1)
                    },
                     new ToaDo()
                    {
                        x = int.Parse(x2),
                        y = int.Parse(y2)
                    },
                    new ToaDo()
                    {
                        x = int.Parse(x3),
                        y = int.Parse(y3)
                    },
                    new ToaDo()
                    {
                        x = int.Parse(x4),
                        y = int.Parse(y4)
                    }
                };
                TuGiac tuGiac = new TuGiac()
                {
                    dinh1 = dinhs.OrderByDescending(x => x.y).ThenBy(x => x.x).First(),
                    dinh2 = dinhs.OrderByDescending(x => x.y).ThenBy(x => x.x).ElementAt(1),
                    dinh3 = dinhs.OrderBy(x => x.y).ThenBy(x => x.x).First(),
                    dinh4 = dinhs.OrderBy(x => x.y).ThenBy(x => x.x).ElementAt(1),
                };

                label15.Text = tuGiac.ChuVi().ToString();
                label16.Text = tuGiac.DienTich().ToString();
            }
        }

        public bool isNumber(string input)
        {
            return double.TryParse(input, out double number);
        }

    }
}
