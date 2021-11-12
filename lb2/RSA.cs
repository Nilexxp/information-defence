using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.IO;

namespace lb2
{
    public class RSA
    {
        public BigInteger p = 0;    
        public BigInteger q = 0;    
        public BigInteger n;        
        public BigInteger e;        
        public BigInteger d;        
        List<string> primeArr;
        static Random rn = new Random();
        long y;
        public readonly static char[] characters = new char[] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z', ' ', ',', '.', ':', ';',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
            'у', 'ф', 'ч', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ',
            'э', 'ю', 'я',};
        public RSA()
        {
            InitPrimeArray();
            this.p = GetRandPrime();
            this.q = GetRandPrime();
            this.n = BigInteger.Multiply(this.p, this.q);
            BigInteger temp = BigInteger.Multiply(p - 1, q - 1);
            this.d = CalcD(temp);
            this.e = CalcE(d, temp);
        }
        public string Encrypt(string input)
        {
            string output = "";
            List<string> result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                BigInteger temp = new BigInteger(Array.IndexOf(characters, input[i]));
                temp = BigInteger.Pow(temp, (int)e);
                temp %= n;
                result.Add(temp.ToString());
            }
            foreach (string num in result)
                output += '-'+num;
            return output.Trim('-');
        }
        public string Decrypt(string inp)
        {
            List<string> input = inp.Split('-').ToList();
            string result = "";
            foreach (string num in input)
            {
                BigInteger temp = new BigInteger(Convert.ToDouble(num));
                temp = BigInteger.Pow(temp, (int)d);
                temp %= n;
                int index = (int)temp;
                result += characters[index].ToString();
            }
            return result;
        }
        public BigInteger GetRandPrime()
        {
            try
            {
                return BigInteger.Parse(primeArr[rn.Next(200/*primeArr.Count*/)]);
            }
            catch
            {
                throw new Exception("Ошибка преобразования строки из файла с простыми числами");
            }

        }
        int InitPrimeArray()
        {

            try
            {
                string[] lines = File.ReadAllLines("Primes1-5.txt"/*"primes.txt"*//*"Prime.txt"*/);
                primeArr = new List<string>();/*string[lines.Length];*/
                foreach (string line in lines)
                    foreach (string num in line.Split())
                        if (num != "")
                            primeArr.Add(num);
            }
            catch
            {
                throw new Exception("Ошибка чтения файла с простыми числами");
            }
            return 0;
        }
        private BigInteger CalcD(BigInteger M)
        {
            BigInteger D = M - 1;
            for (BigInteger i = 2; i <= M; i++)
                if ((M % i == 0) && (D % i == 0))
                {
                    D--;
                    i = 1;
                }
            return D;
        }
        private BigInteger CalcE(BigInteger D, BigInteger M)
        {
            BigInteger E = 10;
            while (true)
            {
                if ((E * D) % M == 1)
                    break;
                else
                    E++;
            }
            return E;
        }
    }
}
