using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Math_practice13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TaskSelector.SelectedIndex = 0;
            UpdateInputPanel(0);
        }

        private void TaskSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateInputPanel(TaskSelector.SelectedIndex);
        }

        private void UpdateInputPanel(int taskIndex)
        {
            InputPanel.Children.Clear();
            ResultText.Text = "";

            string[] labels = {
                "Введите двоичное число:",
                "Введите двоичное число:",
                "Введите двоичное число:",
                "Введите дробное двоичное число (с точкой):",
                "Введите дробное двоичное число (с точкой):",
                "Введите дробное двоичное число (с точкой):",
                "Введите 15 двузначных чисел (через пробел):",
                "Введите 9 восьмеричных чисел (через пробел):",
                "Введите 7 двузначных чисел (через пробел):",
                "Введите 7 элементов первого массива (через пробел):",
                "Введите 9 элементов второго массива (через пробел):",
                "Введите 12 двоичных чисел (через пробел):",
                "Введите 10 элементов массива (должно быть 2 одинаковых):",
                "Введите двоичное число:",
                "Введите 5 двоичных чисел (через пробел):",
                "Введите 5 двоичных чисел (через пробел):",
                "Введите 5 двоичных чисел (через пробел):",
                "Введите двоичное число:",
                "Введите 10 целых чисел (через пробел):",
                "Введите 5 целых чисел (через пробел):",
                "Введите 5 целых чисел (через пробел):",
                "Введите 10 целых чисел (через пробел):",
                "Введите 10 целых чисел (через пробел):",
                "Введите 5 двоичных чисел (через пробел):",
                "Введите 5 двоичных чисел (через пробел):",
                "Введите 5 двоичных чисел (через пробел):",
                "Введите 5 двоичных чисел (черес пробел):",
                "Введите 5 вещественных чисел (через пробел):",
                "Введите число R:",
                "Введите 5 двоичных чисел (через пробел):",
                "Введите двоичное число D:",
                "Введите положительное двоичное число:",
                "Введите отрицательное двоичное число (доп. код):",
                "Введите 3 десятичных числа (через пробел):"
            };

            int[] inputsCount = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 2, 2, 1 };

            for (int i = 0; i < inputsCount[taskIndex]; i++)
            {
                InputPanel.Children.Add(new Label { Content = labels[taskIndex], Margin = new Thickness(0, 5, 0, 0) });
                InputPanel.Children.Add(new TextBox { Margin = new Thickness(0, 0, 0, 5) });
            }
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultText.Text = "";
                int taskIndex = TaskSelector.SelectedIndex;
                var textBoxes = InputPanel.Children.OfType<TextBox>().ToArray();
                string[] inputs = new string[textBoxes.Length];

                for (int i = 0; i < textBoxes.Length; i++)
                {
                    inputs[i] = textBoxes[i].Text;
                }

                string result = "";
                switch (taskIndex)
                {
                    case 0: result = Task1(inputs[0]); break;
                    case 1: result = Task2(inputs[0]); break;
                    case 2: result = Task3(inputs[0]); break;
                    case 3: result = Task4(inputs[0]); break;
                    case 4: result = Task5(inputs[0]); break;
                    case 5: result = Task6(inputs[0]); break;
                    case 6: result = Task7(inputs[0]); break;
                    case 7: result = Task8(inputs[0]); break;
                    case 8: result = Task9(inputs[0]); break;
                    case 9: result = Task10(inputs[0], inputs[1]); break;
                    case 10: result = Task11(inputs[0]); break;
                    case 11: result = Task12(inputs[0]); break;
                    case 12: result = Task13(inputs[0]); break;
                    case 13: result = Task14(inputs[0]); break;
                    case 14: result = Task15(inputs[0]); break;
                    case 15: result = Task16(inputs[0]); break;
                    case 16: result = Task17(inputs[0]); break;
                    case 17: result = Task18(inputs[0]); break;
                    case 18: result = Task19(inputs[0]); break;
                    case 19: result = Task20(inputs[0]); break;
                    case 20: result = Task21(inputs[0]); break;
                    case 21: result = Task22(inputs[0]); break;
                    case 22: result = Task23(inputs[0]); break;
                    case 23: result = Task24(inputs[0]); break;
                    case 24: result = Task25(inputs[0]); break;
                    case 25: result = Task26(inputs[0]); break;
                    case 26: result = Task27(inputs[0], inputs[1]); break;
                    case 27: result = Task28(inputs[0], inputs[1]); break;
                    case 28: result = Task29(inputs[0], inputs[1]); break;
                    case 29: result = Task30(inputs[0]); break;
                }

                ResultText.Text = result;
            }
            catch (Exception ex)
            {
                ResultText.Text = "Ошибка: " + ex.Message;
            }
        }

        private string Task1(string binary)
        {
            int result = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - 1 - i] == '1')
                {
                    result += (int)Math.Pow(2, i);
                }
            }
            return $"Десятичное: {result}";
        }

        private string Task2(string binary)
        {
            int decimalNum = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - 1 - i] == '1')
                {
                    decimalNum += (int)Math.Pow(2, i);
                }
            }

            string octal = "";
            while (decimalNum > 0)
            {
                octal = (decimalNum % 8) + octal;
                decimalNum /= 8;
            }

            return $"Восьмеричное: {octal}";
        }

        private string Task3(string binary)
        {
            int decimalNum = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - 1 - i] == '1')
                {
                    decimalNum += (int)Math.Pow(2, i);
                }
            }

            string hex = "";
            while (decimalNum > 0)
            {
                int remainder = decimalNum % 16;
                hex = (remainder < 10) ? remainder + hex : (char)('A' + remainder - 10) + hex;
                decimalNum /= 16;
            }

            return $"Шестнадцатеричное: {hex}";
        }

        private string Task4(string binary)
        {
            string[] parts = binary.Split('.');
            if (parts.Length != 2) throw new ArgumentException("Некорректный формат");

            int intPart = 0;
            for (int i = 0; i < parts[0].Length; i++)
            {
                if (parts[0][parts[0].Length - 1 - i] == '1')
                {
                    intPart += (int)Math.Pow(2, i);
                }
            }

            double fracPart = 0;
            for (int i = 0; i < parts[1].Length; i++)
            {
                if (parts[1][i] == '1')
                {
                    fracPart += Math.Pow(2, -(i + 1));
                }
            }

            return $"Десятичное: {intPart + fracPart}";
        }

        private string Task5(string binary)
        {
            string[] parts = binary.Split('.');
            if (parts.Length != 2) throw new ArgumentException("Некорректный формат");

            int intPart = 0;
            for (int i = 0; i < parts[0].Length; i++)
            {
                if (parts[0][parts[0].Length - 1 - i] == '1')
                {
                    intPart += (int)Math.Pow(2, i);
                }
            }

            string octalInt = "";
            int tempInt = intPart;
            while (tempInt > 0)
            {
                octalInt = (tempInt % 8) + octalInt;
                tempInt /= 8;
            }

            double fracPart = 0;
            for (int i = 0; i < parts[1].Length; i++)
            {
                if (parts[1][i] == '1')
                {
                    fracPart += Math.Pow(2, -(i + 1));
                }
            }

            string octalFrac = "";
            double tempFrac = fracPart;
            for (int i = 0; i < 6; i++)
            {
                tempFrac *= 8;
                int digit = (int)tempFrac;
                octalFrac += digit;
                tempFrac -= digit;
                if (tempFrac == 0) break;
            }

            return $"Восьмеричное: {octalInt}.{octalFrac}";
        }

        private string Task6(string binary)
        {
            string[] parts = binary.Split('.');
            if (parts.Length != 2) throw new ArgumentException("Некорректный формат");

            int intPart = 0;
            for (int i = 0; i < parts[0].Length; i++)
            {
                if (parts[0][parts[0].Length - 1 - i] == '1')
                {
                    intPart += (int)Math.Pow(2, i);
                }
            }

            string hexInt = "";
            int tempInt = intPart;
            while (tempInt > 0)
            {
                int remainder = tempInt % 16;
                hexInt = (remainder < 10) ? remainder + hexInt : (char)('A' + remainder - 10) + hexInt;
                tempInt /= 16;
            }

            double fracPart = 0;
            for (int i = 0; i < parts[1].Length; i++)
            {
                if (parts[1][i] == '1')
                {
                    fracPart += Math.Pow(2, -(i + 1));
                }
            }

            string hexFrac = "";
            double tempFrac = fracPart;
            for (int i = 0; i < 6; i++)
            {
                tempFrac *= 16;
                int digit = (int)tempFrac;
                hexFrac += digit.ToString("X");
                tempFrac -= digit;
                if (tempFrac == 0) break;
            }

            return $"Шестнадцатеричное: {hexInt}.{hexFrac}";
        }

        private string Task7(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 15) throw new ArgumentException("Нужно 15 чисел");

            int[] array = new int[15];
            for (int i = 0; i < 15; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            int[] newArray = new int[15];
            for (int i = 0; i < 15; i++)
            {
                int num = array[i];
                int tens = num / 10;
                int units = num % 10;
                newArray[i] = units * 10 + tens;
            }

            string result = "Новый массив:";
            for (int i = 0; i < 15; i++)
            {
                result += " " + newArray[i];
            }

            return result;
        }

        private string Task8(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 9) throw new ArgumentException("Нужно 9 чисел");

            int[] decimalArray = new int[9];
            for (int i = 0; i < 9; i++)
            {
                int num = 0;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    int digit = numbers[i][j] - '0';
                    num += digit * (int)Math.Pow(8, numbers[i].Length - 1 - j);
                }
                decimalArray[i] = num;
            }

            string result = "Десятичный массив:";
            for (int i = 0; i < 9; i++)
            {
                result += " " + decimalArray[i];
            }

            return result;
        }

        private string Task9(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 7) throw new ArgumentException("Нужно 7 чисел");

            int[] array = new int[7];
            for (int i = 0; i < 7; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            int[] newArray = new int[7];
            for (int i = 0; i < 7; i++)
            {
                newArray[i] = array[i] / 10;
            }

            string result = "Массив старших разрядов:";
            for (int i = 0; i < 7; i++)
            {
                result += " " + newArray[i];
            }

            return result;
        }

        private string Task10(string input1, string input2)
        {
            string[] numbers1 = input1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] numbers2 = input2.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers1.Length != 7 || numbers2.Length != 9) throw new ArgumentException("Нужно 7 и 9 чисел");

            double[] array1 = new double[7];
            for (int i = 0; i < 7; i++)
            {
                array1[i] = double.Parse(numbers1[i]);
            }

            double[] array2 = new double[9];
            for (int i = 0; i < 9; i++)
            {
                array2[i] = double.Parse(numbers2[i]);
            }

            double[] merged = new double[16];
            for (int i = 0; i < 7; i++) merged[i] = array1[i];
            for (int i = 0; i < 9; i++) merged[7 + i] = array2[i];

            for (int i = 0; i < merged.Length - 1; i++)
            {
                for (int j = 0; j < merged.Length - 1 - i; j++)
                {
                    if (merged[j] < merged[j + 1])
                    {
                        double temp = merged[j];
                        merged[j] = merged[j + 1];
                        merged[j + 1] = temp;
                    }
                }
            }

            string result = "Объединенный массив:";
            for (int i = 0; i < merged.Length; i++)
            {
                result += " " + merged[i];
            }

            return result;
        }

        private string Task11(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 12) throw new ArgumentException("Нужно 12 чисел");

            Dictionary<string, int> counts = new Dictionary<string, int>();
            for (int i = 0; i < 12; i++)
            {
                if (counts.ContainsKey(numbers[i]))
                {
                    counts[numbers[i]]++;
                }
                else
                {
                    counts[numbers[i]] = 1;
                }
            }

            List<string> resultList = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                if (counts[numbers[i]] <= 2)
                {
                    resultList.Add(numbers[i]);
                }
            }

            string result = "Результат:";
            for (int i = 0; i < resultList.Count; i++)
            {
                result += " " + resultList[i];
            }

            return result;
        }

        private string Task12(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 10) throw new ArgumentException("Нужно 10 чисел");

            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            int firstIndex = -1, secondIndex = -1;
            bool found = false;

            for (int i = 0; i < array.Length && !found; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        firstIndex = i;
                        secondIndex = j;
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                return $"Одинаковые элементы на позициях: {firstIndex} и {secondIndex}";
            }
            else
            {
                return "Дубликаты не найдены";
            }
        }

        private string Task13(string binary)
        {
            char[] shifted = new char[binary.Length];
            for (int i = 0; i < binary.Length; i++)
            {
                shifted[(i + binary.Length - 2) % binary.Length] = binary[i];
            }

            int original = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - 1 - i] == '1')
                {
                    original += (int)Math.Pow(2, i);
                }
            }

            int shiftedNum = 0;
            for (int i = 0; i < shifted.Length; i++)
            {
                if (shifted[shifted.Length - 1 - i] == '1')
                {
                    shiftedNum += (int)Math.Pow(2, i);
                }
            }

            return $"Исходное: {binary}\nПосле сдвига: {new string(shifted)}\nРазность: {original - shiftedNum}";
        }

        private string Task14(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 5) throw new ArgumentException("Нужно 5 чисел");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (string.Compare(numbers[j], numbers[j + 1]) < 0)
                    {
                        string temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int num = 0;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][numbers[i].Length - 1 - j] == '1')
                    {
                        num += (int)Math.Pow(2, j);
                    }
                }
                sum += num;
            }

            string result = "Отсортированный массив:";
            for (int i = 0; i < 5; i++)
            {
                result += " " + numbers[i];
            }

            result += $"\nСумма: {sum}";

            return result;
        }

        private string Task15(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 5) throw new ArgumentException("Нужно 5 чисел");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (string.Compare(numbers[j], numbers[j + 1]) > 0)
                    {
                        string temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int num = 0;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][numbers[i].Length - 1 - j] == '1')
                    {
                        num += (int)Math.Pow(2, j);
                    }
                }
                sum += num;
            }

            double average = (double)sum / 5;

            string result = "Отсортированный массив:";
            for (int i = 0; i < 5; i++)
            {
                result += " " + numbers[i];
            }

            result += $"\nСреднее: {average}";

            return result;
        }

        private string Task16(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 5) throw new ArgumentException("Нужно 5 чисел");

            int[] values = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int num = 0;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][numbers[i].Length - 1 - j] == '1')
                    {
                        num += (int)Math.Pow(2, j);
                    }
                }
                values[i] = num;
            }

            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < 5; i++)
            {
                if (values[i] < values[minIndex]) minIndex = i;
                if (values[i] > values[maxIndex]) maxIndex = i;
            }

            string temp = numbers[minIndex];
            numbers[minIndex] = numbers[maxIndex];
            numbers[maxIndex] = temp;

            string result = "Массив после замены:";
            for (int i = 0; i < 5; i++)
            {
                result += " " + numbers[i];
            }

            return result;
        }

        private string Task30(string input)
        {
            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numbers.Length != 3) throw new ArgumentException("Нужно 3 числа");

            string[] binaryArray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(numbers[i]);
                string binary = "";
                while (num > 0)
                {
                    binary = (num % 2) + binary;
                    num /= 2;
                }
                binaryArray[i] = binary;
            }

            string result = "Двоичный массив:";
            for (int i = 0; i < 3; i++)
            {
                result += " " + binaryArray[i];
            }

            return result;
        }
    }
}
