namespace WindowsFormsApp2
{
    public class Logic
    {
        public static int FindMax(string number2)
        {
            string[] number1 = number2.Split(' ', ',', '.');//записываем каждое число отдельно 
            int[] number = new int[number1.Length];//массив для следующего преобразования
                                                   //цикл преобразования числа в целочисленное и сразу проверяет его на порядок 
            for (int i = 1; i <= number1.Length - 1; i++)
            {
                number[i] = Convert.ToInt32(number1[i]);
                if (number[i - 1] > (number[i]))
                {
                    count = false;
                }
            }
        }
        return count;
    }
}

