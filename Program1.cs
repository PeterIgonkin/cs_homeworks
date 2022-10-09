using System;
namespace prc02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первую строку");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string str2 = Console.ReadLine();
            ex_1(str1, str2, out string ans);
            Console.WriteLine(ans);
            Console.WriteLine("Введите количество чисел в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите числа через пробел");
            ReadArray(n, out int[] mas);
            coctail_sort(ref mas, n);
            PrintArray(mas, n);
            //ex_2(mas, n, out int[] answer);
            //PrintArray(answer, 2);
        }
        static void PrintArray(in int[] mas, in int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mas[i]} ");
            }
        }
        static void ReadArray(in int n, out int[] mas)
        {
            mas = new int[n];
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(s[i]);
            }
        }
        static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void ex_1(string str1, string str2, out string answer)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            for (int i = 0; i < str1.Length; i++)
            {
                bool c = false;
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        c = true;
                        str2.Remove(j, 1);
                        break;
                    }
                }
                if (c == false)
                {
                    answer = "no";
                    return;
                }
            }
            answer = "yes";
            return;
        }
        /*static void qsort(ref int[] mas, in int n, int i = 0)
        {
            int j = n - 1 + i;
            int v = mas[(j+1) >> 1];
            do
            {
                while (mas[i] < mas[v]) i++;
                while (mas[j] > mas[v]) j--;
                if (i <= j)
                {
                    swap(ref mas[i], ref mas[j]);
                    i++;
                    j--;
                }
            } while (i <= j);
            if (i < n - 1) qsort(ref mas, n - i, i);
            if (j > 0) qsort(ref mas, j + 1);
        }
        */
        static void coctail_sort(ref int[] mas, in int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                for (int j = 0 + i; j < n - 1 - i; j++)
                {
                    if (mas[j] > mas[j+1]) swap(ref mas[j], ref mas[j+1]);
                }
                for (int j = n - 2 - i; j > 0 + i; j--)
                {
                    if(mas[j] < mas[j - 1])
                    {
                        swap(ref mas[j], ref mas[j - 1]);
                        flag = true;
                    }
                }
                if (flag == false) break;
            }
        }
        /*static void ex_2(in int[] mas, in int n, out int[] ans)
        {
            ans = new int[2];
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int c = 0;
                int last = 0;
                for (int j = i + 1; j < n; j++)
                {
                    if (mas[i] < mas[j]) c++;
                    else last = j - 1;
                }
                if (c > max)
                {
                    max = c;
                    ans[0] = mas[i];
                    ans[1] = mas[last];
                }
                i = last;
            }
        */
        }
    }
}

