using System;

namespace lb3
{
    class Vigener
    {
        public readonly static char[] characters = new char[] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z', ' ', ',', '.', ':', ';',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
            'у', 'ф', 'ч', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ',
            'э', 'ю', 'я',};
        //шифрование текста
        static public string Encrypt(string text, long key)
        {
            string output = "";
            //перебор всех символов для шифрации
            foreach (char c in text.ToLower())
                output += characters[(Array.IndexOf(characters, c) + key) % characters.Length];

            return output;
        }
        //дешифрование текста
        static public string Decrypt(string text, long key)
        {
            string output = "";
            //перебор всех символов для дешифрации
            foreach (char c in text.ToLower())
                output += characters[(Array.IndexOf(characters, c) + characters.Length - (key % characters.Length)) % characters.Length];

            return output;
        }
    }
}
