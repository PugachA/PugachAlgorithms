using System;
using System.Collections.Generic;
using System.Text;

namespace PugachAlgorithms
{
    public static class Search
    {
        //Простой алгоритм поиска элемента в массиве перебором
        static public int SearchSimple(int[] a, int x)
        {
            int L = a.Length;
            int i = 0;
            // с проверкой выхода за границу массива
            while (i < L && a[i] != x)
                i++;
            if (i < L)
                // если элемент найден, возвращаем его индекс
                return i;
            else
                // если элемент не найден, возвращаем -1
                return -1;
        }
    }
}
