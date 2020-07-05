using System;

namespace aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] arr = { 22, 7, 11, 4, 20, 8, 99, 77, 1 };

            #region 
            //int[] arr = {54,226,93,17,77,31,44,55,20};
            //for (int i = 0; i<arr.Length-1; i++)
            //{
            //    int min_index = i;
            //    int min_num = arr[i];
            //    for (int j = i; j<arr.Length; j++)
            //    {
            //        if (arr[j] < min_num)
            //        {
            //            min_index = j;
            //            min_num = arr[j];
            //        }
            //    }
            //    if(min_num != i)
            //    {
            //        arr[min_index] = arr[i];
            //        arr[i] = min_num;
            //    }
            //}
            //Console.WriteLine(arr.Length);
            //foreach (int i in arr)
            //{
            //    Console.Write(i+ " ");
            //}
            #endregion
            #region 冒泡排序 从小到大排列

            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    int temp = 0;
            //    for (int j=0; j<arr.Length-1-i; j++)
            //    {
            //        if (arr[j] > arr[j+1]) //从大到小排列改成<
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion
            #region 选择排序,从大到小 当前索引及之后的元素中最大的排在当前索引位置
            //int max_index = 0;
            //int max_num = 0;
            //for (int i=0; i<arr.Length-1; i++)
            //{
            //    max_index = i;
            //    max_num = arr[i];
            //    for(int j= i+1; j < arr.Length; j++)
            //    {
            //        if (arr[j] > max_num) //从小到大排改成<
            //        {
            //            max_index = j;
            //            max_num = arr[j];
            //        }
            //    }
            //    if (max_num != arr[i])
            //    {
            //        arr[max_index] = arr[i];
            //        arr[i] = max_num;
            //    }
            //}
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region 插入排序，从小到大。左边是排序好的，将没排序好的插入到排好序的序列
            //int temp = 0;
            //for (int i=1; i<arr.Length; i++)
            //{
            //    for (int j=i; j>0; j--)
            //    {
            //        if (arr[j] < arr[j-1])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j-1];
            //            arr[j - 1] = temp;
            //        }
            //    }
            //}
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region 递归实现二分法查找
            int val = 20;
            bool result = Search(arr, val);
            Console.WriteLine(result? "存在要查找的值"+val : "不存在要查找的值:" +val);
            val = 88;
            result = Search(arr, val);
            Console.WriteLine(result ? "存在要查找的值" + val : "不存在要查找的值:" + val);
            #endregion
        }
        public static bool Search(int[] arr, int val)
        {
            if (arr.Length == 0)
            {
                return false;
            }

            int mid = (arr.Length - 1) / 2;
            if (arr[mid] == val)
            {
                return true;
            }
            else if (val < arr[mid])
            {
                return Search(Slice(arr, 0, mid - 1) ,val);
            }
            else
            {
                return Search(Slice(arr, mid + 1, arr.Length - 1) ,val);
            }
        }

        public static int[] Slice(int[] arr, int startIndex,int endIndex)
        {
            int len = endIndex - startIndex + 1;
            int[] newArr = new int[len];
            int j = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                newArr[j] = arr[i];
                j++;
            }
            return newArr;
        }
    }
}
