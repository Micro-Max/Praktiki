using System;
using System.Windows.Forms;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] testStrings = new string[]
            {
                "В начале 123 и дальше текст",
                "Тут 45 и тут 55 числа",
                "Нет чисел вообще",
                "Конец строки 789",
                "Смешано 1 abc 2def 3 4ghi5 6"
            };

            foreach (string s in testStrings)
            {
                int sum = SumOfNumbersInString(s);
                listBox1.Items.Add($"\"{s}\" → сумма: {sum}");
            }
        }

        private int SumOfNumbersInString(string input)
        {
            int sum = 0;
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
