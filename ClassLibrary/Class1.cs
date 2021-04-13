using System;
using System.IO;

namespace ClassLibrary
{
    public class IntArray
    {
        int[] a;    //закрытый одномерный массив
        int length;      //закрытая длина

        public IntArray(int length)
        {
            a = new int[length];
            this.length = length;
        }
        public IntArray(params int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Недостаточно аргументов в методе");
            }
            length = arr.Length;
            a = new int[length];
            for (int i = 0; i < length; i++) a[i] = arr[i];
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (length != value)
                {
                    length = value;
                }
            }
        }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < length)
                {
                    return a[i];
                }
                else { return 0; }
            }
            set
            {
                if (i >= 0 && i < length && value >= 0 && value <= 100)
                {
                    a[i] = value;
                }
            }
        }

        public static IntArray RandomIntArray(int length, int a, int b) // создание массива длины length и заполнение его случайными целыми числами в диапазоне от a до b, стр. 148-150  
        {
            var arr = new IntArray(length);
            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(a, b);
            }
            return arr;
        }

        public static IntArray ArrayFromTextFile(string fileName)  //ввод массива из текстового файла с именем filename, стр. 258-259 
        {
            try
            {
                StreamReader f = new StreamReader(fileName);
                IntArray arr = new IntArray(System.IO.File.ReadAllLines(fileName).Length);
                for (int i = 0; i < System.IO.File.ReadAllLines(fileName).Length; i++)
                {
                        arr[i] = Convert.ToInt32(f.ReadLine());
                }
                f.Close();
                return arr;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Проверьте правильность имени файла!");
                IntArray arr = new IntArray(1);
                return arr;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                IntArray arr = new IntArray(1);
                return arr;
            }
        }
        public static void ArrayToTextFile(IntArray arr, string fileName)   //вывод массива arr в текстовый файл с именем filename, стр. 256-257
        {
            try
            {
                StreamWriter f = new StreamWriter(fileName);

                f.WriteLine("Вывод в текстовый файл:");
                for (int i = 0; i < arr.length; i++)
                {
                    f.WriteLine(arr[i]);
                }
                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }
        }
        public static int SumArray(IntArray arr)   //вычисление суммы элементов массива arr, стр. 128-129
        {
            int sum = 0;
            for (int i = 0; i < arr.length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static IntArray operator ++(IntArray arr)   // ++: инкремент: увеличение на 1 всех элементов массива, 163-164
        {
            for (int i = 0; i < arr.length; i++)
            {
                arr[i] += 1;
            }
            return arr;
        }
        public static IntArray operator +(IntArray x, int y)  // +: сложение массива x со скаляром y, стр. 165-167
        {
            IntArray temp = new IntArray(x.a);

            for (int i = 0; i < temp.length; i++)
            {
                temp[i] += y;
            }
            return temp;
        }
        public static IntArray operator +(int x, IntArray y)  // +: сложение скаляра x с массивом y, стр. 165-167
        {
            IntArray temp = new IntArray(y.a);

            for (int i = 0; i < temp.length; i++)
            {
                temp[i] += x;
            }
            return temp;
        }
        public static IntArray operator +(IntArray x, IntArray y)  // +: сложение двух массивов x и y, стр. 165-167
        {
            IntArray first = new IntArray(x.a);
            IntArray second = new IntArray(y.a);

            if (first.length >= second.length)
            {
                for (int i = 0; i < first.length; i++)
                {
                    first[i] += second[i];
                }
            }
            else
            {
                for (int i = 0; i < first.length; i++)
                {
                    first[i] += second[i];
                }
                for (int i = 0; i < first.length; i++)
                {
                    first[i] += second[first.length + i];
                }
            }
            return first;
        }
        public static IntArray operator --(IntArray arr)    // --: декремент: уменьшение на 1 всех элементов массива
        {
            for (int i = 0; i < arr.length; i++)
            {
                arr[i] -= 1;
            }
            return arr;
        }
        public static IntArray operator -(IntArray x, int y)  // -: вычитание из массива x скаляра y (x - y)
        {
            IntArray temp = new IntArray(x.a);

            for (int i = 0; i < temp.length; i++)
            {
                temp[i] -= y;
            }
            return temp;
        }
        public static IntArray operator -(int x, IntArray y)  // -: вычитание из скаляра x массива y (x - y)
        {
            IntArray temp = new IntArray(y.a);

            for (int i = 0; i < temp.length; i++)
            {
                y -= temp[i];
            }
            return temp;
        }
        public static IntArray operator -(IntArray x, IntArray y)  // -: вычитание из массива x массива y (x - y)
        {
            IntArray first = new IntArray(x.a);
            IntArray second = new IntArray(y.a);

            if (first.length >= second.length)
            {
                for (int i = 0; i < first.length; i++)
                {
                    first[i] -= second[i];
                }
            }
            else
            {
                for (int i = 0; i < first.length; i++)
                {
                    first[i] -= second[i];
                }
                for (int i = 0; i < first.length; i++)
                {
                    first[i] -= second[first.length + i];
                }
            }
            return first;
        }
    }
}