using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗИ_лаба1_визуальн
{
    class DoubleSquare
    {
        //массивы 7 на 5
        private static char[,] sq1 = new char[,]
    {
          {'5', '6', '7', '8', '9'},
          {'ж', 'щ', 'н', 'ю', 'р'},
          {'и', 'т', 'ь', 'ц', 'б'},
          {'я', 'м', 'е', '.', 'с'},
          {'0', '1', '2', '3', '4'},
          {'в', 'ы', 'п', 'ч', ' '},
          {'й', 'д', 'у', 'о', 'к'},
          {'з', 'э', 'ф', 'г', 'ш'},
          {'х', 'а', ',', 'л', 'ъ'}
    };
        private static char[,] sq2 = new char[,]
    {
          {'и', 'ч', 'г', 'я', 'т'},
          {',', 'ж', 'м', 'ь', 'о'},
          {'0', '1', '2', '3', '4'},
          {'з', 'ю', 'р', 'в', 'щ'},
          {'ц', 'й', 'п', 'е', 'л'},
          {'ъ', 'а', 'н', '.', 'х'},
          {'э', 'к', 'с', 'ш', 'д'},
          {'б', 'ф', 'у', 'ы', ' '},
          {'5', '6', '7', '8', '9'}
    };
        public static string Encrypt(string text)
        {
            text = text.ToLower();

            string result_text = "";
            //проверка на четность строки
            if (text.Length % 2 != 0)
                text += ' ';

            int length = text.Length / 2;//количество итераций
            int k = 0;
            char[,] bigram = new char[length, 2];//для начальной строки
            char[,] kripto_bigram = new char[length, 2];//для конечной строки
                                                        //запись изначальной строки, совместно с разделением на биграммы (по столбикам)
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bigram[i, j] = text[k];
                    k++;
                }
            }
            int step = 0;
            while (step < length)
            {
                //поиск символа в первом и втором квадратах
                Cortege cortege1 = FindIndexes(bigram[step, 0], sq1);
                Cortege cortege2 = FindIndexes(bigram[step, 1], sq2);
                //запись соотвевтующих симолов из первого и второго квадратов
                kripto_bigram[step, 0] = sq2[cortege1.I, cortege2.J];
                kripto_bigram[step, 1] = sq1[cortege2.I, cortege1.J];

                step++;
            }

            //запись полученной строки в результирующий текст
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result_text += kripto_bigram[i, j].ToString();
                }
            }

            return result_text;
        }


        public static string Decrypt(string text)
        {
            string result_text = "";

            int length = text.Length / 2;
            int k = 0;

            char[,] bigram = new char[length, 2];
            char[,] kripto_bigram = new char[length, 2];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bigram[i, j] = text[k];
                    k++;
                }
            }

            int step = 0;
            while (step < length)
            {
                Cortege cortege1 = FindIndexes(bigram[step, 0], sq2);
                Cortege cortege2 = FindIndexes(bigram[step, 1], sq1);

                kripto_bigram[step, 0] = sq1[cortege1.I, cortege2.J];
                kripto_bigram[step, 1] = sq2[cortege2.I, cortege1.J];

                step++;
            }


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result_text += kripto_bigram[i, j].ToString();
                }
            }


            return result_text;
        }

        private static Cortege FindIndexes(char symbol, char[,] matrix)
        {
            Cortege cortege = new Cortege();
            //перебор всех значений в поиске символа
            for (int i = 0; i < sq1.GetLength(0); i++)
            {
                for (int j = 0; j < sq1.GetLength(1); j++)
                {
                    if (symbol == matrix[i, j])
                    {
                        //запись найденных координат в кортеж
                        cortege.I = i;
                        cortege.J = j;
                        return cortege;
                    }
                }
            }

            return null;
        }

        private class Cortege
        {
            public int I { get; set; }
            public int J { get; set; }
            public Cortege() { }
        }
    }
}
