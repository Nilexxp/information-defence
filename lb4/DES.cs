using System;

namespace lb4
{
    class DES
    {
        #region поля класса
        /// <summary>
        /// Размер блока
        /// </summary>
        private const int sizeOfBlock = 32;
        /// <summary>
        /// Размер одного символа
        /// </summary>
        private const int sizeOfChar = 16;
        /// <summary>
        /// Сдвиг ключа
        /// </summary>
        private const int shiftKey = 16;
        /// <summary>
        /// Количество раундов
        /// </summary>
        private const int quantityOfRounds = 1;
        /// <summary>
        /// Бинарные блоки
        /// </summary>
        private string[] blocks;
        #endregion
        #region основные методы шифрации и дешифрации
        /// <summary>
        /// Метод шифрации
        /// </summary>
        /// <param name="text">Текст для шифрации</param>
        /// <param name="keyWord">Кодовое слово</param>
        /// <returns>(зашифрованный текст, полученное кодовое слово)</returns>
        public (string text, string keyWord) Encrypt(string text, string keyWord)
        {
            if (keyWord.Length > 0)
            {
                string result = "", binKey;
                text = StringToRightLength(text);

                blocks = CutStringIntoBlocks(text);

                keyWord = CorrectKeyWord(keyWord, text.Length / (2 * blocks.Length));
                binKey = StringToBinaryFormat(keyWord);

                for (int j = 0; j < quantityOfRounds; j++)
                {
                    for (int i = 0; i < blocks.Length; i++)
                        blocks[i] = EncodeOneRound(blocks[i], binKey);

                    binKey = KeyToNextRound(binKey);
                }

                binKey = KeyToPrevRound(binKey);
                keyWord = StringFromBinaryToNormalFormat(binKey);

                for (int i = 0; i < blocks.Length; i++)
                    result += blocks[i];

                result = StringFromBinaryToNormalFormat(result);

                return (result, keyWord);
            }
            else
                throw new Exception("Ошибка ключа");
        }

