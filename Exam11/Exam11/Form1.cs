using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtRecept.TextLength < 4)
            {
                MessageBox.Show("Длина названия рецепта должна быть больше 4 символов", "Внимание");
            }
            if (txtRecept.TextLength > 50)
            {
                MessageBox.Show("Длина названия рецепта не должна превышать 60 символов", "Внимание");
            }


            if (txtIngridient.TextLength < 10)
            {
                MessageBox.Show("Длина названия ингридиента должна быть больше 10 символов", "Внимание");
            }
            if (txtRecept.TextLength > 35)
            {
                MessageBox.Show("Длина названия ингридиента не должна превышать 35 символов", "Внимание");
            }
            txtCount.Text =txtCount.Text.Replace(" ", "");
            if (txtCount.Text.Substring(0, 1) == "-")
            {
                MessageBox.Show("Введите положительное число", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtCount.Text = txtCount.Text.Substring(1);
            }
        }
    }
}
