using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Установить, является ли последовательность цифр при просмотре их слева направо упорядоченной по возрастанию." +
                " Например, для последовательности 1,4,7,8 ответ положительный, для чисел 1,7,8,2 и 1,6,6,8 — отрицательный и т. п.", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] num = numbertext.Text.Split(' ', ',', '.');
            for (int i = 0; i < num.Length; i++)
            {
                if (!int.TryParse(num[i], out int value))
                {
                    MessageBox.Show("Вы ввели не числа!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    break;
                }
            }
            var count = Logic
            result.Text = $"Числа упорядочены по возрастанию";
        }

       
        
    }
}