        /// <summary>
        /// Метод дешифрации
        /// </summary>
        /// <param name="text">Текст для дешифрации</param>
        /// <param name="keyWord">Кодовое слово</param>
        /// <returns>(зашифрованный текст, полученное кодовое слово)</returns>
        public (string text, string keyWord) Decrypt(string text, string keyWord)
        {
            if (keyWord.Length > 0)
            {
                string result = "";
                string binKey = StringToBinaryFormat(keyWord);

                text = StringToBinaryFormat(text);

                blocks = CutBinaryStringIntoBlocks(text);

                for (int j = 0; j < quantityOfRounds; j++)
                {
                    for (int i = 0; i < blocks.Length; i++)
                        blocks[i] = DecodeOneRound(blocks[i], binKey);

                    binKey = KeyToPrevRound(binKey);
                }

                binKey = KeyToNextRound(binKey);
                keyWord = StringFromBinaryToNormalFormat(binKey);

                for (int i = 0; i < blocks.Length; i++)
                    result += blocks[i];

                result = StringFromBinaryToNormalFormat(result);

                return (result, keyWord);
            }
            else
                throw new Exception("Ошибка ключа");
        }
        #endregion
        #region Вспомогательные функции
        /// <summary>
        /// Реализация XOR для двух бинарных строк
        /// </summary>
        /// <param name="s1">Бинарная строка 1</param>
        /// <param name="s2">Бинарная строка 2</param>
        /// <returns>Бинарный результат</returns>
        private string XOR(string strA, string strB)
        {
            string result = "";

            for (int i = 0; i < strA.Length; i++)
            {
                bool a = Convert.ToBoolean(Convert.ToInt32(strA[i].ToString()));
                bool b = Convert.ToBoolean(Convert.ToInt32(strB[i].ToString()));

                if (a ^ b)
                    result += "1";
                else
                    result += "0";
            }
            return result;
        }
        /// <summary>
        /// Функция для шифрования
        /// </summary>
        /// <param name="s1">Бинарная строка 1</param>
        /// <param name="s2">Бинарная строка 2</param>
        /// <returns>Бинарный результат шифрования</returns>
        private string EncFunction(string strA, string strB)
        {
            return XOR(strA, strB);
        }
        #endregion
        #region Разбиение строк на блоки
        /// <summary>
        /// Разбивает строку на блоки, записывается в Blocks[]
        /// </summary>
        /// <param name="input">Строка для разбиения</param>
        private string[] CutStringIntoBlocks(string input)
        {
            string[] block = new string[(input.Length * sizeOfChar) / sizeOfBlock];

            int lengthOfBlock = input.Length / block.Length;

            for (int i = 0; i < block.Length; i++)
            {
                block[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
                block[i] = StringToBinaryFormat(block[i]);
            }

            return block;
        }

        /// <summary>
        /// Разбивает бинарную строку на блоки
        /// </summary>
        /// <param name="input">Бинарная строка для разбиения</param>
        private string[] CutBinaryStringIntoBlocks(string input)
        {
            string[] block = new string[input.Length / sizeOfBlock];

            int lengthOfBlock = input.Length / block.Length;

            for (int i = 0; i < block.Length; i++)
                block[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);

            return block;
        }
        #endregion
        #region Исправление длинн строк
        /// <summary>
        /// Добавляет к строке "#", для ровного деления на sizeOfBlock
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Строка, делящаяся без остатка на sizeOfBlock</returns>
        private string StringToRightLength(string input)
        {
            while (((input.Length * sizeOfChar) % sizeOfBlock) != 0)
                input += "#";

            return input;
        }

        /// <summary>
        /// Исправление длины ключегого слова до корректной
        /// </summary>
        /// <param name="input">Слово-ключ</param>
        /// <param name="lengthKey">Нужная длина для ключа</param>
        /// <returns>Готовое слово-ключ</returns>
        private string CorrectKeyWord(string input, int lengthKey)
        {
            if (input.Length > lengthKey)
                input = input.Substring(0, lengthKey);
            else
                while (input.Length < lengthKey)
                    input = "0" + input;

            return input;
        }
        #endregion
        #region Одна итерация шифарции/дешифрации
        /// <summary>
        /// Один раунд DES шифрования
        /// </summary>
        /// <param name="input">Строка для шифрования</param>
        /// <param name="key">Ключ для шифрования</param>
        /// <returns>Зашифрованная строка</returns>
        private string EncodeOneRound(string input, string key)
        {
            //разделение пополам
            string L = input.Substring(0, input.Length / 2);
            string R = input.Substring(input.Length / 2, input.Length / 2);
            //шифрование
            return R + XOR(L, EncFunction(R, key));
        }

        /// <summary>
        /// Один раунд DES расшифрования
        /// </summary>
        /// <param name="input">Строка для расшифрования</param>
        /// <param name="key">Ключ для расшифрования</param>
        /// <returns>Расшифрованная строка</returns>
        private string DecodeOneRound(string input, string key)
        {
            //разделение пополам
            string L = input.Substring(0, input.Length / 2);
            string R = input.Substring(input.Length / 2, input.Length / 2);
            //Дешифрование
            return XOR(EncFunction(L, key), R) + L;
        }
        #endregion
        #region Вычисление ключей для следующих раундов
        /// <summary>
        /// Вычисление ключа для следующего раунда шифрования, согласно циклическому сдвигу
        /// </summary>
        /// <param name="key">Исходный ключ для сдвига</param>
        /// <returns>Полученный ключ после сдвига</returns>
        private string KeyToNextRound(string key)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                key = key[key.Length - 1] + key;
                key = key.Remove(key.Length - 1);
            }

            return key;
        }

        /// <summary>
        /// Вычисление ключа для следующего раунда расшифрования, согласно циклическому сдвигу
        /// </summary>
        /// <param name="key">Исходный ключ для обратного сдвига</param>
        /// <returns>Полученный ключ после обратного сдвига</returns>
        private string KeyToPrevRound(string key)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                key = key + key[0];
                key = key.Remove(0, 1);
            }

            return key;
        }
        #endregion
        #region Переводы в/из бинарных строк
        /// <summary>
        /// Перевод строки в бинарный формат
        /// </summary>
        /// <param name="input">Строка для перевода</param>
        /// <returns>Строка в бинарном формате</returns>
        private string StringToBinaryFormat(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                string charBinary = Convert.ToString(input[i], 2);

                while (charBinary.Length < sizeOfChar)
                    charBinary = "0" + charBinary;

                output += charBinary;
            }

            return output;
        }

        /// <summary>
        /// Перевод бинарной строки в символьную строку
        /// </summary>
        /// <param name="input">Бинарная строка</param>
        /// <returns>Символьная строка</returns>
        private string StringFromBinaryToNormalFormat(string input)
        {
            string output = "";

            while (input.Length > 0)
            {
                string char_binary = input.Substring(0, sizeOfChar);
                input = input.Remove(0, sizeOfChar);

                int a = 0;
                int degree = char_binary.Length - 1;

                foreach (char c in char_binary)
                    a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);

                output += ((char)a).ToString();
            }

            return output;
        }
        #endregion
    }
}
