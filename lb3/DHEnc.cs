using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace lb3
{
    class DHEnc
    {
        #region Поля класса
        List<string> primeNum;
        Random rn;
        public int g { get; protected set; }
        public int q { get; protected set; }
        public BigInteger a { get; protected set; }
        public BigInteger b { get; protected set; }
        public BigInteger A { get; protected set; }
        public BigInteger B { get; protected set; }
        public BigInteger Ka { get; protected set; }
        public BigInteger Kb { get; protected set; }
        #endregion
        #region Создание
        public DHEnc()
        {
            rn = new Random();
            InitPrimeArray();
            this.g = rn.Next(1000);
            this.q = rn.Next(1000);
            this.a = GetRandPrime();
            this.b = GetRandPrime();
        }
        public void Calculate()
        {
            A = BigInteger.Pow(g, (int)a) % q;
            B = BigInteger.Pow(g, (int)b) % q;
            Ka = BigInteger.Pow(B, (int)a) % q;
            Kb = BigInteger.Pow(A, (int)b) % q;
        }
        #endregion
        #region Вспомогательные методы
        public BigInteger GetRandPrime()
        {
            try
            {
                return BigInteger.Parse(primeNum[rn.Next(200/*primeArr.Count*/)]);
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
                string[] lines = File.ReadAllLines("Primes1-5.txt");
                primeNum = new List<string>();
                foreach (string line in lines)
                    foreach (string num in line.Split())
                        if (num != "")
                            primeNum.Add(num);
            }
            catch
            {
                throw new Exception("Ошибка чтения файла с простыми числами");
            }
            return 0;
        }
        #endregion
        #region Методы шифрации и дешифрации
        public string Encrypt(string input)
        {
            //string output = "";
            //foreach (char letter in input)
            //{
            //    output += Math.Pow((int)letter, (int)K).ToString() + " ";
            //}
            //return output;
            return Vigener.Encrypt(input, (long)Ka);
        }
        public string Decrypt(string input)
        {
            //string output = "";
            //string[] inputArr = input.Split();
            //foreach (string letter in inputArr)
            //{
            //    output += Convert.ToInt32(Math.Pow(Convert.ToInt32(letter), (1 / (int)K)));
            //}
            //return output;
            return Vigener.Decrypt(input, (long)Ka);
        }
        #endregion
    }

    
}
