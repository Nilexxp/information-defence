using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗИ_лаба1_визуальн
{
    class Vigener
    {
        public readonly static char[] charactersRu = new char[] {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
            'у', 'ф', 'ч', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ',
            'э', 'ю', 'я', ' ', ',',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public readonly static char[] charactersEn = new char[] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z', ' ', ',',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        //шифрование текста
        static public string Encrypt(string text, int key, bool isRu = true)
        {
            string output = "";
            char[] alphabet;
            //выбор алфавита в зависимости от флага
            if (isRu)
                alphabet = charactersRu;
            else
                alphabet = charactersEn;
            //перебор всех символов для шифрации
            foreach (char c in text.ToLower())
                output += alphabet[(Array.IndexOf(alphabet, c) + key) % alphabet.Length];

            return output;
        }

        //дешифрование текста
        static public string Decrypt(string text, int key, bool isRu = true)
        {
            string output = "";
            char[] alphabet;
            //выбор алфавита в зависимости от флага
            if (isRu)
                alphabet = charactersRu;
            else
                alphabet = charactersEn;
            //перебор всех символов для дешифрации
            foreach (char c in text.ToLower())
                output += alphabet[(Array.IndexOf(alphabet, c) + alphabet.Length - key % alphabet.Length) % alphabet.Length] ;

            return output;
        }
    }
}
