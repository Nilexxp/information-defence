using System;

namespace lb5
{
    class BCH
    {
        static string[] Px = { "заполнитель 0"," заполнитель 1","111", "1011", "10011" };
        public static (string, string) Encode(string input)
        {
            ///шифрация сообщения
            ///берем изначальное сообщение
            int mess = Convert.ToInt32(input, 2);
            ///умножаем на r, где r - это индекс бита с конца числа
            int r = GetR(input) - 1;
            mess *= Convert.ToInt32(Math.Pow(10, r + 1).ToString(), 2);
            ///то, что получилось - разделить на порождающий полином (согласно r), вычитание по модулю 2
            mess /= Convert.ToInt32(Px[r], 2);
            ///полученное значение  - проверочные символы
            return (input + Convert.ToString(mess, 2), (input + Convert.ToString(mess, 2)).Length + "/" + r);
        }
        public static string Decode(string input, int pxNum)
        {
            string px = Px[pxNum];
            if (!IsError(input, pxNum))
            {
                input = Correct(input, pxNum);
            }
            int r = Array.IndexOf(Px, px);
            int start = input.Length - r, end = input.Length - 1;
            string output = "";
            for (int i = 0; i < start; i++)
            {
                output += input[i];
            }
            ///расшифровка правильного сообщения
            return output;
        }
        public static string Correct(string input, int pxNum)
        {
            string px = Px[pxNum];
            string temp = input;
            string errBit = "1" + new string(input.ToCharArray(1, input.Length - 1));
            int cnt = 0;
            while (Convert.ToInt32(errBit, 2) / Convert.ToInt32(px, 2) != Convert.ToInt32(temp, 2) / Convert.ToInt32(px, 2))
            {
                temp += "0";
                cnt++;
            }
            ///исправление сообщения с ошибкой
            ///сдвигать влево до тех пор, пока все не сойдется (домножать на x)
            ///количество итераций - бит, в котором ошибка

            char[] output = input.ToCharArray();
            output[output.Length - cnt - 1] = output[output.Length - cnt - 1] == '1' ? '0' : '1';
            return new string(output);
        }
        public static bool IsError(string input, int pxNum)
        {
            string px = Px[pxNum];
            ///проверка на наличие ошибки
            ///закодированный полином должен делиться на образующий без остатка
            //if (Convert.ToInt32(input, 2) % Convert.ToInt32(px, 2) == 0)
            //    return false;

            return true;
        }
        static int GetR(string n)
        {
            return (int)Math.Round(Math.Round(Math.Log(Convert.ToInt32(n, 2) + 1, 2), MidpointRounding.AwayFromZero));
        }
    }
}
