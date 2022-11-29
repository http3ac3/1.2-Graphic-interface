using System;
using System.Windows.Forms;

namespace Exercize_2_WinForms
{
    public partial class Form1 : Form
    {
        int m, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAnswerButton_Click(object sender, EventArgs e)
        {
            try
            {
                m = int.Parse(MValueTextBox.Text);
                
            }
            catch
            {
                AnswerTextBox.Text =  "Некорректный ввод! Доступен только ввод цифр и знака \"минус\"";
                return;
            }

            try
            {
                n = int.Parse(NValueTextBox.Text);
                if (n == 0)
                {
                    AnswerTextBox.Text = "Делить на 0 нельзя!";
                    return;
                }
            }
            catch
            {
                AnswerTextBox.Text = "Некорректный ввод! Доступен только ввод цифр и знака \"минус\"";
                return;
            }

            if (m % n == 0)
                AnswerTextBox.Text = $"Частное от деления числа {m} на числа {n}: {m / n}";
            else
                AnswerTextBox.Text = $"M на N нацело не делится";
        }
    }
}
