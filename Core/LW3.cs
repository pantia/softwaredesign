using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
  public class LW3 {
    private static Random r = new Random();

    public static int[,] Generate31() {
      int[,] matrix = new int[4, 5];
      for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
          matrix[i, j] = r.Next(-50, 50);
        }
      }
      return matrix;
    }


    public static int[] Generate32() {
      int[] array = new int[50];
      for(int i = 0; i < array.GetLength(0); i++) {
        array[i] = r.Next(-24, 25); 
      }
      return array;
    }

    public static int[] Calculate(int[,] matrix) {
      int[] output = new int[matrix.GetLength(1)];
      for(int i = 0; i < matrix.GetLength(1); i++) {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(0); j++) {
          sum = sum + matrix[j, i];

        }
        output[i] = sum;
      }
      return output;
    }

    static void Swap(ref int e1, ref int e2) {
      var temp = e1;
      e1 = e2;
      e2 = temp;
    }

    public static int[] ShakerSort(int[] array) {
      for(var i = 0; i < array.Length / 2; i++) {
        var swapFlag = false;
        //прохід зліва направо
        for(var j = i; j < array.Length - i - 1; j++) {
          if(array[j] > array[j + 1]) {
            Swap(ref array[j], ref array[j + 1]);
            swapFlag = true;
          }
        }

        //прохід справа наліво
        for(var j = array.Length - 2 - i; j > i; j--) {
          if(array[j - 1] > array[j]) {
            Swap(ref array[j - 1], ref array[j]);
            swapFlag = true;
          }
        }

        //якщо обмінів не було
        if(!swapFlag) {
          break;
        }
      }

      return array;
    }

    public static int[] InsertionSort(int[] array) {
      for(var i = 0; i < array.Length; i++) {
        var key = array[i];
        var j = i;
        while((j > 0) && (array[j - 1] > key)) {
          Swap(ref array[j - 1], ref array[j]);
          j--;
        }

        array[j] = key;
      }

      return array;
    }

    public static int[] BubbleSort(int[] array) {
      var len = array.Length;
      for(var i = 1; i < len; i++) {
        for(var j = 0; j < len - i; j++) {
          if(array[j] > array[j + 1]) {
            Swap(ref array[j], ref array[j + 1]);
          }
        }
      }

      return array;
    }


    static int[] StoogeSort(int[] array, int startIndex, int endIndex) {
      if(array[startIndex] > array[endIndex]) {
        Swap(ref array[startIndex], ref array[endIndex]);
      }

      if(endIndex - startIndex > 1) {
        var len = (endIndex - startIndex + 1) / 3;
        StoogeSort(array, startIndex, endIndex - len);
        StoogeSort(array, startIndex + len, endIndex);
        StoogeSort(array, startIndex, endIndex - len);
      }

      return array;
    }

    public static int[] StoogeSort(int[] array) {
      return StoogeSort(array, 0, array.Length - 1);
    }

    public static int[] ShellSort(int[] array) { 
      var d = array.Length / 2;
      while(d >= 1) {
        for(var i = d; i < array.Length; i++) {
          var j = i;
          while((j >= d) && (array[j - d] > array[j])) {
            Swap(ref array[j], ref array[j - d]);
            j = j - d;
          }
        }

        d = d / 2;
      }

      return array;
    }

    //метод для злиття масивів
    static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex) {
      var left = lowIndex;
      var right = middleIndex + 1;
      var tempArray = new int[highIndex - lowIndex + 1];
      var index = 0;

      while((left <= middleIndex) && (right <= highIndex)) {
        if(array[left] < array[right]) {
          tempArray[index] = array[left];
          left++;
        } else {
          tempArray[index] = array[right];
          right++;
        }

        index++;
      }

      for(var i = left; i <= middleIndex; i++) {
        tempArray[index] = array[i];
        index++;
      }

      for(var i = right; i <= highIndex; i++) {
        tempArray[index] = array[i];
        index++;
      }

      for(var i = 0; i < tempArray.Length; i++) {
        array[lowIndex + i] = tempArray[i];
      }
    }

    //сортування злиттям
    static int[] MergeSort(int[] array, int lowIndex, int highIndex) {
      if(lowIndex < highIndex) {
        var middleIndex = (lowIndex + highIndex) / 2;
        MergeSort(array, lowIndex, middleIndex);
        MergeSort(array, middleIndex + 1, highIndex);
        Merge(array, lowIndex, middleIndex, highIndex);
      }

      return array;
    }

    public static int[] MergeSort(int[] array) {
      return MergeSort(array, 0, array.Length - 1);
    }

    static int IndexOfMin(int[] array, int n) {
      int result = n;
      for(var i = n; i < array.Length; ++i) {
        if(array[i] < array[result]) {
          result = i;
        }
      }

      return result;
    }

    public static int[] SelectionSort(int[] array, int currentIndex = 0) {
      if(currentIndex == array.Length)
        return array;

      var index = IndexOfMin(array, currentIndex);
      if(index != currentIndex) {
        Swap(ref array[index], ref array[currentIndex]);
      }

      return SelectionSort(array, currentIndex + 1);
    }


    static int Partition(int[] array, int minIndex, int maxIndex) {
      var pivot = minIndex - 1;
      for(var i = minIndex; i < maxIndex; i++) {
        if(array[i] < array[maxIndex]) {
          pivot++;
          Swap(ref array[pivot], ref array[i]);
        }
      }

      pivot++;
      Swap(ref array[pivot], ref array[maxIndex]);
      return pivot;
    }

    //швидке сортування
    static int[] QuickSort(int[] array, int minIndex, int maxIndex) {
      if(minIndex >= maxIndex) {
        return array;
      }

      var pivotIndex = Partition(array, minIndex, maxIndex);
      QuickSort(array, minIndex, pivotIndex - 1);
      QuickSort(array, pivotIndex + 1, maxIndex);

      return array;
    }

    public static int[] QuickSort(int[] array) {
      return QuickSort(array, 0, array.Length - 1);
    }

    public static int LinearSearch(int[] array, int searchedValue) {

      for(int i = 0; i < array.Length; i++) {
        if(array[i] == searchedValue) {
          return i;
        }
      }
      return -1;
    }
    public static int BinarySearch(int[] array, int searchedValue, int first, int last) { 
      if(first > last) { 
        return -1;
      } 
      var middle = (first + last) / 2; 
      var middleValue = array[middle]; 
      if(middleValue == searchedValue) {
        return middle;
      } else {
        if(middleValue > searchedValue) { 
          return BinarySearch(array, searchedValue, first, middle - 1);
        } else { 
          return BinarySearch(array, searchedValue, middle + 1, last);
        }
      }
    }

    public static string LongestCommonSubstring(string a, string b) {
      var n = a.Length;
      var m = b.Length;
      var array = new int[n, m];
      var maxValue = 0;
      var maxI = 0;
      for(int i = 0; i < n; i++) {
        for(int j = 0; j < m; j++) {
          if(a[i] == b[j]) {
            array[i, j] = (i == 0 || j == 0)
                ? 1
                : array[i - 1, j - 1] + 1;
            if(array[i, j] > maxValue) {
              maxValue = array[i, j];
              maxI = i;
            }
          }
        }
      }

      return a.Substring(maxI + 1 - maxValue, maxValue);
    }
  }
}
